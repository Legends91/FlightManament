using QLBH;
using QLBH.Models;

namespace WinFormsApp1
{

    public partial class fMain : Form
    {


        public fMain()
        {

            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Category_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageCategory"))
                return;
            OpenChildForm(new fManageCategory());
        }
        private void Ticket_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageTicket"))
                return;
            OpenChildForm(new fManageTicket());
        }
        private void SanBay_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageSanBay"))
                return;
            OpenChildForm(new fManageSanBay());
        }
        private void MayBay_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageProduct"))
                return;
            OpenChildForm(new fManageProduct());
        }
        private void KhachHang_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageCustomer"))
                return;
            OpenChildForm(new fManageCustomer());
        }

        private void DatVe_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageOrderTicket"))
                return;
            OpenChildForm(new fManageOrderTicket());
        }
        private void Chitietdatve_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fProcessOrderTicketDetails"))
                return;
            OpenChildForm(new fProcessOrderTicketDetails());
        }
        private void NhanVien_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("Employees"))
                return;
            OpenChildForm(new Employees());


        }

        private void ChuyenBay_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageChuyenBay"))
                return;
            OpenChildForm(new fManageChuyenBay());
        }

        private void BaoCao_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageReport"))
                return;
            OpenChildForm(new fManageReport());
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Hide();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /*
        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageCustomer"))
                return;
            fManageCustomer f = new fManageCustomer();
            //f.MdiParent = this;
            f.ShowDialog();
        }
        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewCustomer"))
                return;
            fNewCustomer f = new fNewCustomer();
            //f.MdiParent = this;
            f.ShowDialog();
        }
        private void fManageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("Employees"))
                return;
            Employees f = new Employees();
            //f.MdiParent = this;
            f.ShowDialog();
        }
        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewEmployee"))
                return;
            fNewEmployee f = new fNewEmployee();
            //f.MdiParent = this;
            f.ShowDialog();
        }
        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageCategory"))
                return;
            fManageCategory f = new fManageCategory();
            //f.MdiParent = this;
            f.ShowDialog();
        }
        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageProduct"))
                return;
            fManageProduct f = new fManageProduct();
            //f.MdiParent = this;
            f.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageChuyenBay"))
                return;
            fManageChuyenBay f = new fManageChuyenBay();
            //f.MdiParent = this;
            f.ShowDialog();

        }
        private void manageTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageTicket"))
                return;
            fManageTicket f = new fManageTicket();
            f.ShowDialog();
        }
        private void manageOrderTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageOrderTicket"))
                return;
            fManageOrderTicket f = new fManageOrderTicket();
            f.ShowDialog();
        }
        private void manageOrderTicketDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fProcessOrderTicketDetails"))
                return;
            fProcessOrderTicketDetails f = new fProcessOrderTicketDetails();
            f.ShowDialog();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReportCategoryProductGroupByCategory"))
                return;
            fReportCategoryProductGroupByCategory f = new fReportCategoryProductGroupByCategory();
            f.ShowDialog();
        }

        private void sanBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageSanBay"))
                return;
            fManageSanBay f = new fManageSanBay();
            //f.MdiParent = this;
            f.ShowDialog();
        }
        private void chuyenBayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReportChuyenBayGroupByEmployee"))
                return;
            fReportChuyenBay f = new fReportChuyenBay();
            f.ShowDialog();
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReportEmployee"))
                return;
            fReportEmployee f = new fReportEmployee();
            f.ShowDialog();
        }
        private void véToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReportTicket"))
                return;
            fReportTicket f = new fReportTicket();
            f.ShowDialog();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        */


        private void fMain_Load(object sender, EventArgs e)
        {
            if (Utility.employee.RoleID == 5)
            {
                KhachHang.Enabled = false;
                NhanVien.Enabled = false;
                LoaiMayBay.Enabled = false;
                MayBay.Enabled = false;
                SanBay.Enabled = false;
                ChuyenBay.Enabled = false;
                Ticket.Enabled = false;
                DatVe.Enabled = false;
                BaoCao.Enabled = false;
            }
            if (Utility.employee.RoleID != 1 & Utility.employee.RoleID == 2)
            {
                KhachHang.Enabled = false;
                NhanVien.Enabled = false;
                LoaiMayBay.Enabled = false;
                MayBay.Enabled = false;
                SanBay.Enabled = false;
                ChuyenBay.Enabled = true;
                Ticket.Enabled = false;
                DatVe.Enabled = false;
                BaoCao.Enabled = false;
            }
            if (Utility.employee.RoleID != 1 & Utility.employee.RoleID == 3)
            {
                KhachHang.Enabled = false;
                NhanVien.Enabled = true;
                LoaiMayBay.Enabled = false;
                MayBay.Enabled = false;
                SanBay.Enabled = false;
                ChuyenBay.Enabled = false;
                Ticket.Enabled = false;
                DatVe.Enabled = false;
                BaoCao.Enabled = false;
            }
            if (Utility.employee.RoleID != 1 & Utility.employee.RoleID == 4)
            {
                KhachHang.Enabled = true;
                NhanVien.Enabled = false;
                LoaiMayBay.Enabled = false;
                MayBay.Enabled = false;
                SanBay.Enabled = false;
                ChuyenBay.Enabled = false;
                Ticket.Enabled = false;
                DatVe.Enabled = false;
                BaoCao.Enabled = false;
            }



        }

        



        /*foreach (ToolStripMenuItem t in menuStrip1.Items)
   foreach (ToolStripItem c in t.DropDownItems)
       if (t != reportToolStripMenuItem)
       {
           if (c.Name.Contains("new") && Utility.employee.RoleID == 2)
               break;
           c.Enabled = false; //hoặc c.Visible = false; 
       } */


    }
}
