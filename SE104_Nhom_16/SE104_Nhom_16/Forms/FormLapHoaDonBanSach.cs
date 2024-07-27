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
    public partial class FormLapHoaDonBanSach : Form
    {
        int bChonHD = 0;
        public static string mahd = "";
        public static string khachtra = "";
        public static string tongtien = "";
        public static string tienthua = "";
      
       
        public FormLapHoaDonBanSach()
        {
            InitializeComponent();
            txtSoLuongTonToiThieu.Text = SoLuongTonSauToiThieu().ToString();
            txtSoTienNoToiDa.Text = SoTienNoToiDa().ToString();
            MaHD_up();
            listViewChonSach();
            listViewHoaDon();
        }

        private object SoTienNoToiDa()
        {
            object data = 0;
            string query = "SELECT SoTienNoToiDa FROM THAMSO";
            data = DataProvider.Instance.ExecuteScalar(query);
            return data;
        }

        private object SoLuongTonSauToiThieu()
        {
            object data = 0;
            string query = "SELECT SoLuongTonSauToiThieu FROM THAMSO";
            data = DataProvider.Instance.ExecuteScalar(query);
            return data;
        }

        private object HoTenKhachHang(string makh)
        {
            object hoten;
            string query = "SELECT HoTenKhachHang FROM KHACHHANG WHERE MaKhachHang= " + makh;
            hoten = DataProvider.Instance.ExecuteScalar(query);
            return hoten;

        }
        private object DiaChiKhachHang(string makh)
        {
            object hoten;
            string query = "SELECT DiaChi FROM KHACHHANG WHERE MaKhachHang= " + makh;
            hoten = DataProvider.Instance.ExecuteScalar(query);
            return hoten;

        }
        private object SoTienNoKhachHang(string makh)
        {
            object hoten;
            string query = "SELECT SoTienNo FROM KHACHHANG WHERE MaKhachHang= " + makh;
            hoten = DataProvider.Instance.ExecuteScalar(query);
            return hoten;

        }

        private void lblNgayNhap_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblMaKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void listViewChonSach()
        {
            //string query = "Select MASACH, TENSACH, TENTG, TENLINHVUC, TENLOAISACH, GIAMUA, GIABIA, LANTAIBAN, " +
            // "TENNHAXUATBAN, NAMXUATBAN From SACH LEFT JOIN TACGIA ON SACH.MATG = TACGIA.MATG";
            string query = "SELECT MaSach, TenSach, TheLoai, TacGia, SoLuongTon, DonGia FROM SACH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listViewSach.Clear();
            this.listViewSach.Items.Clear();
            this.listViewSach.View = View.Details;
            this.listViewSach.Columns.Add("MÃ SÁCH", 150);
            this.listViewSach.Columns.Add("TÊN SÁCH", 270);
            this.listViewSach.Columns.Add("THỂ LOẠI", 200);
            this.listViewSach.Columns.Add("TÁC GIẢ", 100);
            this.listViewSach.Columns.Add("SỐ LƯỢNG TỒN", 150);
            this.listViewSach.Columns.Add("ĐƠN GIÁ", 100);
            this.listViewSach.GridLines = true;
            this.listViewSach.FullRowSelect = true;
            this.listViewSach.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listViewSach.Items.Add(row["MaSach"].ToString());
                this.listViewSach.Items[i].SubItems.Add(row["TenSach"].ToString());
                this.listViewSach.Items[i].SubItems.Add(row["TheLoai"].ToString());
                this.listViewSach.Items[i].SubItems.Add(row["TacGia"].ToString());
                this.listViewSach.Items[i].SubItems.Add(row["SoLuongTon"].ToString());
                this.listViewSach.Items[i].SubItems.Add(row["DonGia"].ToString());
                i++;
            }
        }

        private bool IsMaKhachHangExists(int maKH)
        {
            string query = "SELECT MaKhachHang FROM KHACHHANG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                int maKhachHang = Convert.ToInt32(row["MaKhachHang"]);
                if (maKhachHang == maKH)
                    return true;
            }

            return false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int NoToiDa = 0;
            int maKH = 0;
            Int32.TryParse(txtMaKhachHang.Text, out maKH);
            Int32.TryParse(txtSoTienNoToiDa.Text, out NoToiDa);

            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN MÃ KHÁCH HÀNG CẦN TÌM!", "THÔNG BÁO");
            }
            else if (!IsMaKhachHangExists(maKH))
            {
                MessageBox.Show("KHÔNG TÌM THẤY KHÁCH HÀNG!", "THÔNG BÁO");
            }
            else
            {
                txtHoTenKhachHang.Text = HoTenKhachHang(txtMaKhachHang.Text).ToString();
                txtDiaChi.Text = DiaChiKhachHang(txtMaKhachHang.Text).ToString();
                txtSoTienNo.Text = SoTienNoKhachHang(txtMaKhachHang.Text).ToString();

                int SoTienNo = 0;
                Int32.TryParse(txtSoTienNo.Text, out SoTienNo);

                if (SoTienNo > NoToiDa)
                {
                    MessageBox.Show("KHÁCH HÀNG NỢ HƠN " + NoToiDa + ", KHÔNG THỂ MUA TIẾP", "THÔNG BÁO");
                    txtMaKhachHang.Clear();
                    txtHoTenKhachHang.Clear();
                    txtDiaChi.Clear();
                    txtSoTienNo.Clear();

                }
            }
        }

        private object MaHD()
        {

            string query = "SELECT MAX(MaPhieuHoaDon)+1 FROM PHIEUHOADON";
            object MaHD = DataProvider.Instance.ExecuteScalar(query);
            return MaHD;
        }

        private void MaHD_up()
        {
            txtMaHoaDon.Text = MaHD().ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int SoLuongTonToiThieu = 0;
            Int32.TryParse(txtSoLuongTonToiThieu.Text, out SoLuongTonToiThieu);

            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("NHẬP MÃ KHÁCH HÀNG!", "THÔNG BÁO");
                txtHoTenKhachHang.ReadOnly = false;
            }
            else
            {
                txtHoTenKhachHang.ReadOnly = true;
                txtMaKhachHang.ReadOnly = true;
                int dem = 0;
                foreach (ListViewItem item in this.listViewSach.Items)
                {
                    if (item.Checked)
                    {
                        dem++;
                    }
                }

                if (dem == 1)
                {
                    int hientai = 0;
                    foreach (ListViewItem item in this.listViewSach.Items)
                    {
                        if (item.Checked == true)
                        {
                            string query4 = "Select SoLuongTon From SACH where MASACH = '" + item.SubItems[0].Text + "'";
                            object data4 = DataProvider.Instance.ExecuteScalar(query4);
                            int SoLuongSachConLai;
                            SoLuongSachConLai = Convert.ToInt32(data4) - Convert.ToInt32(numericUpDownSoLuong.Value);
                            if ((SoLuongSachConLai - SoLuongTonToiThieu) >= Convert.ToInt32(numericUpDownSoLuong.Value))
                            {

                                string query5 = "Select DonGia From SACH where MASACH = '" + item.SubItems[0].Text + "'";
                                object data5 = DataProvider.Instance.ExecuteScalar(query5);


                                hientai = Convert.ToInt32(data5) * Convert.ToInt32(numericUpDownSoLuong.Value);


                                Console.WriteLine(hientai);

                                int mahd = 0;
                                Int32.TryParse(txtMaHoaDon.Text, out mahd);


                                try
                                {
                                    string timenow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    string query1 = "insert into PHIEUHOADON values (" + mahd + "," +
                                        txtMaKhachHang.Text + ", '" + timenow + "')";


                                    DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
                                    //tong = tong + hientai;
                                }
                                catch
                                {
                                    string timenow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    string query2 = "Update PHIEUHOADON set NgayLapHoaDon = '" + timenow + "'" +
                                        " where MaPhieuHoaDon = " + mahd;
                                    DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
                                }
                                listViewHoaDon();


                                string query3 = "Insert into CHITIETPHIEUHOADON values ( (SELECT MAX(MaChiTietPhieuHoaDon)+1 FROM CHITIETPHIEUHOADON) , '" +
                                    mahd + "' , '" + item.SubItems[0].Text + "' , '" + numericUpDownSoLuong.Value + "')";
                                DataTable data3 = DataProvider.Instance.ExecuteQuery(query3);

                                int SoTienNo = 0;
                                Int32.TryParse(txtSoTienNo.Text, out SoTienNo);

                                int temp1 = SoTienNo;
                                int temp2 = (int)(hientai * 1.05);
                                int temp3 = temp1 + temp2;

                                string query6 = "INSERT INTO BAOCAOCONGNO VALUES ((SELECT MAX(MaChiTietCongNo) + 1 FROM BAOCAOCONGNO), MONTH(GETDATE()), YEAR(GETDATE())," + txtMaKhachHang.Text + ", " + temp1 + ", " + temp2 + "," + temp3 + ")";

                                DataTable data6 = DataProvider.Instance.ExecuteQuery(query6);

                                string queryupdatesach = "UPDATE SACH SET SoLuongTon = " + SoLuongSachConLai + " Where MaSach = '" + item.SubItems[0].Text + "'";
                                DataTable updatesach = DataProvider.Instance.ExecuteQuery(queryupdatesach);


                                string query7 = "Select MASACH From SACH where MASACH = '" + item.SubItems[0].Text + "'";
                                object MaSach1 = DataProvider.Instance.ExecuteScalar(query7);

                                int MaSach2 = 0;
                                Int32.TryParse(MaSach1.ToString(), out MaSach2);

                                int temp4 = MaSach2;
                                int temp5 = Convert.ToInt32(data4);
                                int temp6 = (-1)*Convert.ToInt32(numericUpDownSoLuong.Value);
                                int temp7 = SoLuongSachConLai;

                                string query8 = "INSERT INTO BAOCAOTON VALUES ((SELECT MAX(MaChiTietTon) + 1 FROM BAOCAOTON), MONTH(GETDATE()), YEAR(GETDATE())," + temp4 + ", " + temp5 + ", " + temp6 + "," + temp7 + ")";

                                DataTable data8 =DataProvider.Instance.ExecuteQuery(query8);

                                MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                            }
                            else
                            {
                                MessageBox.Show("\t\t" + "KHÔNG CÒN SÁCH ĐỦ '" + "\n\t\t" + item.SubItems[1].Text + "" + "\t\t" + "' TRONG KHO", "THÔNG BÁO");
                            }
                            listViewChonSach();
                        }
                    }
                    numericUpDownSoLuong.Value = 1;

                }
                else if (dem == 0)
                {
                    MessageBox.Show("CHƯA CHỌN SÁCH!", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("CHỌN TỪNG SÁCH VÀ NHẬP SỐ LƯỢNG!", "THÔNG BÁO");
                }
            }
        }

        private void FormLapHoaDonBanSach_Load(object sender, EventArgs e)
        {

        }

        private void listViewHoaDon()
        {
            string query = "select PHIEUHOADON.MaPhieuHoaDon, KHACHHANG.HoTenKhachHang, PHIEUHOADON.NgayLapHoaDon, PHIEUHOADON.MaKhachHang" +
                " from PHIEUHOADON, KHACHHANG" +
                " where PHIEUHOADON.MaKhachHang = KHACHHANG.MaKhachHang " +
                "order by MaPhieuHoaDon desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvHoaDon.Clear();
            this.dgvHoaDon.Items.Clear();
            this.dgvHoaDon.View = View.Details;
            this.dgvHoaDon.Columns.Add("MÃ HÓA ĐƠN", 110);
            this.dgvHoaDon.Columns.Add("TÊN KHÁCH HÀNG", 190);
            this.dgvHoaDon.Columns.Add("NGÀY LẬP", 200);
            this.dgvHoaDon.Columns.Add("ma khach hang", 0);
          
            this.dgvHoaDon.GridLines = true;
            this.dgvHoaDon.FullRowSelect = true;
            this.dgvHoaDon.CheckBoxes = true;


            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvHoaDon.Items.Add(row["MaPhieuHoaDon"].ToString());
                this.dgvHoaDon.Items[i].SubItems.Add(row["HoTenKhachHang"].ToString());
                this.dgvHoaDon.Items[i].SubItems.Add(row["NgayLapHoaDon"].ToString());
                this.dgvHoaDon.Items[i].SubItems.Add(row["MaKhachHang"].ToString());
                i++;
            }

            
        }


        private void listViewChiTietHoaDon()
        {
            string query2 = "select CHITIETPHIEUHOADON.MaPhieuHoaDon, CHITIETPHIEUHOADON.MaSach, SACH.TenSach, CHITIETPHIEUHOADON.SoLuongBan" +
                " from CHITIETPHIEUHOADON " +
                "join SACH on CHITIETPHIEUHOADON.MaSach = SACH.MaSach" +
                " where MaPhieuHoaDon= " + mahd;
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);

            this.dgvChiTietHoaDon.Clear();
            this.dgvChiTietHoaDon.Items.Clear();
            this.dgvChiTietHoaDon.View = View.Details;
            this.dgvChiTietHoaDon.Columns.Add("MÃ HÓA ĐƠN", 110);
            this.dgvChiTietHoaDon.Columns.Add("MÃ SÁCH", 110);
            this.dgvChiTietHoaDon.Columns.Add("TÊN SÁCH", 190);
            this.dgvChiTietHoaDon.Columns.Add("SỐ LƯỢNG", 110);
    
            this.dgvChiTietHoaDon.GridLines = true;
            this.dgvChiTietHoaDon.FullRowSelect = true;

            foreach (ListViewItem item in this.dgvHoaDon.Items)
            {
                if (item.Checked == true)
                {

                    txtMaKhachHang.Text = item.SubItems[3].Text;
                }

            }

            int i = 0;
            foreach (DataRow row in data2.Rows)
            {
                this.dgvChiTietHoaDon.Items.Add(row["MaPhieuHoaDon"].ToString());
                this.dgvChiTietHoaDon.Items[i].SubItems.Add(row["MaSach"].ToString());
                this.dgvChiTietHoaDon.Items[i].SubItems.Add(row["TenSach"].ToString());
                this.dgvChiTietHoaDon.Items[i].SubItems.Add(row["SoLuongBan"].ToString());
            
                i++;
            }

            //int totalmoney = 0;
           /* string querygetmoney = "  Select SUM((CHITIETPHIEUHOADON.SoLuongBan * SACH.DonGia))*105/100 AS 'TongTien'  " +
                                   "from CHITIETPHIEUHOADON, SACH, PHIEUHOADON  " +
                                   "WHERE CHITIETPHIEUHOADON.MaSach = SACH.MaSach AND CHITIETPHIEUHOADON.MaPhieuHoaDon=PHIEUHOADON.MaPhieuHoaDon " +
                                   "AND CHITIETPHIEUHOADON.MaPhieuHoaDon = " + mahd;
            object getmoney = DataProvider.Instance.ExecuteScalar(querygetmoney);*/
            
           
            txtTongTien.Text = totalMoney().ToString();
        }

        private object totalMoney()
        {
            string querygetmoney = "  Select SUM((CHITIETPHIEUHOADON.SoLuongBan * SACH.DonGia))*105/100 AS 'TongTien'  " +
                                   "from CHITIETPHIEUHOADON, SACH, PHIEUHOADON  " +
                                   "WHERE CHITIETPHIEUHOADON.MaSach = SACH.MaSach AND CHITIETPHIEUHOADON.MaPhieuHoaDon=PHIEUHOADON.MaPhieuHoaDon " +
                                   "AND CHITIETPHIEUHOADON.MaPhieuHoaDon = " + mahd;
            object getmoney = DataProvider.Instance.ExecuteScalar(querygetmoney);
            return getmoney;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            int tienno = 0;
            Int32.TryParse(txtTienThua.Text, out tienno);
            Console.WriteLine(tienno);

            if (tienno < 0)
            {
                tienno = Math.Abs(tienno);
                Console.WriteLine(tienno);
                string query = " update KHACHHANG set SoTienNo = SoTienNo + '" + tienno +
                    "' from KHACHHANG join PHIEUHOADON" +
                    " on KHACHHANG.MaKhachHang = PHIEUHOADON.MaKhachHang " +
                    "where PHIEUHOADON.MaPhieuHoaDon = " + mahd;
                DataTable updateNo = DataProvider.Instance.ExecuteQuery(query);

            }

            khachtra = txtKhachTra.Text;
            tongtien = txtTongTien.Text;
            tienthua = txtTienThua.Text;
            //MessageBox.Show("HOÀN THÀNH HÓA ĐƠN!", "THÔNG BÁO");
            listViewChonSach();
            listViewHoaDon();
            MaHD_up();
            dgvChiTietHoaDon.Clear();
            dateTimePickerNgayLap.Text = DateTime.Now.ToString();
            txtTongTien.Text = "";
            txtTienThua.Text = "";
            txtKhachTra.Text = "";
            txtMaKhachHang.ReadOnly = false;

            
            frmBaoCaoHoaDon f = new frmBaoCaoHoaDon();

            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.dgvHoaDon.Items)
            {
                if (item.Checked)
                {
                    count++;
                    //txbTenKhachHang.Text = item.SubItems[1].Text;
                }
            }

            if (count == 1)
            {
                bChonHD = 1;
                foreach (ListViewItem item in this.dgvHoaDon.Items)
                {
                    if (item.Checked == true)
                    {
                        mahd = item.SubItems[0].Text;
                    }

                }
                listViewChiTietHoaDon();
               
            }
            else if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN HÓA ĐƠN NÀO!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ XEM CHI TIẾT CÙNG LÚC NHIỀU HÓA ĐƠN!", "THÔNG BÁO");
            }
            listViewHoaDon();
        }

        private void txtSoTienNo_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

   /*     private void textKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }*/

        private void txtKhachTra_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtKhachTra.Text, "[^0-9]"))
            {
                MessageBox.Show("TIỀN TRẢ PHẢI LÀ SỐ", "THÔNG BÁO");
                txtKhachTra.Text = txtKhachTra.Text.Remove(txtKhachTra.Text.Length - 1);
            }
            int tongtien = 0;
            Int32.TryParse(txtTongTien.Text,out tongtien);
            int num = 0;
            if (int.TryParse(txtKhachTra.Text, out num))
            {
                string text = (num - tongtien).ToString();
                txtTienThua.Text = text;
            }
        }

        private void numericUpDownSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblSoLuongTonToiThieu_Click(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMaKhachHang.Text, "[^0-9]"))
            {
                MessageBox.Show("MÃ KHÁCH HÀNG CHỈ LÀ SỐ", "THÔNG BÁO");
                txtMaKhachHang.Text = txtMaKhachHang.Text.Remove(txtMaKhachHang.Text.Length - 1);
            }
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
