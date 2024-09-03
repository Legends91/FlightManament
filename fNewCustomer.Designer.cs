namespace QLBH
{
    partial class fNewCustomer
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
            txtName = new TextBox();
            txtCCCD = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ckGender = new CheckBox();
            btSave = new Button();
            btClose = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(415, 27);
            txtName.TabIndex = 0;
            toolTip1.SetToolTip(txtName, "Length");
            txtName.Validating += txtName_Validating;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(391, 110);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(154, 27);
            txtCCCD.TabIndex = 3;
            toolTip1.SetToolTip(txtCCCD, "Length");
            txtCCCD.Validating += txtCCCD_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(130, 110);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(146, 27);
            txtPhone.TabIndex = 4;
            toolTip1.SetToolTip(txtPhone, "Length");
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(415, 27);
            txtEmail.TabIndex = 5;
            toolTip1.SetToolTip(txtEmail, "Length");
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(326, 113);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 5;
            label2.Text = "CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "Điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 7;
            label4.Text = "Ngày/tháng/năm sinh";
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.BackColor = Color.Transparent;
            ckGender.CheckAlign = ContentAlignment.MiddleRight;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Indeterminate;
            ckGender.Location = new Point(415, 165);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(87, 24);
            ckGender.TabIndex = 1;
            ckGender.Text = "Giới tính";
            ckGender.ThreeState = true;
            ckGender.UseVisualStyleBackColor = false;
            // 
            // btSave
            // 
            btSave.Location = new Point(341, 216);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 7;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(451, 216);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 8;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(171, 165);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(105, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2000, 8, 31, 0, 0, 0, 0);
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // fNewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Employee1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(592, 269);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(ckGender);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtCCCD);
            Controls.Add(txtName);
            DoubleBuffered = true;
            Name = "fNewCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập thêm khách hàng mới";
            FormClosing += fNewCustomer_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtCCCD;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox ckGender;
        private Button btSave;
        private Button btClose;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ToolTip toolTip1;
    }
}