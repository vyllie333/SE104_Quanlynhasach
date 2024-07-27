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
    public partial class frmSuaSach : Form
    {
        int bChon = 0;
        public frmSuaSach()
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
                int masach;
                int soluongton;
                Int32.TryParse(txtMaSach.Text, out masach);
                Int32.TryParse(txtSoLuongTon.Text, out soluongton);

                string query = "UPDATE SACH SET TenSach=" + "N'" + txtTenSach.Text.ToString() + "'" + ", TheLoai = N'" + txtTheLoai.Text.ToString() + "'" +
                    ", TacGia = N'" + txtTacGia.Text.ToString() + "'" + ", SoLuongTon = " + soluongton + ", DonGia = " + numericUpDownGiaMua.Value +
                    "WHERE MaSach = " + masach;
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("ĐÃ CẬP NHẬP!", "THÔNG BÁO");
                listView1_SelectedIndexChanged();
                bChon = 0;
            }
            else
            {
                MessageBox.Show("CHƯA CHỌN SÁCH!", "THÔNG BÁO");
               
            }
           
        }


        private void listView1_SelectedIndexChanged()
        {
            //string query = "Select MASACH, TENSACH, TENTG, TENLINHVUC, TENLOAISACH, GIAMUA, GIABIA, LANTAIBAN, " +
               // "TENNHAXUATBAN, NAMXUATBAN From SACH LEFT JOIN TACGIA ON SACH.MATG = TACGIA.MATG";
            string query = "SELECT MaSach, TenSach, TheLoai, TacGia, SoLuongTon, DonGia FROM SACH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvSuaSach.Clear();
            this.dgvSuaSach.Items.Clear();
            this.dgvSuaSach.View = View.Details;
            this.dgvSuaSach.Columns.Add("MÃ SÁCH", 150);
            this.dgvSuaSach.Columns.Add("TÊN SÁCH", 270);
            this.dgvSuaSach.Columns.Add("THỂ LOẠI", 200);
            this.dgvSuaSach.Columns.Add("TÁC GIẢ", 100);
            this.dgvSuaSach.Columns.Add("SỐ LƯỢNG TỒN", 150);
            this.dgvSuaSach.Columns.Add("ĐƠN GIÁ", 100);
            this.dgvSuaSach.GridLines = true;
            this.dgvSuaSach.FullRowSelect = true;
            this.dgvSuaSach.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvSuaSach.Items.Add(row["MaSach"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["TenSach"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["TheLoai"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["TacGia"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["SoLuongTon"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["DonGia"].ToString());
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
                        txtMaSach.Text = item.SubItems[0].Text;
                        txtTenSach.Text = item.SubItems[1].Text;
                       
                        txtTheLoai.Text = item.SubItems[2].Text;
                        txtTacGia.Text = item.SubItems[3].Text;
                        txtSoLuongTon.Text = item.SubItems[4].Text;

                        numericUpDownGiaMua.Text = item.SubItems[5].Text;
                        
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

        private void lblMaLoaiSach_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuongTon_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoLuongTon.Text, "[^0-9]"))
            {
                MessageBox.Show("CHỈ NHẬP SỐ", "THÔNG BÁO");
                txtSoLuongTon.Text = txtSoLuongTon.Text.Remove(txtSoLuongTon.Text.Length - 1);
            }
        }
    }
}
