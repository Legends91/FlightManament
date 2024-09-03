using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using System.Data;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fNewChuyenBay : Form
    {
        ChuyenBay chuyenbay;
        EFDbContext db = new EFDbContext();
        public fNewChuyenBay()
        {
            InitializeComponent();
        }

        private void fNewChuyenBay_Load(object sender, EventArgs e)
        {
            EFDbContext db = new EFDbContext();
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ProductID";
            cbProducts.DataSource = db.Products.ToList();

            cbProducts.DataSource = db.Products.Select(c => new
            {
                c.ProductID,
                c.Name
            }).ToList();

            /*  cbEmployees.DisplayMember = "Name";
              cbEmployees.ValueMember = "EmployeeID";
              cbEmployees.DataSource = db.Employees.ToList();
              cbEmployees.DataSource = db.Employees.Select(c => new
              {
                  c.EmployeeID,
                  c.Name
              }).ToList(); */

            cbSanBayDi.ValueMember = "SanBayID";
            cbSanBayDi.DataSource = db.SanBays.ToList();
            cbSanBayDi.DataSource = db.SanBays.Select(c => new
            {
                c.SanBayID,
                c.TenSanBay
            }).ToList();

            cbSanBayDen.ValueMember = "SanBayID";
            cbSanBayDen.DataSource = db.SanBays.ToList();
            cbSanBayDen.DataSource = db.SanBays.Select(c => new
            {
                c.SanBayID,
                c.TenSanBay
            }).ToList();

            cbSanBayDen.Text = null;

        }
        private void fNewChuyenBay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbProducts.Text))
            {
                toolTip1.Show("Hãy nhập máy bay?", cbProducts, 0, 0, 1000);
                cbProducts.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbSanBayDi.Text))
            {
                toolTip1.Show("Hãy nhập sân bay khởi hành?", cbSanBayDi, 0, 0, 1000);
                cbSanBayDi.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbSanBayDen.Text))
            {
                toolTip1.Show("Hãy nhập sân bay đến nơi?", cbSanBayDen, 0, 0, 1000);
                cbSanBayDen.Focus();
                return;
            }
            /*   if (string.IsNullOrWhiteSpace(cbEmployees.Text))
               {
                   toolTip1.Show("Hãy nhập nhân viên?", cbEmployees, 0, 0, 1000);
                   cbEmployees.Focus();
                   return;
               }
            */

            try
            {

                Utility.product = db.Products.SingleOrDefault(e => e.ProductID == Convert.ToInt64(cbProducts.SelectedValue));
                // Utility.employee = db.Employees.SingleOrDefault(e => e.EmployeeID == Convert.ToInt64(cbEmployees.SelectedValue));
                if (Utility.product != null /* && Utility.employee != null */)
                {
                    chuyenbay = new ChuyenBay();
                    chuyenbay.ProductID = Convert.ToInt64(cbProducts.SelectedValue);
                    //chuyenbay.EmployeeID = Convert.ToInt64(cbEmployees.SelectedValue);
                    chuyenbay.SanBayDi = cbSanBayDi.Text;
                    chuyenbay.SanBayDen = cbSanBayDen.Text;
                    chuyenbay.ThoiGianDi = Convert.ToDateTime(mThoiGianDi.Text).TimeOfDay;
                    chuyenbay.ThoiGianDen = Convert.ToDateTime(mThoiGianDen.Text).TimeOfDay;
                    using (var db = new EFDbContext())
                    {
                        db.ChuyenBays.Add(chuyenbay); //Thêm nhân viên vào csdl
                        db.SaveChanges(); //Lưu các thay đổi vào csdl
                    }
                    cbProducts.Text = null;
                    //  cbEmployees.Text = null;
                    cbSanBayDi.Text = null;
                    cbSanBayDen.Text = null;
                    toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
                }
                else
                {
                    toolTip1.Show("Nhập sai máy bay?", cbProducts, 0, 0, 1000);
                    cbProducts.Focus();
                    return;
                }
                /* else if ( Utility.employee != null )
                 {
                     toolTip1.Show("Nhập sai nhân viên?", cbEmployees, 0, 0, 1000);
                     cbEmployees.Focus();
                     return;
                 } */
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
               1000);
            }

        }




        private void cbProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EFDbContext db = new EFDbContext();
            long? ChuyenBayID = Convert.ToInt64(cbProducts.SelectedValue);
            ChuyenBay chuyenbay = db.ChuyenBays.Include(o => o.SanBays).Single(o => o.ChuyenBayID == ChuyenBayID);
            Text = "Thêm mới chuyến bay " + chuyenbay.ChuyenBayID.ToString();
            mThoiGianDi.Text = chuyenbay.ThoiGianDi.ToString();
            mThoiGianDen.Text = chuyenbay.ThoiGianDen.ToString();
            cbSanBayDi.Text = chuyenbay.SanBayDi.ToString();
            cbSanBayDen.Text = chuyenbay.SanBayDen.ToString();
        }


    }
}
