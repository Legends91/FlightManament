namespace QLBH
{
    partial class fManageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageCategory));
            btClose = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            CategoryID = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
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
            btClose.Location = new Point(563, 54);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 42;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(217, 9);
            label2.Name = "label2";
            label2.Size = new Size(241, 28);
            label2.TabIndex = 44;
            label2.Text = "QUẢN LÝ LOẠI MÁY BAY";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CategoryID, CategoryName, Edit, Delete });
            dataGridView1.Location = new Point(73, 88);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(534, 223);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CategoryID
            // 
            CategoryID.DataPropertyName = "CategoryID";
            CategoryID.FillWeight = 10F;
            CategoryID.Frozen = true;
            CategoryID.HeaderText = "Mã Loại Máy Bay";
            CategoryID.MinimumWidth = 8;
            CategoryID.Name = "CategoryID";
            CategoryID.ReadOnly = true;
            CategoryID.Width = 200;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.FillWeight = 10F;
            CategoryName.HeaderText = "Tên Loại Máy Bay";
            CategoryName.MinimumWidth = 8;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            CategoryName.Width = 150;
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
            label1.Location = new Point(176, 57);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 43;
            label1.Text = "Tên loại máy bay";
            // 
            // txtName
            // 
            txtName.Location = new Point(301, 54);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 27);
            txtName.TabIndex = 40;
            // 
            // btFind
            // 
            btFind.Location = new Point(453, 54);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(90, 27);
            btFind.TabIndex = 41;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(22, 50);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(90, 27);
            btNew.TabIndex = 39;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // reload
            // 
            reload.Image = (Image)resources.GetObject("reload.Image");
            reload.Location = new Point(22, 9);
            reload.Name = "reload";
            reload.Size = new Size(50, 32);
            reload.TabIndex = 45;
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // fManageCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 322);
            ControlBox = false;
            Controls.Add(reload);
            Controls.Add(btClose);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btFind);
            Controls.Add(btNew);
            DoubleBuffered = true;
            Name = "fManageCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý loại máy bay";
            Activated += fManageCategory_Activated;
            Load += fManageCategory_Load;
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
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button reload;
    }
}