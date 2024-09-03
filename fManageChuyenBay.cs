using Microsoft.EntityFrameworkCore;
using QLBH.Models;

namespace QLBH
{
    public partial class fManageChuyenBay : Form
    {

        public fManageChuyenBay()
        {
            InitializeComponent();
        }

        private void fManageChuyenBay_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.ChuyenBays.Load();
                dataGridView1.DataSource = db.ChuyenBays.Select(c => new
                {
                    c.ChuyenBayID,
                    c.ProductID,
                    //   c.EmployeeID,
                    c.SanBayDi,
                    c.SanBayDen,
                    c.ThoiGianDi,
                    c.ThoiGianDen,
                }).ToList();
            }
        }
        private void fManageChuyenBay_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.ChuyenBays.Load();
                dataGridView1.DataSource = db.ChuyenBays.Select(c => new
                {
                    c.ChuyenBayID,
                    c.ProductID,
                    //   c.EmployeeID,
                    c.SanBayDi,
                    c.SanBayDen,
                    c.ThoiGianDi,
                    c.ThoiGianDen,
                }).ToList();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            fNewChuyenBay f = new fNewChuyenBay();
            //f.MdiParent = this.MdiParent;
            f.ShowDialog();
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {

                dataGridView1.DataSource = db.ChuyenBays.Where(c => c.SanBayDi.Contains(txtName.Text) || c.SanBayDen.Contains(txtName.Text)).ToList();
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Hãy nhập mã chuyến bay! ");
                    txtName.Focus();
                    return;
                }



            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long ChuyenBayID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ChuyenBayID"].Value);
                    using (var db = new EFDbContext())
                    {
                        ChuyenBay chuyenBay = db.ChuyenBays.Single(c => c.ChuyenBayID == ChuyenBayID);
                        if (MessageBox.Show("Bạn muốn xóa chuyến bay này? ", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                        {
                            db.ChuyenBays.Remove(chuyenBay);
                            db.SaveChanges();
                            fManageChuyenBay_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditChuyenBay"))
                    return;

                fEditChuyenBay f = new fEditChuyenBay(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ChuyenBayID"].Value));
                f.ShowDialog();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            fManageChuyenBay_Load(sender, e);
        }
    }
}





