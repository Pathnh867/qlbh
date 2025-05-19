using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.Models;

namespace QLBH
{
    public partial class fNewCustomer : Form
    {
        private Customer? customer;
        private ToolTip tooltip = new ToolTip();

        public fNewCustomer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                tooltip.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                tooltip.Show("Hãy nhập địa chỉ khách hàng?", txtAddress, 0, 0, 1000);
                txtAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                tooltip.Show("Hãy nhập điện thoại?", txtPhone, 0, 0, 1000);
                txtPhone.Focus();
                return;
            }

            try
            {
                //Tạo khách hàng mới
                customer = new Customer(); //Tạo một đối tượng khách hàng mới
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.Phone = txtPhone.Text;
                customer.Email = txtEmail.Text;
                customer.BirthDate = dtpBirthDate.Value.Date; // Sửa từ Birthdate thành BirthDate
                customer.Gender = ckGender.CheckState == CheckState.Indeterminate ? (bool?)null : ckGender.Checked;
                customer.Status = ckStatus.Checked;

                using (var db = new EFDbContext())
                {
                    db.Customers.Add(customer); //Thêm khách hàng vào bộ đối tượng
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }

                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                txtAddress.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
                //dtpBirthDate.Text = null;//Không tác dụng
                ckGender.CheckState = CheckState.Indeterminate;
                ckStatus.Checked = true;

                tooltip.Show("Lưu thành công!", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                tooltip.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }

            txtName.Focus();
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                tooltip.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                tooltip.Show("Tên khách hàng <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                tooltip.Show("Hãy nhập địa chỉ?", txtAddress, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtAddress.Text.Length > 250)
            {
                tooltip.Show("Địa chỉ <= 250 ký tự?", txtAddress, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length == 10)
                return;

            tooltip.Show("Không đúng dạng số điện thoại?", txtPhone, 0, 0, 1000);
            e.Cancel = true;
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return; //Có thể không cần nhập dữ liệu cho cột có thể null

            if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                tooltip.Show("Không đúng dạng địa chỉ email?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtEmail.Text.Length > 100)
            {
                tooltip.Show("Địa chỉ email <= 100 ký tự?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void dtpBirthDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dtpBirthDate.Value.Date > DateTime.Now.Date)
            {
                tooltip.Show("Ngày/tháng/năm <= hiện tại?", dtpBirthDate, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void fNewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Không cần thực hiện gì
        }
        private void fNewCustomer_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định
            dtpBirthDate.Value = new DateTime(2000, 1, 1);
            ckGender.CheckState = CheckState.Indeterminate;
            ckStatus.Checked = true;
        }
    }
}