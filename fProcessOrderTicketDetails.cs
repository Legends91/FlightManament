using Microsoft.EntityFrameworkCore;
using QLBH.Models;

namespace QLBH
{
    public partial class fProcessOrderTicketDetails : Form
    {
        private EFDbContext db = new EFDbContext();

        private void loadOrderTicketDetails()
        {
            long? OrderTicketID = Convert.ToInt64(cbOrderTicket.SelectedValue);
            var details = db.OrderTicketDetails.Where(d => d.OrderTicketID == OrderTicketID).Select(d => new { d.OrderTicketDetailID, d.OrderTicketID, d.TicketID, d.Price, d.Quantity, d.OrderDate, d.Status }).ToList();
            List<OrderTicketDetailsAndChuyenBay> list = new List<OrderTicketDetailsAndChuyenBay>();
            foreach (var d in details)
            {
                OrderTicketDetailsAndChuyenBay detail = new OrderTicketDetailsAndChuyenBay();
                detail.OrderTicketDetailID = d.OrderTicketDetailID;
                detail.OrderTicketID = d.OrderTicketID;
                detail.TicketID = d.TicketID;
                detail.Price = d.Price;
                detail.Quantity = d.Quantity;
                detail.OrderDate = d.OrderDate;
                detail.Status = d.Status;
                list.Add(detail);
            }
            dataGridView1.DataSource = list;
            cbOrderTicket.Focus();
        }
        public fProcessOrderTicketDetails()
        {

            InitializeComponent();

        }
        private void fProcessOrderTicketDetails_Load(object sender, EventArgs e)
        {
            EFDbContext db = new EFDbContext();

            cbOrderTicket.ValueMember = "OrderTicketID";
            cbOrderTicket.DataSource = db.OrderTickets.ToList();

            cbVe.DisplayMember = "Name";
            cbVe.ValueMember = "TicketID";
            cbVe.DataSource = db.Tickets.Select(p => new
            {
                p.TicketID,
                p.Name
            }).ToList();

            cbSanBayDi.ValueMember = "SanBayID";
            cbSanBayDi.DataSource = db.SanBays.ToList();
            cbSanBayDi.DataSource = db.SanBays.Select(c => new
            {
                c.SanBayID,
                c.TenSanBay
            }).ToList();

            cbSanBayDen.ValueMember = "SanBayID";
            cbSanBayDen.DataSource = db.SanBays.ToList();
            cbSanBayDen.DataSource = db.SanBays.Select(c => new
            {
                c.SanBayID,
                c.TenSanBay
            }).ToList();

            cbOrderTicket.Text = null;
            cbVe.Text = null;
            cbSanBayDi.Text = null;
            cbSanBayDen.Text = null;
            mQuantity.ValidatingType = typeof(Int32);


        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fProcessOrderTicketDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        private void cbOrderTickets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            long? OrderTicketID = Convert.ToInt64(cbOrderTicket.SelectedValue);
            OrderTicket ordertickets = db.OrderTickets.Include(o => o.Customers).Single(o => o.OrderTicketID == OrderTicketID);
            ChuyenBay chuyenbay = db.ChuyenBays.Include(o => o.SanBays).Single(o => o.ChuyenBayID == OrderTicketID);

            Text = "Xử lý chi tiết đơn hàng " + ordertickets.OrderTicketID.ToString();
            cbSanBayDi.Text = chuyenbay.SanBayDi.ToString();
            cbSanBayDen.Text = chuyenbay.SanBayDen.ToString();
            dtOrderDate.Text = ordertickets.OrderDate.ToShortDateString();
            mThoiGianDi.Text = chuyenbay.ThoiGianDi.ToString();
            mThoiGianDen.Text = chuyenbay.ThoiGianDen.ToString();
            cbVe.Text = ordertickets.ChuyenBayID.ToString();

            cbCustomers.Text = ordertickets.Customers.Name;
            cbVe.Text = null;
            mQuantity.Text = "1";
            loadOrderTicketDetails();

            dataGridView1.Columns["TicketID"].ReadOnly = true;
            dataGridView1.Columns["OrderTicketID"].ReadOnly = true;


        }
        private void cbVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            long Ticket = Convert.ToInt32(cbVe.SelectedValue);
            mPrice.Text = db.Tickets.Where(p => p.TicketID == Ticket).Select(p => p.Price).SingleOrDefault().ToString();//lỗi với Single
            mQuantity.Focus();
        }
        private void cbVe_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbVe.Text))
            {

                toolTip1.Show("Hãy nhập hoặc chọn vé?", cbVe, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (cbVe.FindStringExact(cbVe.Text) < 0)
            {
                toolTip1.Show("Nhập sai loại vé?", cbVe, 0, 0, 1000);
                e.Cancel = true;
            }
            else //Kiểm tra chọn mã số trùng
            {
                long? OrderTicketID = Convert.ToInt64(cbOrderTicket.SelectedValue);
                long TicketID = TicketID = Convert.ToInt64(cbVe.SelectedValue);
                if (db.OrderTicketDetails.SingleOrDefault(o => o.OrderTicketID == OrderTicketID && o.TicketID == TicketID) != null)//không dùng Single
                {
                    toolTip1.Show("Hãy chọn vé khác. Đơn đặt vé đã có vé này? ", cbVe, 0, 0, 1000);
                    e.Cancel = true;
                }
            }
        }
        private void btAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbVe.Text))
            {
                toolTip1.Show("Hãy nhập Vé?", cbVe, 0, 0, 1000);
                cbVe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mQuantity.Text))
            {
                toolTip1.Show("Hãy nhập số lượng?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }

            try
            {

                long? OrderID = Convert.ToInt64(cbOrderTicket.SelectedValue);
                OrderTicketDetail orderticketdetail = new OrderTicketDetail();
                orderticketdetail.OrderTicketID = (long)OrderID;
                orderticketdetail.TicketID = Convert.ToInt64(cbVe.SelectedValue);
                orderticketdetail.Quantity = Convert.ToInt32(mQuantity.Text);
                orderticketdetail.Price = Convert.ToDecimal(mPrice.Text);
                orderticketdetail.OrderDate = dtOrderDate.Value.Date;
                orderticketdetail.Status = ckTT.CheckState == CheckState.Indeterminate ? (bool?)null : ckTT.Checked;
                db.OrderTicketDetails.Add(orderticketdetail);
                db.SaveChanges();


                cbVe.Text = null;
                mQuantity.Text = null;
                //mPrice.Text = null;
                loadOrderTicketDetails();
                toolTip1.Show("Thêm thành công.", btAddOrderDetail, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Thêm thất bại? Error: " + ex.Message, btAddOrderDetail,
               0, 0, 1000);
            }
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderTicketDetail orderdetail;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long? OrderTicketID = Convert.ToInt64(cbOrderTicket.SelectedValue);
                    long TicketID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["TicketID"].Value);
                    orderdetail = db.OrderTicketDetails.Single(o => o.TicketID == TicketID && o.OrderTicketID == OrderTicketID);
                    if (MessageBox.Show("Bạn muốn xóa đơn hàng: " + TicketID + "?", "Xóa",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.OrderTicketDetails.Remove(orderdetail);
                        db.SaveChanges();
                        loadOrderTicketDetails();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
        }
        /*private void btSave_Click(object sender, EventArgs e)
        {
            OrderTicketDetail orderticketdetail;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    long? OrderTicketID = Convert.ToInt64(cbOrderTicket.SelectedValue);
                    orderticketdetail = new OrderTicketDetail();
                    long TicketID = Convert.ToInt64(dataGridView1.Rows[i].Cells["TicketID"].Value);
                    orderticketdetail = db.OrderTicketDetails.Single(o => o.OrderTicketID == OrderTicketID && o.TicketID == TicketID);
                    orderticketdetail.Quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["Quantity"].Value);
                    orderticketdetail.Price = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Price"].Value);

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
                   1000);
                    return;
                }
            }
            loadOrderTicketDetails();
            toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
        } */
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Quantity")
            {
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Hãy nhập số lượng?";
                    e.Cancel = true;
                    return;
                }
                else
                {
                    try
                    {
                        if (Convert.ToInt32(e.FormattedValue) < 0)
                        {
                            dataGridView1.Rows[e.RowIndex].ErrorText = "Số lượng phải >= 0 ? ";
                            e.Cancel = true;
                        }
                        else
                            dataGridView1.Rows[e.RowIndex].ErrorText = "";
                    }
                    catch

                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText = "Dữ liệu sai kiểu số nguyên ? ";
                        e.Cancel = true;
                        return;
                    }
                }
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = true;
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = false;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Price")
            {
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Hãy nhập giá bán?";
                    e.Cancel = true;
                    return;
                }
                else
                {
                    try
                    {
                        if (Convert.ToDecimal(e.FormattedValue) < 0)
                        {
                            dataGridView1.Rows[e.RowIndex].ErrorText = "Giá bán phải >= 0 ? ";

                            e.Cancel = true;
                        }
                        else
                            dataGridView1.Rows[e.RowIndex].ErrorText = "";
                    }
                    catch
                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText = "Dữ liệu sai kiểu số thực ? ";

                        e.Cancel = true;
                        return;

                    }
                }
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = true;
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = false;
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            mQuantity.Text = "0";
            cbOrderTicket.Focus();
            mQuantity.Text = null;
        }



        private void cbOrderTickets_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbOrderTicket.FindStringExact(cbOrderTicket.Text) < 0)
            {
                toolTip1.Show("Nhập sai Mã đặt?", cbOrderTicket, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void mQuantity_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu số nguyên?", mQuantity, 0, 0, 1000);
                e.Cancel = false;
            }
            else
            if ((Int32)e.ReturnValue < 0)
            {
                toolTip1.Show("Số lượng phải >= 0?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }
        }


    }
}