using QLBH.Models;
using System.ComponentModel;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fNewProduct : Form
    {
        Product product;
        public fNewProduct()
        {
            InitializeComponent();
        }
        private void fNewProduct_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                cbCategories.DisplayMember = "CategoryName";
                cbCategories.ValueMember = "CategoryID";
                cbCategories.DataSource = db.Categories.Select(c => new { c.CategoryID, c.CategoryName }).ToList();
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close(); //Nhớ thiết lập thuộc tính
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbCategories.Text))
            {
                toolTip1.Show("Hãy nhập loại sản phẩm?", cbCategories, 0, 0, 1000);
                cbCategories.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                toolTip1.Show("Hãy nhập nhà sản xuất?", txtManufacturer, 0, 0, 1000);
                txtManufacturer.Focus();
                return;
            }
            try
            {
                product = new Product(); //Tạo một thể hiện cho sản phẩm mới
                product.Name = txtName.Text;
                product.Manufacturer = txtManufacturer.Text;
                product.Status = ckStatus.Checked;
                product.CategoryID = Convert.ToInt64(cbCategories.SelectedValue);
                using (var db = new EFDbContext())
                {
                    db.Products.Add(product); //Thêm sản phẩm vào bối cảnh
                    db.SaveChanges(); //Lưu các thay đổi vào csdl 
                                      //Lưu hình vào thư mục hình và tên tập tin hình vào csdl
                    if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                    {
                        string ext = txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."), txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                        product.ImageFile = product.ProductID + ext;
                        pictureBox1.Image.Save(Utility.ImagePath + product.ProductID
                       + ext);
                        db.SaveChanges(); //Lưu các thay đổi vào csdl
                    }
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                //cbCategories.Text = null;
                txtManufacturer.Text = null;
                ckStatus.Checked = true;
                txtImageFile.Text = null;
                pictureBox1.ImageLocation = null;
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
               1000);
            }
            txtName.Focus();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All file|*.*|Bitmap File | *.bmp; *.dib | JPEG | *.jpg; *.jpe; *.jpeg; *.jfif | GIF | *.gif | TIFF | *.tif; *.tiff | PNG | *.png | ICO | *.ico";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                e.Cancel = true; //Phải nhập dữ liệu cho cột not null
            }
            else if (txtName.Text.Length > 200)
            {
                toolTip1.Show("Tên sản phẩm - tối đa 200 ký tự?", txtName, 0, 0,
               1000);
                e.Cancel = true;
            }
        }

        private void txtImageFile_Validating(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = null;
            if (string.IsNullOrWhiteSpace(txtImageFile.Text))
                return; //Không cần nhập dữ liệu cho cột có thể null
            if (txtImageFile.Text.Length > 200)
            {
                toolTip1.Show("Tên tập tin - tối đa 200 ký tự?", txtImageFile, 0, 0,
               1000);
                e.Cancel = true;
            }
            if (!File.Exists(txtImageFile.Text))
            {
                toolTip1.Show("Tên tập tin sai hoặc Tập tin không tồn tại?",
               txtImageFile, 0, 0, 1000);
                e.Cancel = true;
            }
            else
                pictureBox1.ImageLocation = txtImageFile.Text;

        }
        private void txtManufacturer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                toolTip1.Show("Hãy nhập tên nhà sản xuất?", txtManufacturer, 0, 0, 1000);
                e.Cancel = true; //Phải nhập dữ liệu cho cột not null
            }
            else if (txtManufacturer.Text.Length > 200)
            {
                toolTip1.Show("Tên nhà sản xuất - tối đa 200 ký tự?", txtManufacturer, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void cbCategories_Validating(object sender, CancelEventArgs e)
        {
            if (cbCategories.FindStringExact(cbCategories.Text) < 0) //Nếu sai tên loại
            {
                toolTip1.Show("Nhập sai loại sản phẩm?", cbCategories, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void fNewProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }


    }
}

