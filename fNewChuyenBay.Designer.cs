namespace QLBH
{
    partial class fNewChuyenBay
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
            cbProducts = new ComboBox();
            btClose = new Button();
            btSave = new Button();
            label2 = new Label();
            label1 = new Label();
            cbSanBayDi = new ComboBox();
            cbSanBayDen = new ComboBox();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            panel2 = new Panel();
            label6 = new Label();
            mThoiGianDen = new MaskedTextBox();
            label13 = new Label();
            mThoiGianDi = new MaskedTextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cbProducts
            // 
            cbProducts.Location = new Point(12, 43);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(373, 28);
            cbProducts.TabIndex = 1;
            cbProducts.SelectionChangeCommitted += cbProducts_SelectionChangeCommitted;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(530, 180);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 8;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(418, 180);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 7;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(418, 20);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 11;
            label2.Text = "Sân bay khởi hành";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 9;
            label1.Text = "Máy Bay";
            // 
            // cbSanBayDi
            // 
            cbSanBayDi.FormattingEnabled = true;
            cbSanBayDi.Location = new Point(418, 43);
            cbSanBayDi.Name = "cbSanBayDi";
            cbSanBayDi.Size = new Size(373, 28);
            cbSanBayDi.TabIndex = 3;
            // 
            // cbSanBayDen
            // 
            cbSanBayDen.FormattingEnabled = true;
            cbSanBayDen.Location = new Point(418, 133);
            cbSanBayDen.Name = "cbSanBayDen";
            cbSanBayDen.Size = new Size(373, 28);
            cbSanBayDen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(418, 110);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 22;
            label4.Text = "Sân bay đến";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(mThoiGianDen);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(mThoiGianDi);
            panel2.Location = new Point(12, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 81);
            panel2.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(207, 12);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 21;
            label6.Text = "THỜI GIAN ĐẾN";
            // 
            // mThoiGianDen
            // 
            mThoiGianDen.Enabled = false;
            mThoiGianDen.Location = new Point(220, 40);
            mThoiGianDen.Mask = "00:00:00";
            mThoiGianDen.Name = "mThoiGianDen";
            mThoiGianDen.Size = new Size(125, 27);
            mThoiGianDen.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(30, 12);
            label13.Name = "label13";
            label13.Size = new Size(121, 23);
            label13.TabIndex = 19;
            label13.Text = "THỜI GIAN ĐI";
            // 
            // mThoiGianDi
            // 
            mThoiGianDi.Enabled = false;
            mThoiGianDi.Location = new Point(30, 40);
            mThoiGianDi.Mask = "00:00:00";
            mThoiGianDi.Name = "mThoiGianDi";
            mThoiGianDi.Size = new Size(125, 27);
            mThoiGianDi.TabIndex = 5;
            // 
            // fNewChuyenBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Employee1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 236);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(cbSanBayDen);
            Controls.Add(cbSanBayDi);
            Controls.Add(cbProducts);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "fNewChuyenBay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mới chuyến bay";
            FormClosing += fNewChuyenBay_FormClosing;
            Load += fNewChuyenBay_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProducts;
        private Button btClose;
        private Button btSave;
        private Label label2;
        private Label label1;
        private ComboBox cbSanBayDi;
        private ComboBox cbSanBayDen;
        private Label label4;
        private ToolTip toolTip1;
        private Panel panel2;
        private Label label6;
        private MaskedTextBox mThoiGianDen;
        private Label label13;
        private MaskedTextBox mThoiGianDi;
    }
}