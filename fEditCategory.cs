using QLBH.Models;

namespace QLBH
{
    public partial class fEditCategory : Form
    {
        Category category;
        private long CategoryID;
        EFDbContext db = new EFDbContext();
        public fEditCategory(long CategoryID)
        {
            InitializeComponent();
            this.CategoryID = CategoryID;
        }
        private void fEditCategory_Load(object sender, EventArgs e)
        {

            category = db.Categories.Single(p => p.CategoryID == CategoryID);
            Text += " - Mã Loại Máy Bay " + category.CategoryID.ToString();
            txtName.Text = category.CategoryName;

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên loại máy bay?", txtName, 0, 0,
               1000);
                txtName.Focus();
                return;
            }

            try
            {
                category.CategoryName = txtName.Text;
                db.SaveChanges(); //Lưu các thay đổi vào csdl
                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
                btClose.Focus();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message,
               btSave, 0, 0, 1000);
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên loại máy bay?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên loại máy bay <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void fEditCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;

        }
    }
}
