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
    public partial class FormLapPhieuNhapSach : Form
    {
        public FormLapPhieuNhapSach()
        {
            InitializeComponent();
            txtSoLuongNhapItNhat.Text = SoLuongNhapItNhat().ToString();
            txtSoLuongTonToiDa.Text = SoLuongTonToiDaTruocNhap().ToString();
            this.dataGridView3.DefaultCellStyle.Font = new Font("Bahnschrift", 9);
            showListPhieuNhap();


        }



        private object SoLuongNhapItNhat()
        {
            object data = 0;
            string query = "SELECT SoLuongNhapItNhat FROM THAMSO";
            data = DataProvider.Instance.ExecuteScalar(query);
            return data;
        }

        private object SoLuongTonToiDaTruocNhap()
        {
            object data = 0;
            string query = "SELECT SoLuongTonToiDaTruocNhap FROM THAMSO";
            data = DataProvider.Instance.ExecuteScalar(query);
            return data;
        }

        private object SoLuongTonCuaSach(string masach)
        {
            object data = 0;
            string query = "SELECT SoLuongTon FROM SACH WHERE MaSach =" + masach;
            data = DataProvider.Instance.ExecuteScalar(query);
            return data;
        }

        private DataTable updateSoLuongSach(string ma, string soluongnhap)
        {
            DataTable dt = new DataTable();
            string query = "UPDATE SACH SET SACH.SoLuongTon=SACH.SoLuongTon +" + soluongnhap +
                " FROM SACH  JOIN CHITIETPHIEUNHAP ON SACH.MaSach = CHITIETPHIEUNHAP.MaSach" +
                " WHERE MaChiTietPhieuNhap = " + ma;
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }


        private void FormLapPhieuNhapSach_Load()
        {

        }
        private DataSet getSearchedData(string masach)
        {
            DataSet ds = new DataSet();
            string query = "SELECT * FROM SACH WHERE MaSach =" + masach;
            ds = DataProvider.Instance.ExecuteQueryList(query);
            return ds;
        }
        private DataSet getAllData()
        {
            FormLapPhieuNhapSach_Load();
            DataSet dataSet = new DataSet();
            string query = "select CHITIETPHIEUNHAP.MaChiTietPhieuNhap, PHIEUNHAP.NgayNhap, SACH.TenSach, CHITIETPHIEUNHAP.SoLuongNhap FROM CHITIETPHIEUNHAP, PHIEUNHAP, SACH WHERE CHITIETPHIEUNHAP.MaPhieuNhap = PHIEUNHAP.MaPhieuNhap" +
                " AND CHITIETPHIEUNHAP.MaSach = SACH.MaSach order by MaChiTietPhieuNhap desc";
            //string query = "SELECT MaSach as 'Mã sách', TenSach as 'Tên sách', TheLoai as 'Thể loại', TacGia as 'Tác giả', SoLuongTon as 'Số lượng tồn', DonGia as 'Đơn giá' FROM SACH";
            dataSet = DataProvider.Instance.ExecuteQueryList(query);
            return dataSet;
        }

        private void panelData_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void panelHandle_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormLapPhieuNhapSach_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtSoLuongNhapItNhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMaSach.Text, "[^0-9]"))
            {
                MessageBox.Show("MÃ SÁCH LÀ SỐ NGUYÊN", "THÔNG BÁO");
                txtMaSach.Text = txtMaSach.Text.Remove(txtMaSach.Text.Length - 1);
            }
        }
        private List<int> GetMaSachList()
        {
            string query = "SELECT MaSach FROM SACH";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<int> maSachList = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                int maSach = Convert.ToInt32(row["MaSach"]);
                maSachList.Add(maSach);
            }

            return maSachList;
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            int MaSach = 0;
            Int32.TryParse(txtMaSach.Text, out MaSach);

            if (txtMaSach.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN MÃ SÁCH CẦN TÌM!", "THÔNG BÁO");
            }
            else
            {
                List<int> maSachList = GetMaSachList();
                bool found = maSachList.Contains(MaSach);

                if (found)
                {
                    dataGridView3.DataSource = getSearchedData(txtMaSach.Text.ToString()).Tables[0];
                }
                else
                {
                    MessageBox.Show("KHÔNG CÓ MÃ SÁCH NÀY!", "THÔNG BÁO");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSoLuongNhapItNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {

            int SoLuongTonToiDa = 0;
            Int32.TryParse(txtSoLuongTonToiDa.Text, out SoLuongTonToiDa);
            int count0 = 0;
            foreach (ListViewItem item in this.listPhieuNhap.Items)
            {
                if (item.Checked)
                    count0++;
            }
            if (count0 > 0)
            {
                int count = 0;
                foreach (ListViewItem item in this.listPhieuNhap.Items)
                {
                    if (item.Checked == true)
                    {
                        try
                        {
                            count++;
                            string Ma = item.Text;

                            object SoLuongTonCuaSach = 0;
                            int soluongton = 0;
                            string query0 = "SELECT SoLuongTon  FROM SACH  " +
                            "JOIN CHITIETPHIEUNHAP ON SACH.MaSach = CHITIETPHIEUNHAP.MaSach" +
                            " WHERE MaChiTietPhieuNhap = " + Ma;
                            SoLuongTonCuaSach = DataProvider.Instance.ExecuteScalar(query0);
                            Int32.TryParse(SoLuongTonCuaSach.ToString(), out soluongton);

                            if (soluongton > SoLuongTonToiDa)
                            {
                                MessageBox.Show("LƯỢNG TỒN CÒN TRÊN " + SoLuongTonToiDa + " SÁCH", "THÔNG BÁO");
                            }
                            else
                            {
                                object SoLuongNhap = 0;
                                string query = "SELECT SoLuongNhap FROM CHITIETPHIEUNHAP WHERE MaChiTietPhieuNhap =" + Ma;
                                SoLuongNhap = DataProvider.Instance.ExecuteScalar(query);

                                updateSoLuongSach(Ma, SoLuongNhap.ToString());
                                MessageBox.Show("NHẬP THÊM " + SoLuongNhap + " THÀNH CÔNG!", "THÔNG BÁO");
                                
                                int SoLuongNhap1;
                                Int32.TryParse(SoLuongNhap.ToString(), out SoLuongNhap1);

                                string query4 = "SELECT MaSach FROM CHITIETPHIEUNHAP WHERE MaChiTietPhieuNhap =" + Ma;
                                object MaSach1 = DataProvider.Instance.ExecuteScalar(query4);

                                int MaSach2 = 0;
                                Int32.TryParse(MaSach1.ToString(), out MaSach2);

                                int temp1 = soluongton;
                                int temp2 = SoLuongNhap1;
                                int temp3 = temp1 + temp2;
                                int temp4 = MaSach2;

                                string query3 = "INSERT INTO BAOCAOTON VALUES ((SELECT MAX(MaChiTietTon) + 1 FROM BAOCAOTON), MONTH(GETDATE()), YEAR(GETDATE())," + temp4 + ", " + temp1 + ", " + temp2 + "," + temp3 + ")";

                                DataTable data3 = DataProvider.Instance.ExecuteQuery(query3);
                            }


                        }
                        catch
                        {
                            MessageBox.Show("KHÔNG THỂ NHẬP!", "THÔNG BÁO");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("KHÔNG CÓ GÌ ĐỂ LẬP PHIẾU NHẬP!", "THÔNG BÁO");
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            int SoLuongTonToiDa = 0;
            Int32.TryParse(txtSoLuongTonToiDa.Text, out SoLuongTonToiDa);

            int SoLuongNhapItNhat = 0;
            Int32.TryParse(txtSoLuongNhapItNhat.Text, out SoLuongNhapItNhat);

            int SoLuongTonSach = 0;

            int SoLuongNhap;
            Int32.TryParse(txtSoLuongNhap.Text, out SoLuongNhap);

            string timenow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string masach1 = txtMaSach.Text;



            if (masach1 == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN MÃ SÁCH CẦN THÊM", "THÔNG BÁO");
            }
            else if (masach1 != "")
            {

                string query0 = "SELECT SoLuongTon FROM SACH WHERE MaSach ="+ masach1;
                object SoLuongTonSach_1 = DataProvider.Instance.ExecuteScalar(query0);
                int SoLuongTonSach_2;

                Int32.TryParse(SoLuongTonSach_1.ToString(), out SoLuongTonSach_2);
                SoLuongTonSach = SoLuongTonSach_2 + SoLuongNhap;


                if (SoLuongTonSach_2 > SoLuongTonToiDa)
                {
                    MessageBox.Show("LƯỢNG TỒN CÒN TRÊN " + SoLuongTonToiDa + " SÁCH", "THÔNG BÁO");
                }
                else if (txtSoLuongNhap.Text == "")
                {
                    MessageBox.Show("VUI LÒNG ĐIỀN SỐ LƯỢNG SÁCH CẦN NHẬP THÊM", "THÔNG BÁO");
                }
                else if (SoLuongNhap < SoLuongNhapItNhat)
                {
                    MessageBox.Show("CẦN NHẬP ÍT NHẤT " + SoLuongNhapItNhat + " SÁCH", "THÔNG BÁO");
                }
                else
                {
                    string query = "INSERT INTO PHIEUNHAP VALUES ((SELECT MAX(MaPhieuNhap) FROM PHIEUNHAP)+1, '" + timenow + "')";
                    string query2 = "INSERT INTO CHITIETPHIEUNHAP VALUES((SELECT MAX(MaChiTietPhieuNhap) FROM CHITIETPHIEUNHAP)+1, (SELECT MAX(MaPhieuNhap) FROM PHIEUNHAP)," + txtMaSach.Text + ", " + SoLuongNhap + ")";


                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
                    showListPhieuNhap();
                    MessageBox.Show("THÊM VÀO PHIẾU NHẬP THÀNH CÔNG!", "THÔNG BÁO");
                }
            }
        }



        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void showListPhieuNhap()
        {
            string query = "select CHITIETPHIEUNHAP.MaChiTietPhieuNhap, PHIEUNHAP.NgayNhap, SACH.TenSach, CHITIETPHIEUNHAP.SoLuongNhap FROM CHITIETPHIEUNHAP, PHIEUNHAP, SACH WHERE CHITIETPHIEUNHAP.MaPhieuNhap = PHIEUNHAP.MaPhieuNhap" +
         " AND CHITIETPHIEUNHAP.MaSach = SACH.MaSach order by MaChiTietPhieuNhap desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listPhieuNhap.Clear();
            this.listPhieuNhap.Items.Clear();
            this.listPhieuNhap.View = View.Details;
            this.listPhieuNhap.Columns.Add("MÃ CTPN", 150);
            this.listPhieuNhap.Columns.Add("NGÀY NHẬP", 300);
            this.listPhieuNhap.Columns.Add("TÊN SÁCH", 450);
            this.listPhieuNhap.Columns.Add("SỐ LƯỢNG NHẬP", 200);

            this.listPhieuNhap.GridLines = true;
            this.listPhieuNhap.FullRowSelect = true;
            this.listPhieuNhap.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listPhieuNhap.Items.Add(row["MaChiTietPhieuNhap"].ToString());
                this.listPhieuNhap.Items[i].SubItems.Add(row["NgayNhap"].ToString());
                this.listPhieuNhap.Items[i].SubItems.Add(row["TenSach"].ToString());
                this.listPhieuNhap.Items[i].SubItems.Add(row["SoLuongNhap"].ToString());

                i++;
            }
        }

        private void listPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string query = "Select TENSACH, TENTG, TENLINHVUC, TENLOAISACH, " +
               "GIABIA, LANTAIBAN, TENNHAXUATBAN, NAMXUATBAN From SACH LEFT JOIN TACGIA " +
               "ON SACH.MATG = TACGIA.MATG";*/


        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoLuongNhap.Text, "[^0-9]"))
            {
                MessageBox.Show("SỐ LƯỢNG NHẬP LÀ SỐ NGUYÊN", "THÔNG BÁO");
                txtSoLuongNhap.Text = txtSoLuongNhap.Text.Remove(txtSoLuongNhap.Text.Length - 1);
            }
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSoLuongTonToiDa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
