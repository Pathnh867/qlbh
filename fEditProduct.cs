using Microsoft.EntityFrameworkCore; // Thêm để sử dụng Include 
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
    public partial class fEditProduct : Form
    {
        private Product product;
        private long ProductID;
        private EFDbContext db = new EFDbContext();

        // Constructor với tham số ProductID
        public fEditProduct(long ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
        }

        private void fEditProduct_Load(object sender, EventArgs e)
        {
            try
            {
                // Thiết lập kiểu dữ liệu cho các MaskedTextBox
                mQuantity.ValidatingType = typeof(UInt64);
                mPrice.ValidatingType = typeof(decimal);
                mMarketPrice.ValidatingType = typeof(decimal);

                // Tải thông tin sản phẩm cần sửa đổi
                product = db.Products.Include(p => p.Category).Single(p => p.ProductID == ProductID);

                // Đổi tiêu đề form
                Text = "SỬA ĐỔI SẢN PHẨM " + product.ProductID.ToString();
                lblTitle.Text = "SỬA ĐỔI SẢN PHẨM";

                // Điền dữ liệu vào các điều khiển
                txtName.Text = product.Name;
                mQuantity.Text = product.Quantity.ToString();
                mPrice.Text = product.Price.ToString();
                mMarketPrice.Text = product.MarketPrice?.ToString();
                ckStatus.Checked = product.Status;
                rDescription.Text = product.Description;
                txtImageFile.Text = string.IsNullOrWhiteSpace(product.ImageFile) ? null :
                                    Utility.ImagePath + product.ImageFile;
                pictureBox1.ImageLocation = txtImageFile.Text;

                // Nạp dữ liệu cho ComboBox
                cbCategories.DisplayMember = "Name";
                cbCategories.ValueMember = "CategoryID";
                cbCategories.DataSource = db.Categories.OrderBy(c => c.Order)
                    .Select(c => new { c.CategoryID, c.Name }).ToList();

                // Chọn loại sản phẩm hiện tại
                cbCategories.SelectedValue = product.CategoryID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cbCategories.Text))
            {
                toolTip1.Show("Hãy nhập loại sản phẩm?", cbCategories, 0, 0, 1000);
                cbCategories.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(mQuantity.Text))
            {
                toolTip1.Show("Hãy nhập số lượng?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(mPrice.Text))
            {
                toolTip1.Show("Hãy nhập giá bán?", mPrice, 0, 0, 1000);
                mPrice.Focus();
                return;
            }

            try
            {
                // Cập nhật thông tin sản phẩm
                product.Name = txtName.Text;
                product.Quantity = Convert.ToInt32(mQuantity.Text);
                product.Price = Convert.ToDecimal(mPrice.Text);
                product.MarketPrice = string.IsNullOrWhiteSpace(mMarketPrice.Text) ?
                                    (decimal?)null : Convert.ToDecimal(mMarketPrice.Text);
                product.Description = rDescription.Text;
                product.Status = ckStatus.Checked;
                product.CategoryID = Convert.ToInt32(cbCategories.SelectedValue);

                // Xóa tập tin hình cũ nếu cần
                if (!string.IsNullOrWhiteSpace(product.ImageFile) &&
                    txtImageFile.Text != Utility.ImagePath + product.ImageFile)
                {
                    File.Delete(Utility.ImagePath + product.ImageFile);
                    product.ImageFile = null;
                }

                // Lưu tập tin hình mới nếu có
                if (!string.IsNullOrWhiteSpace(txtImageFile.Text) &&
                    txtImageFile.Text != Utility.ImagePath + product.ImageFile)
                {
                    string ext = txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."),
                               txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                    product.ImageFile = product.ProductID + ext;

                    // Nếu có sẵn hình từ OpenFileDialog
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Save(Utility.ImagePath + product.ProductID + ext);
                    }
                    // Nếu không, copy trực tiếp từ file nguồn
                    else if (File.Exists(txtImageFile.Text))
                    {
                        File.Copy(txtImageFile.Text, Utility.ImagePath + product.ProductID + ext, true);
                    }
                }

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SaveChanges();

                // Hiển thị thông báo thành công
                toolTip1.Show("Đã lưu thành công.", btSave, 0, 0, 1000);

                // Đặt DialogResult để form cha biết sản phẩm đã được cập nhật
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
        }

        // Các phương thức kiểm tra dữ liệu nhập - giống như trong fNewProduct
        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 200)
            {
                toolTip1.Show("Tên sản phẩm - tối đa 200 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtImageFile_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImageFile.Text))
                return; // Không cần nhập dữ liệu cho cột có thể null

            if (txtImageFile.Text.Length > 200)
            {
                toolTip1.Show("Tên tập tin - tối đa 200 ký tự?", txtImageFile, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (!File.Exists(txtImageFile.Text) && !txtImageFile.Text.StartsWith(Utility.ImagePath))
            {
                toolTip1.Show("Tên tập tin sai hoặc Tập tin không tồn tại?", txtImageFile, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbCategories_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbCategories.FindStringExact(cbCategories.Text) < 0) // Nếu sai tên loại
            {
                toolTip1.Show("Nhập sai loại sản phẩm?", cbCategories, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mQuantity_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput) // Nếu nhập sai kiểu
            {
                toolTip1.Show("Dữ liệu sai kiểu số nguyên?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (e.ReturnValue != null && (UInt64)e.ReturnValue < 0) // Nếu giá trị âm
            {
                toolTip1.Show("Số lượng phải >= 0?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu số thực?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (e.ReturnValue != null && (decimal)e.ReturnValue < 0)
            {
                toolTip1.Show("Giá phải >= 0?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mMarketPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mMarketPrice.Text))
                return; // Không cần nhập dữ liệu cho cột có thể null

            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu số thực?", mMarketPrice, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (e.ReturnValue != null && (decimal)e.ReturnValue < 0)
            {
                toolTip1.Show("Giá phải >= 0?", mMarketPrice, 0, 0, 1000);
                e.Cancel = true;
            }
        }
    }
}