using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fReportEmployee : Form
    {
        EFDbContext db = new EFDbContext();
        ReportViewer reportViewer;
        public fReportEmployee()
        {
            InitializeComponent();
        }
        private void fReportEmployee_Load(object sender, EventArgs e)
        {

            reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            using (var db = new EFDbContext())
            {
                cbEmployees.DisplayMember = "Name";
                cbEmployees.ValueMember = "EmployeeID";
                cbEmployees.DataSource = db.Employees.Select(c => new
                {
                    c.EmployeeID,
                    c.Name
                }).ToList();
                cbEmployees.Text = null;

            }
        }
        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var db = new EFDbContext())
            {
                long EmployeeID = Convert.ToInt64(cbEmployees.SelectedValue);
                reportViewer.Reset();
                reportViewer.LocalReport.DataSources.Add(new
               ReportDataSource("ds_View_Employee", db.Employees.Where(p => p.EmployeeID == EmployeeID ||
               cbEmployees.SelectedIndex < 0).Select(p => new
               {
                   p.Name,
                   p.EmployeeID,
                   p.Gender,
                   p.DayWork,
                   p.BirthDay,
                   p.CCCD,
                   p.Phone,
                   p.RoleID,
               }).ToList()));

                reportViewer.Dock = DockStyle.Fill;
                reportViewer.LocalReport.ReportPath =
               Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
               "\\rEmployee.rdlc";
                Controls.Add(reportViewer);

                reportViewer.RefreshReport();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}


