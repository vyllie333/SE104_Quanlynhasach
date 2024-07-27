using SE104_Nhom_16.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;


namespace SE104_Nhom_16.Forms
{
    public partial class frmTaiKhoan : Form
    {
        int bChonTK = 0;
        public frmTaiKhoan()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCapNhap_Click(object sender, EventArgs e)
        {
            if (bChonTK == 1)
            {

                string query0 = "Select MatKhau From TAIKHOAN WHERE Email = '" + txbTenDangNhap.Text + "'";
                object data0 = DataProvider.Instance.ExecuteScalar(query0);

                if (data0.ToString() == txbMKHienTai.Text)
                {
                    if (txbMKHienTai.Text == "")
                    {
                        MessageBox.Show("CHƯA NHẬP MẬT KHẨU HIỆN TẠI, MỜI NHẬP !", "THÔNG BÁO");
                    }

                    else if (txbMKMoi.Text == "")
                    {
                        MessageBox.Show("CHƯA NHẬP MẬT KHẨU MỚI, MỜI NHẬP !", "THÔNG BÁO");
                    }
                    else if (txbMKMoiNhapLai.Text == "")
                    {
                        MessageBox.Show("CHƯA NHẬP MẬT KHẨU NHẬP LẠI, MỜI NHẬP !", "THÔNG BÁO");
                    }
                    else if (txbMKMoi.Text == txbMKMoiNhapLai.Text)
                    {
                        string query = "Update TAIKHOAN set MatKhau='" + txbMKMoiNhapLai.Text + "' Where Email='" + txbTenDangNhap.Text + "'";
                        DataTable data = DataProvider.Instance.ExecuteQuery(query);
                        txbTenDangNhap.Text = "";
                        txbMKHienTai.Text = "";
                        txbMKMoiNhapLai.Text = "";
                        txbMKMoi.Text = "";
                        MessageBox.Show("CẬP NHẬP TÀI KHOẢN THÀNH CÔNG!", "THÔNG BÁO");
                        bChonTK = 0;


                        //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
                    }
                    else
                    {
                        MessageBox.Show("MẬT KHẨU NHẬP LẠI KHÔNG ĐÚNG, MỜI NHẬP LẠI!", "THÔNG BÁO");
                    }
                }
                else
                {
                    MessageBox.Show("MẬT KHẨU HIỆN TẠI KHÔNG ĐÚNG, MỜI NHẬP LẠI!", "THÔNG BÁO");
                }
            }
            else
            {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN!", "THÔNG BÁO");
            }
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select Email, HoTen, TenPhanQuyen, TAIKHOAN.MaPhanQuyen From TAIKHOAN left join PHANQUYEN " +
                "on TAIKHOAN.MaPhanQuyen = PHANQUYEN.MaPhanQuyen";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvTaiKhoan.Clear();
            this.dgvTaiKhoan.Items.Clear();
            this.dgvTaiKhoan.View = View.Details;
            this.dgvTaiKhoan.Columns.Add("DANH SÁCH CÁC NGƯỜI DÙNG", 380);
            this.dgvTaiKhoan.Columns.Add("HỌ TÊN NG DÙNG",300);
            this.dgvTaiKhoan.Columns.Add("QUYỀN HẠN", 180);
            this.dgvTaiKhoan.Columns.Add("MÃ PHÂN QUYỀN", 100);
            this.dgvTaiKhoan.GridLines = true;
            this.dgvTaiKhoan.FullRowSelect = true;
            this.dgvTaiKhoan.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvTaiKhoan.Items.Add(row["Email"].ToString());

                this.dgvTaiKhoan.Items[i].SubItems.Add(row["HoTen"].ToString());

                this.dgvTaiKhoan.Items[i].SubItems.Add(row["TenPhanQuyen"].ToString());

                this.dgvTaiKhoan.Items[i].SubItems.Add(row["MaPhanQuyen"].ToString());
                i++;
            }
        }

        private void bChon_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.dgvTaiKhoan.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN NÀO!", "THÔNG BÁO");
            }
            else if (count == 1)
            {
                bChonTK = 1;
                foreach (ListViewItem item in this.dgvTaiKhoan.Items)
                {
                    if (item.Checked == true)
                    {
                        txbTenDangNhap.Text = item.SubItems[0].Text;
                    }
                }
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ CẬP NHẬP CÙNG LÚC NHIỀU TÀI KHOẢN!", "THÔNG BÁO");
            }
        }

        private void lblTenDangNhap1_Click(object sender, EventArgs e)
        {

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {

        }
        private object MaTaiKhoan()
        {

            string query = "SELECT MAX(MaTaiKhoan)+1 FROM TAIKHOAN";
            object MaHD = DataProvider.Instance.ExecuteScalar(query);
            return MaHD;
        }
        private bool IsMailExists(string email)
        {
            email = txtRegEmail.Text;
            string query = "SELECT Email FROM TAIKHOAN";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string mail = row["Email"].ToString();
                if (mail == email)
                    return true;
            }

            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string email = txtRegEmail.Text;

            if (txtRegEmail.Text == "" || txtRegPass.Text == "" || txtRegName.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else
            {
                bool found = IsMailExists(email);

                if (found== true)
                {
                    MessageBox.Show("EMAIL ĐÃ ĐƯỢC SỬ DỤNG!", "THÔNG BÁO");
                }
                else
                {
                    int matk = 0;
                    Int32.TryParse(MaTaiKhoan().ToString(), out matk);

                    string query = "INSERT INTO TAIKHOAN VALUES(" + matk + ", N'" + txtRegEmail.Text.ToString() + "'" + ", N'" + txtRegPass.Text.ToString()
                        + "'" + ", N'" + txtRegName.Text.ToString() + "', " + "'1'" + ")";

                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                }
            }
        }

        private void txbTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int count0 = 0;
            foreach (ListViewItem item in this.dgvTaiKhoan.Items)
            {
                if (item.Checked)
                    count0++;
            }
            if (count0 > 0)
            {
                DialogResult d;
                d = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    int count = 0;
                    foreach (ListViewItem item in this.dgvTaiKhoan.Items)
                    {
                        if (item.Checked == true)
                        {
                            string MA = item.SubItems[3].Text;
                            if (MA == "2")
                            {
                                MessageBox.Show("KHÔNG THỂ XÓA QUẢN LÍ!", "THÔNG BÁO");
                            }
                            else
                            {

                                try
                                {
                                    count++;
                                    string Email = item.SubItems[0].Text;
                                    Console.WriteLine(Email);
                                    string query = "Delete From TAIKHOAN Where Email = '" + Email + "'";
                                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                                    item.Remove();
                                    MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                                }
                                catch
                                {
                                    MessageBox.Show("KHÔNG THỂ XÓA!", "THÔNG BÁO");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("KHÔNG CÓ GÌ ĐỂ XÓA!", "THÔNG BÁO");
            }

        }

        private void dgvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            string query = "Select Email, HoTen, TenPhanQuyen, TAIKHOAN.MaPhanQuyen From TAIKHOAN left join PHANQUYEN " +
                "on TAIKHOAN.MaPhanQuyen = PHANQUYEN.MaPhanQuyen";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvTaiKhoan.Clear();
            this.dgvTaiKhoan.Items.Clear();
            this.dgvTaiKhoan.View = View.Details;
            this.dgvTaiKhoan.Columns.Add("DANH SÁCH CÁC NGƯỜI DÙNG", 380);
            this.dgvTaiKhoan.Columns.Add("HỌ TÊN NG DÙNG", 300);
            this.dgvTaiKhoan.Columns.Add("QUYỀN HẠN", 180);
            this.dgvTaiKhoan.Columns.Add("MÃ PHÂN QUYỀN", 100);
            this.dgvTaiKhoan.GridLines = true;
            this.dgvTaiKhoan.FullRowSelect = true;
            this.dgvTaiKhoan.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvTaiKhoan.Items.Add(row["Email"].ToString());

                this.dgvTaiKhoan.Items[i].SubItems.Add(row["HoTen"].ToString());

                this.dgvTaiKhoan.Items[i].SubItems.Add(row["TenPhanQuyen"].ToString());

                this.dgvTaiKhoan.Items[i].SubItems.Add(row["MaPhanQuyen"].ToString());
                i++;
            }
        }
    }
}
