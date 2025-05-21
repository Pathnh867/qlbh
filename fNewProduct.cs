using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fNewProduct : Form
    {
        private Product product;

        public fNewProduct()
        {
            InitializeComponent();
        }

        private void fNewProduct_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                cbCategories.DisplayMember = "Name";
                cbCategories.ValueMember = "CategoryID";
                cbCategories.DataSource = db.Categories.OrderBy(c => c.Order)
                    .Select(c => new { c.CategoryID, c.Name }).ToList();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All file|*.*|Bitmap File|*.bmp;*.dib|JPEG|*.jpg;*.jpe;*.jpeg;*.jfif|GIF|*.gif|TIFF|*.tif;*.tiff|PNG|*.png|ICO|*.ico";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                product = new Product(); //Tạo một đối tượng cho sản phẩm mới
                product.Name = txtName.Text;
                product.Quantity = Convert.ToInt32(mQuantity.Text);
                product.Price = Convert.ToDecimal(mPrice.Text);
                product.MarketPrice =
                    string.IsNullOrWhiteSpace(mMarketPrice.Text) ? (decimal?)null :
                    Convert.ToDecimal(mMarketPrice.Text);
                product.Description = rDescription.Text;
                product.Status = ckStatus.Checked;
                product.CategoryID = Convert.ToInt32(cbCategories.SelectedValue);

                using (var db = new EFDbContext())
                {
                    db.Products.Add(product); //Thêm sản phẩm vào bối cảnh
                    db.SaveChanges(); //Lưu các thay đổi vào csdl

                    //Lưu hình vào thư mục hình
                    if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                    {
                        string ext =
                            txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."),
                            txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                        product.ImageFile = product.ProductID + ext;
                        pictureBox1.Image.Save(Utility.ImagePath + product.ProductID + ext);
                        db.SaveChanges(); //Lưu các thay đổi vào csdl
                    }
                }

                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                //cbCategories.Text = null;
                mQuantity.Text = null;
                mPrice.Text = null;
                mMarketPrice.Text = null;
                rDescription.Text = null;
                ckStatus.Checked = true;
                txtImageFile.Text = null;
                pictureBox1.ImageLocation = null;

                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
            txtName.Focus();
        }
    }
}