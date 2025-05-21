namespace QLBH
{
    partial class fEditProduct
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
            toolTip1 = new ToolTip(components);
            btClose = new Button();
            btSave = new Button();
            pictureBox1 = new PictureBox();
            btBrowse = new Button();
            txtImageFile = new TextBox();
            lblImageFile = new Label();
            rDescription = new RichTextBox();
            lblDescription = new Label();
            mMarketPrice = new MaskedTextBox();
            lblMarketPrice = new Label();
            mPrice = new MaskedTextBox();
            lblPrice = new Label();
            mQuantity = new MaskedTextBox();
            lblQuantity = new Label();
            ckStatus = new CheckBox();
            cbCategories = new ComboBox();
            lblCategory = new Label();
            txtName = new TextBox();
            lblName = new Label();
            openFileDialog1 = new OpenFileDialog();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.ImageAlign = ContentAlignment.TopCenter;
            btClose.Location = new Point(526, 496);
            btClose.Name = "btClose";
            btClose.Size = new Size(100, 40);
            btClose.TabIndex = 30;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.Location = new Point(406, 496);
            btSave.Name = "btSave";
            btSave.Size = new Size(100, 40);
            btSave.TabIndex = 28;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(506, 266);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btBrowse
            // 
            btBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBrowse.ImageAlign = ContentAlignment.TopCenter;
            btBrowse.Location = new Point(816, 226);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(40, 27);
            btBrowse.TabIndex = 27;
            btBrowse.Text = "...";
            btBrowse.TextAlign = ContentAlignment.TopCenter;
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(506, 226);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(300, 27);
            txtImageFile.TabIndex = 25;
            txtImageFile.Validating += txtImageFile_Validating;
            // 
            // lblImageFile
            // 
            lblImageFile.AutoSize = true;
            lblImageFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImageFile.ForeColor = Color.Black;
            lblImageFile.Location = new Point(506, 196);
            lblImageFile.Name = "lblImageFile";
            lblImageFile.Size = new Size(97, 20);
            lblImageFile.TabIndex = 26;
            lblImageFile.Text = "Tập tin hình:";
            // 
            // rDescription
            // 
            rDescription.Location = new Point(56, 226);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(400, 150);
            rDescription.TabIndex = 23;
            rDescription.Text = "";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(56, 196);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(93, 20);
            lblDescription.TabIndex = 24;
            lblDescription.Text = "Mô tả ngắn:";
            // 
            // mMarketPrice
            // 
            mMarketPrice.Location = new Point(776, 143);
            mMarketPrice.Name = "mMarketPrice";
            mMarketPrice.Size = new Size(150, 27);
            mMarketPrice.TabIndex = 21;
            mMarketPrice.TypeValidationCompleted += mMarketPrice_TypeValidationCompleted;
            // 
            // lblMarketPrice
            // 
            lblMarketPrice.AutoSize = true;
            lblMarketPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarketPrice.ForeColor = Color.Black;
            lblMarketPrice.Location = new Point(656, 146);
            lblMarketPrice.Name = "lblMarketPrice";
            lblMarketPrice.Size = new Size(112, 20);
            lblMarketPrice.TabIndex = 22;
            lblMarketPrice.Text = "Giá thị trường:";
            // 
            // mPrice
            // 
            mPrice.Location = new Point(456, 143);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(150, 27);
            mPrice.TabIndex = 19;
            mPrice.TypeValidationCompleted += mPrice_TypeValidationCompleted;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(386, 146);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(66, 20);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "Giá bán:";
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(186, 143);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(150, 27);
            mQuantity.TabIndex = 17;
            mQuantity.TypeValidationCompleted += mQuantity_TypeValidationCompleted;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(56, 146);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(75, 20);
            lblQuantity.TabIndex = 18;
            lblQuantity.Text = "Số lượng:";
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckStatus.Location = new Point(806, 96);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(102, 24);
            ckStatus.TabIndex = 16;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(556, 93);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(200, 28);
            cbCategories.TabIndex = 14;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(486, 96);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(42, 20);
            lblCategory.TabIndex = 15;
            lblCategory.Text = "Loại:";
            // 
            // txtName
            // 
            txtName.Location = new Point(186, 93);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 11;
            txtName.Validating += txtName_Validating;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(56, 96);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 20);
            lblName.TabIndex = 13;
            lblName.Text = "Tên Sản phẩm:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkRed;
            lblTitle.Location = new Point(329, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(291, 32);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Chỉnh sửa sản phẩm";
            // 
            // fEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            ControlBox = false;
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(pictureBox1);
            Controls.Add(btBrowse);
            Controls.Add(txtImageFile);
            Controls.Add(lblImageFile);
            Controls.Add(rDescription);
            Controls.Add(lblDescription);
            Controls.Add(mMarketPrice);
            Controls.Add(lblMarketPrice);
            Controls.Add(mPrice);
            Controls.Add(lblPrice);
            Controls.Add(mQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(ckStatus);
            Controls.Add(cbCategories);
            Controls.Add(lblCategory);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "fEditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh sửa chi tiết sản phẩm";
            Load += fEditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Button btClose;
        private Button btSave;
        private PictureBox pictureBox1;
        private Button btBrowse;
        private TextBox txtImageFile;
        private Label lblImageFile;
        private RichTextBox rDescription;
        private Label lblDescription;
        private MaskedTextBox mMarketPrice;
        private Label lblMarketPrice;
        private MaskedTextBox mPrice;
        private Label lblPrice;
        private MaskedTextBox mQuantity;
        private Label lblQuantity;
        private CheckBox ckStatus;
        private ComboBox cbCategories;
        private Label lblCategory;
        private TextBox txtName;
        private Label lblName;
        private OpenFileDialog openFileDialog1;
        private Label lblTitle;
    }
}