namespace QLBH
{
    partial class fNewProduct
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
            txtManufacturer = new TextBox();
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
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(142, 76);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(426, 27);
            txtManufacturer.TabIndex = 59;
            txtManufacturer.Validating += txtManufacturer_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(595, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(523, 129);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(45, 29);
            btBrowse.TabIndex = 52;
            btBrowse.Text = "...";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(474, 187);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 55;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(351, 187);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 54;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(144, 183);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(160, 28);
            cbCategories.TabIndex = 48;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.BackColor = Color.Transparent;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(605, 173);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 49;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(25, 191);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 57;
            label6.Text = "Loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(18, 83);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 56;
            label3.Text = "Nhà sản xuất";
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(142, 129);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(375, 27);
            txtImageFile.TabIndex = 50;
            txtImageFile.Validating += txtImageFile_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(426, 27);
            txtName.TabIndex = 47;
            txtName.Validating += txtName_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(25, 129);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 53;
            label2.Text = "Tập tin hình";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(23, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 51;
            label1.Text = "Tên sản phẩm";
            // 
            // fNewProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Employee1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(740, 235);
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
            DoubleBuffered = true;
            Name = "fNewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mới máy bay";
            FormClosing += fNewProduct_FormClosing;
            Load += fNewProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtManufacturer;
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
    }
}