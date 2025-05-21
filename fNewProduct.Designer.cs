namespace QLBH
{
    partial class fNewProduct
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
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblCategory = new Label();
            cbCategories = new ComboBox();
            ckStatus = new CheckBox();
            lblQuantity = new Label();
            mQuantity = new MaskedTextBox();
            lblPrice = new Label();
            mPrice = new MaskedTextBox();
            lblMarketPrice = new Label();
            mMarketPrice = new MaskedTextBox();
            lblDescription = new Label();
            rDescription = new RichTextBox();
            lblImageFile = new Label();
            txtImageFile = new TextBox();
            btBrowse = new Button();
            pictureBox1 = new PictureBox();
            btSave = new Button();
            btClose = new Button();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkRed;
            lblTitle.Location = new Point(323, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(358, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nhập thêm sản phẩm mới";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(50, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Tên Sản phẩm:";
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(480, 100);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(42, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Loại:";
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(550, 97);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(200, 28);
            cbCategories.TabIndex = 1;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckStatus.Location = new Point(800, 100);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(102, 24);
            ckStatus.TabIndex = 2;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(50, 150);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(75, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Số lượng:";
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(180, 147);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(150, 27);
            mQuantity.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(380, 150);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(66, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Giá bán:";
            // 
            // mPrice
            // 
            mPrice.Location = new Point(450, 147);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(150, 27);
            mPrice.TabIndex = 4;
            // 
            // lblMarketPrice
            // 
            lblMarketPrice.AutoSize = true;
            lblMarketPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarketPrice.ForeColor = Color.Black;
            lblMarketPrice.Location = new Point(650, 150);
            lblMarketPrice.Name = "lblMarketPrice";
            lblMarketPrice.Size = new Size(112, 20);
            lblMarketPrice.TabIndex = 6;
            lblMarketPrice.Text = "Giá thị trường:";
            // 
            // mMarketPrice
            // 
            mMarketPrice.Location = new Point(770, 147);
            mMarketPrice.Name = "mMarketPrice";
            mMarketPrice.Size = new Size(150, 27);
            mMarketPrice.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(50, 200);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(93, 20);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Mô tả ngắn:";
            // 
            // rDescription
            // 
            rDescription.Location = new Point(50, 230);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(400, 150);
            rDescription.TabIndex = 6;
            rDescription.Text = "";
            // 
            // lblImageFile
            // 
            lblImageFile.AutoSize = true;
            lblImageFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImageFile.ForeColor = Color.Black;
            lblImageFile.Location = new Point(500, 200);
            lblImageFile.Name = "lblImageFile";
            lblImageFile.Size = new Size(97, 20);
            lblImageFile.TabIndex = 8;
            lblImageFile.Text = "Tập tin hình:";
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(500, 230);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(300, 27);
            txtImageFile.TabIndex = 7;
            // 
            // btBrowse
            // 
            btBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBrowse.ImageAlign = ContentAlignment.TopCenter;
            btBrowse.Location = new Point(810, 230);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(40, 27);
            btBrowse.TabIndex = 8;
            btBrowse.Text = "...";
            btBrowse.TextAlign = ContentAlignment.TopCenter;
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(500, 270);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btSave
            // 
            btSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.Location = new Point(400, 500);
            btSave.Name = "btSave";
            btSave.Size = new Size(100, 40);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.ImageAlign = ContentAlignment.TopCenter;
            btClose.Location = new Point(520, 500);
            btClose.Name = "btClose";
            btClose.Size = new Size(100, 40);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // fNewProduct
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
            Name = "fNewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập thêm sản phẩm mới";
            WindowState = FormWindowState.Maximized;
            Load += fNewProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblCategory;
        private ComboBox cbCategories;
        private CheckBox ckStatus;
        private Label lblQuantity;
        private MaskedTextBox mQuantity;
        private Label lblPrice;
        private MaskedTextBox mPrice;
        private Label lblMarketPrice;
        private MaskedTextBox mMarketPrice;
        private Label lblDescription;
        private RichTextBox rDescription;
        private Label lblImageFile;
        private TextBox txtImageFile;
        private Button btBrowse;
        private PictureBox pictureBox1;
        private Button btSave;
        private Button btClose;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
    }
}