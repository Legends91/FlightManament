using Microsoft.EntityFrameworkCore;
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

namespace QLBH
{
    public partial class fManageTicket : Form
    {
        public fManageTicket()
        {
            InitializeComponent();
        }
        private void fManageTicket_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.Tickets.Load();
                dataGridView1.DataSource = db.Tickets.Local.ToList();
            }
        }
        private void fManageTicket_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.Tickets.Load();
                dataGridView1.DataSource = db.Tickets.Local.ToList();
            }
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Tickets.Where(c =>
               c.Name.Contains(txtName.Text)).ToList();
            }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            fNewTicket f = new fNewTicket();
            f.ShowDialog();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long TicketID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["TicketID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Ticket ticket = db.Tickets.Single(c => c.TicketID == TicketID);
                        if (MessageBox.Show("Bạn muốn xóa vé " + ticket.Name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Tickets.Remove(ticket);
                            db.SaveChanges();
                            fManageTicket_Activated(sender, e);
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
                if (Utility.IsOpeningForm("fEditTicket"))
                    return;
                fEditTicket f = new fEditTicket(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["TicketID"].Value));
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
            fManageTicket_Load(sender, e);
        }
    }
}
