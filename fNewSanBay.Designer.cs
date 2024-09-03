namespace QLBH
{
    partial class fNewSanBay
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
            txtSanBayID = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(23, 133);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 68;
            label5.Text = "Địa điểm";
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(303, 175);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 66;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(189, 175);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 65;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(23, 82);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 67;
            label1.Text = "Tên sân bay";
            // 
            // txtSanBayID
            // 
            txtSanBayID.Location = new Point(113, 28);
            txtSanBayID.Name = "txtSanBayID";
            txtSanBayID.Size = new Size(284, 27);
            txtSanBayID.TabIndex = 0;
            txtSanBayID.Validating += txtSanBayID_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 27);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(113, 133);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(284, 27);
            txtAddress.TabIndex = 2;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(23, 31);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 71;
            label2.Text = "Mã sân bay";
            // 
            // fNewSanBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Employee1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(447, 227);
            Controls.Add(label2);
            Controls.Add(txtSanBayID);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label1);
            Name = "fNewSanBay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mới sân bay";
            FormClosing += fNewSanBay_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button btClose;
        private Button btSave;
        private Label label1;
        private TextBox txtSanBayID;
        private TextBox txtName;
        private TextBox txtAddress;
        private ToolTip toolTip1;
        private Label label2;

    }
}