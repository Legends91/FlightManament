namespace QLBH
{
    public partial class fManageReport : Form
    {
        public fManageReport()
        {
            InitializeComponent();
        }
        private void ChuyenBay_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReportChuyenBay"))
                return;
            fReportChuyenBay f = new fReportChuyenBay();
            //f.MdiParent = this;
            f.ShowDialog();
        }
        private void OrderTicket_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReportTicket"))
                return;
            fReportTicket f = new fReportTicket();
            //f.MdiParent = this;
            f.ShowDialog();
        }
        private void ProductCategory_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReportCategoryProductGroupByCategory"))
                return;
            fReportCategoryProductGroupByCategory f = new fReportCategoryProductGroupByCategory();
            //f.MdiParent = this;
            f.ShowDialog();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReportEmployee"))
                return;
            fReportEmployee f = new fReportEmployee();
            //f.MdiParent = this;
            f.ShowDialog();
        }
    }

}
