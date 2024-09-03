namespace QLBH
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            label2 = new Label();
            dataGridView1 = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewCheckBoxColumn();
            BirthDay = new DataGridViewTextBoxColumn();
            DayWork = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            RoleID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            txtName = new TextBox();
            btFind = new Button();
            btNew = new Button();
            btClose = new Button();
            reload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(201, 34);
            label2.Name = "label2";
            label2.Size = new Size(217, 28);
            label2.TabIndex = 10;
            label2.Text = "QUẢN LÝ NHÂN VIÊN";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, EmployeeName, Phone, Email, Password, Gender, BirthDay, DayWork, CCCD, RoleID, Edit, Delete });
            dataGridView1.Location = new Point(39, 70);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1223, 271);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.Frozen = true;
            EmployeeID.HeaderText = "Mã Nhân Viên";
            EmployeeID.MinimumWidth = 8;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            EmployeeID.Width = 131;
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeName.DataPropertyName = "Name";
            EmployeeName.Frozen = true;
            EmployeeName.HeaderText = "Họ Tên";
            EmployeeName.MinimumWidth = 8;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.Width = 85;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "SĐT";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 65;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 75;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Mật Khẩu";
            Password.MinimumWidth = 8;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Width = 101;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới Tính";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.ThreeState = true;
            Gender.Width = 74;
            // 
            // BirthDay
            // 
            BirthDay.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BirthDay.DataPropertyName = "BirthDay";
            BirthDay.HeaderText = "Ngày Sinh";
            BirthDay.MinimumWidth = 6;
            BirthDay.Name = "BirthDay";
            BirthDay.ReadOnly = true;
            BirthDay.Width = 105;
            // 
            // DayWork
            // 
            DayWork.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DayWork.DataPropertyName = "DayWork";
            DayWork.HeaderText = "Ngày Vào Làm";
            DayWork.MinimumWidth = 6;
            DayWork.Name = "DayWork";
            DayWork.ReadOnly = true;
            DayWork.Width = 134;
            // 
            // CCCD
            // 
            CCCD.DataPropertyName = "CCCD";
            CCCD.HeaderText = "CCCD";
            CCCD.MinimumWidth = 6;
            CCCD.Name = "CCCD";
            CCCD.ReadOnly = true;
            CCCD.Width = 125;
            // 
            // RoleID
            // 
            RoleID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RoleID.DataPropertyName = "RoleID";
            RoleID.HeaderText = "Mã Phân Quyền";
            RoleID.MinimumWidth = 8;
            RoleID.Name = "RoleID";
            RoleID.ReadOnly = true;
            RoleID.Width = 141;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 64;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(682, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 9;
            label1.Text = "Tên nhân viên";
            // 
            // txtName
            // 
            txtName.Location = new Point(803, 38);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 5;
            // 
            // btFind
            // 
            btFind.Location = new Point(1036, 39);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(90, 27);
            btFind.TabIndex = 6;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(43, 40);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(90, 27);
            btNew.TabIndex = 7;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(1168, 40);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 31;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // reload
            // 
            reload.Image = (Image)resources.GetObject("reload.Image");
            reload.Location = new Point(43, 3);
            reload.Name = "reload";
            reload.Size = new Size(50, 32);
            reload.TabIndex = 32;
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1273, 360);
            ControlBox = false;
            Controls.Add(reload);
            Controls.Add(btClose);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btFind);
            Controls.Add(btNew);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            WindowState = FormWindowState.Maximized;
            Activated += Employees_Activated;
            Load += Employees_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtName;
        private Button btFind;
        private Button btNew;
        private Button btClose;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewCheckBoxColumn Gender;
        private DataGridViewTextBoxColumn BirthDay;
        private DataGridViewTextBoxColumn DayWork;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn RoleID;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button reload;
    }
}