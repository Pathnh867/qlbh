namespace QLBH
{
    partial class fManageProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblCategory = new Label();
            cbCategories = new ComboBox();
            btNew = new Button();
            lblNumOfProduct = new Label();
            lblProductName = new Label();
            txtName = new TextBox();
            btFind = new Button();
            ckCategory = new CheckBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            MarketPrice = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ImageFile = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkRed;
            lblTitle.Location = new Point(305, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(329, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(50, 80);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Chọn loại:";
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(130, 77);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(200, 28);
            cbCategories.TabIndex = 0;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // btNew
            // 
            btNew.Location = new Point(50, 120);
            btNew.Name = "btNew";
            btNew.Size = new Size(100, 35);
            btNew.TabIndex = 5;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // lblNumOfProduct
            // 
            lblNumOfProduct.AutoSize = true;
            lblNumOfProduct.Location = new Point(170, 130);
            lblNumOfProduct.Name = "lblNumOfProduct";
            lblNumOfProduct.Size = new Size(109, 20);
            lblNumOfProduct.TabIndex = 6;
            lblNumOfProduct.Text = "Số sản phẩm: 0";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(582, 80);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(103, 20);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "Tên sản phẩm:";
            // 
            // txtName
            // 
            txtName.Location = new Point(692, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 2;
            // 
            // btFind
            // 
            btFind.Location = new Point(902, 75);
            btFind.Name = "btFind";
            btFind.Size = new Size(60, 27);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // ckCategory
            // 
            ckCategory.AutoSize = true;
            ckCategory.CheckAlign = ContentAlignment.MiddleRight;
            ckCategory.Checked = true;
            ckCategory.CheckState = CheckState.Checked;
            ckCategory.Location = new Point(692, 110);
            ckCategory.Name = "ckCategory";
            ckCategory.Size = new Size(231, 24);
            ckCategory.TabIndex = 4;
            ckCategory.Text = "Tìm theo loại sản phẩm và tên";
            ckCategory.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(370, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Quantity, Price, MarketPrice, Description, ImageFile, Status, Edit, Delete });
            dataGridView1.Location = new Point(41, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(910, 522);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.Width = 104;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductName.DataPropertyName = "Name";
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 78;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            Quantity.DefaultCellStyle = dataGridViewCellStyle1;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 94;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Price.DefaultCellStyle = dataGridViewCellStyle2;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 70;
            // 
            // MarketPrice
            // 
            MarketPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MarketPrice.DataPropertyName = "MarketPrice";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            MarketPrice.DefaultCellStyle = dataGridViewCellStyle3;
            MarketPrice.HeaderText = "MarketPrice";
            MarketPrice.MinimumWidth = 6;
            MarketPrice.Name = "MarketPrice";
            MarketPrice.Width = 116;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 114;
            // 
            // ImageFile
            // 
            ImageFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ImageFile.DataPropertyName = "ImageFile";
            ImageFile.HeaderText = "ImageFile";
            ImageFile.MinimumWidth = 6;
            ImageFile.Name = "ImageFile";
            ImageFile.Width = 103;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            Status.Width = 78;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 41;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 59;
            // 
            // fManageProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(986, 753);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(ckCategory);
            Controls.Add(btFind);
            Controls.Add(txtName);
            Controls.Add(lblProductName);
            Controls.Add(lblNumOfProduct);
            Controls.Add(btNew);
            Controls.Add(cbCategories);
            Controls.Add(lblCategory);
            Controls.Add(lblTitle);
            Name = "fManageProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Sản phẩm";
            Activated += fManageProduct_Activated;
            Load += fManageProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCategory;
        private ComboBox cbCategories;
        private Button btNew;
        private Label lblNumOfProduct;
        private Label lblProductName;
        private TextBox txtName;
        private Button btFind;
        private CheckBox ckCategory;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn MarketPrice;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ImageFile;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}