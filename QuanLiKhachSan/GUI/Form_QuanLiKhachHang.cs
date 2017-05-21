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
    public partial class Form_QuanLiKhachHang : MetroForm
    {
        BUS_KhachHang customer = null;
        BUS_DichVu service = null;
        List<string> listservice = null;

        public Form_QuanLiKhachHang()
        {
            InitializeComponent();
        }

        private void Form_QuanLiKhachHang_Load(object sender, EventArgs e)
        {
            customer = new BUS_KhachHang();
            DataTable tbl = customer.DSKhachHang();
            dataGridView1.DataSource = tbl;

            service = new BUS_DichVu();
            DataTable tblservice = service.DSDichVu();
            listservice = new List<string>();
            foreach (DataRow row in tblservice.Rows)
            {
                cmbService.Items.Add(row[1].ToString() + " : " + row[2].ToString());
                listservice.Add(row[1].ToString());
            }
          
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            cmbServiceUsed.Items.Clear();
            List<string> serviceused = null;
            int index = dataGridView1.CurrentRow.Index;
            txtName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            if (dataGridView1.Rows[index].Cells[2].Value.ToString() == "Nam")
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;
            txtTel.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtPeopleId.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtClassroomId.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            dtpOrder.Text = Convert.ToString(dataGridView1.Rows[index].Cells[6].Value);
            dtpGiveBack.Text = Convert.ToString(dataGridView1.Rows[index].Cells[7].Value);
            txtPayments.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
            DataTable tblserviceused = service.DSDichVuSuDung();
            serviceused = new List<string>();
            foreach (DataRow row in tblserviceused.Rows)
            {
                if (row[0].ToString() == dataGridView1.Rows[index].Cells[0].Value.ToString())
                {
                    cmbServiceUsed.Items.Add(listservice[int.Parse(row[1].ToString())-1] + " : " + row[2].ToString());
                    serviceused.Add(row[2].ToString());
                }                  
            }
        }

        public void LoadComboBox()
        {
            DataTable tblserviceused = service.DSDichVuSuDung();
            foreach (DataRow row in tblserviceused.Rows)
            {
                if (row[0].ToString() == dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString())
                {
                    cmbServiceUsed.Items.Add(listservice[int.Parse(row[1].ToString())-1] + " : " + row[2].ToString());                   
                }
            }
        }

        public List<string> Themkh()
        {
            List<string> kh = new List<string>();
            kh.Add(txtName.Text);
            string sex;
            if (rdbMale.Checked == true)
                sex = "Nam";
            else
                sex = "Nữ";
            kh.Add(sex);
            kh.Add(txtTel.Text);
            kh.Add(txtPeopleId.Text);
            kh.Add(txtClassroomId.Text);       
            kh.Add(Convert.ToDateTime(dtpOrder.Text).ToString("MM/dd/yyyy"));
            kh.Add(Convert.ToDateTime(dtpGiveBack.Text).ToString("MM/dd/yyyy"));
            kh.Add(txtPayments.Text);      
            return kh;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn sửa khách hàng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Enabled = false;
                customer = new BUS_KhachHang();
                string codeId = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if (customer.SuaKh(Themkh(), codeId))
                {
                    MessageBox.Show("Đã sửa khách hàng !", "Thông báo", MessageBoxButtons.OK);
                    DataTable tbl = customer.DSKhachHang();
                    dataGridView1.DataSource = tbl;
                    dataGridView1.Enabled = true;
                }
                else
                    MessageBox.Show("Không sửa được khách hàng ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa khách hàng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customer = new BUS_KhachHang();
                string codeId = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if (customer.XoaKh(codeId))
                {
                    MessageBox.Show("Đã xoá khách hàng !", "Thông báo", MessageBoxButtons.OK);
                    DataTable tbl = customer.DSKhachHang();
                    dataGridView1.DataSource = tbl;
                }
                else
                    MessageBox.Show("Không xóa được nhân viên ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string[] servicename = cmbService.Text.ToString().Split(':');

            //for (int i = 0; i < cmbServiceUsed.Items.Count; i++)
            //{
            //    string[] servicenameuse = cmbServiceUsed.Items[i].ToString().Split(':');
            //    if (servicenameuse[0].Trim() == servicename[0].Trim())
            //        MessageBox.Show("aaa");
            //    else
            //        MessageBox.Show("aaa1111");
            //}
            string str = null;
            int count = 0;
            for(int j = 0; j < cmbServiceUsed.Items.Count;j++)
            {
                string[] servicenameuse = cmbServiceUsed.Items[j].ToString().Split(':');
                str += servicenameuse[0] + "  ";
            }        
            if (str.Contains(servicename[0].Trim()))
            {
                //cmbServiceUsed.Items.Remove(cmbService.Text.ToString());
                //cmbServiceUsed.Items.Add()

                DataTable tblserviceused = service.DSDichVuSuDung();
                foreach (DataRow row in tblserviceused.Rows)
                {
                    if (row[1].ToString() == listservice.IndexOf(servicename[0].Trim()).ToString() && row[0].ToString() == dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString())
                        count = int.Parse(row[2].ToString());
                }
                if (service.SuaDv(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(), listservice.IndexOf(servicename[0].Trim()) + 1, count + 1))
                {
                    MessageBox.Show("Thêm dịch vụ 1111", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadComboBox();
                }
                else
                    MessageBox.Show("Không thêm được dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                if (service.ThemDv(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(), listservice.IndexOf(servicename[0].Trim()) + 1, 1))
                {
                    MessageBox.Show("Thêm dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadComboBox();
                }
                else
                    MessageBox.Show("Không thêm được dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
