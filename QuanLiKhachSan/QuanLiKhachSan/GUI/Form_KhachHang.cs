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

using DTO_Model;
using BUS;

namespace GUI
{
    public partial class Form_KhachHang : MetroForm
    {
        public static string classroomid = string.Empty;

        public static List<string> items = null;      

        public Form_KhachHang()
        {
            InitializeComponent();
        }

        private void Form_KhachHang_Load(object sender, EventArgs e)
        {
            labIdClass.Text = "Phòng " + classroomid;
            foreach (var item in items)
            {
                cmbItem.Items.Add(item);
            }       
        }

        public List<string> Inserts()
        {
            List<string> kh = new List<string>();
            kh.Add(txtName.Text);
            if (rbdMale.Checked)
                kh.Add("Nam");
            else
                kh.Add("Nữ");         
            kh.Add(txtTel.Text);
            kh.Add(txtPeopleId.Text);
            kh.Add(classroomid);
            kh.Add(dtpDateOrder.Value.ToString("MM/dd/yyyy"));
            kh.Add(dtpGiveBack.Value.ToString("MM/dd/yyyy"));
            kh.Add(txtPayments.Text);
            return kh;
        }
        private void btnInserts_Click(object sender, EventArgs e)
        {
            BUS_KhachHang customer = new BUS_KhachHang();
            if(customer.ThemkH(Inserts()))
            {
                DataTable tblkh = new DataTable();
                tblkh = customer.DSKhachHang();
                DataRow dtr = tblkh.Rows[tblkh.Rows.Count - 1];
                BUS_Phong classroom = new BUS_Phong();
                if(classroom.NhanTraPhong("Yes", dtr[0].ToString(), classroomid))
                {
                    MessageBox.Show("Đã đặt phòng", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            this.Close();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            /// tai sao ko đóng form được ?????
            //Form_KhachHang frmkh = new Form_KhachHang();
            //frmkh.Close();
            this.Close();
            
        }
    }
}
