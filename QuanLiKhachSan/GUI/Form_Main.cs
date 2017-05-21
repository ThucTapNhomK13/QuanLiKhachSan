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

namespace GUI
{
    public partial class Form_Main : MetroForm
    {
        public static string name = String.Empty;
        public Form_Main()
        {
            InitializeComponent();
        }

        //private void TExport_Click(object sender, EventArgs e)
        //{

        //}

        //private void TAdmin_Click(object sender, EventArgs e)
        //{

        //}

        //private void TGoods_Click(object sender, EventArgs e)
        //{

        //}

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form_HoaDon listbill = new Form_HoaDon();
            listbill.ShowDialog();
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form_QuanLiKhachHang listcustomer = new Form_QuanLiKhachHang();
            listcustomer.ShowDialog();
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Form_Phong classroom = new Form_Phong();
            classroom.ShowDialog();
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            labName.Text = name;
        }
    }
}
