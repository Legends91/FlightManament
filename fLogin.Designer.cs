namespace QLBH
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btClose = new Button();
            btLogin = new Button();
            liForget = new LinkLabel();
            lblMessage = new Label();
            label2 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 36;
            label1.Text = "Đăng nhập hệ thống";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(109, 165);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 38;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(92, 208);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 39;
            label4.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 158);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(148, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(202, 205);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(148, 27);
            txtPassword.TabIndex = 1;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Red;
            btClose.CausesValidation = false;
            btClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = SystemColors.ControlText;
            btClose.Image = (Image)resources.GetObject("btClose.Image");
            btClose.Location = new Point(242, 307);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 48);
            btClose.TabIndex = 3;
            btClose.Text = "Đóng";
            btClose.TextImageRelation = TextImageRelation.TextBeforeImage;
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.PaleGreen;
            btLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btLogin.ForeColor = SystemColors.ControlText;
            btLogin.Image = (Image)resources.GetObject("btLogin.Image");
            btLogin.Location = new Point(92, 307);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(132, 48);
            btLogin.TabIndex = 2;
            btLogin.Text = "Đăng nhập";
            btLogin.TextImageRelation = TextImageRelation.TextBeforeImage;
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // liForget
            // 
            liForget.AutoSize = true;
            liForget.BackColor = Color.Transparent;
            liForget.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            liForget.Location = new Point(178, 258);
            liForget.Name = "liForget";
            liForget.Size = new Size(114, 20);
            liForget.TabIndex = 44;
            liForget.TabStop = true;
            liForget.Text = "Quên mật khẩu";
            liForget.LinkClicked += liForget_LinkClicked;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.WhiteSmoke;
            lblMessage.BorderStyle = BorderStyle.FixedSingle;
            lblMessage.FlatStyle = FlatStyle.System;
            lblMessage.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.Image = (Image)resources.GetObject("lblMessage.Image");
            lblMessage.ImageAlign = ContentAlignment.MiddleRight;
            lblMessage.Location = new Point(92, 90);
            lblMessage.Margin = new Padding(2, 0, 2, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(312, 25);
            lblMessage.TabIndex = 37;
            lblMessage.Text = "Chào Bạn!";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(160, 157);
            label2.Name = "label2";
            label2.Size = new Size(43, 28);
            label2.TabIndex = 45;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(160, 198);
            label5.Name = "label5";
            label5.Size = new Size(43, 34);
            label5.TabIndex = 46;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(491, 520);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(liForget);
            Controls.Add(btClose);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblMessage);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            TransparencyKey = Color.WhiteSmoke;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btClose;
        private Button btLogin;
        private LinkLabel liForget;
        private Label lblMessage;
        private Label label2;
        private Label label5;
    }
}