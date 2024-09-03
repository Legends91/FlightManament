using Microsoft.EntityFrameworkCore;
using QLBH.Models;

namespace QLBH
{
    public partial class fManageCustomer : Form
    {
        public fManageCustomer()
        {
            InitializeComponent();
        }
        private void fManageCustomer_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.Customers.Load();
                dataGridView1.DataSource = db.Customers.Local.ToList();
            }
        }
        private void fManageCustomer_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.Customers.Load();
                dataGridView1.DataSource = db.Customers.Local.ToList();
            }
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Customers.Where(c =>
               c.Name.Contains(txtName.Text)).ToList();
            }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            fNewCustomer f = new fNewCustomer();
            f.ShowDialog();

        }
        private void dataGridView1_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long CustomerID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Customer customer = db.Customers.Single(c => c.CustomerID == CustomerID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + customer.Name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                        {
                            db.Customers.Remove(customer);
                            db.SaveChanges();
                            fManageCustomer_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditCustomer"))
                    return;
                fEditCustomer f = new fEditCustomer(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].
               Value));
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
            fManageCustomer_Load(sender, e);
        }
    }
}