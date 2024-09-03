namespace QLBH
{
    partial class fNewCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNewCategory));
            btClose = new Button();
            btSave = new Button();
            label1 = new Label();
            txtName = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(329, 96);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 2;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(195, 96);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 1;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 67;
            label1.Text = "Tên loại máy bay";
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 27);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // fNewCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(456, 155);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label1);
            Controls.Add(txtName);
            DoubleBuffered = true;
            Name = "fNewCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mới loại máy bay";
            FormClosing += fNewCategory_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btClose;
        private Button btSave;
        private Label label1;
        private TextBox txtName;
        private ToolTip toolTip1;
    }
}