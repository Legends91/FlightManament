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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageProduct));
            label2 = new Label();
            btNew = new Button();
            label1 = new Label();
            txtName = new TextBox();
            btFind = new Button();
            dataGridView1 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ImageFile = new DataGridViewTextBoxColumn();
            Manufacturer = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label3 = new Label();
            cbCategories = new ComboBox();
            ckCategory = new CheckBox();
            pictureBox1 = new PictureBox();
            btClose = new Button();
            reload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(244, 25);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 5;
            label2.Text = "QUẢN LÝ MÁY BAY";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btNew
            // 
            btNew.Location = new Point(22, 75);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(90, 27);
            btNew.TabIndex = 5;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(487, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên sản phẩm";
            // 
            // txtName
            // 
            txtName.Location = new Point(591, 22);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 27);
            txtName.TabIndex = 2;
            // 
            // btFind
            // 
            btFind.Location = new Point(807, 22);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(90, 27);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductID, Category, ProductName, ImageFile, Manufacturer, Status, Edit, Delete });
            dataGridView1.Location = new Point(22, 109);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1337, 271);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductID
            // 
            ProductID.DataPropertyName = "ProductID";
            ProductID.Frozen = true;
            ProductID.HeaderText = "Mã Máy Bay";
            ProductID.MinimumWidth = 8;
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            ProductID.Width = 125;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Category.DataPropertyName = "CategoryID";
            Category.Frozen = true;
            Category.HeaderText = "Mã Loại Máy Bay";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 151;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "Name";
            ProductName.Frozen = true;
            ProductName.HeaderText = "Tên Máy Bay";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 160;
            // 
            // ImageFile
            // 
            ImageFile.DataPropertyName = "ImageFile";
            ImageFile.HeaderText = "Ảnh";
            ImageFile.MinimumWidth = 8;
            ImageFile.Name = "ImageFile";
            ImageFile.ReadOnly = true;
            ImageFile.Resizable = DataGridViewTriState.True;
            ImageFile.Width = 120;
            // 
            // Manufacturer
            // 
            Manufacturer.DataPropertyName = "Manufacturer";
            Manufacturer.HeaderText = "Nhà Sản Xuất";
            Manufacturer.MinimumWidth = 6;
            Manufacturer.Name = "Manufacturer";
            Manufacturer.ReadOnly = true;
            Manufacturer.Width = 140;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Tình Trạng";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 84;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 40;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(166, 78);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 11;
            label3.Text = "Chọn loại";
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(244, 74);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(205, 28);
            cbCategories.TabIndex = 0;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // ckCategory
            // 
            ckCategory.AutoSize = true;
            ckCategory.CheckAlign = ContentAlignment.MiddleRight;
            ckCategory.Checked = true;
            ckCategory.CheckState = CheckState.Checked;
            ckCategory.Location = new Point(591, 65);
            ckCategory.Name = "ckCategory";
            ckCategory.Size = new Size(231, 24);
            ckCategory.TabIndex = 4;
            ckCategory.Text = "Tìm theo loại sản phẩm và tên";
            ckCategory.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(986, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(1265, 75);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 31;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // reload
            // 
            reload.Image = (Image)resources.GetObject("reload.Image");
            reload.Location = new Point(22, 12);
            reload.Name = "reload";
            reload.Size = new Size(50, 32);
            reload.TabIndex = 33;
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // fManageProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 395);
            ControlBox = false;
            Controls.Add(reload);
            Controls.Add(btClose);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(ckCategory);
            Controls.Add(cbCategories);
            Controls.Add(label3);
            Controls.Add(btFind);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btNew);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "fManageProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý máy bay";
            WindowState = FormWindowState.Maximized;
            Activated += fManageProduct_Activated;
            Load += fManageProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btNew;
        private Label label1;
        private TextBox txtName;
        private Button btFind;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox cbCategories;
        private CheckBox ckCategory;
        private PictureBox pictureBox1;
        private Button btClose;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ImageFile;
        private DataGridViewTextBoxColumn Manufacturer;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button reload;
    }
}