using Microsoft.Reporting.WinForms;
using System.Data;

namespace QLBH
{
    public partial class fReportTicket : Form
    {
        EFDbContext db = new EFDbContext();
        public fReportTicket()
        {
            InitializeComponent();
        }

        private void fReportTicket_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("ds_Ticket", db.OrderTicketDetails.Select(p => new
           {
               p.TicketID,
               p.Quantity,
               p.Price,

           }).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\rOrderTicketDetail.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
