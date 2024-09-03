using Microsoft.Reporting.WinForms;
using System.Data;

namespace QLBH
{
    public partial class fReportCategoryProductGroupByCategory : Form
    {
        EFDbContext db = new EFDbContext();
        ReportViewer reportViewer;
        public fReportCategoryProductGroupByCategory()
        {
            InitializeComponent();
        }

        private void fReportCategoryProductGroupByCategory_Load(object sender, EventArgs e)
        {

            reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            using (var db = new EFDbContext())
            {
                cbCategories.DisplayMember = "CategoryName";
                cbCategories.ValueMember = "CategoryID";
                cbCategories.DataSource = db.Categories.Select(c => new
                {
                    c.CategoryID,
                    c.CategoryName
                }).ToList();
                cbCategories.Text = null;

            }
        }
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var db = new EFDbContext())
            {
                long CategoryID = Convert.ToInt64(cbCategories.SelectedValue);
                reportViewer.Reset();
                reportViewer.LocalReport.DataSources.Add(new
               ReportDataSource("ds_View_CategoryProduct", db.Products.Where(p => p.CategoryID == CategoryID ||
               cbCategories.SelectedIndex < 0).Select(p => new
               {
                   p.ProductID,
                   p.Name,
                   p.Manufacturer,
                   p.Status,
                   p.Categories.CategoryName

               }).ToList()));

                reportViewer.Dock = DockStyle.Fill;
                reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
               "\\rCategoryProductGroupByCategory.rdlc";
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
