namespace QLBH
{
    partial class fProcessOrderTicketDetails
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            cbOrderTicket = new ComboBox();
            label4 = new Label();
            label10 = new Label();
            cbVe = new ComboBox();
            panel2 = new Panel();
            label11 = new Label();
            dtOrderDate = new DateTimePicker();
            label13 = new Label();
            btAddOrderDetail = new Button();
            btClose = new Button();
            panel3 = new Panel();
            mThoiGianDi = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            mThoiGianDen = new MaskedTextBox();
            label7 = new Label();
            panel4 = new Panel();
            mQuantity = new MaskedTextBox();
            label8 = new Label();
            mPrice = new MaskedTextBox();
            label9 = new Label();
            ckTT = new CheckBox();
            cbCustomers = new ComboBox();
            dataGridView1 = new DataGridView();
            Delete = new DataGridViewButtonColumn();
            OrderTicketDetailID = new DataGridViewTextBoxColumn();
            OrderTicketID = new DataGridViewTextBoxColumn();
            TicketID = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            toolTip1 = new ToolTip(components);
            label12 = new Label();
            cbSanBayDi = new ComboBox();
            label2 = new Label();
            cbSanBayDen = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Khách hàng";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(cbOrderTicket);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbVe);
            panel1.Location = new Point(31, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 119);
            panel1.TabIndex = 3;
            // 
            // cbOrderTicket
            // 
            cbOrderTicket.FormattingEnabled = true;
            cbOrderTicket.Location = new Point(185, 63);
            cbOrderTicket.Name = "cbOrderTicket";
            cbOrderTicket.Size = new Size(151, 28);
            cbOrderTicket.TabIndex = 0;
            toolTip1.SetToolTip(cbOrderTicket, "Length");
            cbOrderTicket.SelectionChangeCommitted += cbOrderTickets_SelectionChangeCommitted;
            cbOrderTicket.Validating += cbOrderTickets_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(185, 28);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 4;
            label4.Text = "Chọn mã đặt vé";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(18, 28);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 2;
            label10.Text = "Chọn vé";
            // 
            // cbVe
            // 
            cbVe.FormattingEnabled = true;
            cbVe.Location = new Point(18, 63);
            cbVe.Name = "cbVe";
            cbVe.Size = new Size(137, 28);
            cbVe.TabIndex = 1;
            cbVe.SelectedIndexChanged += cbVe_SelectedIndexChanged;
            cbVe.Validating += cbVe_Validating;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dtOrderDate);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btAddOrderDetail);
            panel2.Controls.Add(btClose);
            panel2.Location = new Point(425, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 111);
            panel2.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(47, 47);
            label11.Name = "label11";
            label11.Size = new Size(123, 20);
            label11.TabIndex = 21;
            label11.Text = "Ngày/tháng/năm";
            // 
            // dtOrderDate
            // 
            dtOrderDate.CustomFormat = "dd/MM/yyyy";
            dtOrderDate.Enabled = false;
            dtOrderDate.Format = DateTimePickerFormat.Custom;
            dtOrderDate.Location = new Point(47, 70);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(123, 27);
            dtOrderDate.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(61, 20);
            label13.Name = "label13";
            label13.Size = new Size(96, 23);
            label13.TabIndex = 19;
            label13.Text = "NGÀY ĐẶT";
            // 
            // btAddOrderDetail
            // 
            btAddOrderDetail.Location = new Point(229, 20);
            btAddOrderDetail.Name = "btAddOrderDetail";
            btAddOrderDetail.Size = new Size(94, 29);
            btAddOrderDetail.TabIndex = 3;
            btAddOrderDetail.Text = "Thêm";
            btAddOrderDetail.UseVisualStyleBackColor = true;
            btAddOrderDetail.Click += btAddOrderDetail_Click;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(229, 71);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 5;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(mThoiGianDi);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(mThoiGianDen);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(425, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 119);
            panel3.TabIndex = 6;
            // 
            // mThoiGianDi
            // 
            mThoiGianDi.Enabled = false;
            mThoiGianDi.Location = new Point(11, 72);
            mThoiGianDi.Mask = "00:00:00";
            mThoiGianDi.Name = "mThoiGianDi";
            mThoiGianDi.Size = new Size(145, 27);
            mThoiGianDi.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 49);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 21;
            label5.Text = "Thời Gian Đến Nơi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 49);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 20;
            label6.Text = "Thời Gian Khởi Hành";
            // 
            // mThoiGianDen
            // 
            mThoiGianDen.Enabled = false;
            mThoiGianDen.Location = new Point(164, 72);
            mThoiGianDen.Mask = "00:00:00";
            mThoiGianDen.Name = "mThoiGianDen";
            mThoiGianDen.Size = new Size(145, 27);
            mThoiGianDen.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(113, 15);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 19;
            label7.Text = "THỜI GIAN";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(mQuantity);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(mPrice);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(31, 214);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 111);
            panel4.TabIndex = 5;
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(18, 71);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(125, 27);
            mQuantity.TabIndex = 21;
            toolTip1.SetToolTip(mQuantity, "Length");
            mQuantity.TypeValidationCompleted += mQuantity_TypeValidationCompleted;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(185, 38);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 8;
            label8.Text = "Đơn giá";
            // 
            // mPrice
            // 
            mPrice.Enabled = false;
            mPrice.Location = new Point(185, 70);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(151, 27);
            mPrice.TabIndex = 20;
            toolTip1.SetToolTip(mPrice, "Length");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 38);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 4;
            label9.Text = "Số lượng";
            // 
            // ckTT
            // 
            ckTT.AutoSize = true;
            ckTT.BackColor = SystemColors.GradientInactiveCaption;
            ckTT.CheckAlign = ContentAlignment.MiddleRight;
            ckTT.Checked = true;
            ckTT.CheckState = CheckState.Indeterminate;
            ckTT.Location = new Point(207, 25);
            ckTT.Name = "ckTT";
            ckTT.Size = new Size(173, 24);
            ckTT.TabIndex = 3;
            ckTT.Text = "Tình trạng thanh toán";
            ckTT.ThreeState = true;
            ckTT.UseVisualStyleBackColor = false;
            // 
            // cbCustomers
            // 
            cbCustomers.Enabled = false;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(31, 49);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(349, 28);
            cbCustomers.TabIndex = 10;
            toolTip1.SetToolTip(cbCustomers, "Length");
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "DataGridView";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delete, OrderTicketDetailID, OrderTicketID, TicketID, Price, Quantity, OrderDate, Status, Amount });
            dataGridView1.Location = new Point(31, 346);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(720, 127);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 59;
            // 
            // OrderTicketDetailID
            // 
            OrderTicketDetailID.DataPropertyName = "OrderTicketDetailID";
            OrderTicketDetailID.HeaderText = "Mã Chi Tiết";
            OrderTicketDetailID.MinimumWidth = 6;
            OrderTicketDetailID.Name = "OrderTicketDetailID";
            OrderTicketDetailID.Width = 125;
            // 
            // OrderTicketID
            // 
            OrderTicketID.DataPropertyName = "OrderTicketID";
            OrderTicketID.HeaderText = "Mã Đặt Vé";
            OrderTicketID.MinimumWidth = 8;
            OrderTicketID.Name = "OrderTicketID";
            OrderTicketID.Width = 81;
            // 
            // TicketID
            // 
            TicketID.DataPropertyName = "TicketID";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            TicketID.DefaultCellStyle = dataGridViewCellStyle1;
            TicketID.HeaderText = "Mã Vé";
            TicketID.MinimumWidth = 6;
            TicketID.Name = "TicketID";
            TicketID.ToolTipText = "Length";
            TicketID.Width = 101;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Price.DefaultCellStyle = dataGridViewCellStyle2;
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ToolTipText = "Length";
            Price.Width = 81;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.ToolTipText = "Length";
            Quantity.Width = 102;
            // 
            // OrderDate
            // 
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.HeaderText = "Ngày đặt";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Tình trạng thanh toán";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            Status.ThreeState = true;
            Status.Width = 120;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Tổng Giá";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.ToolTipText = "Length";
            Amount.Width = 103;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.GradientInactiveCaption;
            label12.Location = new Point(425, 29);
            label12.Name = "label12";
            label12.Size = new Size(129, 20);
            label12.TabIndex = 35;
            label12.Text = "Sân bay khởi hành";
            // 
            // cbSanBayDi
            // 
            cbSanBayDi.Enabled = false;
            cbSanBayDi.FormattingEnabled = true;
            cbSanBayDi.Location = new Point(425, 49);
            cbSanBayDi.Name = "cbSanBayDi";
            cbSanBayDi.Size = new Size(156, 28);
            cbSanBayDi.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(603, 29);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 38;
            label2.Text = "Sân bay đến";
            // 
            // cbSanBayDen
            // 
            cbSanBayDen.Enabled = false;
            cbSanBayDen.FormattingEnabled = true;
            cbSanBayDen.Location = new Point(603, 49);
            cbSanBayDen.Name = "cbSanBayDen";
            cbSanBayDen.Size = new Size(148, 28);
            cbSanBayDen.TabIndex = 37;
            // 
            // fProcessOrderTicketDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Details1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(789, 484);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(cbSanBayDen);
            Controls.Add(ckTT);
            Controls.Add(cbSanBayDi);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(cbCustomers);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "fProcessOrderTicketDetails";
            Text = "Xử lý chi tiết chuyến bay";
            WindowState = FormWindowState.Maximized;
            FormClosing += fProcessOrderTicketDetails_FormClosing;
            Load += fProcessOrderTicketDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox cbOrderTicket;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label10;
        private Button btClose;
        private ComboBox cbCustomers;
        private MaskedTextBox mThoiGianDen;
        private DateTimePicker dtOrderDate;
        private Label label11;
        private Label label13;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
        private ComboBox cbVe;
        private Label label8;
        private MaskedTextBox mPrice;
        private Button btAddOrderDetail;
        private MaskedTextBox mThoiGianDi;
        private CheckBox ckTT;
        private Label label12;
        private ComboBox cbSanBayDi;
        private Label label2;
        private ComboBox cbSanBayDen;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn OrderTicketDetailID;
        private DataGridViewTextBoxColumn OrderTicketID;
        private DataGridViewTextBoxColumn TicketID;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn Amount;
        private MaskedTextBox mQuantity;
        private Label label9;
    }
}