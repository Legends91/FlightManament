namespace QLBH
{
    partial class fEditOrderTicket
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
            dtOrderTicket = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            rDescription = new RichTextBox();
            btClose = new Button();
            btSave = new Button();
            label2 = new Label();
            cbChuyenBay = new ComboBox();
            label3 = new Label();
            cbCustomer = new ComboBox();
            label1 = new Label();
            cbOrderTicket = new ComboBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // dtOrderTicket
            // 
            dtOrderTicket.CustomFormat = "dd/MM/yyyy";
            dtOrderTicket.Format = DateTimePickerFormat.Custom;
            dtOrderTicket.Location = new Point(765, 38);
            dtOrderTicket.Name = "dtOrderTicket";
            dtOrderTicket.Size = new Size(137, 27);
            dtOrderTicket.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(749, 15);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 53;
            label5.Text = "Ngày/tháng/năm sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 51;
            label4.Text = "Mô tả ngắn";
            // 
            // rDescription
            // 
            rDescription.Location = new Point(488, 66);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(414, 154);
            rDescription.TabIndex = 50;
            rDescription.Text = "";
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(717, 226);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 49;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(584, 226);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 48;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 204);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 47;
            label2.Text = "Mã Chuyến Bay";
            // 
            // cbChuyenBay
            // 
            cbChuyenBay.FormattingEnabled = true;
            cbChuyenBay.Location = new Point(22, 227);
            cbChuyenBay.Name = "cbChuyenBay";
            cbChuyenBay.Size = new Size(373, 28);
            cbChuyenBay.TabIndex = 46;
            cbChuyenBay.Validating += cbChuyenBay_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 116);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 45;
            label3.Text = "Khách Hàng";
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(22, 144);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(373, 28);
            cbCustomer.TabIndex = 44;
            cbCustomer.Validating += cbCustomer_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 55;
            label1.Text = "Mã Đặt Vé";
            // 
            // cbOrderTicket
            // 
            cbOrderTicket.Enabled = false;
            cbOrderTicket.FormattingEnabled = true;
            cbOrderTicket.Location = new Point(22, 66);
            cbOrderTicket.Name = "cbOrderTicket";
            cbOrderTicket.Size = new Size(373, 28);
            cbOrderTicket.TabIndex = 54;
            // 
            // fEditOrderTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 286);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(cbOrderTicket);
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
            Name = "fEditOrderTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa đặt vé";
            FormClosing += fEditOrderTicket_FormClosing;
            Load += fEditOrderTicket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtOrderTicket;
        private Label label5;
        private Label label4;
        private RichTextBox rDescription;
        private Button btClose;
        private Button btSave;
        private Label label2;
        private ComboBox cbChuyenBay;
        private Label label3;
        private ComboBox cbCustomer;
        private Label label1;
        private ComboBox cbOrderTicket;
        private ToolTip toolTip1;
    }
}