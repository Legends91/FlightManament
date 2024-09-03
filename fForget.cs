using QLBH.Models;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace QLBH
{
    public partial class fForget : Form
    {



        EFDbContext db = new EFDbContext();
        public fForget()
        {
            InitializeComponent();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
            fLogin f = new fLogin();
            f.Show();
        }

        private void fForget_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btForget_Click(object sender, EventArgs e)
        {


            if (txtEmail.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập tên người dùng?";
                txtEmail.Select();
            }

            else if (txtPassword.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập mật khẩu mới?";
                txtPassword.Select();
            }
            else if (txtRePassword.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập đúng mật khẩu";
                txtRePassword.Focus();
                return;
            }
            else
            {
                try
                {


                    Utility.employee = db.Employees.SingleOrDefault(e => e.Email == txtEmail.Text);
                    if (Utility.employee != null) //Nếu đúng email 
                    {
                        if (txtPassword.Text == txtRePassword.Text)
                        {
                            Utility.employee.Password = txtRePassword.Text;
                            db.SaveChanges(); //Lưu các thay đổi vào csdl
                            DialogResult = DialogResult.OK;
                            Close();
                            fLogin f = new fLogin();
                            f.Show();
                        }
                        else lblMessage.Text = "Mật khẩu không trùng khớp!";
                    }
                    //đóng form
                    else
                    {
                        lblMessage.Text = "Không tìm thấy Email!";
                    }




                }

                catch (Exception ex)
                {
                    lblMessage.Text = "Lỗi";

                }
            }

        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return;
            if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                toolTip1.Show("Không đúng dạng địa chỉ email?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtEmail.Text.Length > 100)
            {
                toolTip1.Show("Địa chỉ email <= 100 ký tự?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Length > 15)
            {
                toolTip1.Show("Phải nhập mật khẩu dưới 15 ký tự!", txtPassword, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtRePass_Validating(object sender, CancelEventArgs e)
        {

            if (txtPassword.Text.Length > 15)
            {
                toolTip1.Show("Phải nhập mật khẩu dưới 15 ký tự!", txtRePassword, 0, 0, 1000);
                e.Cancel = true;
            }

        }


    }
}
