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
using DTO;
using System.Globalization;

namespace QuanLyQuanCafe
{
    public partial class fTaskManager : Form
    {

        public fTaskManager()
        {
            InitializeComponent();

            LoadTable();
            LoadFoodCategory();
            //LoadSwitchTable();
            LoadSwitchTable(cmbSwitchTable);
            
        }

        #region Method
        private void LoadFoodCategory ()
        {
            List<FoodCategory> lsCategory = FoodCategoryBUL.Instance.GetListCategory();
            cmbCategory.DataSource = lsCategory;
            cmbCategory.DisplayMember = "Name";
        }


        private void LoadFoodListByCategoryID (int id)
        {
            List<Food> lsFood = FoodBUL.Instance.GetListFoodByCategoryID(id);
            cmbFood.DataSource = lsFood;
            cmbFood.DisplayMember = "Name";
        }

        

        // Environment.NewLine trả về một dòng mới trong môi trường gọi nó
        private void LoadTable ()
        {
            flpTable.Controls.Clear();

            List<Table> lsTable = TableBUL.Instance.MakeListTable();

            foreach (Table item in lsTable)
            {
                Button btn = new Button() {Width = TableBUL.TableWidth, Height = TableBUL.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                // Lưu btn 
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    case "Có người":
                        btn.BackColor = Color.DarkOrange;
                        break;
                    default:
                        btn.BackColor = Color.MediumSpringGreen;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        private void LoadSwitchTable (ComboBox cb)
        {
            // Cách 1
            cb.DataSource = TableBUL.Instance.MakeListTable();
            cb.DisplayMember = "Name";

            // Cách 2
            //List<Table> lsTable = TableBUL.Instance.MakeListTable();
            //cmbSwitchTable.DataSource = lsTable;
            //cmbSwitchTable.DisplayMember = "Name";

        }

        private void ShowBill(int id)
        {
            

            lsvBill.Items.Clear();
            List<DTO.Menu> lsMenu = MenuBUL.Instance.GetListMenuByTable(id);
            float totalprice = 0;

            foreach (DTO.Menu item in lsMenu)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                totalprice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }
            //CultureInfo culure = new CultureInfo("vi-VN");
            //txtTotalPrice.Text = totalprice.ToString("c", culure);

            txtTotalPrice.Text = totalprice.ToString();

        }


        #endregion

        #region Event
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            // Mỗi khi click btn nào thì listview sẽ có tag của thằng đó
            lsvBill.Tag = (sender as Button).Tag;

            ShowBill(tableID);
        }

        private void tmsLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmsAccountProfile_Click(object sender, EventArgs e)
        {
            fAccountProfile frmAP = new fAccountProfile();
            frmAP.ShowDialog();
        }

        private void tmsAdmin_Click(object sender, EventArgs e)
        {
            fAdmin frmA = new fAdmin();
            frmA.ShowDialog();
        }

        private void fTaskManager_Load(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            FoodCategory selected = cb.SelectedItem as FoodCategory;
            id = selected.Id;

            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // Một table thì có tối đa một bill
            Table table = lsvBill.Tag as Table;

            int idBill = BillBUL.Instance.getUncheckBillIdByTableId(table.Id);
            int foodId = (cmbFood.SelectedItem as Food).Id;
            int count = int.Parse(nudFoodCount.Value.ToString());


            if (idBill == -1)
            {
                BillBUL.Instance.InsertBill(table.Id);

                int MaxIdBill = BillBUL.Instance.GetMaxIdBill();
                BillInfoBUL.Instance.InsertBillInfo(MaxIdBill, foodId, count);

               
            }
            else
            {
                BillInfoBUL.Instance.InsertBillInfo(idBill, foodId, count);
            }

            ShowBill(table.Id);
            LoadTable();

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillBUL.Instance.getUncheckBillIdByTableId(table.Id);
            int discount = int.Parse(nudCostPer.Value.ToString());

            double totalPrice = Convert.ToDouble(txtTotalPrice.Text);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}?\n Tổng tiền - (Tổng tiền / 100) x Giảm giá \n {1} - ({1} / 100) x {2} = {3}",table.Name, totalPrice, discount, finalTotalPrice ), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    BillBUL.Instance.CheckOut(idBill, discount);
                    ShowBill(table.Id);

                    LoadTable();
                }
            }

        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).Id;
            int id2 = (cmbSwitchTable.SelectedItem as Table).Id;

            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bản {0} sang bàn {1} không ?", (lsvBill.Tag as Table).Name, (cmbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TableBUL.Instance.SwitchTable(id1, id2);

                LoadTable();
            }
        }
        private void btnPerCost_Click(object sender, EventArgs e)
        {
            
        }


        #endregion

        
    }
}
