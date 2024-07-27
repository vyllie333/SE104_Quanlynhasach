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
    public partial class frmThemKhachHang : Form
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
            txtMaKH.Text = MaKH().ToString();
            numericUpDownTienNo.Value = 0;
        }

        private object MaKH()
        {

            string query = "SELECT MAX(MaKhachHang)+1 FROM KHACHHANG";
            object MaHD = DataProvider.Instance.ExecuteScalar(query);
            return MaHD;
        }



        private void bThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtHoTenKH.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else
            {
                int makh = 0;
                if (Int32.TryParse(txtMaKH.Text, out makh) == false)
                {
                    MessageBox.Show("MÃ KHÁCH HÀNG PHẢI LÀ SỐ NGUYÊN!", "THÔNG BÁO");
                }
                else
                {
                    string query = "INSERT INTO KHACHHANG VALUES(" + makh + ", N'" + txtHoTenKH.Text.ToString() + "'" + ", N'" + txtDiaChi.Text.ToString()
                    + "'" + ", N'" + txtDienThoai.Text.ToString() + "'" + ", N'" + txtEmail.Text.ToString() + "'" + ", '" + numericUpDownTienNo.Value + "'" + ")";

                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");

                    numericUpDownTienNo.Value = 1000;
                    this.Hide();
                }

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

        private void lblTenLinhVuc_Click(object sender, EventArgs e)
        {

        }

        private void lblGiaMua_Click(object sender, EventArgs e)
        {

        }

        private void lblMaSach_Click(object sender, EventArgs e)
        {

        }
    }
}
