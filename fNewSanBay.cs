using QLBH.Models;

namespace QLBH
{
    public partial class fNewSanBay : Form
    {
        SanBay sanbay;
        public fNewSanBay()
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
                toolTip1.Show("Hãy nhập tên sân bay?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSanBayID.Text))
            {
                toolTip1.Show("Hãy nhập mã sân bay?", txtSanBayID, 0, 0, 1000);
                txtSanBayID.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa điểm?", txtAddress, 0, 0,
               1000);
                txtAddress.Focus();
                return;
            }

            try
            {
                //Tạo khách hàng mới
                sanbay = new SanBay(); //Tạo một thể hiện cho khách hàng mới
                sanbay.SanBayID = txtName.Text;
                sanbay.TenSanBay = txtSanBayID.Text;
                sanbay.Address = txtAddress.Text;


                using (var db = new EFDbContext())
                {
                    db.SanBays.Add(sanbay); //Thêm khách hàng vào csdl
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtSanBayID.Text = null;
                txtName.Text = null;
                txtAddress.Text = null;


                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
               1000);
            }
            txtSanBayID.Focus();
        }
        private void txtSanBayID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSanBayID.Text))
            {
                toolTip1.Show("Hãy nhập mã sân bay?", txtSanBayID, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtSanBayID.Text.Length > 100)
            {
                toolTip1.Show("Mã sân bay <= 100 ký tự?", txtSanBayID, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sân bay?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên sân bay <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSanBayID.Text))
            {
                toolTip1.Show("Hãy nhập địa điểm?", txtSanBayID, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtSanBayID.Text.Length > 100)
            {
                toolTip1.Show("Tên địa điểm <= 100 ký tự?", txtSanBayID, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void fNewSanBay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }


    }
}
