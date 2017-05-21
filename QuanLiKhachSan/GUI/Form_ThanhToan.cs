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
    public partial class Form_ThanhToan : MetroForm
    {
        public static List<string> item = null;

        public Form_ThanhToan()
        {
            InitializeComponent();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListBill_Click(object sender, EventArgs e)
        {
            Form_HoaDon bill = new Form_HoaDon();
            bill.Show();
        }

        public List<String> Inserts()
        {
            List<string> hd = new List<string>();
            hd.Add(dtpDate.Value.ToString("MM/dd/yyyy"));
            hd.Add(txtPayments.Text);
            hd.Add(txtPay.Text);
            hd.Add(txtIdStaff.Text);
            hd.Add("Đã thanh toán");
            hd.Add(txtCustomerId.Text);
            return hd;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn trả phòng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BUS_Phong classroom = new BUS_Phong();
                BUS_HoaDon bill = new BUS_HoaDon();
                if (classroom.NhanTraPhong("No", "0", item[0]) && bill.ThemHd(Inserts()))
                {
                    MessageBox.Show("Đã trả phòng  !", "Thông báo", MessageBoxButtons.OK);                  
                }
                else
                    MessageBox.Show("Trả phòng thất bại !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void Form_ThanhToan_Load(object sender, EventArgs e)
        {
            // Lấy giá tiền các dịch vụ
            List<string> servicelist = new List<string>();
            BUS_DichVu service = new BUS_DichVu();
            DataTable tblService = service.DSDichVu();
            foreach (DataRow row in tblService.Rows)
            {
                servicelist.Add(row[2].ToString());
            }

            // Tính tiền dịch vụ
            int pay = 0;           
            DataTable tblServiceuse = service.DSDichVuSuDung();
            foreach (DataRow row in tblServiceuse.Rows)
            {
                if (row[0].ToString() == item[0])
                    pay += int.Parse(row[2].ToString()) * int.Parse(servicelist[int.Parse(row[1].ToString()) - 1].ToString());
            }

            // Hiển thị các thông tin
            labIdroom.Text = item[0];
            BUS_KhachHang customer = new BUS_KhachHang();
            DataTable tblCustomer = customer.DSKhachHang();
            foreach (DataRow row in tblCustomer.Rows)
            {              
                if (row[0].ToString() == item[2])
                {
                    txtCustomerId.Text = item[2];
                    txtNameCustomer.Text = row[1].ToString();
                    txtPayments.Text = row[8].ToString();
                    dtpDate.Text = Convert.ToString(row[7].ToString());                  
                    TimeSpan d = Convert.ToDateTime(row[7].ToString()).Subtract(Convert.ToDateTime(row[6].ToString()));
                    double days = d.TotalDays;
                    pay += int.Parse(days.ToString()) * int.Parse(item[1]);                 
                }
            }
            pay = pay - int.Parse(txtPayments.Text.ToString());
            txtPay.Text = pay.ToString();
        }
    }
}
