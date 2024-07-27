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
    public partial class frmXoaKhachHang : Form
    {
        public frmXoaKhachHang()
        {
            InitializeComponent();
            listView1_ItemChecked();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_ItemChecked()
        {
            string query = "SELECT MaKhachHang, HoTenKhachHang, DiaChi, DienThoai, Email, SoTienNo FROM KHACHHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvXoaSach.Items.Clear();
            this.dgvXoaSach.View = View.Details;
            this.dgvXoaSach.Columns.Add("MÃ KHÁCH HÀNG", 60);
            this.dgvXoaSach.Columns.Add("HỌ TÊN KH", 200);
            this.dgvXoaSach.Columns.Add("ĐỊA CHỈ", 320);
            this.dgvXoaSach.Columns.Add("ĐIỆN THOẠI", 200);
            this.dgvXoaSach.Columns.Add("EMAIL", 155);

            this.dgvXoaSach.Columns.Add("SỐ TIỀN NỢ", 155);

            this.dgvXoaSach.GridLines = true;
            this.dgvXoaSach.FullRowSelect = true;
            this.dgvXoaSach.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvXoaSach.Items.Add(row["MaKhachHang"].ToString());
                this.dgvXoaSach.Items[i].SubItems.Add(row["HoTenKhachHang"].ToString());
                this.dgvXoaSach.Items[i].SubItems.Add(row["DiaChi"].ToString());
                this.dgvXoaSach.Items[i].SubItems.Add(row["DienThoai"].ToString());
                this.dgvXoaSach.Items[i].SubItems.Add(row["Email"].ToString());
                this.dgvXoaSach.Items[i].SubItems.Add(row["SoTienNo"].ToString());

                i++;
            }
        }


        private void bXoa_Click(object sender, EventArgs e)
        {
            int count0 = 0;
            foreach (ListViewItem item in this.dgvXoaSach.Items)
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
                    foreach (ListViewItem item in this.dgvXoaSach.Items)
                    {
                        if (item.Checked == true)
                        {
                            try
                            {
                                count++;
                                string Ma = item.Text;
                                Console.WriteLine(Ma);
                                string query = "Delete From KHACHHANG Where MaKhachHang = '" + Ma + "'";
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
            else
            {
                MessageBox.Show("KHÔNG CÓ GÌ ĐỂ XÓA!", "THÔNG BÁO");
            }
        }

        private void frmXoaSach_Load(object sender, EventArgs e)
        {

        }
    }
}
