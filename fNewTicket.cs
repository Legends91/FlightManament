using QLBH.Models;

namespace QLBH
{
    public partial class fNewTicket : Form
    {
        Ticket ticket;
        public fNewTicket()
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
                toolTip1.Show("Hãy nhập tên vé?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mPrice.Text))
            {
                toolTip1.Show("Hãy nhập giá vé?", mPrice, 0, 0,
               1000);
                mPrice.Focus();
                return;
            }

            try
            {
                //Tạo khách hàng mới
                ticket = new Ticket(); //Tạo một thể hiện cho khách hàng mới
                ticket.Name = txtName.Text;
                ticket.Price = Convert.ToDecimal(mPrice.Text);


                using (var db = new EFDbContext())
                {
                    db.Tickets.Add(ticket); //Thêm khách hàng vào csdl
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                mPrice.Text = null;


                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
               1000);
            }
            txtName.Focus();
        }
        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên vé?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên vé <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void mPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu số nguyên?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
            else
            if ((Int64)e.ReturnValue < 0)
            {
                toolTip1.Show("Giá vé phải >= 0?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void fNewTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
