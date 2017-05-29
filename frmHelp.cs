using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.vn/?gws_rd=ssl");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtSearch.Text);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://phanmem25az.blogspot.com/2017/05/huong-dan-su-dung-phan-mem-quan-ly.html");
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Form_Main main = new Form_Main();
            this.Hide();
            main.Show();
        }
    }
}
