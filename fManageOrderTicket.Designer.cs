namespace QLBH
{
    partial class fManageOrderTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageOrderTicket));
            label2 = new Label();
            btFind = new Button();
            btNew = new Button();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            OrderTicketID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            ChuyenBayID = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Sửa = new DataGridViewButtonColumn();
            Xóa = new DataGridViewButtonColumn();
            btClose = new Button();
            reload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(376, 24);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 10;
            label2.Text = "QUẢN LÝ ĐẶT VÉ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btFind
            // 
            btFind.Location = new Point(921, 83);
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
            btNew.Location = new Point(17, 80);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(90, 27);
            btNew.TabIndex = 4;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "Tất cả", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbMonth.Location = new Point(403, 83);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(108, 28);
            cbMonth.TabIndex = 1;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(180, 81);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(108, 28);
            cbYear.TabIndex = 0;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(122, 84);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 84);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 14;
            label1.Text = "Tháng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(126, 84);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 15;
            label4.Text = "Năm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(570, 84);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 16;
            label5.Text = "Ngày đặt hàng";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(705, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderTicketID, CustomerID, ChuyenBayID, OrderDate, Description, Sửa, Xóa });
            dataGridView1.Location = new Point(17, 123);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(891, 242);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OrderTicketID
            // 
            OrderTicketID.DataPropertyName = "OrderTicketID";
            OrderTicketID.HeaderText = "Mã Đặt Vé";
            OrderTicketID.MinimumWidth = 8;
            OrderTicketID.Name = "OrderTicketID";
            OrderTicketID.ReadOnly = true;
            OrderTicketID.Width = 130;
            // 
            // CustomerID
            // 
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "Mã Khách Hàng";
            CustomerID.MinimumWidth = 8;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Width = 116;
            // 
            // ChuyenBayID
            // 
            ChuyenBayID.DataPropertyName = "ChuyenBayID";
            ChuyenBayID.HeaderText = "Mã Chuyến Bay";
            ChuyenBayID.MinimumWidth = 8;
            ChuyenBayID.Name = "ChuyenBayID";
            ChuyenBayID.ReadOnly = true;
            ChuyenBayID.Width = 125;
            // 
            // OrderDate
            // 
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.HeaderText = "Ngày Đặt Vé";
            OrderDate.MinimumWidth = 8;
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            OrderDate.Width = 150;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Ghi Chú";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 180;
            // 
            // Sửa
            // 
            Sửa.HeaderText = "Sửa";
            Sửa.MinimumWidth = 8;
            Sửa.Name = "Sửa";
            Sửa.ReadOnly = true;
            Sửa.Resizable = DataGridViewTriState.True;
            Sửa.SortMode = DataGridViewColumnSortMode.Automatic;
            Sửa.Text = "Sửa";
            Sửa.UseColumnTextForButtonValue = true;
            Sửa.Width = 63;
            // 
            // Xóa
            // 
            Xóa.HeaderText = "Xóa";
            Xóa.MinimumWidth = 8;
            Xóa.Name = "Xóa";
            Xóa.ReadOnly = true;
            Xóa.Text = "Xóa";
            Xóa.UseColumnTextForButtonValue = true;
            Xóa.Width = 63;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(921, 123);
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
            reload.Location = new Point(17, 12);
            reload.Name = "reload";
            reload.Size = new Size(50, 32);
            reload.TabIndex = 33;
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // fManageOrderTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1035, 388);
            ControlBox = false;
            Controls.Add(reload);
            Controls.Add(btClose);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Controls.Add(label2);
            Controls.Add(btFind);
            Controls.Add(btNew);
            DoubleBuffered = true;
            Name = "fManageOrderTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý đặt vé";
            WindowState = FormWindowState.Maximized;
            Activated += fManageOrder_Activated;
            Load += fManageOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btFind;
        private Button btNew;
        private ComboBox cbMonth;
        private ComboBox cbYear;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn OrderTicketID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn ChuyenBayID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewButtonColumn Sửa;
        private DataGridViewButtonColumn Xóa;
        private Button btClose;
        private Button reload;
    }
}