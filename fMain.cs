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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            // Hiển thị tên người dùng đã đăng nhập
            Text = "Quản lý Bán hàng - " + Utility.Employee.Name;

            // Phân quyền theo RoleID
            switch (Utility.Employee.RoleID)
            {
                case 1: // Quản lý nhân viên
                        // Hiển thị chỉ menu Nhân viên, ẩn các menu khác
                    customerToolStripMenuItem.Visible = false;
                    categoryToolStripMenuItem.Visible = false;
                    productToolStripMenuItem.Visible = false;
                    orderToolStripMenuItem.Visible = false;
                    orderDetailToolStripMenuItem.Visible = false;
                    reportToolStripMenuItem.Visible = false;
                    break;

                case 2: // Quản lý dữ liệu và xem báo cáo
                        // Ẩn menu quản lý nhân viên
                    employeeToolStripMenuItem.Visible = false;
                    // Hiển thị các menu khác
                    break;

                case 3: // Chỉ nhập liệu
                        // Ẩn các chức năng quản lý, chỉ để lại các chức năng nhập liệu
                    manageEmployeeToolStripMenuItem.Visible = false;
                    manageCustomerToolStripMenuItem.Visible = false;
                    manageCategoryToolStripMenuItem.Visible = false;
                    productToolStripMenuItem1.Visible = false;
                    manageOrderToolStripMenuItem.Visible = false;
                    manageOrderDetailsToolStripMenuItem.Visible = false;
                    reportToolStripMenuItem.Visible = false;
                    break;

                case 4: // Chỉ xem báo cáo
                        // Ẩn tất cả các menu khác, chỉ hiển thị menu báo cáo
                    employeeToolStripMenuItem.Visible = false;
                    customerToolStripMenuItem.Visible = false;
                    categoryToolStripMenuItem.Visible = false;
                    productToolStripMenuItem.Visible = false;
                    orderToolStripMenuItem.Visible = false;
                    orderDetailToolStripMenuItem.Visible = false;
                    // Chỉ để lại menu báo cáo
                    break;
            }
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fManageCustomer f = new fManageCustomer();


            f.MdiParent = this;


            f.Show();
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNewCustomer f = new fNewCustomer();
            if (f.ShowDialog() == DialogResult.OK)
            {

                f.Show();
            }
        }
    }
}