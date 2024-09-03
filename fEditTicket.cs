using QLBH.Models;

namespace QLBH
{
    public partial class fEditTicket : Form
    {
        Ticket ticket;
        long TicketID;
        EFDbContext db = new EFDbContext();
        public fEditTicket(long TicketID)
        {
            InitializeComponent();
            this.TicketID = TicketID;
        }
        private void fEditTicket_Load(object sender, EventArgs e)
        {

            ticket = db.Tickets.Single(p => p.TicketID == TicketID);
            Text += " - Mã Vé " + ticket.TicketID.ToString();
            txtName.Text = ticket.Name;
            mPrice.Text = ticket.Price.ToString();
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên vé?", txtName, 0, 0,
               1000);
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
                ticket.Name = txtName.Text;
                ticket.Price = Convert.ToDecimal(mPrice.Text);
                db.SaveChanges(); //Lưu các thay đổi vào csdl
                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
                btClose.Focus();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message,
               btSave, 0, 0, 1000);
            }
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


        private void fEditTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;

        }






    }
}
