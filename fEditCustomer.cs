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
    public partial class fEditCustomer : Form
    {
        private Customer? customer;
        private long CustomerID;
        private EFDbContext db = new EFDbContext();
        private ToolTip tooltip = new ToolTip();

        // Constructor với tham số CustomerID
        public fEditCustomer(long CustomerID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
        }

        // Sự kiện Load của form
        private void fEditCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                // Tìm khách hàng cần sửa
                customer = db.Customers.Single(p => p.CustomerID == CustomerID);

                // Cập nhật tiêu đề form
                this.Text = "SỬA THÔNG TIN KHÁCH HÀNG " + customer.CustomerID.ToString();

                // Đổ dữ liệu vào các điều khiển
                txtName.Text = customer.Name;
                txtAddress.Text = customer.Address;
                txtPhone.Text = customer.Phone;
                txtEmail.Text = customer.Email;
                dtpBirthDate.Value = customer.BirthDate;

                // Xử lý giới tính
                ckGender.CheckState = customer.Gender == null ?
                    CheckState.Indeterminate :
                    (customer.Gender == true ? CheckState.Checked : CheckState.Unchecked);

                // Xử lý trạng thái
                ckStatus.Checked = customer.Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin khách hàng: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        // Sự kiện nhấn nút Lưu
        private void btSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
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
                // Cập nhật thông tin khách hàng
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.Phone = txtPhone.Text;
                customer.Email = txtEmail.Text;
                customer.BirthDate = dtpBirthDate.Value.Date;
                customer.Gender = ckGender.CheckState == CheckState.Indeterminate ? (bool?)null : ckGender.Checked;
                customer.Status = ckStatus.Checked;

                // Lưu thay đổi vào CSDL
                db.SaveChanges();

                tooltip.Show("Cập nhật thành công!", btSave, 0, 0, 1000);

                // Đặt DialogResult để form cha biết cập nhật thành công
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                tooltip.Show("Cập nhật thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
        }

        // Sự kiện nhấn nút Hủy
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Các phương thức kiểm tra dữ liệu nhập
        private void txtName_Validating(object sender, CancelEventArgs e)
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

        private void txtAddress_Validating(object sender, CancelEventArgs e)
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

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length == 10)
                return;

            tooltip.Show("Không đúng dạng số điện thoại?", txtPhone, 0, 0, 1000);
            e.Cancel = true;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return; // Có thể không cần nhập dữ liệu cho cột có thể null

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

        private void dtpBirthDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpBirthDate.Value.Date > DateTime.Now.Date)
            {
                tooltip.Show("Ngày/tháng/năm <= hiện tại?", dtpBirthDate, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        // Xử lý khi đóng form
        private void fEditCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {
            // Không cần thực hiện gì
        }
    }
}