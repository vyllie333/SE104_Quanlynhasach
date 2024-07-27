using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SE104_Nhom_16.DAO;

namespace SE104_Nhom_16
{
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
            txtMaSach.Text = MaSach().ToString();

        }


        private object MaSach()
        {

            string query = "SELECT MAX(MaSach)+1 FROM SACH";
            object MaHD = DataProvider.Instance.ExecuteScalar(query);
            return MaHD;
        }


        private void bThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "" || txtTenSach.Text == "" || txtTacGia.Text == "" || txtTheLoai.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else
            {

                int masach = 0;
                Int32.TryParse(txtMaSach.Text, out masach);

                string query = "INSERT INTO SACH VALUES(" + masach + ", N'" + txtTenSach.Text.ToString() + "'" + ", N'" + txtTheLoai.Text.ToString()
                    + "'" + ", N'" + txtTacGia.Text.ToString() + "'" + ", 0" + ", '" + numericUpDownGiaMua.Value + "'" + ")";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
               
                numericUpDownGiaMua.Value = 1000;
                this.Hide();
            }

        }

        private void txbTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownGiaMua_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
