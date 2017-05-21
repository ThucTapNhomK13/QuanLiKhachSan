using MetroFramework.Controls;
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

<<<<<<< HEAD

=======
>>>>>>> origin/master
namespace GUI
{
    public partial class Form_Phong : MetroForm
    {

        BUS_Phong classroom = null;
        DataTable tblClassifyRoom = null;
        DataTable tblClass = null;
        public Form_Phong()
        {
            InitializeComponent();
            //CreateRoom();
        }
        #region
        //void CreateRoom()
        //{
        //    Button oldBtn = new Button() { Width = 0, Location = new Point(30, 35) };
        //    for (int i = 0; i < 2; i++)
        //    {
        //        for (int j = 0; j < 7; j++)
        //        {
        //            MetroButton btn = new MetroButton()
        //            {
        //                Width = 75,
        //                Height = 75,
        //                Location = new Point(oldBtn.Location.X + oldBtn.Width + 25, oldBtn.Location.Y),
        //                BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\class.png"),
        //                BackgroundImageLayout = ImageLayout.Stretch

        //            };
        //            metroTabPage1.Controls.Add(btn);
        //            MetroLabel lab = new MetroLabel()
        //            {
        //                Width = 83,
        //                Height = 19,
        //                Location = new Point(btn.Location.X, btn.Location.Y + 75),
        //                Text = "Chưa đặt"

        //            };
        //            metroTabPage1.Controls.Add(lab);
        //            oldBtn = btn;
        //        }
        //        oldBtn.Location = new Point(30, oldBtn.Location.Y + 155);
        //        oldBtn.Width = 0;
        //        oldBtn.Height = 0;
        //    }
        //}
        #endregion

        void Set()
        {
            txtClassify.Enabled = true;
            txtId.Enabled = true;
            txtPrice.Enabled = true;                    
            txtStage.Enabled = true;
            rbdEnable.Enabled = true;
            rbdDisenable.Enabled = true;
        }

        void Unlock()
        {
            txtClassify.Enabled = false;
            txtId.Enabled = false;
            txtPrice.Enabled = false;
            txtStage.Enabled = false;
            rbdEnable.Enabled = false;
            rbdDisenable.Enabled = false;
        }

        public void LoadData()
        {
            classroom = new BUS_Phong();
            tblClass = new DataTable();
            tblClass = classroom.DSPhong();
            dataGridView1.DataSource = tblClass;
            tblClassifyRoom = new DataTable();
            tblClassifyRoom = classroom.LoaiPhong();
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                if (dataGridView1.Rows[i].Cells["tinhtrang"].Value.ToString() == "Yes")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                }
            }
        }

        private void Form_Phong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            txtId.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            int stage = Convert.ToInt32(txtId.Text.ToString()) / 100;
            txtStage.Text = stage.ToString();
            Form_KhachHang.items = new List<string>();
            foreach (DataRow row in tblClassifyRoom.Rows)
            {
                if (row[0].ToString() == dataGridView1.Rows[index].Cells[3].Value.ToString())
                {
                    txtClassify.Text = row[1].ToString();
                    //Form_ThanhToan.item.Add(row[2].ToString());               
                }
                
            }
            txtClassify.Text = dataGridView1.Rows[index].Cells["loaiphong"].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            if (dataGridView1.Rows[index].Cells["tinhtrang"].Value.ToString() == "Yes")
            {
                rbdDisenable.Checked = true;
                btnOrder.Enabled = false;
                btnGiveBack.Enabled = true;
            }
            else
            {
                rbdEnable.Checked = true;
                btnOrder.Enabled = true;
                btnGiveBack.Enabled = false;
            }
        }
    
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Form_KhachHang.classroomid = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            Form_KhachHang frm_kh = new Form_KhachHang();
            frm_kh.ShowDialog();
        }

        private void btnGiveBack_Click(object sender, EventArgs e)
        {
            Form_ThanhToan.item = new List<string>();
            Form_ThanhToan.item.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            Form_ThanhToan.item.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
            Form_ThanhToan.item.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString());
            Form_ThanhToan frm_pay = new Form_ThanhToan();
            frm_pay.ShowDialog();
        }

        private void btnLoaddata_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSerach.Text == "")
                LoadData();
            List<Phong> classroomsearch = new List<Phong>();
            Phong room = null;           
            foreach (DataRow row in tblClass.Rows)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (row[i].ToString().Contains(txtSerach.Text))
                    {
                        room = new Phong(row[0].ToString(), row[1].ToString(), int.Parse(row[2].ToString()), int.Parse(row[3].ToString()), row[4].ToString());
                        classroomsearch.Add(room);                       
                        break;
                    }

                }
            }           
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = classroomsearch;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells["tinhtrang"].Value.ToString() == "Yes")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                }
            }
        }
    }
}
