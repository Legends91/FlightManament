namespace QLBH
{
    partial class fManageTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageTicket));
            btClose = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            TicketID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
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
            btClose.Location = new Point(607, 44);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 5;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(331, 9);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 37;
            label2.Text = "QUẢN LÝ VÉ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TicketID, Name, Price, Edit, Delete });
            dataGridView1.Location = new Point(41, 77);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(660, 217);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TicketID
            // 
            TicketID.DataPropertyName = "TicketID";
            TicketID.FillWeight = 10F;
            TicketID.Frozen = true;
            TicketID.HeaderText = "Mã Vé";
            TicketID.MinimumWidth = 8;
            TicketID.Name = "TicketID";
            TicketID.ReadOnly = true;
            TicketID.Width = 200;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.FillWeight = 10F;
            Name.HeaderText = "Tên Vé";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 150;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.FillWeight = 10F;
            Price.HeaderText = "Giá Vé";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
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
            label1.Location = new Point(264, 47);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 36;
            label1.Text = "Tên Vé";
            // 
            // txtName
            // 
            txtName.Location = new Point(320, 44);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 27);
            txtName.TabIndex = 2;
            // 
            // btFind
            // 
            btFind.Location = new Point(472, 44);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(90, 27);
            btFind.TabIndex = 4;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(41, 40);
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
            reload.Location = new Point(41, 3);
            reload.Name = "reload";
            reload.Size = new Size(50, 32);
            reload.TabIndex = 38;
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // fManageTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(887, 317);
            Controls.Add(reload);
            Controls.Add(btClose);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btFind);
            Controls.Add(btNew);
            DoubleBuffered = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý vé";
            Activated += fManageTicket_Activated;
            Load += fManageTicket_Load;
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
        private DataGridViewTextBoxColumn TicketID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button reload;
    }
}