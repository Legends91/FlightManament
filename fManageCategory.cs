using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using System.Data;

namespace QLBH
{
    public partial class fManageCategory : Form
    {
        public fManageCategory()
        {
            InitializeComponent();
        }

        private void fManageCategory_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.Categories.Load();
                dataGridView1.DataSource = db.Categories.Select(c => new
                {
                    c.CategoryID,
                    c.CategoryName,
                }).ToList();
            }
        }
        private void fManageCategory_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.Categories.Load();
                dataGridView1.DataSource = db.Categories.Select(c => new
                {
                    c.CategoryID,
                    c.CategoryName,
                }).ToList();
            }
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Categories.Where(c => c.CategoryName.Contains(txtName.Text)).ToList();
            }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            fNewCategory f = new fNewCategory();
            f.ShowDialog();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long CategoryID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CategoryID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Category category = db.Categories.Single(c => c.CategoryID == CategoryID);
                        if (MessageBox.Show("Bạn muốn xóa sân bay: " + category.CategoryName, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Categories.Remove(category);
                            db.SaveChanges();
                            fManageCategory_Activated(sender, e);
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
                if (Utility.IsOpeningForm("fEditCategory"))
                    return;
                fEditCategory f = new fEditCategory(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CategoryID"].Value));
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
            fManageCategory_Load(sender, e);
        }
    }
}
