namespace QLBH
{
    partial class fEditChuyenBay
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
            panel2 = new Panel();
            label6 = new Label();
            mThoiGianDen = new MaskedTextBox();
            label13 = new Label();
            mThoiGianDi = new MaskedTextBox();
            label4 = new Label();
            cbSanBayDen = new ComboBox();
            cbSanBayDi = new ComboBox();
            cbProducts = new ComboBox();
            btClose = new Button();
            btSave = new Button();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(mThoiGianDen);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(mThoiGianDi);
            panel2.Location = new Point(12, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 91);
            panel2.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(213, 12);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 21;
            label6.Text = "THỜI GIAN ĐẾN";
            // 
            // mThoiGianDen
            // 
            mThoiGianDen.Location = new Point(226, 41);
            mThoiGianDen.Mask = "00:00:00";
            mThoiGianDen.Name = "mThoiGianDen";
            mThoiGianDen.Size = new Size(125, 27);
            mThoiGianDen.TabIndex = 20;
            mThoiGianDen.TypeValidationCompleted += mThoiGianDen_TypeValidationCompleted;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(34, 12);
            label13.Name = "label13";
            label13.Size = new Size(121, 23);
            label13.TabIndex = 19;
            label13.Text = "THỜI GIAN ĐI";
            // 
            // mThoiGianDi
            // 
            mThoiGianDi.Location = new Point(34, 41);
            mThoiGianDi.Mask = "00:00:00";
            mThoiGianDi.Name = "mThoiGianDi";
            mThoiGianDi.Size = new Size(125, 27);
            mThoiGianDi.TabIndex = 14;
            mThoiGianDi.TypeValidationCompleted += mThoiGianDi_TypeValidationCompleted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 115);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 34;
            label4.Text = "Sân bay đến";
            // 
            // cbSanBayDen
            // 
            cbSanBayDen.FormattingEnabled = true;
            cbSanBayDen.Location = new Point(415, 138);
            cbSanBayDen.Name = "cbSanBayDen";
            cbSanBayDen.Size = new Size(373, 28);
            cbSanBayDen.TabIndex = 33;
            cbSanBayDen.Validating += cbSanBayDen_Validating;
            // 
            // cbSanBayDi
            // 
            cbSanBayDi.FormattingEnabled = true;
            cbSanBayDi.Location = new Point(415, 48);
            cbSanBayDi.Name = "cbSanBayDi";
            cbSanBayDi.Size = new Size(373, 28);
            cbSanBayDi.TabIndex = 32;
            cbSanBayDi.Validating += cbSanBayDi_Validating;
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(9, 48);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(373, 28);
            cbProducts.TabIndex = 25;
            cbProducts.Validating += cbProducts_Validating;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(521, 177);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 29;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(411, 177);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 28;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 27;
            label2.Text = "Sân bay đi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 26;
            label1.Text = "Máy Bay";
            // 
            // fEditChuyenBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 233);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(cbSanBayDen);
            Controls.Add(cbSanBayDi);
            Controls.Add(cbProducts);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fEditChuyenBay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa chuyến bay";
            FormClosing += fEditChuyenBay_FormClosing;
            Load += fEditChuyenBay_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label6;
        private MaskedTextBox mThoiGianDen;
        private Label label13;
        private MaskedTextBox mThoiGianDi;
        private Label label4;
        private ComboBox cbSanBayDen;
        private ComboBox cbSanBayDi;
        private ComboBox cbProducts;
        private Button btClose;
        private Button btSave;
        private Label label2;
        private Label label1;
        private ToolTip toolTip1;
    }
}