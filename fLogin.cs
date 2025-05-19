using System;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập tên người dùng?";
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập mật khẩu?";
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    using (var db = new EFDbContext())
                    {
                        Utility.Employee = db.Employees.SingleOrDefault(e =>
                        e.Email == txtUsername.Text && e.Password == txtPassword.Text);
                        if (Utility.Employee == null) //Nếu đăng nhập thất bại
                        {
                            lblMessage.Text = "Sai tên người dùng hoặc mật khẩu";
                            txtUsername.Focus();
                        }
                        else
                            DialogResult = DialogResult.OK; //đóng form
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Lỗi";
                }
            }
        }
        private void fLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = ""; 
            txtPassword.Text = "";
            lblMessage.Text = "";
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void liForget_Click(object sender, EventArgs e)
        {
            
        }
    }
}