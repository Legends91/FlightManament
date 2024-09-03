using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBH
{
    public partial class fNewOrderTicket : Form
    {
        OrderTicket orderticket;
        EFDbContext db = new EFDbContext();
        public fNewOrderTicket()
        {
            InitializeComponent();
        }
        private void fNewOrderTicket_Load(object sender, EventArgs e)
        {
            EFDbContext db = new EFDbContext();


            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DataSource = db.Customers.ToList();
            cbCustomer.DataSource = db.Customers.Select(c => new
            {
                c.CustomerID,
                c.Name
            }).ToList();

            cbChuyenBay.ValueMember = "ChuyenBayID";
            cbChuyenBay.DataSource = db.ChuyenBays.ToList();

            cbCustomer.Text = null;
            cbChuyenBay.Text = null;


        }
        private void fNewOrderTicket_FormClosing(object sender, FormClosingEventArgs e)
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
                orderticket = new OrderTicket();
                orderticket.CustomerID = Convert.ToInt64(cbCustomer.SelectedValue);
                orderticket.ChuyenBayID = Convert.ToInt64(cbChuyenBay.SelectedValue);
                orderticket.OrderDate = dtOrderTicket.Value.Date;
                orderticket.Description = rDescription.Text;

                using (var db = new EFDbContext())
                {
                    db.OrderTickets.Add(orderticket);
                    db.SaveChanges();
                }


                cbCustomer.Text = null;
                cbChuyenBay.Text = null;
                rDescription.Text = null;
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
            fNewOrderTicket_Load(sender, e);
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
