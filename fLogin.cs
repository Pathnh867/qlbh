using Microsoft.IdentityModel.Tokens;
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
            else if (txtUsername.Text != "u")
            {
                lblMessage.Text = "Bạn đã nhập sai tên người dùng?";
                txtUsername.Focus();
            }
            else if (txtPassword.Text != "1")
            {
                lblMessage.Text = "Bạn đã nhập sai mật khẩu?";
                txtPassword.Focus();
            }
            else
            {
                Utility.Username = txtUsername.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
