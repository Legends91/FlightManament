namespace QLBH
{
    partial class fEditProduct
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
            pictureBox1 = new PictureBox();
            btBrowse = new Button();
            btClose = new Button();
            btSave = new Button();
            cbCategories = new ComboBox();
            ckStatus = new CheckBox();
            label6 = new Label();
            label3 = new Label();
            txtImageFile = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            txtManufacturer = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(587, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(515, 113);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(45, 29);
            btBrowse.TabIndex = 36;
            btBrowse.Text = "...";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(466, 171);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 39;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(340, 171);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 38;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(136, 167);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(160, 28);
            cbCategories.TabIndex = 28;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(597, 157);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 29;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 175);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 43;
            label6.Text = "Loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 60);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 40;
            label3.Text = "Nhà sản xuất";
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(134, 113);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(375, 27);
            txtImageFile.TabIndex = 34;
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(426, 27);
            txtName.TabIndex = 27;
            toolTip1.SetToolTip(txtName, "Length");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 113);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 37;
            label2.Text = "Tập tin hình";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 35;
            label1.Text = "Tên sản phẩm";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(134, 60);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(426, 27);
            txtManufacturer.TabIndex = 46;
            toolTip1.SetToolTip(txtManufacturer, "Length");
            // 
            // fEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 218);
            ControlBox = false;
            Controls.Add(txtManufacturer);
            Controls.Add(pictureBox1);
            Controls.Add(btBrowse);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(cbCategories);
            Controls.Add(ckStatus);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtImageFile);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fEditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa đổi máy bay";
            FormClosing += fEditProduct_FormClosing;
            Load += fEditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btBrowse;
        private Button btClose;
        private Button btSave;
        private ComboBox cbCategories;
        private CheckBox ckStatus;
        private Label label6;
        private Label label3;
        private TextBox txtImageFile;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private TextBox txtManufacturer;
    }
}