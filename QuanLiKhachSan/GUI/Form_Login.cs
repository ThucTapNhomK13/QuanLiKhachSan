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
    public partial class Form_Login : MetroForm
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        void setNull()
        {
            txtPasswords.Text = "";
            txtUser.Text = "";
            txtUser.Focus(); // Dat con tro vao o co cai nay !!!
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setNull();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BUS_User us = new BUS_User();
            List<DangNhap> dn = us.dangNhap();
            bool test = false;
            for (int i = 0; i < dn.Count; i++)
            {
                if (dn[i].tendangnhap.ToString() == txtUser.Text.ToString() &&
                    dn[i].matkhau.ToString() == txtPasswords.Text.ToString())
                {
                    test = true;
                    Form_Main.name = txtUser.Text.ToString();
                }
            }
            if (test)
            {           
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
                Form_Main main = new Form_Main();
                main.Show();
                
            }
            else
            {
                MessageBox.Show("Bạn đã điền sai tên đăng nhập hoặc mật khẩu ! ", "Thông báo", MessageBoxButtons.OK);
                setNull();
            }
        
    }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
