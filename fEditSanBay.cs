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
    public partial class fEditSanBay : Form
    {
        SanBay sanbay;
        string SanBayID;
        EFDbContext db = new EFDbContext();
        public fEditSanBay(string SanBayID)
        {
            InitializeComponent();
            this.SanBayID = SanBayID;
        }
        private void fEditSanBay_Load(object sender, EventArgs e)
        {

            sanbay = db.SanBays.Single(p => p.SanBayID == SanBayID);
            Text += " - Mã Sân Bay " + sanbay.SanBayID.ToString();

            txtName.Text = sanbay.TenSanBay;
            txtAddress.Text = sanbay.Address;
        }
        private void btSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sân bay?", txtName, 0, 0,
               1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa điểm?", txtAddress, 0, 0,
               1000);
                txtAddress.Focus();
                return;
            }
            try
            {

                sanbay.TenSanBay = txtName.Text;
                sanbay.Address = txtAddress.Text;
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

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sân bay?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên sân bay <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập địa điểm?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên địa điểm <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }


        private void fEditSanBay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }


    }
}
