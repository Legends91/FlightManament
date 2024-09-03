namespace QLBH
{
    partial class fNewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNewEmployee));
            cbRoleID = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btClose = new Button();
            btSave = new Button();
            ckGender = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtCCCD = new TextBox();
            txtName = new TextBox();
            toolTip1 = new ToolTip(components);
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            SuspendLayout();
            // 
            // cbRoleID
            // 
            cbRoleID.FormattingEnabled = true;
            cbRoleID.Location = new Point(362, 30);
            cbRoleID.Name = "cbRoleID";
            cbRoleID.Size = new Size(178, 28);
            cbRoleID.TabIndex = 1;
            cbRoleID.Validating += cbRoleID_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(243, 29);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 58;
            label7.Text = "Phân quyền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(385, 176);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 57;
            label6.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(469, 173);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(299, 27);
            txtPassword.TabIndex = 5;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(50, 129);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 56;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(168, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(600, 27);
            txtEmail.TabIndex = 3;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(196, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 27);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2000, 1, 26, 0, 0, 0, 0);
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(645, 266);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(502, 268);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.BackColor = Color.Transparent;
            ckGender.CheckAlign = ContentAlignment.MiddleRight;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Indeterminate;
            ckGender.Location = new Point(582, 34);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(87, 24);
            ckGender.TabIndex = 8;
            ckGender.Text = "Giới tính";
            ckGender.ThreeState = true;
            ckGender.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(28, 223);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 55;
            label4.Text = "Ngày/tháng/năm sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(50, 169);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 54;
            label3.Text = "Điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(385, 223);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 53;
            label2.Text = "CCCD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(50, 88);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 52;
            label1.Text = "Tên nhân viên";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(168, 169);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(165, 27);
            txtPhone.TabIndex = 4;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(469, 220);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(299, 27);
            txtCCCD.TabIndex = 6;
            txtCCCD.Validating += txtCCCD_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(600, 27);
            txtName.TabIndex = 2;
            txtName.Validating += txtName_Validating;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(196, 268);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(137, 27);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.Validating += dateTimePicker2_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(10, 273);
            label8.Name = "label8";
            label8.Size = new Size(180, 20);
            label8.TabIndex = 60;
            label8.Text = "Ngày/tháng/năm vào làm";
            // 
            // fNewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(813, 325);
            ControlBox = false;
            Controls.Add(dateTimePicker2);
            Controls.Add(label8);
            Controls.Add(cbRoleID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(dateTimePicker1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(ckGender);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtCCCD);
            Controls.Add(txtName);
            Name = "fNewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mới nhân viên";
            FormClosing += fNewEmployee_FormClosing;
            Load += fNewEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbRoleID;
        private Label label7;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtEmail;
        private DateTimePicker dateTimePicker1;
        private Button btClose;
        private Button btSave;

        private CheckBox ckGender;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtCCCD;
        private TextBox txtName;
        private ToolTip toolTip1;
        private DateTimePicker dateTimePicker2;
        private Label label8;
    }
}