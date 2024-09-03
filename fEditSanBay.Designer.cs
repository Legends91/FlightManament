namespace QLBH
{
    partial class fEditSanBay
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
            toolTip1 = new ToolTip(components);
            txtAddress = new TextBox();
            label5 = new Label();
            btClose = new Button();
            btSave = new Button();
            label1 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(112, 87);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(284, 27);
            txtAddress.TabIndex = 1;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 87);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 74;
            label5.Text = "Địa điểm";
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(302, 140);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 3;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(186, 140);
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
            label1.Location = new Point(20, 39);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 73;
            label1.Text = "Tên sân bay";
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 27);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // fEditSanBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 190);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "fEditSanBay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa sân bay";
            FormClosing += fEditSanBay_FormClosing;
            Load += fEditSanBay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private TextBox txtAddress;
        private Label label5;
        private Button btClose;
        private Button btSave;
        private Label label1;
        private TextBox txtName;
    }
}