namespace QLBH
{
    partial class fNewOrderTicket
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
            label3 = new Label();
            cbCustomer = new ComboBox();
            label2 = new Label();
            cbChuyenBay = new ComboBox();
            btClose = new Button();
            btSave = new Button();
            label4 = new Label();
            rDescription = new RichTextBox();
            dtOrderTicket = new DateTimePicker();
            label5 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 38);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 35;
            label3.Text = "Khách Hàng";
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(12, 66);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(373, 28);
            cbCustomer.TabIndex = 34;
            cbCustomer.Validating += cbCustomer_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 37;
            label2.Text = "Mã Chuyến Bay";
            // 
            // cbChuyenBay
            // 
            cbChuyenBay.FormattingEnabled = true;
            cbChuyenBay.Location = new Point(12, 149);
            cbChuyenBay.Name = "cbChuyenBay";
            cbChuyenBay.Size = new Size(373, 28);
            cbChuyenBay.TabIndex = 36;
            cbChuyenBay.Validating += cbChuyenBay_Validating;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(702, 183);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 39;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(579, 183);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 38;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(479, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 41;
            label4.Text = "Mô tả ngắn";
            // 
            // rDescription
            // 
            rDescription.Location = new Point(479, 66);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(414, 111);
            rDescription.TabIndex = 40;
            rDescription.Text = "";
            // 
            // dtOrderTicket
            // 
            dtOrderTicket.CustomFormat = "dd/MM/yyyy";
            dtOrderTicket.Format = DateTimePickerFormat.Custom;
            dtOrderTicket.Location = new Point(756, 38);
            dtOrderTicket.Name = "dtOrderTicket";
            dtOrderTicket.Size = new Size(137, 27);
            dtOrderTicket.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(740, 15);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 43;
            label5.Text = "Ngày/tháng/năm sinh";
            // 
            // fNewOrderTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Employee1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(923, 227);
            ControlBox = false;
            Controls.Add(dtOrderTicket);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(rDescription);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label2);
            Controls.Add(cbChuyenBay);
            Controls.Add(label3);
            Controls.Add(cbCustomer);
            DoubleBuffered = true;
            Name = "fNewOrderTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt Vé Mới";
            FormClosing += fNewOrderTicket_FormClosing;
            Load += fNewOrderTicket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cbCustomer;
        private Label label2;
        private ComboBox cbChuyenBay;
        private Button btClose;
        private Button btSave;
        private Label label4;
        private RichTextBox rDescription;
        private DateTimePicker dtOrderTicket;
        private Label label5;
        private ToolTip toolTip1;
    }
}