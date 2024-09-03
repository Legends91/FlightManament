using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using System.Data;

namespace QLBH
{
    public partial class fManageSanBay : Form
    {
        public fManageSanBay()
        {
            InitializeComponent();
        }

        private void fManageSanBay_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.SanBays.Load();

                dataGridView1.DataSource = db.SanBays.Select(c => new
                {
                    c.SanBayID,
                    c.TenSanBay,
                    c.Address,
                }).ToList();
            }
        }
        private void fManageSanBay_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.SanBays.Load();

                dataGridView1.DataSource = db.SanBays.Select(c => new
                {
                    c.SanBayID,
                    c.TenSanBay,
                    c.Address,
                }).ToList();
            }
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.SanBays.Where(c => c.TenSanBay.Contains(txtName.Text)).ToList();
            }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            fNewSanBay f = new fNewSanBay();
            f.ShowDialog();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    string SanBayID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["SanBayID"].Value);
                    using (var db = new EFDbContext())
                    {
                        SanBay sanbay = db.SanBays.Single(c => c.SanBayID == SanBayID);
                        if (MessageBox.Show("Bạn muốn xóa sân bay: " + sanbay.TenSanBay, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.SanBays.Remove(sanbay);
                            db.SaveChanges();
                            fManageSanBay_Activated(sender, e);
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
                if (Utility.IsOpeningForm("fEditSanBay"))
                    return;
                fEditSanBay f = new fEditSanBay(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["SanBayID"].Value));
                //f.MdiParent = this.MdiParent;
                f.ShowDialog();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            fManageSanBay_Load(sender, e);
        }
    }
}
