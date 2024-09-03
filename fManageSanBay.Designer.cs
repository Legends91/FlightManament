namespace QLBH
{
    partial class fManageSanBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageSanBay));
            btClose = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            SanBayID = new DataGridViewTextBoxColumn();
            TenSanBay = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            txtName = new TextBox();
            btFind = new Button();
            btNew = new Button();
            reload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(597, 54);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 4;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(245, 9);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 44;
            label2.Text = "QUẢN LÝ SÂN BAY";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SanBayID, TenSanBay, Address, Edit, Delete });
            dataGridView1.Location = new Point(31, 87);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(660, 223);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SanBayID
            // 
            SanBayID.DataPropertyName = "SanBayID";
            SanBayID.FillWeight = 10F;
            SanBayID.Frozen = true;
            SanBayID.HeaderText = "Mã Sân Bay";
            SanBayID.MinimumWidth = 8;
            SanBayID.Name = "SanBayID";
            SanBayID.ReadOnly = true;
            SanBayID.Width = 200;
            // 
            // TenSanBay
            // 
            TenSanBay.DataPropertyName = "TenSanBay";
            TenSanBay.FillWeight = 10F;
            TenSanBay.HeaderText = "Tên Sân Bay";
            TenSanBay.MinimumWidth = 8;
            TenSanBay.Name = "TenSanBay";
            TenSanBay.ReadOnly = true;
            TenSanBay.Width = 150;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.FillWeight = 10F;
            Address.HeaderText = "Địa Điểm";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 125;
            // 
            // Edit
            // 
            Edit.FillWeight = 10F;
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 60;
            // 
            // Delete
            // 
            Delete.FillWeight = 10F;
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 57);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 43;
            label1.Text = "Tên Sân Bay";
            // 
            // txtName
            // 
            txtName.Location = new Point(341, 54);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 27);
            txtName.TabIndex = 2;
            // 
            // btFind
            // 
            btFind.Location = new Point(493, 56);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(90, 27);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(31, 50);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(90, 27);
            btNew.TabIndex = 1;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // reload
            // 
            reload.Image = (Image)resources.GetObject("reload.Image");
            reload.Location = new Point(31, 5);
            reload.Name = "reload";
            reload.Size = new Size(50, 32);
            reload.TabIndex = 45;
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // fManageSanBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(721, 331);
            Controls.Add(reload);
            Controls.Add(btClose);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btFind);
            Controls.Add(btNew);
            DoubleBuffered = true;
            Name = "fManageSanBay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sân bay";
            Activated += fManageSanBay_Activated;
            Load += fManageSanBay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btClose;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtName;
        private Button btFind;
        private Button btNew;
        private DataGridViewTextBoxColumn SanBayID;
        private DataGridViewTextBoxColumn TenSanBay;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button reload;
    }
}