using SE104_Nhom_16.DAO;
using SE104_Nhom_16.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SE104_Nhom_16
{
    public partial class frmSuaKhachHang : Form
    {
        int bChon = 0;
        public frmSuaKhachHang()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bbLuu_Click(object sender, EventArgs e)
        {
            if (bChon == 1)
            {
                int makh;
                
                Int32.TryParse(txtMaKH.Text, out makh);
                

                string query = "UPDATE KHACHHANG SET HoTenKhachHang=" + "N'" + txtHoTenKH.Text.ToString() + "'" + ", DienThoai = N'" + txtDienThoai.Text.ToString() + "'" +
                    ", DiaChi = N'" + txtDiaChi.Text.ToString() + "'" 
                    +", Email = N'" + txtEmail.Text.ToString() + "'" +  ", SoTienNo = " + numericUpDownTienNo.Value +
                    "WHERE MaKhachHang = " + makh;
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("ĐÃ CẬP NHẬP!", "THÔNG BÁO");
                listView1_SelectedIndexChanged();
                bChon = 0;
            }
            else
            {
                MessageBox.Show("CHƯA CHỌN KHÁCH HÀNG!", "THÔNG BÁO");
               
            }
           
        }


        private void listView1_SelectedIndexChanged()
        {
            string query = "SELECT MaKhachHang, HoTenKhachHang, DiaChi, DienThoai, Email, SoTienNo FROM KHACHHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvSuaSach.Items.Clear();
            this.dgvSuaSach.View = View.Details;
            this.dgvSuaSach.Columns.Add("MÃ KHÁCH HÀNG", 60);
            this.dgvSuaSach.Columns.Add("HỌ TÊN KH", 200);
            this.dgvSuaSach.Columns.Add("ĐỊA CHỈ", 320);
            this.dgvSuaSach.Columns.Add("ĐIỆN THOẠI", 200);
            this.dgvSuaSach.Columns.Add("EMAIL", 155);

            this.dgvSuaSach.Columns.Add("SỐ TIỀN NỢ", 155);

            this.dgvSuaSach.GridLines = true;
            this.dgvSuaSach.FullRowSelect = true;
            this.dgvSuaSach.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvSuaSach.Items.Add(row["MaKhachHang"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["HoTenKhachHang"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["DiaChi"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["DienThoai"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["Email"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["SoTienNo"].ToString());

                i++;
            }
        }

    
   
 

        private void bbChon_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.dgvSuaSach.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN SÁCH!", "THÔNG BÁO");
            }

            else if (count == 1)
            {
                bChon = 1;
                foreach (ListViewItem item in this.dgvSuaSach.Items)
                {
                    if (item.Checked == true)
                    {
                        txtMaKH.Text = item.SubItems[0].Text;
                        txtHoTenKH.Text = item.SubItems[1].Text;
                        txtDiaChi.Text = item.SubItems[2].Text;
                        txtDienThoai.Text = item.SubItems[3].Text;
                      
                        txtEmail.Text = item.SubItems[4].Text;

                        numericUpDownTienNo.Text = item.SubItems[5].Text;
                        
                    }

                }
                


            }

            else
            {
                MessageBox.Show("KHÔNG THỂ CẬP NHẬP CÙNG LÚC NHIỀU SÁCH!", "THÔNG BÁO");
            }

            
        }

        private void frmSuaSach_Load(object sender, EventArgs e)
        {

        }

        private void lblTenLinhVuc_Click(object sender, EventArgs e)
        {

        }

        private void dgvSuaSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTenTacGia_Click(object sender, EventArgs e)
        {

        }

        private void lblMaLoaiSach_Click(object sender, EventArgs e)
        {

        }
    }
}
