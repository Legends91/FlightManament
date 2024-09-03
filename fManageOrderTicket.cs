using QLBH.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace QLBH
{
    public partial class fManageOrderTicket : Form
    {
        public fManageOrderTicket()
        {
            InitializeComponent();
        }
        private void fManageOrder_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year + 1; i >= 2015; i--)
                cbYear.Items.Add(i);
            dataGridView1.Width = dataGridView1.Width;
        }
        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = string.IsNullOrWhiteSpace(cbYear.Text) ? DateTime.Now.Year : Convert.ToInt32(cbYear.Text);

            byte month = Convert.ToByte(string.IsNullOrWhiteSpace(cbMonth.Text) ? DateTime.Now.Month : (cbMonth.Text == "Tất cả" ? 0 : cbMonth.Text));
            using (var db = new EFDbContext())
            {
                if (month == 0)
                    dataGridView1.DataSource = db.OrderTickets.Where(o =>
                   o.OrderDate.Year == year).Select(o => new
                   {
                       o.OrderTicketID,
                       o.CustomerID,
                       o.ChuyenBayID,
                       o.OrderDate,
                       o.Description,
                   }).ToList();
                else
                    dataGridView1.DataSource = db.OrderTickets.Where(o =>
                   o.OrderDate.Year == year && o.OrderDate.Month == month).Select(o => new
                   {
                       o.OrderTicketID,
                       o.CustomerID,
                       o.ChuyenBayID,
                       o.OrderDate,
                       o.Description,

                   }).ToList();
            }
            //lblNumOfOrder.Text = "Số đơn hàng: " + dataGridView1.Rows.Count;
        }
        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMonth_SelectedIndexChanged(sender, e);
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                DateTime OrderDate = dateTimePicker1.Value.Date;
                dataGridView1.DataSource = db.OrderTickets.Where(o => o.OrderDate ==
               OrderDate || OrderDate == null).Select(o => new
               {
                   o.OrderTicketID,
                   o.CustomerID,
                   o.ChuyenBayID,
                   o.OrderDate,
                   o.Description,

               }).ToList();

            }
        }
        private void fManageOrder_Activated(object sender, EventArgs e)
        {
            cbMonth_SelectedIndexChanged(sender, e);
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewOrderTicket"))
                return;
            fNewOrderTicket f = new fNewOrderTicket();
            //f.MdiParent = this.MdiParent;
            f.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Xóa")
            {
                try
                {
                    long OrderTicketID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["OrderTicketID"].Value);
                    using (var db = new EFDbContext())
                    {
                        OrderTicket ordertickets = db.OrderTickets.Single(c => c.OrderTicketID == OrderTicketID);
                        if (MessageBox.Show("Bạn muốn xóa mã đặt vé " + ordertickets.OrderTicketID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                       DialogResult.Yes)
                        {
                            db.OrderTickets.Remove(ordertickets);

                            db.SaveChanges();
                            fManageOrder_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sửa")
            {
                if (Utility.IsOpeningForm("fEditOrderTicket"))
                    return;
                fEditOrderTicket f = new fEditOrderTicket(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["OrderTicketID"].Value)
               );
                //f.MdiParent = this.MdiParent;
                f.ShowDialog();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            cbMonth_SelectedIndexChanged(sender, e);
        }
    }
}