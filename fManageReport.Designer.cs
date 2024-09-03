namespace QLBH
{
    partial class fManageReport
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
            panel1 = new Panel();
            OrderTicket = new Button();
            Employee = new Button();
            ChuyenBay = new Button();
            ProductCategory = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(OrderTicket);
            panel1.Controls.Add(Employee);
            panel1.Controls.Add(ChuyenBay);
            panel1.Controls.Add(ProductCategory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 44);
            panel1.TabIndex = 0;
            // 
            // OrderTicket
            // 
            OrderTicket.BackColor = Color.Snow;
            OrderTicket.Dock = DockStyle.Left;
            OrderTicket.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrderTicket.Location = new Point(593, 0);
            OrderTicket.Name = "OrderTicket";
            OrderTicket.Size = new Size(192, 44);
            OrderTicket.TabIndex = 4;
            OrderTicket.Text = "Báo cáo biểu đồ mua vé";
            OrderTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            OrderTicket.UseVisualStyleBackColor = false;
            OrderTicket.Click += OrderTicket_Click;
            // 
            // Employee
            // 
            Employee.BackColor = Color.Snow;
            Employee.Dock = DockStyle.Left;
            Employee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Employee.Location = new Point(410, 0);
            Employee.Name = "Employee";
            Employee.Size = new Size(183, 44);
            Employee.TabIndex = 3;
            Employee.Text = "Báo cáo thẻ nhân viên";
            Employee.TextImageRelation = TextImageRelation.ImageBeforeText;
            Employee.UseVisualStyleBackColor = false;
            Employee.Click += Employee_Click;
            // 
            // ChuyenBay
            // 
            ChuyenBay.BackColor = Color.Snow;
            ChuyenBay.Dock = DockStyle.Left;
            ChuyenBay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChuyenBay.Location = new Point(254, 0);
            ChuyenBay.Name = "ChuyenBay";
            ChuyenBay.Size = new Size(156, 44);
            ChuyenBay.TabIndex = 2;
            ChuyenBay.Text = "Báo cáo chuyến bay";
            ChuyenBay.TextImageRelation = TextImageRelation.ImageBeforeText;
            ChuyenBay.UseVisualStyleBackColor = false;
            ChuyenBay.Click += ChuyenBay_Click;
            // 
            // ProductCategory
            // 
            ProductCategory.BackColor = Color.Snow;
            ProductCategory.Dock = DockStyle.Left;
            ProductCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductCategory.Location = new Point(0, 0);
            ProductCategory.Name = "ProductCategory";
            ProductCategory.Size = new Size(254, 44);
            ProductCategory.TabIndex = 1;
            ProductCategory.Text = "Báo cáo máy bay và loại máy bay";
            ProductCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            ProductCategory.UseVisualStyleBackColor = false;
            ProductCategory.Click += ProductCategory_Click;
            // 
            // fManageReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 46);
            Controls.Add(panel1);
            Name = "fManageReport";
            Text = "fManageReport";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button OrderTicket;
        private Button Employee;
        private Button ChuyenBay;
        private Button ProductCategory;
    }
}