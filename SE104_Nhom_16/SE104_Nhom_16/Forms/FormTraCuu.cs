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
    public partial class FormTraCuu : Form
    {
        public FormTraCuu()
        {
            InitializeComponent();
            showAllSach();
            showAllKhachHang();
        }

        private DataTable getSearchedDataByMaKH(string makh)
        {
            DataTable ds = new DataTable();
            string query = "SELECT * FROM KHACHHANG WHERE MaKhachHang =" + makh;
            ds = DataProvider.Instance.ExecuteQuery(query);
            return ds;
        }
        private DataTable getSearchedDataByHoTen(string hoten)
        {
            DataTable ds = new DataTable();
            string query = "SELECT  MaKhachHang, HoTenKhachHang, DiaChi, DienThoai, Email,SoTienNo, dbo.ufn_removeMark(HoTenKhachHang) AS khongdau FROM KHACHHANG WHERE dbo.ufn_removeMark(HoTenKhachHang ) LIKE '%" + hoten + "%' OR HoTenKhachHang LIKE '%" + hoten + "%'";
            ds = DataProvider.Instance.ExecuteQuery(query);
            return ds;
        }
        private DataTable getSearchedDataBySDT(string sdt)
        {
            DataTable ds = new DataTable();
            string query = "SELECT * FROM KHACHHANG WHERE DienTHoai = '" + sdt + "'";
            ds = DataProvider.Instance.ExecuteQuery(query);
            return ds;
        }


        //Sach
        private DataTable getSearchedDataByMaSach(string masach)
        {
            DataTable ds = new DataTable();
            string query = "SELECT MaSach, TenSach, TheLoai, TacGia, SoLuongTon, DonGia, dbo.ufn_removeMark(TheLoai) AS khongdau   FROM SACH WHERE MaSach =" + masach;
            ds = DataProvider.Instance.ExecuteQuery(query);
            return ds;
        }
        private DataTable getSearchedDataByTenSach(string tensach)
        {
            DataTable ds = new DataTable();
            string query = "SELECT MaSach, TenSach, TheLoai, TacGia, SoLuongTon, DonGia, dbo.ufn_removeMark(TenSach) AS khongdau   FROM SACH WHERE dbo.ufn_removeMark(TenSach)  LIKE '%" + tensach + "%' OR TenSach  LIKE '%" + tensach + "%'";
            ds = DataProvider.Instance.ExecuteQuery(query);
            return ds;
        }
        private DataTable getSearchedDataByTheLoai(string theloai)
        {
            DataTable ds = new DataTable();
            string query = "SELECT MaSach, TenSach, TheLoai, TacGia, SoLuongTon, DonGia, dbo.ufn_removeMark(TheLoai) AS khongdau   FROM SACH WHERE dbo.ufn_removeMark(TheLoai)  LIKE '%" + theloai + "%' OR TheLoai  LIKE '%" + theloai + "%'";
            ds = DataProvider.Instance.ExecuteQuery(query);
            return ds;
        }
        private DataTable getSearchedDataByTacGia(string tacgia)
        {
            DataTable ds = new DataTable();
            string query = "SELECT MaSach, TenSach, TheLoai, TacGia, SoLuongTon, DonGia, dbo.ufn_removeMark(TacGia) AS khongdau  FROM SACH WHERE dbo.ufn_removeMark(TacGia)  LIKE '%" + tacgia + "%' OR TacGia LIKE '%" + tacgia + "%'";
            ds = DataProvider.Instance.ExecuteQuery(query);
            return ds;
        }





        private void showSearchedKhachHang()
        {

            string query = "select * from KHACHHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (txtMaKhachHang.Text == "")
            {
                if (txtHoTenKhachHang.Text == "")
                {
                    if (txtDienThoai.Text == "")
                    {
                        MessageBox.Show("VUI LÒNG ĐIỀN THÔNG TIN CẦN TÌM!", "THÔNG BÁO");
                    }
                    else
                    {
                        data = getSearchedDataBySDT(txtDienThoai.Text.ToString());
                    }
                }
                else
                {
                    data = getSearchedDataByHoTen(txtHoTenKhachHang.Text.ToString());
                }
            }
            else
            {
                data = getSearchedDataByMaKH(txtMaKhachHang.Text.ToString());
            }


            this.listKhachHang.Clear();
            this.listKhachHang.Items.Clear();
            this.listKhachHang.View = View.Details;
            this.listKhachHang.Columns.Add("MÃ KH", 50);
            this.listKhachHang.Columns.Add("HỌ TÊN KH", 200);
            this.listKhachHang.Columns.Add("ĐỊA CHỈ", 350);
            this.listKhachHang.Columns.Add("ĐIỆN THOẠI", 100);
            this.listKhachHang.Columns.Add("EMAIL", 150);
            this.listKhachHang.Columns.Add("SỐ TIỀN NỢ", 150);

            this.listKhachHang.GridLines = true;
            this.listKhachHang.FullRowSelect = true;


            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listKhachHang.Items.Add(row["MaKhachHang"].ToString());
                this.listKhachHang.Items[i].SubItems.Add(row["HoTenKhachHang"].ToString());
                this.listKhachHang.Items[i].SubItems.Add(row["DiaChi"].ToString());
                this.listKhachHang.Items[i].SubItems.Add(row["DienThoai"].ToString());
                this.listKhachHang.Items[i].SubItems.Add(row["Email"].ToString());
                this.listKhachHang.Items[i].SubItems.Add(row["SoTienNo"].ToString());


                i++;
            }
        }

        private void showSearchedSach()
        {

            string query = "SELECT MaSach, TenSach, TheLoai, TacGia, SoLuongTon, DonGia, dbo.ufn_removeMark(TheLoai) AS khongdau   FROM SACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (txtMaSach.Text == "")
            {
                if (txtTenSach.Text == "")
                {
                    if (txtTheLoai.Text == "")
                    {
                        if (txtTacGia.Text == "")
                        {
                            MessageBox.Show("VUI LÒNG ĐIỀN THÔNG TIN CẦN TÌM!", "THÔNG BÁO");

                        }
                        else
                        {
                            data = getSearchedDataByTacGia(txtTacGia.Text.ToString());
                        }
                    }
                    else
                    {
                        data = getSearchedDataByTheLoai(txtTheLoai.Text.ToString());
                    }
                }
                else
                {
                    data = getSearchedDataByTenSach(txtTenSach.Text.ToString());
                }
            }
            else
            {
                data = getSearchedDataByMaSach(txtMaSach.Text.ToString());
            }


            this.listSach.Clear();
            this.listSach.Items.Clear();
            this.listSach.View = View.Details;
            this.listSach.Columns.Add("MÃ SÁCH", 70);
            this.listSach.Columns.Add("TÊN SÁCH", 250);
            this.listSach.Columns.Add("THỂ LOẠI", 100);
            this.listSach.Columns.Add("TÁC GIẢ", 200);
            this.listSach.Columns.Add("SỐ LƯỢNG TỒN", 120);
            this.listSach.Columns.Add("ĐƠN GIÁ", 120);
            this.listSach.Columns.Add("KHONG DAU", 0);

            this.listSach.GridLines = true;
            this.listSach.FullRowSelect = true;


            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listSach.Items.Add(row["MaSach"].ToString());
                this.listSach.Items[i].SubItems.Add(row["TenSach"].ToString());
                this.listSach.Items[i].SubItems.Add(row["TheLoai"].ToString());
                this.listSach.Items[i].SubItems.Add(row["TacGia"].ToString());
                this.listSach.Items[i].SubItems.Add(row["SoLuongTon"].ToString());
                this.listSach.Items[i].SubItems.Add(row["DonGia"].ToString());
                this.listSach.Items[i].SubItems.Add(row["khongdau"].ToString());



                i++;
            }
        }

        private void showAllKhachHang()
        {



            string query = "select * from KHACHHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listKhachHang.Clear();
            this.listKhachHang.Items.Clear();
            this.listKhachHang.View = View.Details;
            this.listKhachHang.Columns.Add("MÃ KH", 50);
            this.listKhachHang.Columns.Add("HỌ TÊN KH", 200);
            this.listKhachHang.Columns.Add("ĐỊA CHỈ", 350);
            this.listKhachHang.Columns.Add("ĐIỆN THOẠI", 100);
            this.listKhachHang.Columns.Add("EMAIL", 150);
            this.listKhachHang.Columns.Add("SỐ TIỀN NỢ", 150);

            this.listKhachHang.GridLines = true;
            this.listKhachHang.FullRowSelect = true;


            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listKhachHang.Items.Add(row["MaKhachHang"].ToString());
                this.listKhachHang.Items[i].SubItems.Add(row["HoTenKhachHang"].ToString());
                this.listKhachHang.Items[i].SubItems.Add(row["DiaChi"].ToString());
                this.listKhachHang.Items[i].SubItems.Add(row["DienThoai"].ToString());
                this.listKhachHang.Items[i].SubItems.Add(row["Email"].ToString());
                this.listKhachHang.Items[i].SubItems.Add(row["SoTienNo"].ToString());


                i++;
            }
        }

        private void showAllSach()
        {



            string query = "select * from SACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listSach.Clear();
            this.listSach.Items.Clear();
            this.listSach.View = View.Details;
            this.listSach.Columns.Add("MÃ SÁCH", 70);
            this.listSach.Columns.Add("TÊN SÁCH", 250);
            this.listSach.Columns.Add("THỂ LOẠI", 100);
            this.listSach.Columns.Add("TÁC GIẢ", 200);
            this.listSach.Columns.Add("SỐ LƯỢNG TỒN", 120);
            this.listSach.Columns.Add("ĐƠN GIÁ", 120);

            this.listSach.GridLines = true;
            this.listSach.FullRowSelect = true;


            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listSach.Items.Add(row["MaSach"].ToString());
                this.listSach.Items[i].SubItems.Add(row["TenSach"].ToString());
                this.listSach.Items[i].SubItems.Add(row["TheLoai"].ToString());
                this.listSach.Items[i].SubItems.Add(row["TacGia"].ToString());
                this.listSach.Items[i].SubItems.Add(row["SoLuongTon"].ToString());
                this.listSach.Items[i].SubItems.Add(row["DonGia"].ToString());


                i++;
            }
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            showSearchedKhachHang();
        }

        private void lblTheLoai_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSearchedSach();
        }

        private void FormTraCuu_Load(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMaKhachHang.Text, "[^0-9]"))
            {
                MessageBox.Show("MÃ KHÁCH HÀNG LÀ SỐ NGUYÊN", "THÔNG BÁO");
                txtMaKhachHang.Text = txtMaKhachHang.Text.Remove(txtMaKhachHang.Text.Length - 1);
            }
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMaSach.Text, "[^0-9]"))
            {
                MessageBox.Show("MÃ SÁCH LÀ SỐ NGUYÊN", "THÔNG BÁO");
                txtMaSach.Text = txtMaSach.Text.Remove(txtMaSach.Text.Length - 1);
            }
        }

        private void txtHoTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
