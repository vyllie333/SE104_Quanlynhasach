using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SE104_Nhom_16.DAO;

namespace SE104_Nhom_16.Forms
{
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
            showData(); 
            this.dataGridView1.DefaultCellStyle.Font = new Font("Bahnschrift", 9);

        }

        private DataSet getAllData()
        {

            DataSet dataSet = new DataSet();
            string query = "SELECT * FROM KHACHHANG";
            //string query = "SELECT MaSach as 'Mã sách', TenSach as 'Tên sách', TheLoai as 'Thể loại', TacGia as 'Tác giả', SoLuongTon as 'Số lượng tồn', DonGia as 'Đơn giá' FROM SACH";
            dataSet = DataProvider.Instance.ExecuteQueryList(query);
            return dataSet;
        }

        private void showData()
        {
            dataGridView1.DataSource = getAllData().Tables[0];
            //dataGridView1.DataMember = "SACH";
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btbThem_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();
            f.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frmSuaKhachHang f = new frmSuaKhachHang();
            f.ShowDialog();
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            frmXoaKhachHang f = new frmXoaKhachHang();
            f.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
