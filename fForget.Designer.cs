namespace QLBH
{
    partial class fForget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fForget));
            btClose = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblMessage = new Label();
            label1 = new Label();
            txtRePassword = new TextBox();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btForget = new Button();
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.Image = (Image)resources.GetObject("btClose.Image");
            btClose.Location = new Point(142, 257);
            btClose.Name = "btClose";
            btClose.Size = new Size(124, 48);
            btClose.TabIndex = 44;
            btClose.Text = "Quay lại";
            btClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(271, 164);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(148, 27);
            txtPassword.TabIndex = 41;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(271, 120);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(148, 27);
            txtEmail.TabIndex = 40;
            txtEmail.Validating += txtUser_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(107, 167);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 47;
            label4.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(129, 123);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 46;
            label3.Text = "Email";
            // 
            // lblMessage
            // 
            lblMessage.BorderStyle = BorderStyle.FixedSingle;
            lblMessage.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.Image = (Image)resources.GetObject("lblMessage.Image");
            lblMessage.ImageAlign = ContentAlignment.MiddleRight;
            lblMessage.Location = new Point(138, 71);
            lblMessage.Margin = new Padding(2, 0, 2, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(419, 32);
            lblMessage.TabIndex = 46;
            lblMessage.Text = "Hãy nhập thông tin";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(271, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 45;
            label1.Text = "Quên mật khẩu";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(271, 207);
            txtRePassword.Margin = new Padding(2);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.PasswordChar = '*';
            txtRePassword.Size = new Size(148, 27);
            txtRePassword.TabIndex = 42;
            txtRePassword.Validating += txtRePass_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 207);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 49;
            label2.Text = "Nhập lại mật khẩu";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(223, 160);
            label5.Name = "label5";
            label5.Size = new Size(43, 34);
            label5.TabIndex = 51;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(223, 119);
            label6.Name = "label6";
            label6.Size = new Size(43, 28);
            label6.TabIndex = 50;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(223, 200);
            label7.Name = "label7";
            label7.Size = new Size(43, 34);
            label7.TabIndex = 52;
            // 
            // btForget
            // 
            btForget.BackColor = Color.PaleGreen;
            btForget.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btForget.Image = (Image)resources.GetObject("btForget.Image");
            btForget.Location = new Point(319, 257);
            btForget.Name = "btForget";
            btForget.Size = new Size(186, 48);
            btForget.TabIndex = 43;
            btForget.Text = "Đổi mật khẩu mới";
            btForget.TextImageRelation = TextImageRelation.TextBeforeImage;
            btForget.UseVisualStyleBackColor = false;
            btForget.Click += btForget_Click;
            // 
            // fForget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(645, 360);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtRePassword);
            Controls.Add(label2);
            Controls.Add(btClose);
            Controls.Add(btForget);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblMessage);
            Controls.Add(label1);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "fForget";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên mật khẩu";
            FormClosing += fForget_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btClose;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label lblMessage;
        private Label label1;
        private TextBox txtRePassword;
        private Label label2;
        private ToolTip toolTip1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btForget;
    }
}