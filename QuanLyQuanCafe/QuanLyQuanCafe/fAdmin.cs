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
    public partial class fAdmin : Form
    {
        #region Thuộc tính
        //private AccountBUL _ABul = new AccountBUL();

        #endregion

        public fAdmin()
        {
            InitializeComponent();

            LoadAccount();
            LoadTable();
            LoadFood();
            LoadCategory();
            LoadBill();
        }

        #region Phương thức ngoài

        private void LoadAccount ()
        {
            dgvAccount.DataSource = AccountBUL.Instance.getAllAccount();

            dgvAccount.Columns[0].HeaderText = "Mã";
            dgvAccount.Columns[1].HeaderText = "Tên tài khoản";
            dgvAccount.Columns[2].HeaderText = "Loại tài khoản";

            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadBill ()
        {
            dgvBill.DataSource = BillBUL.Instance.GetAllBill();

            dgvBill.Columns[0].HeaderText = "Mã";
            dgvBill.Columns[1].HeaderText = "Ngày vào";
            dgvBill.Columns[2].HeaderText = "Ngày ra";
            dgvBill.Columns[3].HeaderText = "Bàn";
            dgvBill.Columns[4].HeaderText = "Thanh toán";
            dgvBill.Columns[5].HeaderText = "Giảm giá";

            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadFood ()
        {
            dgvFood.DataSource = FoodBUL.Instance.GetListAllFood();

            dgvFood.Columns[0].HeaderText = "Mã";
            dgvFood.Columns[1].HeaderText = "Tên món";
            dgvFood.Columns[2].HeaderText = "Danh mục";
            dgvFood.Columns[3].HeaderText = "Giá";

            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadTable ()
        {
            dgvTable.DataSource = TableBUL.Instance.getAllTable();

            dgvTable.Columns[0].HeaderText = "Mã";
            dgvTable.Columns[1].HeaderText = "Tên bàn";
            dgvTable.Columns[2].HeaderText = "Trạng thái";

            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LoadCategory ()
        {
            dgvCatagori.DataSource = FoodCategoryBUL.Instance.GetListCategory();

            dgvCatagori.Columns[0].HeaderText = "Mã";
            dgvCatagori.Columns[1].HeaderText = "Loại đồ ăn";

            dgvCatagori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        

        #endregion

        private void fAdmin_Load(object sender, EventArgs e)
        {
            

        }


    }
}
