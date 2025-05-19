namespace QLBH
{
    partial class fNewCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            lblGender = new Label();
            lblBirthDate = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            txtName = new TextBox();
            ckGender = new CheckBox();
            dtpBirthDate = new DateTimePicker();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btSave = new Button();
            btCancel = new Button();
            lblStatus = new Label();
            ckStatus = new CheckBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkRed;
            lblTitle.Location = new Point(104, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NHẬP KHÁCH HÀNG MỚI";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 84);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Tên khách hàng:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(23, 135);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 2;
            lblGender.Text = "Giới tính:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(23, 181);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(77, 20);
            lblBirthDate.TabIndex = 3;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(23, 230);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(58, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Địa chỉ:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(23, 275);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(81, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(23, 321);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 7;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Indeterminate;
            ckGender.Location = new Point(143, 138);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(18, 17);
            ckGender.TabIndex = 8;
            ckGender.ThreeState = true;
            ckGender.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(143, 181);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(108, 27);
            dtpBirthDate.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(143, 228);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 25);
            txtAddress.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(143, 273);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 25);
            txtPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 320);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 25);
            txtEmail.TabIndex = 12;
            // 
            // btSave
            // 
            btSave.Location = new Point(253, 366);
            btSave.Name = "btSave";
            btSave.Size = new Size(100, 43);
            btSave.TabIndex = 13;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btnSave_Click;
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.IndianRed;
            btCancel.ForeColor = SystemColors.ButtonHighlight;
            btCancel.Location = new Point(359, 366);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(100, 43);
            btCancel.TabIndex = 14;
            btCancel.Text = "Hủy";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btnCancel_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(222, 135);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(78, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Trạng thái:";
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(349, 138);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(18, 17);
            ckStatus.TabIndex = 16;
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // fNewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            ControlBox = false;
            Controls.Add(ckStatus);
            Controls.Add(lblStatus);
            Controls.Add(btCancel);
            Controls.Add(btSave);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(dtpBirthDate);
            Controls.Add(ckGender);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblBirthDate);
            Controls.Add(lblGender);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fNewCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập khách hàng mới";
            Load += fNewCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblGender;
        private Label lblBirthDate;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblEmail;
        private TextBox txtName;
        private CheckBox ckGender;
        private DateTimePicker dtpBirthDate;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btSave;
        private Button btCancel;
        private Label lblStatus;
        private CheckBox ckStatus;
    }
}