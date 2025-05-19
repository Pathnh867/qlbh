namespace QLBH
{
    partial class fEditCustomer
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
            components = new System.ComponentModel.Container();
            ckStatus = new CheckBox();
            lblStatus = new Label();
            btCancel = new Button();
            btSave = new Button();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            dtpBirthDate = new DateTimePicker();
            ckGender = new CheckBox();
            txtName = new TextBox();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblBirthDate = new Label();
            lblGender = new Label();
            lblName = new Label();
            lblTitle = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(154, 176);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(18, 17);
            ckStatus.TabIndex = 33;
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(33, 173);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(78, 20);
            lblStatus.TabIndex = 32;
            lblStatus.Text = "Trạng thái:";
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.IndianRed;
            btCancel.ForeColor = SystemColors.ButtonHighlight;
            btCancel.Location = new Point(370, 396);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(100, 30);
            btCancel.TabIndex = 31;
            btCancel.Text = "Hủy";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(264, 396);
            btSave.Name = "btSave";
            btSave.Size = new Size(100, 30);
            btSave.TabIndex = 30;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 338);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 25);
            txtEmail.TabIndex = 29;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(154, 289);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 25);
            txtPhone.TabIndex = 28;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(154, 246);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 25);
            txtAddress.TabIndex = 27;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(154, 204);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(108, 27);
            dtpBirthDate.TabIndex = 26;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Indeterminate;
            ckGender.Location = new Point(154, 136);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(63, 24);
            ckGender.TabIndex = 25;
            ckGender.Text = "Nam";
            ckGender.ThreeState = true;
            ckGender.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 24;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(34, 341);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(34, 294);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(81, 20);
            lblPhone.TabIndex = 22;
            lblPhone.Text = "Điện thoại:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(34, 246);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(58, 20);
            lblAddress.TabIndex = 21;
            lblAddress.Text = "Địa chỉ:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(34, 209);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(77, 20);
            lblBirthDate.TabIndex = 20;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(34, 137);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 19;
            lblGender.Text = "Giới tính:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(34, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 20);
            lblName.TabIndex = 18;
            lblName.Text = "Tên khách hàng:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkRed;
            lblTitle.Location = new Point(24, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(435, 31);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "CHỈNH SỬA THÔNG TIN KHÁCH HÀNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // fEditCustomer
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
            Name = "fEditCustomer";
            Text = "Chỉnh sửa thông tin";
            ResumeLayout(false);
            PerformLayout();
            Load += fEditCustomer_Load;
        }

        #endregion

        private CheckBox ckStatus;
        private Label lblStatus;
        private Button btCancel;
        private Button btSave;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private DateTimePicker dtpBirthDate;
        private CheckBox ckGender;
        private TextBox txtName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblBirthDate;
        private Label lblGender;
        private Label lblName;
        private Label lblTitle;
        private ToolTip toolTip1;
    }
}