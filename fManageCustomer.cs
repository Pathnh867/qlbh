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
    public partial class fManageCustomer : Form
    {
        EFDbContext db = new EFDbContext();
        public fManageCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            var data = db.Customers.Select(c => new
            {
                c.CustomerID,
                c.Name,
                c.Gender,
                c.BirthDate,
                c.Address,
                c.Phone,
                c.Email,
                c.Status
            }).ToList();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = data;

            dataGridView1.AutoResizeColumns();
            if (dataGridView1.Columns["Edit"] != null)
                dataGridView1.Columns["Edit"].Width = 50;

            if (dataGridView1.Columns["Delete"] != null)
                dataGridView1.Columns["Delete"].Width = 50;
        }


        private void fManageCustomer_Load(object sender, EventArgs e)
        {

            // Thay bằng việc thiết lập location và size cụ thể
            dataGridView1.Location = new Point(1, 117); // Vị trí hiện tại trong properties
            dataGridView1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 120);

            // Hoặc sử dụng Anchor để DataGridView thay đổi kích thước theo form
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            // Đảm bảo rằng tất cả các cột được hiển thị
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tải dữ liệu
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long CustomerID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Customer customer = db.Customers.Single(c => c.CustomerID == CustomerID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + customer.Name,
                            "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Customers.Remove(customer);
                            db.SaveChanges();
                            LoadData();
                        }
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                try
                {
                    // Lấy CustomerID của hàng được chọn
                    long CustomerID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value);

                    // Mở form sửa khách hàng
                    fEditCustomer f = new fEditCustomer(CustomerID);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        // Tải lại dữ liệu nếu sửa thành công
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Customers.Select(c => new
                {
                    c.CustomerID,
                    c.Name,
                    c.Gender,
                    c.BirthDate,
                    c.Address,
                    c.Phone,
                    c.Email,
                    c.Status
                }).Where(c =>
                    c.Name.Contains(txtName.Text)).ToList();
            }

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            fNewCustomer f = new fNewCustomer();
            if (f.ShowDialog() == DialogResult.OK)
            {
                
                LoadData();
            }
        }
    }
}
