using QLBH.Models;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

namespace QLBH
{
    public partial class fEditEmployee : Form
    {
        Employee employee;
        long EmployeeID;
        EFDbContext db = new EFDbContext();
        public fEditEmployee(long EmployeeID)
        {
            InitializeComponent();
            this.EmployeeID = EmployeeID;
        }
        private void fEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void fEditEmployee_Load(object sender, EventArgs e)
        {
            employee = db.Employees.Single(p => p.EmployeeID == EmployeeID);
            Text += " - Mã NV " + employee.EmployeeID.ToString();
            cbRoleID.DisplayMember = "Name";
            cbRoleID.ValueMember = "RoleID";
            cbRoleID.DataSource = db.Roles.ToList();
            cbRoleID.Text = employee.Roles.ToString();
            cbRoleID.DataSource = db.Roles.Select(c => new
            {
                c.RoleID,
                c.Name
            }).ToList();
            cbRoleID.Text = employee.Roles.Name;

            txtName.Text = employee.Name;
            txtCCCD.Text = employee.CCCD;
            txtPhone.Text = employee.Phone;
            txtEmail.Text = employee.Email;
            txtPassword.Text = employee.Password;
            dateTimePicker1.Text = employee.BirthDay.ToString();
            ckGender.CheckState = employee.Gender == null ? CheckState.Indeterminate : (employee.Gender == true ? CheckState.Checked : CheckState.Unchecked);

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên nhân viên?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ nhân viên?", txtCCCD, 0, 0, 1000);
                txtCCCD.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                toolTip1.Show("Hãy nhập điện thoại?", txtPhone, 0, 0, 1000);
                txtPhone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                toolTip1.Show("Hãy nhập email nhân viên?", txtEmail, 0, 0, 1000);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                toolTip1.Show("Hãy nhập mật khẩu?", txtPassword, 0, 0, 1000);
                txtPassword.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbRoleID.Text))
            {
                toolTip1.Show("Hãy nhập phân quyền?", cbRoleID, 0, 0, 1000);
                cbRoleID.Focus();
                return;
            }
            try
            {

                employee.Name = txtName.Text;
                employee.CCCD = txtCCCD.Text;
                employee.Phone = txtPhone.Text;
                employee.Email = txtEmail.Text;
                employee.Password = txtPassword.Text;
                employee.BirthDay = dateTimePicker1.Value.Date;
                employee.DayWork = dateTimePicker2.Value.Date;
                employee.Gender = ckGender.CheckState == CheckState.Indeterminate ? (bool?)null : ckGender.Checked;

                employee.RoleID = Convert.ToInt64(cbRoleID.SelectedValue);
                db.SaveChanges(); //Lưu các thay đổi vào csdl

                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
                btClose.Focus();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
        }
        private void txtRoleID_Validating(object sender, CancelEventArgs e)
        {
            if (cbRoleID.FindStringExact(cbRoleID.Text) < 0)
            {
                toolTip1.Show("Nhập sai phân quyền?", cbRoleID, 0, 0, 1000);
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
                toolTip1.Show("Không đúng dạng địa chỉ email?", txtEmail,
               0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtEmail.Text.Length > 100)
            {
                toolTip1.Show("Địa chỉ email <= 100 ký tự?", txtEmail, 0,
               0, 1000);
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
