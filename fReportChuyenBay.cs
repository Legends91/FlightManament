using Microsoft.Reporting.WinForms;
using System.Data;

namespace QLBH
{
    public partial class fReportChuyenBay : Form
    {
        EFDbContext db = new EFDbContext();
        ReportViewer reportViewer;
        public fReportChuyenBay()
        {
            InitializeComponent();
        }
        private void fReportChuyenBay_Load(object sender, EventArgs e)
        {

            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("ds_ChuyenBay", db.ChuyenBays.Select(p => new
           {
               p.ChuyenBayID,
               p.ProductID,
               p.SanBayDi,
               p.SanBayDen,
               p.ThoiGianDi,
               p.ThoiGianDen,


           }).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\rChuyenBayGroupByEmployee.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();

            /* using (var db = new EFDbContext())
             {
                 cbEmployees.DisplayMember = "Name";
                 cbEmployees.ValueMember = "EmployeeID";
                 cbEmployees.DataSource = db.Employees.Select(c => new
                 {
                     c.EmployeeID,
                     c.Name
                 }).ToList();
                 cbEmployees.Text = null;
             } */
        }
        /*private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

             using (var db = new EFDbContext())
             {
                 long EmployeeID = Convert.ToInt64(cbEmployees.SelectedValue);
                 reportViewer.Reset();
                 reportViewer.LocalReport.DataSources.Add(new
                ReportDataSource("ds_View_ChuyenBayEmployee", db.ChuyenBays.Where(p => p.EmployeeID == EmployeeID ||
                cbEmployees.SelectedIndex < 0).Select(p => new
                {
                    p.ChuyenBayID,
                    p.ProductID,
                    p.SanBayDi,
                    p.SanBayDen,
                    p.ThoiGianDi,
                    p.ThoiGianDen,
                    p.Employees.Name
                }).ToList()));

                 reportViewer.Dock = DockStyle.Fill;
                 reportViewer.LocalReport.ReportPath =
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                "\\rChuyenBayGroupByEmployee.rdlc";
                 Controls.Add(reportViewer);

                 reportViewer.RefreshReport(); 
             }*/
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }

}

