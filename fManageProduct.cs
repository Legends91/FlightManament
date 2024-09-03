using QLBH.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace QLBH
{
    public partial class fManageProduct : Form
    {
        private long CategoryID;
        public fManageProduct()
        {
            InitializeComponent();
        }
        private void fManageProduct_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                cbCategories.DisplayMember = "CategoryName";
                cbCategories.ValueMember = "CategoryID";

                cbCategories.DataSource = db.Categories.Select(c => new { c.CategoryID, c.CategoryName }).ToList();

            }
        }



        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                if (ckCategory.Checked) dataGridView1.DataSource = db.Products.Where(p =>
                   p.Name.Contains(txtName.Text) && (p.CategoryID == CategoryID ||
                   cbCategories.SelectedIndex < 0)).Select(p => new
                   {
                       p.ProductID,
                       p.CategoryID,
                       p.Name,
                       p.ImageFile,
                       p.Manufacturer,
                       p.Status
                   }).ToList();
                else
                    dataGridView1.DataSource = db.Products.Where(p =>
                   p.Name.Contains(txtName.Text)).Select(p => new
                   {
                       p.ProductID,
                       p.CategoryID,
                       p.Name,
                       p.ImageFile,
                       p.Manufacturer,
                       p.Status
                   }).ToList();
            }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewProduct"))
                return;
            fNewProduct f = new fNewProduct();
            //f.MdiParent = this.MdiParent;
            f.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long ProductID =
                   Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Product product = db.Products.Single(c => c.ProductID ==
                       ProductID);
                        if (MessageBox.Show("Bạn muốn xóa sản phẩm " +
                       product.Name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                       DialogResult.Yes)
                        {
                            db.Products.Remove(product);
                            db.SaveChanges();
                            fManageProduct_Activated(sender, e);
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
                if (Utility.IsOpeningForm("fEditProduct"))
                    return;
                fEditProduct f = new fEditProduct(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value));
                //f.MdiParent = this.MdiParent;
                f.ShowDialog();
            }
        }
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs
       e)
        {
            using (var db = new EFDbContext())
            {
                CategoryID = Convert.ToInt64(cbCategories.SelectedValue);
                dataGridView1.DataSource = db.Products.Where(p => p.CategoryID ==
               CategoryID).Select(p => new
               {
                   p.ProductID,
                   p.CategoryID,
                   p.Name,
                   p.ImageFile,
                   p.Manufacturer,
                   p.Status
               }).ToList();
                //lblNumOfProduct.Text = "Số sản phẩm: " +dataGridView1.Rows.Count;
            }
        }
        private void fManageProduct_Activated(object sender, EventArgs e)
        {
            cbCategories_SelectedIndexChanged(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.ImageLocation = Utility.ImagePath + dataGridView1.Rows[e.RowIndex].Cells["ImageFile"].Value;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            fManageProduct_Load(sender, e); 
        }
    }
}