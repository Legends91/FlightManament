using System.Windows.Forms;
using WinFormsApp1;

namespace QLBH
{
    public partial class fLogin : Form
    {

        public fLogin()
        {
            InitializeComponent();

        }



        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btLogin_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập tên người dùng?";
                txtEmail.Select();
            }
            else if (txtPassword.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập mật khẩu?";
                txtPassword.Select();
            }
            else
            {
                try
                {

                    using (var db = new EFDbContext())
                    {

                        Utility.employee = db.Employees.SingleOrDefault(e => e.Email == txtEmail.Text && e.Password == txtPassword.Text);
                        if (Utility.employee != null) //Nếu đăng nhập thành công   
                        {
                            DialogResult = DialogResult.OK;
                            fMain f = new fMain();
                            f.Show();
                            this.Hide();
                        }//đóng form
                        else
                        { lblMessage.Text = "Sai tên người dùng hoặc mật khẩu"; }


                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Lỗi";

                }
            }
        }

        private void liForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            if (Utility.IsOpeningForm("fForget"))
                return;
            fForget f = new fForget();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Hide();
        }


    }
}
