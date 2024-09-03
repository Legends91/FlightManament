using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fEditProduct : Form
    {
        private Product product;
        private long ProductID;
        private EFDbContext db = new EFDbContext();
        public fEditProduct(long ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
        }
        private void fEditProduct_Load(object sender, EventArgs e)
        {
            product = db.Products.Single(p => p.ProductID == ProductID);
            Text += " - Mã SP " + product.ProductID.ToString();
            txtName.Text = product.Name;
            txtManufacturer.Text = product.Manufacturer.ToString();
            ckStatus.Checked = product.Status;

            txtImageFile.Text =
           string.IsNullOrWhiteSpace(product.ImageFile) ? null : Utility.ImagePath + product.ImageFile;
            pictureBox1.ImageLocation = txtImageFile.Text; //Hiển thị hình
                                                           //Nạp dữ liệu cho ComboBox
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryID";
            cbCategories.DataSource = db.Categories.ToList();
            cbCategories.Text = product.Categories.ToString();
            cbCategories.DataSource = db.Categories.Select(c => new
            {
                c.CategoryID,
                c.CategoryName
            }).ToList();
            cbCategories.Text = product.Categories.CategoryName;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close(); //Nhớ thiết lập thuộc tính
        }
        private void btBrowse_Click(object sender, EventArgs e)
        {
            //Nhớ xóa trống thuộc tính Filename lúc thiết kế
            //Filter có thể thiết lập lúc thiết kế
            openFileDialog1.Filter = "All file|*.*|Bitmap File | *.bmp; *.dib | JPEG | *.jpg; *.jpe; *.jpeg; *.jfif | GIF | *.gif | TIFF | *.tif; *.tiff | PNG | *.png | ICO | *.ico";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên máy bay?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbCategories.Text))
            {
                toolTip1.Show("Hãy nhập loại máy bay?", cbCategories, 0, 0, 1000);
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
                product.Name = txtName.Text;
                product.Manufacturer = txtManufacturer.Text;
                product.Status = ckStatus.Checked;
                product.CategoryID = Convert.ToInt64(cbCategories.SelectedValue);
                if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                {
                    string ext = txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."), txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                    product.ImageFile = product.ProductID + ext;
                    pictureBox1.Image.Save(Utility.ImagePath + product.ProductID + ext);
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }


                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
                btClose.Focus();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message,
               btSave, 0, 0, 1000);
            }
        }
        private void fEditProduct_FormClosing(object sender,
       FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}