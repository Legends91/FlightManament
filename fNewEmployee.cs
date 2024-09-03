using QLBH.Models;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace QLBH
{
    public partial class fNewEmployee : Form
    {
        Employee employee;

        public fNewEmployee()
        {
            InitializeComponent();
        }
        private void fNewEmployee_Load(object sender, EventArgs e)
        {
            EFDbContext db = new EFDbContext();


            cbRoleID.DisplayMember = "Name";
            cbRoleID.ValueMember = "RoleID";
            cbRoleID.DataSource = db.Roles.ToList();

            cbRoleID.DataSource = db.Roles.Select(c => new
            {
                c.RoleID,
                c.Name
            }).ToList();

        }
        private void fNewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbRoleID.Text))
            {
                toolTip1.Show("Hãy nhập phân quyền?", cbRoleID, 0, 0, 1000);
                cbRoleID.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên nhân viên?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                toolTip1.Show("Hãy nhập CCCD nhân viên?", txtCCCD, 0, 0, 1000);
                txtCCCD.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                toolTip1.Show("Hãy nhập điện thoại?", txtPhone, 0, 0, 1000);
                txtPhone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                toolTip1.Show("Hãy nhập mật khẩu?", txtPassword, 0, 0, 1000);
                txtPassword.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                toolTip1.Show("Hãy nhập ngày?", dateTimePicker1, 0, 0, 1000);
                dateTimePicker1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(dateTimePicker2.Text))
            {
                toolTip1.Show("Hãy nhập ngày?", dateTimePicker2, 0, 0, 1000);
                dateTimePicker2.Focus();
                return;
            }
            try
            {
                employee = new Employee();
                employee.Name = txtName.Text;
                employee.CCCD = txtCCCD.Text;
                employee.Phone = txtPhone.Text;
                employee.Email = txtEmail.Text;
                employee.Password = txtPassword.Text;
                employee.BirthDay = dateTimePicker1.Value.Date;
                employee.DayWork = dateTimePicker2.Value.Date;
                employee.Gender = ckGender.CheckState == CheckState.Indeterminate ? (bool?)null : ckGender.Checked;
                employee.RoleID = Convert.ToInt64(cbRoleID.SelectedValue);
                using (var db = new EFDbContext())
                {
                    db.Employees.Add(employee); //Thêm nhân viên vào csdl
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                txtCCCD.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
                txtPassword.Text = null;
                cbRoleID.Text = null;

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



        private void cbRoleID_Validating(object sender, CancelEventArgs e)
        {
            EFDbContext db = new EFDbContext();
            if (cbRoleID.FindStringExact(cbRoleID.Text) < 0 || cbRoleID.FindStringExact(cbRoleID.Text) >= 6)
            {
                toolTip1.Show("Nhập sai phân quyền!", cbRoleID, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên nhân viên?", txtName, 0, 0,
               1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên khách hàng <= 100 ký tự?", txtName, 0,
               0, 1000);
                e.Cancel = true;
            }
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
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

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length == 10)
                return;
            //if (Regex.IsMatch(txtPhone.Text, @"\d{11}") && txtPhone.Text.Length == 11)
            // return;
            toolTip1.Show("Không đúng dạng số điện thoại?", txtPhone, 0, 0, 1000);
            e.Cancel = true;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
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

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại?", dateTimePicker1, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker2.Value.Date <= dateTimePicker1.Value.Date)
            {
                toolTip1.Show("Ngày vào làm > Ngày sinh?", dateTimePicker2, 0, 0, 1000);
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


    }
}
