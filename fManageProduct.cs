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
    public partial class fManageProduct : Form
    {
        private int CategoryID;

        public fManageProduct()
        {
            InitializeComponent();
        }

        private void fManageProduct_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                cbCategories.DisplayMember = "Name";
                cbCategories.ValueMember = "CategoryID";
                //lệnh dưới đây nằm sau 2 lệnh trên
                cbCategories.DataSource =
                    db.Categories.OrderBy(c => c.Order)
                    .Select(c => new { c.CategoryID, c.Name })
                    .ToList();
                //cbCategories.Text = null;
                //dataGridView1.Width = ClientSize.Width - 10;
            }
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                CategoryID = Convert.ToInt32(cbCategories.SelectedValue);
                dataGridView1.DataSource = db.Products.Where(p =>
                    p.CategoryID == CategoryID).Select(p => new {
                        p.ProductID,
                        p.Name,
                        p.Quantity,
                        p.Price,
                        p.MarketPrice,
                        p.Description,
                        p.ImageFile,
                        p.Status
                    }).ToList();
                lblNumOfProduct.Text = "Số sản phẩm: " + dataGridView1.Rows.Count;
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                if (ckCategory.Checked)
                    dataGridView1.DataSource = db.Products.Where(p =>
                        p.Name.Contains(txtName.Text) && (p.CategoryID == CategoryID ||
                        cbCategories.SelectedIndex < 0)).Select(p => new {
                            p.ProductID,
                            p.Name,
                            p.Quantity,
                            p.Price,
                            p.MarketPrice,
                            p.Description,
                            p.ImageFile,
                            p.Status
                        }).ToList();
                else
                    dataGridView1.DataSource = db.Products.Where(p =>
                        p.Name.Contains(txtName.Text)).Select(p => new {
                            p.ProductID,
                            p.Name,
                            p.Quantity,
                            p.Price,
                            p.MarketPrice,
                            p.Description,
                            p.ImageFile,
                            p.Status
                        }).ToList();
                lblNumOfProduct.Text = "Số sản phẩm: " + dataGridView1.Rows.Count;
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            fNewProduct f = new fNewProduct();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["ImageFile"].Value != null)
            {
                pictureBox1.ImageLocation = Utility.ImagePath +
                    dataGridView1.Rows[e.RowIndex].Cells["ImageFile"].Value;
            }
        }

        private void fManageProduct_Activated(object sender, EventArgs e)
        {
            cbCategories_SelectedIndexChanged(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}