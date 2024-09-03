namespace QLBH
{
    partial class fReportCategoryProductGroupByCategory
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
            cbCategories = new ComboBox();
            btClose = new Button();
            SuspendLayout();
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Items.AddRange(new object[] { "Tất cả" });
            cbCategories.Location = new Point(763, 1);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(178, 28);
            cbCategories.TabIndex = 2;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(957, 1);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 56;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // fReportCategoryProductGroupByCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 450);
            ControlBox = false;
            Controls.Add(btClose);
            Controls.Add(cbCategories);
            Name = "fReportCategoryProductGroupByCategory";
            Text = "fReportCategoryProductGroupByCategory";
            WindowState = FormWindowState.Maximized;
            Load += fReportCategoryProductGroupByCategory_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbCategories;
        private Button btClose;
    }
}