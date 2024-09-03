using QLBH.Models;
using System.ComponentModel;

namespace QLBH
{
    public partial class fNewCategory : Form
    {
        Category category;
        public fNewCategory()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên loại máy bay?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }


            try
            {
                //Tạo khách hàng mới
                category = new Category(); //Tạo một thể hiện cho khách hàng mới
                category.CategoryName = txtName.Text;
                using (var db = new EFDbContext())
                {
                    db.Categories.Add(category); //Thêm khách hàng vào csdl
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;



                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
               1000);
            }
            txtName.Focus();
        }


        private void fNewCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
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
    }
}
