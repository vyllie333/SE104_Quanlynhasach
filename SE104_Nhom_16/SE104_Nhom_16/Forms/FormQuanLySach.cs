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
using SE104_Nhom_16.Forms;

namespace SE104_Nhom_16.Forms
{
    public partial class FormQuanLySach : Form
    {
        public FormQuanLySach()
        {
            InitializeComponent();
            showData();
            this.dataGridView1.DefaultCellStyle.Font = new Font("Bahnschrift", 9);
        }

        private void FormQuanLySach_Load(object sender, EventArgs e)
        {
        }

        private DataSet getAllData()
        {
           
            DataSet dataSet = new DataSet();
            string query = "SELECT * FROM SACH";
            //string query = "SELECT MaSach as 'Mã sách', TenSach as 'Tên sách', TheLoai as 'Thể loại', TacGia as 'Tác giả', SoLuongTon as 'Số lượng tồn', DonGia as 'Đơn giá' FROM SACH";
            dataSet = DataProvider.Instance.ExecuteQueryList(query);
            return dataSet;
        }

        private void showData()
        {
            dataGridView1.DataSource = getAllData().Tables[0];
            //dataGridView1.DataMember = "SACH";
        }

        private void btbThem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fThemSach
            frmThemSach f = new frmThemSach();

            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaSach f = new frmSuaSach();
            f.ShowDialog();
         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmXoaSach f = new frmXoaSach();
            f.ShowDialog();
        }
    }
}
