namespace QLBH
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelLogin = new Label();
            labelUserName = new Label();
            labelPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btOK = new Button();
            btCancel = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.ForeColor = Color.IndianRed;
            labelLogin.Location = new Point(38, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(338, 81);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Đăng Nhập";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(48, 117);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(149, 28);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Tên người dùng";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(48, 207);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(94, 28);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(48, 163);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(287, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(48, 252);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(287, 27);
            txtPassword.TabIndex = 4;
            // 
            // btOK
            // 
            btOK.Location = new Point(128, 319);
            btOK.Name = "btOK";
            btOK.Size = new Size(110, 42);
            btOK.TabIndex = 5;
            btOK.Text = "Đăng Nhập";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += button1_Click;
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.IndianRed;
            btCancel.ForeColor = Color.Black;
            btCancel.Location = new Point(128, 367);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(110, 42);
            btCancel.TabIndex = 6;
            btCancel.Text = "Hủy bỏ";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(48, 294);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 7;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 421);
            ControlBox = false;
            Controls.Add(lblMessage);
            Controls.Add(btCancel);
            Controls.Add(btOK);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(labelLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "fLogin";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelUserName;
        private Label labelPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btOK;
        private Button btCancel;
        private Label lblMessage;
    }
}
