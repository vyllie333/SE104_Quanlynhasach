using SE104_Nhom_16.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace SE104_Nhom_16.Forms
{
    public partial class frmBaoCaoHoaDon : Form
    {

        string mahd = FormLapHoaDonBanSach.mahd;
        
        public frmBaoCaoHoaDon()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            txb_TextChanged();
            
            Console.WriteLine(mahd);
        }

       
        
        private void listView1_SelectedIndexChanged()
        {
            string query = " SELECT CHITIETPHIEUHOADON.MaSach, SACH.TenSach, CHITIETPHIEUHOADON.SoLuongBan, (SoLuongBan*SACH.DonGia)*105/100 AS ThanhTien" +
                "  from CHITIETPHIEUHOADON, PHIEUHOADON, SACH " +
                " where CHITIETPHIEUHOADON.MaPhieuHoaDon = PHIEUHOADON.MaPhieuHoaDon" +
                " and CHITIETPHIEUHOADON.MaSach=SACH.MaSach " +
                " and PHIEUHOADON.MaPhieuHoaDon=" + mahd;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("MÃ SÁCH", 70);
            this.listView1.Columns.Add("TÊN SÁCH", 250);
            this.listView1.Columns.Add("SỐ LƯỢNG BÁN", 150);
            this.listView1.Columns.Add("THÀNH TIỀN", 100);
      
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["MaSach"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TenSach"].ToString());
                this.listView1.Items[i].SubItems.Add(row["SoLuongBan"].ToString());
                this.listView1.Items[i].SubItems.Add(row["ThanhTien"].ToString());
               
                i++;
            }
        }

    

        private void txb_TextChanged()
        {
            string getname = "select KHACHHANG.HoTenKhachHang" +
                " from KHACHHANG, PHIEUHOADON " +
                " WheRE KHACHHANG.MaKhachHang = PHIEUHOADON.MaKhachHang AND MaPhieuHoaDon = " + mahd;
            object namekh = DataProvider.Instance.ExecuteScalar(getname);

            txtKhachHang.Text = namekh.ToString();
         
            txtTienThua.Text = FormLapHoaDonBanSach.tienthua.ToString() + " VND";
            txtTongTien.Text = FormLapHoaDonBanSach.tongtien.ToString() + " VND";
            txtKhachTra.Text = FormLapHoaDonBanSach.khachtra.ToString() + " VND";

        }

        private void bThoat_Click(object sender, EventArgs e)
        {
           
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void txbTongDoanhThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTongDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            int windowWidth = 838;
            int windowHeight = 459;

            // Tính toán vị trí và kích thước để căn giữa màn hình
            int left = (Screen.PrimaryScreen.Bounds.Width - windowWidth) / 2;
            int top = (Screen.PrimaryScreen.Bounds.Height - windowHeight) / 2;

            Rectangle bounds = new Rectangle(left, top, windowWidth, windowHeight);

            this.Close();
            using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
            {

                this.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
                string result = @"D:\NAM3\HK2\Technology software\DOAN\SE104_Nhom_16\SE104_Nhom_16\Resources\HOADON" + mahd + ".jpg";
                bitmap.Save(result, ImageFormat.Jpeg);

            }

            MessageBox.Show(@"LƯU ẢNH TẠI SE104_Nhom_16\Resources\HOADON", "THÔNG BÁO");
            this.Close();
        }
    }
}
