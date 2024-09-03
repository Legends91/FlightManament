namespace QLBH
{
    partial class fNewTicket
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
            label5 = new Label();
            btClose = new Button();
            btSave = new Button();
            label1 = new Label();
            txtName = new TextBox();
            mPrice = new MaskedTextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(55, 85);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 62;
            label5.Text = "Giá Vé";
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(331, 137);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 3;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(215, 137);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 2;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(55, 41);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 61;
            label1.Text = "Tên Vé";
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 27);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(141, 82);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(284, 27);
            mPrice.TabIndex = 1;
            mPrice.TypeValidationCompleted += mPrice_TypeValidationCompleted;
            // 
            // fNewTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Employee1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(496, 202);
            Controls.Add(mPrice);
            Controls.Add(label5);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "fNewTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm vé mới";
            FormClosing += fNewTicket_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btClose;
        private Button btSave;
        private Label label1;
        private TextBox txtName;
        private MaskedTextBox mPrice;
        private ToolTip toolTip1;
    }
}