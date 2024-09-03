namespace WinFormsApp1
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            panel_left = new Panel();
            BaoCao = new Button();
            Chitietdatve = new Button();
            DatVe = new Button();
            Ticket = new Button();
            ChuyenBay = new Button();
            SanBay = new Button();
            MayBay = new Button();
            LoaiMayBay = new Button();
            NhanVien = new Button();
            KhachHang = new Button();
            pictureBox1 = new PictureBox();
            DangXuat = new Button();
            Thoat = new Button();
            panel_body = new Panel();
            panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_left
            // 
            panel_left.BackColor = SystemColors.GradientActiveCaption;
            panel_left.Controls.Add(BaoCao);
            panel_left.Controls.Add(Chitietdatve);
            panel_left.Controls.Add(DatVe);
            panel_left.Controls.Add(Ticket);
            panel_left.Controls.Add(ChuyenBay);
            panel_left.Controls.Add(SanBay);
            panel_left.Controls.Add(MayBay);
            panel_left.Controls.Add(LoaiMayBay);
            panel_left.Controls.Add(NhanVien);
            panel_left.Controls.Add(KhachHang);
            panel_left.Controls.Add(pictureBox1);
            panel_left.Controls.Add(DangXuat);
            panel_left.Controls.Add(Thoat);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 0);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(173, 856);
            panel_left.TabIndex = 7;
            // 
            // BaoCao
            // 
            BaoCao.BackColor = SystemColors.Window;
            BaoCao.Dock = DockStyle.Top;
            BaoCao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BaoCao.Image = (Image)resources.GetObject("BaoCao.Image");
            BaoCao.Location = new Point(0, 662);
            BaoCao.Name = "BaoCao";
            BaoCao.Size = new Size(173, 61);
            BaoCao.TabIndex = 53;
            BaoCao.Text = "Báo cáo";
            BaoCao.TextImageRelation = TextImageRelation.ImageBeforeText;
            BaoCao.UseVisualStyleBackColor = false;
            BaoCao.Click += BaoCao_Click;
            // 
            // Chitietdatve
            // 
            Chitietdatve.BackColor = SystemColors.Window;
            Chitietdatve.Dock = DockStyle.Top;
            Chitietdatve.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Chitietdatve.Image = (Image)resources.GetObject("Chitietdatve.Image");
            Chitietdatve.Location = new Point(0, 601);
            Chitietdatve.Name = "Chitietdatve";
            Chitietdatve.Size = new Size(173, 61);
            Chitietdatve.TabIndex = 52;
            Chitietdatve.Text = "Chi tiết đặt vé";
            Chitietdatve.TextImageRelation = TextImageRelation.ImageBeforeText;
            Chitietdatve.UseVisualStyleBackColor = false;
            Chitietdatve.Click += Chitietdatve_Click;
            // 
            // DatVe
            // 
            DatVe.BackColor = SystemColors.Window;
            DatVe.Dock = DockStyle.Top;
            DatVe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DatVe.Image = (Image)resources.GetObject("DatVe.Image");
            DatVe.Location = new Point(0, 540);
            DatVe.Name = "DatVe";
            DatVe.Size = new Size(173, 61);
            DatVe.TabIndex = 51;
            DatVe.Text = "Đặt vé";
            DatVe.TextImageRelation = TextImageRelation.ImageBeforeText;
            DatVe.UseVisualStyleBackColor = false;
            DatVe.Click += DatVe_Click;
            // 
            // Ticket
            // 
            Ticket.BackColor = SystemColors.Window;
            Ticket.Dock = DockStyle.Top;
            Ticket.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Ticket.Image = (Image)resources.GetObject("Ticket.Image");
            Ticket.Location = new Point(0, 479);
            Ticket.Name = "Ticket";
            Ticket.Size = new Size(173, 61);
            Ticket.TabIndex = 50;
            Ticket.Text = "Vé";
            Ticket.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ticket.UseVisualStyleBackColor = false;
            Ticket.Click += Ticket_Click;
            // 
            // ChuyenBay
            // 
            ChuyenBay.BackColor = SystemColors.Window;
            ChuyenBay.Dock = DockStyle.Top;
            ChuyenBay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChuyenBay.Image = (Image)resources.GetObject("ChuyenBay.Image");
            ChuyenBay.Location = new Point(0, 418);
            ChuyenBay.Name = "ChuyenBay";
            ChuyenBay.Size = new Size(173, 61);
            ChuyenBay.TabIndex = 49;
            ChuyenBay.Text = "Chuyến bay";
            ChuyenBay.TextAlign = ContentAlignment.MiddleRight;
            ChuyenBay.TextImageRelation = TextImageRelation.ImageBeforeText;
            ChuyenBay.UseVisualStyleBackColor = false;
            ChuyenBay.Click += ChuyenBay_Click;
            // 
            // SanBay
            // 
            SanBay.BackColor = SystemColors.Window;
            SanBay.Dock = DockStyle.Top;
            SanBay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SanBay.Image = (Image)resources.GetObject("SanBay.Image");
            SanBay.Location = new Point(0, 357);
            SanBay.Name = "SanBay";
            SanBay.Size = new Size(173, 61);
            SanBay.TabIndex = 48;
            SanBay.Text = "Sân bay";
            SanBay.TextImageRelation = TextImageRelation.ImageBeforeText;
            SanBay.UseVisualStyleBackColor = false;
            SanBay.Click += SanBay_Click;
            // 
            // MayBay
            // 
            MayBay.BackColor = SystemColors.Window;
            MayBay.Dock = DockStyle.Top;
            MayBay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MayBay.Image = QLBH.Properties.Resources.MayBay1;
            MayBay.Location = new Point(0, 296);
            MayBay.Name = "MayBay";
            MayBay.Size = new Size(173, 61);
            MayBay.TabIndex = 47;
            MayBay.Text = "Máy bay";
            MayBay.TextImageRelation = TextImageRelation.ImageBeforeText;
            MayBay.UseVisualStyleBackColor = false;
            MayBay.Click += MayBay_Click;
            // 
            // LoaiMayBay
            // 
            LoaiMayBay.BackColor = SystemColors.Window;
            LoaiMayBay.Dock = DockStyle.Top;
            LoaiMayBay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoaiMayBay.Image = (Image)resources.GetObject("LoaiMayBay.Image");
            LoaiMayBay.Location = new Point(0, 235);
            LoaiMayBay.Name = "LoaiMayBay";
            LoaiMayBay.Size = new Size(173, 61);
            LoaiMayBay.TabIndex = 46;
            LoaiMayBay.Text = "Loại máy bay";
            LoaiMayBay.TextImageRelation = TextImageRelation.ImageBeforeText;
            LoaiMayBay.UseVisualStyleBackColor = false;
            LoaiMayBay.Click += Category_Click;
            // 
            // NhanVien
            // 
            NhanVien.BackColor = SystemColors.Window;
            NhanVien.Dock = DockStyle.Top;
            NhanVien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NhanVien.Image = (Image)resources.GetObject("NhanVien.Image");
            NhanVien.Location = new Point(0, 174);
            NhanVien.Name = "NhanVien";
            NhanVien.Size = new Size(173, 61);
            NhanVien.TabIndex = 45;
            NhanVien.Text = "Nhân viên";
            NhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            NhanVien.UseVisualStyleBackColor = false;
            NhanVien.Click += NhanVien_Click;
            // 
            // KhachHang
            // 
            KhachHang.BackColor = SystemColors.Window;
            KhachHang.Dock = DockStyle.Top;
            KhachHang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            KhachHang.Image = (Image)resources.GetObject("KhachHang.Image");
            KhachHang.Location = new Point(0, 113);
            KhachHang.Name = "KhachHang";
            KhachHang.Size = new Size(173, 61);
            KhachHang.TabIndex = 44;
            KhachHang.Text = "Hành Khách";
            KhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            KhachHang.UseVisualStyleBackColor = false;
            KhachHang.Click += KhachHang_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 113);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // DangXuat
            // 
            DangXuat.BackColor = SystemColors.Window;
            DangXuat.Dock = DockStyle.Bottom;
            DangXuat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DangXuat.Image = (Image)resources.GetObject("DangXuat.Image");
            DangXuat.Location = new Point(0, 734);
            DangXuat.Name = "DangXuat";
            DangXuat.Size = new Size(173, 61);
            DangXuat.TabIndex = 15;
            DangXuat.Text = "Đăng xuất";
            DangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            DangXuat.UseVisualStyleBackColor = false;
            DangXuat.Click += DangXuat_Click;
            // 
            // Thoat
            // 
            Thoat.BackColor = SystemColors.Window;
            Thoat.Dock = DockStyle.Bottom;
            Thoat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Thoat.Image = (Image)resources.GetObject("Thoat.Image");
            Thoat.Location = new Point(0, 795);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(173, 61);
            Thoat.TabIndex = 7;
            Thoat.Text = "Thoát";
            Thoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            Thoat.UseVisualStyleBackColor = false;
            Thoat.Click += Thoat_Click;
            // 
            // panel_body
            // 
            panel_body.BackColor = SystemColors.ButtonHighlight;
            panel_body.BackgroundImage = (Image)resources.GetObject("panel_body.BackgroundImage");
            panel_body.BackgroundImageLayout = ImageLayout.Zoom;
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(173, 0);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(939, 856);
            panel_body.TabIndex = 9;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1112, 856);
            ControlBox = false;
            Controls.Add(panel_body);
            Controls.Add(panel_left);
            IsMdiContainer = true;
            Margin = new Padding(2);
            Name = "fMain";
            WindowState = FormWindowState.Maximized;
            Load += fMain_Load;
            panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_left;
        private Panel panel_body;
        private Button Thoat;
        private Button DangXuat;
        private Button BaoCao;
        private Button Chitietdatve;
        private Button DatVe;
        private Button Ticket;
        private Button ChuyenBay;
        private Button SanBay;
        private Button MayBay;
        private Button LoaiMayBay;
        private Button NhanVien;
        private Button KhachHang;
        private PictureBox pictureBox1;
    }
}