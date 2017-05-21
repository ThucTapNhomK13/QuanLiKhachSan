using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using DTO_Model;

namespace GUI
{
    public partial class Form_HoaDon : MetroForm
    {
        BUS_HoaDon bill = null;
        public Form_HoaDon()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            bill = new BUS_HoaDon();
            DataTable tbl = bill.DSHoaDon();
            dataGridView1.DataSource = tbl;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xóa hóa đơn ?" , "Cảnh báo ",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(bill.XoaHd(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Đã xóa hóa đơn", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa hóa đơn thất bại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            txtBillId.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            dtpDate.Text = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
            txtPayments.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtPay.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtIdStaff.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtStatus.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
