namespace QLBH
{
    partial class fReportEmployee
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
            btClose = new Button();
            cbEmployees = new ComboBox();
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(967, 3);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 58;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Items.AddRange(new object[] { "Tất cả" });
            cbEmployees.Location = new Point(773, 3);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(178, 28);
            cbEmployees.TabIndex = 57;
            cbEmployees.SelectedIndexChanged += cbEmployees_SelectedIndexChanged;
            // 
            // fReportEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 450);
            ControlBox = false;
            Controls.Add(btClose);
            Controls.Add(cbEmployees);
            Name = "fReportEmployee";
            Text = "fReportEmployee";
            WindowState = FormWindowState.Maximized;
            Load += fReportEmployee_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btClose;
        private ComboBox cbEmployees;
    }
}