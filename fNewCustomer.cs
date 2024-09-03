using QLBH.Models;
using System.Security.Policy;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBH
{
    public partial class fNewCustomer : Form
    {
        Customer customer;

        public fNewCustomer()
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
                toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ khách hàng?", txtCCCD, 0, 0,
               1000);
                txtCCCD.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                toolTip1.Show("Hãy nhập điện thoại?", txtPhone, 0, 0, 1000);
                txtPhone.Focus();
                return;
            }
            try
            {
                //Tạo khách hàng mới
                customer = new Customer(); //Tạo một thể hiện cho khách hàng mới
                customer.Name = txtName.Text;
                customer.CCCD = txtCCCD.Text;
                customer.Phone = txtPhone.Text;
                customer.Email = txtEmail.Text;
                customer.BirthDay = dateTimePicker1.Value.Date;
                customer.Gender = ckGender.CheckState == CheckState.Indeterminate ? (bool?)null : ckGender.Checked;

                using (var db = new EFDbContext())
                {
                    db.Customers.Add(customer); //Thêm khách hàng vào csdl
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                txtCCCD.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
                //dateTimePicker1.Text = null;//Không tác dụng
                ckGender.CheckState = CheckState.Indeterminate;

                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
               1000);
            }
            txtName.Focus();
        }
        private void txtName_Validating(object sender,
       System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên khách hàng <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void txtCCCD_Validating(object sender,
       System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                toolTip1.Show("Hãy nhập CCCD?", txtCCCD, 0, 0,
               1000);
                e.Cancel = true;
            }
            else if (txtCCCD.Text.Length != 12)
            {
                toolTip1.Show("CCCD phải có 12 số!", txtCCCD, 0, 0,
               1000);
                e.Cancel = true;
            }
        }
        private void txtPhone_Validating(object sender,
       System.ComponentModel.CancelEventArgs e)
        {
            if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length == 10)
                return;
            //if (Regex.IsMatch(txtPhone.Text, @"\d{11}") && txtPhone.Text.Length == 11)
            // return;
            toolTip1.Show("Không đúng dạng số điện thoại?", txtPhone, 0, 0, 1000);
            e.Cancel = true;
        }
        private void txtEmail_Validating(object sender,
       System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return; //Có thể không cần nhập dữ liệu cho cột có thể null
            if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {

                toolTip1.Show("Không đúng dạng địa chỉ email?", txtEmail, 0, 0,
    1000);
                e.Cancel = true;
            }
            else if (txtEmail.Text.Length > 100)
            {
                toolTip1.Show("Địa chỉ email <= 100 ký tự?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void dateTimePicker1_Validating(object sender,
       System.ComponentModel.CancelEventArgs e)
        {
            if (dateTimePicker1.Value.Date >= DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại?", dateTimePicker1, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void fNewCustomer_FormClosing(object sender, FormClosingEventArgs
       e)
        {
            e.Cancel = false;
        }


    }
}