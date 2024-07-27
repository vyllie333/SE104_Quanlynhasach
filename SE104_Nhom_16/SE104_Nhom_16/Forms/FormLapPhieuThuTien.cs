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
    public partial class FormLapPhieuThuTien : Form
    {
        int bChon = 0;
        public FormLapPhieuThuTien()
        {
            InitializeComponent();
            listViewThuTien_SelectedIndexChanged();
            QuyDinh4();
        }

        private object SuDungQuyDinh4()
        {
            object data = 0;
            string query = "SELECT SuDungQuyDinh4 FROM THAMSO";
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

        private object SDTKhachHang(string makh)
        {
            object hoten;
            string query = "SELECT DienThoai FROM KHACHHANG WHERE MaKhachHang= " + makh;
            hoten = DataProvider.Instance.ExecuteScalar(query);
            return hoten;

        }
        private object EmailKhachHang(string makh)
        {
            object hoten;
            string query = "SELECT Email FROM KHACHHANG WHERE MaKhachHang= " + makh;
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

        private void QuyDinh4()
        {
            bool icheck = (bool)SuDungQuyDinh4();
            if (icheck)
            {
                checkQuyDinh.Checked = true;
                checkQuyDinh.CheckState = CheckState.Checked;
            }
            else
            {
                checkQuyDinh.Checked = false;
                checkQuyDinh.CheckState = CheckState.Unchecked;
            }
        }

        private void FormLapPhieuThuTien_Load(object sender, EventArgs e)
        {

        }


        private void listViewThuTien_SelectedIndexChanged()
        {
            string query = "   select MaPhieuThu, HoTenKhachHang, SoTienThu,  PHIEUTHUTIEN.MaKhachHang, " +
                "KHACHHANG.SoTienNo, KHACHHANG.MaKhachHang, KHACHHANG.DiaChi, KHACHHANG.DienThoai, KHACHHANG.Email " +
                "from  PHIEUTHUTIEN join KHACHHANG" +
                " on PHIEUTHUTIEN.MaKhachHang = KHACHHANG.MaKhachHang order by MaPhieuThu desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listViewThuTien.Clear();
            this.listViewThuTien.Items.Clear();
            this.listViewThuTien.View = View.Details;
            this.listViewThuTien.Columns.Add("MÃ PHIẾU THU", 110);
            this.listViewThuTien.Columns.Add("TÊN KHÁCH HÀNG", 390);
            this.listViewThuTien.Columns.Add("SỐ TIỀN THU", 300);
            this.listViewThuTien.Columns.Add("SỐ TIỀN NỢ CÒN LẠI", 220);
            this.listViewThuTien.Columns.Add("MÃ KHÁCH HÀNG", 0);
            this.listViewThuTien.Columns.Add("DIA CHI", 0);
            this.listViewThuTien.Columns.Add("SODIENTHOAI", 0);
            this.listViewThuTien.Columns.Add("EMAIL", 0);
            this.listViewThuTien.GridLines = true;
            this.listViewThuTien.FullRowSelect = true;
            //this.listViewThuTien.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listViewThuTien.Items.Add(row["MaPhieuThu"].ToString());
                this.listViewThuTien.Items[i].SubItems.Add(row["HoTenKhachHang"].ToString());
                this.listViewThuTien.Items[i].SubItems.Add(row["SoTienThu"].ToString());
                this.listViewThuTien.Items[i].SubItems.Add(row["SoTienNo"].ToString());
                this.listViewThuTien.Items[i].SubItems.Add(row["MaKhachHang"].ToString());
                this.listViewThuTien.Items[i].SubItems.Add(row["DiaChi"].ToString());

                this.listViewThuTien.Items[i].SubItems.Add(row["DienThoai"].ToString());

                this.listViewThuTien.Items[i].SubItems.Add(row["Email"].ToString());


                i++;
            }
        }

        private void listViewThuTien_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {

            int maKH = 0;
            Int32.TryParse(txtMaKhachHang.Text, out maKH);

            if (!IsMaKhachHangExists(maKH))
            {
                MessageBox.Show("KHÔNG TÌM THẤY KHÁCH HÀNG!", "THÔNG BÁO");
            }
            else
            {
                txtHoTenKhachHang.Text = HoTenKhachHang(txtMaKhachHang.Text).ToString();
                txtDiaChi.Text = DiaChiKhachHang(txtMaKhachHang.Text).ToString();
                txtSoTienNo.Text = SoTienNoKhachHang(txtMaKhachHang.Text).ToString();
                txtDienThoai.Text = SDTKhachHang(txtMaKhachHang.Text).ToString();
                txtEmail.Text = EmailKhachHang(txtMaKhachHang.Text).ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLapPhiéu_Click(object sender, EventArgs e)
        {
            int SoTienNo = 0;
            Int32.TryParse(txtSoTienNo.Text, out SoTienNo);
            int SoTienThu = 0;
            Int32.TryParse(txtSoTienThu.Text, out SoTienThu);

            if(txtSoTienThu.Text=="")
            {
                MessageBox.Show("CHƯA NHẬP SỐ TIỀN THU", "THÔNG BÁO");
            }
            else if ((checkQuyDinh.Checked == true) && (SoTienThu > SoTienNo))
            {
                MessageBox.Show("SỐ TIỀN THU VƯỢT QUÁ SỐ TIỀN NỢ!", "THÔNG BÁO");
            }
            else
            {
                string timenow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string query = " insert into PHIEUTHUTIEN values ((select max(MaPhieuThu)+1 from PHIEUTHUTIEN), " + txtSoTienThu.Text
                    + ", ' " + timenow + "'," + txtMaKhachHang.Text + ")";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                int temp1 = SoTienNo;
                int temp2 = temp1- SoTienThu;
                int temp3 = (-1) * SoTienThu;

                string query3 = "INSERT INTO BAOCAOCONGNO VALUES ((SELECT MAX(MaChiTietCongNo) + 1 FROM BAOCAOCONGNO), MONTH(GETDATE()), YEAR(GETDATE()),"+ txtMaKhachHang.Text + ", " + temp1 + ", " + temp3 + ","+ temp2 +")" ;

                DataTable data3 = DataProvider.Instance.ExecuteQuery(query3);

                string query2 = "  update KHACHHANG set SoTienNo = " + temp1 + " - " + SoTienThu + " where MaKhachHang = " + txtMaKhachHang.Text;
                DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);

                
            }
                

            listViewThuTien_SelectedIndexChanged();
            txtSoTienThu.Text = "";
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMaKhachHang.Text, "[^0-9]"))
            {
                MessageBox.Show("MÃ KHÁCH HÀNG LÀ SỐ NGUYÊN", "THÔNG BÁO");
                txtMaKhachHang.Text = txtMaKhachHang.Text.Remove(txtMaKhachHang.Text.Length - 1);
            }
        }

        private void txtSoTienThu_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoTienThu.Text, "[^0-9]"))
            {
                MessageBox.Show("SỐ TIỀN THU LÀ SỐ NGUYÊN", "THÔNG BÁO");
                txtSoTienThu.Text = txtSoTienThu.Text.Remove(txtSoTienThu.Text.Length - 1);
            }
        }
    }
}
