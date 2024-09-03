using QLBH.Models;
using System.ComponentModel;
using System.Data;

namespace QLBH
{
    public partial class fEditOrderTicket : Form
    {
        OrderTicket ordertickets;
        private long OrderTicketID;
        EFDbContext db = new EFDbContext();
        public fEditOrderTicket(long OrderTicketID)
        {
            InitializeComponent();
            this.OrderTicketID = OrderTicketID;
        }

        private void fEditOrderTicket_Load(object sender, EventArgs e)
        {
            ordertickets = db.OrderTickets.Single(p => p.OrderTicketID == OrderTicketID);
            Text += " - Mã Đặt Vé " + ordertickets.OrderTicketID.ToString();
            cbOrderTicket.ValueMember = "OrderTicketID";
            cbOrderTicket.DataSource = db.OrderTickets.ToList();
            cbOrderTicket.Text = ordertickets.OrderTicketID.ToString();





            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DataSource = db.Customers.ToList();
            cbCustomer.DataSource = db.Customers.Select(c => new
            {
                c.CustomerID,
                c.Name
            }).ToList();
            cbCustomer.Text = ordertickets.Customers.Name;

            cbChuyenBay.ValueMember = "ChuyenBayID";
            cbChuyenBay.DataSource = db.ChuyenBays.ToList();

            cbChuyenBay.Text = ordertickets.ChuyenBayID.ToString();



            dtOrderTicket.Text = ordertickets.OrderDate.ToShortDateString();
            rDescription.Text = ordertickets.Description;
        }
        private void fEditOrderTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCustomer.Text))
            {
                toolTip1.Show("Hãy nhập khách hàng?", cbCustomer, 0, 0, 1000);
                cbCustomer.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbChuyenBay.Text))
            {
                toolTip1.Show("Hãy nhập chuyến bay?", cbChuyenBay, 0, 0, 1000);
                cbChuyenBay.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(dtOrderTicket.Text))
            {
                toolTip1.Show("Hãy nhập ngày đặt hàng?", dtOrderTicket, 0, 0, 1000);
                dtOrderTicket.Focus();
                return;
            }

            try
            {
                ordertickets.CustomerID = Convert.ToInt64(cbCustomer.SelectedValue);
                ordertickets.ChuyenBayID = Convert.ToInt64(cbChuyenBay.SelectedValue);
                ordertickets.Description = rDescription.Text;
                ordertickets.OrderDate = dtOrderTicket.Value.Date;
                db.SaveChanges(); //Lưu các thay đổi vào csdl
                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
                btClose.Focus();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }

        }
        private void cbCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (cbCustomer.FindStringExact(cbCustomer.Text) < 0) //Nếu sai tên loại
            {
                toolTip1.Show("Nhập sai mã khách hàng?", cbCustomer, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbChuyenBay_Validating(object sender, CancelEventArgs e)
        {
            if (cbChuyenBay.FindStringExact(cbChuyenBay.Text) < 0) //Nếu sai tên loại
            {
                toolTip1.Show("Nhập sai mã chuyến bay?", cbChuyenBay, 0, 0, 1000);
                e.Cancel = true;
            }
        }


    }
}
