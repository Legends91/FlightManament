using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using System.Data;

namespace QLBH
{
    public partial class fEditChuyenBay : Form

    {
        ChuyenBay chuyenbay;
        private long ChuyenBayID;
        EFDbContext db = new EFDbContext();
        public fEditChuyenBay(long ChuyenBayID)
        {
            InitializeComponent();
            this.ChuyenBayID = ChuyenBayID;
        }
        private void fEditChuyenBay_Load(object sender, EventArgs e)
        {
            chuyenbay = db.ChuyenBays.Single(p => p.ChuyenBayID == ChuyenBayID);

            Text += " - Mã CB " + chuyenbay.ChuyenBayID.ToString();
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ProductID";
            cbProducts.DataSource = db.Products.ToList();
            cbProducts.Text = chuyenbay.Products.ToString();
            cbProducts.DataSource = db.Products.Select(c => new
            {
                c.ProductID,
                c.Name
            }).ToList();
            cbProducts.Text = chuyenbay.Products.Name;


            /*
                        cbEmployees.DisplayMember = "Name";
                        cbEmployees.ValueMember = "EmployeeID";
                        cbEmployees.DataSource = db.Employees.ToList();
                        cbEmployees.Text = chuyenbay.Employees.ToString();
                        cbEmployees.DataSource = db.Employees.Select(c => new
                        {
                            c.EmployeeID,
                            c.Name
                        }).ToList();
                        cbEmployees.Text = chuyenbay.Employees.Name;
            */

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




            cbSanBayDen.Text = chuyenbay.SanBayDen.ToString();
            cbSanBayDi.Text = chuyenbay.SanBayDi.ToString();
            mThoiGianDi.Text = chuyenbay.ThoiGianDi.ToString();
            mThoiGianDen.Text = chuyenbay.ThoiGianDen.ToString();

        }
        private void fEditChuyenBay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSanBayDen.Text))
            {
                toolTip1.Show("Hãy nhập sân bay đến nơi?", cbSanBayDen, 0, 0, 1000);
                cbSanBayDen.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbSanBayDi.Text))
            {
                toolTip1.Show("Hãy nhập sân bay khởi hành?", cbSanBayDi, 0, 0, 1000);
                cbSanBayDi.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mThoiGianDi.Text))
            {
                toolTip1.Show("Hãy nhập thời gian khởi hành?", mThoiGianDi, 0, 0, 1000);
                mThoiGianDi.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mThoiGianDen.Text))
            {
                toolTip1.Show("Hãy nhập thời gian đến nơi?", mThoiGianDen, 0, 0, 1000);
                mThoiGianDen.Focus();
                return;
            }

            try
            {

                Utility.product = db.Products.SingleOrDefault(e => e.ProductID == Convert.ToInt64(cbProducts.SelectedValue));
               // Utility.employee = db.Employees.SingleOrDefault(e => e.EmployeeID == Convert.ToInt64(cbEmployees.SelectedValue));
                if (Utility.product != null && Utility.employee != null)
                {


                    chuyenbay.ProductID = Convert.ToInt64(cbProducts.SelectedValue);
                   // chuyenbay.EmployeeID = Convert.ToInt64(cbEmployees.SelectedValue);
                    chuyenbay.SanBayDi = cbSanBayDi.Text;
                    chuyenbay.SanBayDen = cbSanBayDen.Text;
                    chuyenbay.ThoiGianDi = Convert.ToDateTime(mThoiGianDi.Text).TimeOfDay;
                    chuyenbay.ThoiGianDen = Convert.ToDateTime(mThoiGianDen.Text).TimeOfDay;
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                    toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
                    btClose.Focus();
                }


                else /*(Utility.product == null )*/
                {
                    toolTip1.Show("Nhập sai máy bay?", cbProducts, 0, 0, 1000);
                    cbProducts.Focus();
                    return;
                }
              /*  else if (Utility.employee == null)
                {
                    toolTip1.Show("Nhập sai nhân viên?", cbEmployees, 0, 0, 1000);
                    cbEmployees.Focus();
                    return;
                } 
                else if (Utility.sanbaydi == null)
                {
                    toolTip1.Show("Nhập sai sân bay?", cbSanBayDi, 0, 0, 1000);
                    cbSanBayDi.Focus();
                    return;
                }
              */

            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }

        }

        private void cbProducts_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbProducts.Text))
            {
                toolTip1.Show("Hãy nhập máy bay?", cbProducts, 0, 0, 1000);
                cbProducts.Focus();
                return;
            }
        }

       /* private void cbEmployees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbEmployees.Text))
            {
                toolTip1.Show("Hãy nhập nhân viên?", cbEmployees, 0, 0, 1000);
                cbEmployees.Focus();
                return;
            }
        } */

        private void cbSanBayDi_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSanBayDi.Text))
            {
                toolTip1.Show("Hãy nhập sân bay?", cbSanBayDi, 0, 0, 1000);
                cbSanBayDi.Focus();
                return;
            }
        }

        private void cbSanBayDen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSanBayDen.Text))
            {
                toolTip1.Show("Hãy nhập sân bay?", cbSanBayDen, 0, 0, 1000);
                cbSanBayDen.Focus();
                return;
            }
        }
        private void mThoiGianDi_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu Time?", mThoiGianDi, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void mThoiGianDen_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu Time?", mThoiGianDen, 0, 0, 1000);
                e.Cancel = true;
            }
        }


    }
}
