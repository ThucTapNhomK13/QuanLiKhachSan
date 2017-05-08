using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUL;

namespace QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr != DialogResult.OK)
                e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (Login (user, pass))
            {
                fTaskManager frmTM = new fTaskManager();
                this.Hide();
                frmTM.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin đăng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool Login (string user, string pass)
        {
            if (AccountBUL.Instance.Login(user, pass))
                return true;

            return false;
        }

        private void fLogin_Activated(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }
    }
}
