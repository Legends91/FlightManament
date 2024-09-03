namespace QLBH
{
    partial class fManageChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageChuyenBay));
            dataGridView1 = new DataGridView();
            ChuyenBayID = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            SanBayDi = new DataGridViewTextBoxColumn();
            SanBayDen = new DataGridViewTextBoxColumn();
            ThoiGianDi = new DataGridViewTextBoxColumn();
            ThoiGianDen = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btFind = new Button();
            txtName = new TextBox();
            label1 = new Label();
            btNew = new Button();
            label2 = new Label();
            btClose = new Button();
            reload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ChuyenBayID, ProductID, SanBayDi, SanBayDen, ThoiGianDi, ThoiGianDen, Edit, Delete });
            dataGridView1.Location = new Point(40, 83);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(988, 271);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ChuyenBayID
            // 
            ChuyenBayID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ChuyenBayID.DataPropertyName = "ChuyenBayID";
            ChuyenBayID.HeaderText = "Mã Chuyến Bay";
            ChuyenBayID.MinimumWidth = 8;
            ChuyenBayID.Name = "ChuyenBayID";
            ChuyenBayID.ReadOnly = true;
            ChuyenBayID.Width = 139;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "Mã Máy Bay";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            ProductID.Width = 119;
            // 
            // SanBayDi
            // 
            SanBayDi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SanBayDi.DataPropertyName = "SanBayDi";
            SanBayDi.HeaderText = "Sân bay khởi hành";
            SanBayDi.MinimumWidth = 8;
            SanBayDi.Name = "SanBayDi";
            SanBayDi.ReadOnly = true;
            SanBayDi.Width = 158;
            // 
            // SanBayDen
            // 
            SanBayDen.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SanBayDen.DataPropertyName = "SanBayDen";
            SanBayDen.HeaderText = "Sân Bay Đến";
            SanBayDen.MinimumWidth = 8;
            SanBayDen.Name = "SanBayDen";
            SanBayDen.ReadOnly = true;
            SanBayDen.Resizable = DataGridViewTriState.True;
            SanBayDen.Width = 121;
            // 
            // ThoiGianDi
            // 
            ThoiGianDi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ThoiGianDi.DataPropertyName = "ThoiGianDi";
            ThoiGianDi.HeaderText = "Thời Gian Khởi Hành";
            ThoiGianDi.MinimumWidth = 6;
            ThoiGianDi.Name = "ThoiGianDi";
            ThoiGianDi.ReadOnly = true;
            ThoiGianDi.Width = 174;
            // 
            // ThoiGianDen
            // 
            ThoiGianDen.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ThoiGianDen.DataPropertyName = "ThoiGianDen";
            ThoiGianDen.HeaderText = "Thời Gian Đến";
            ThoiGianDen.MinimumWidth = 6;
            ThoiGianDen.Name = "ThoiGianDen";
            ThoiGianDen.ReadOnly = true;
            ThoiGianDen.Width = 132;
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
            // btFind
            // 
            btFind.Location = new Point(793, 52);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(90, 27);
            btFind.TabIndex = 15;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(580, 52);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 27);
            txtName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(450, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 19;
            label1.Text = "Tên sân bay";
            // 
            // btNew
            // 
            btNew.Location = new Point(40, 50);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(90, 27);
            btNew.TabIndex = 17;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(173, 50);
            label2.Name = "label2";
            label2.Size = new Size(227, 28);
            label2.TabIndex = 18;
            label2.Text = "QUẢN LÝ CHUYẾN BAY";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(934, 50);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 30;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // reload
            // 
            reload.Image = (Image)resources.GetObject("reload.Image");
            reload.Location = new Point(40, 12);
            reload.Name = "reload";
            reload.Size = new Size(50, 32);
            reload.TabIndex = 33;
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // fManageChuyenBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 378);
            ControlBox = false;
            Controls.Add(reload);
            Controls.Add(btClose);
            Controls.Add(dataGridView1);
            Controls.Add(btFind);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btNew);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "fManageChuyenBay";
            Text = "Quản lý chuyến bay";
            WindowState = FormWindowState.Maximized;
            Activated += fManageChuyenBay_Activated;
            Load += fManageChuyenBay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btFind;
        private TextBox txtName;
        private Label label1;
        private Button btNew;
        private Label label2;
        private Button btClose;
        private DataGridViewTextBoxColumn ChuyenBayID;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn SanBayDi;
        private DataGridViewTextBoxColumn SanBayDen;
        private DataGridViewTextBoxColumn ThoiGianDi;
        private DataGridViewTextBoxColumn ThoiGianDen;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button reload;
    }
}