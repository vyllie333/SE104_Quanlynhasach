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
    public partial class FormQuyDinh : Form
    {
        bool checktaikhoan = FormMain.checktk;
        public FormQuyDinh()
        {
            InitializeComponent();
            QuyDinh4();
            txtSoLuongNhapItNhat.Text = SoLuongNhapItNhat().ToString();
            txtSoLuongTonToiDa.Text = SoLuongTonToiDaTruocNhap().ToString();
            txtSoTienNoToiDa.Text = SoTienNoToiDa().ToString();
            txtSoLuongTonToiThieu.Text = SoLuongTonSauToiThieu().ToString();

            if (checktaikhoan==false)
            {
                btnCNQD1.Enabled = false;
                btnCNQD2.Enabled = false;
                btnCNQD4.Enabled = false;
                txtSoLuongNhapItNhat.ReadOnly = true;
                txtSoLuongTonToiDa.ReadOnly = true;
                txtSoLuongTonToiThieu.ReadOnly = true;
                txtSoTienNoToiDa.ReadOnly = true;

            }

            
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

        private object SuDungQuyDinh4()
        {
            object data = 0;
            string query = "SELECT SuDungQuyDinh4 FROM THAMSO";
            data = DataProvider.Instance.ExecuteScalar(query);
            return data;
        }


        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void panelHandle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormQuyDinh_Load(object sender, EventArgs e)
        {

        }

        private void QuyDinh4()
        {
            bool icheck = (bool)SuDungQuyDinh4();
            if (icheck)
            {
                checkBox1.Checked = true;
                checkBox1.CheckState = CheckState.Checked;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox1.CheckState = CheckState.Unchecked;
            }
        }

        private void btnCapNhatQD2_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE THAMSO SET SoLuongNhapItNhat=" + txtSoLuongNhapItNhat.Text + ", SoLuongTonToiDaTruocNhap=" + txtSoLuongTonToiDa.Text;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            MessageBox.Show("CẬP NHẬT THÀNH CÔNG!", "THÔNG BÁO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE THAMSO SET SoLuongTonSauToiThieu=" + txtSoLuongTonToiThieu.Text + ", SoTienNoToiDa=" + txtSoTienNoToiDa.Text;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            MessageBox.Show("CẬP NHẬT THÀNH CÔNG!", "THÔNG BÁO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string query = "UPDATE THAMSO SET SuDungQuyDinh4=" + 1;
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("CẬP NHẬT THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
            {
                string query = "UPDATE THAMSO SET SuDungQuyDinh4=" + 0;
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("CẬP NHẬT THÀNH CÔNG!", "THÔNG BÁO");
            }
        }

        private void txtSoLuongNhapItNhat_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoLuongNhapItNhat.Text, "[^0-9]"))
            {
                MessageBox.Show("CHỈ NHẬP SỐ", "THÔNG BÁO");
                txtSoLuongNhapItNhat.Text = txtSoLuongNhapItNhat.Text.Remove(txtSoLuongNhapItNhat.Text.Length - 1);
            }
        }

        private void txtSoLuongTonToiDa_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoLuongTonToiDa.Text, "[^0-9]"))
            {
                MessageBox.Show("CHỈ NHẬP SỐ", "THÔNG BÁO");
                txtSoLuongTonToiDa.Text = txtSoLuongTonToiDa.Text.Remove(txtSoLuongTonToiDa.Text.Length - 1);
            }
        }

        private void txtSoTienNoToiDa_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoTienNoToiDa.Text, "[^0-9]"))
            {
                MessageBox.Show("CHỈ NHẬP SỐ", "THÔNG BÁO");
                txtSoTienNoToiDa.Text = txtSoTienNoToiDa.Text.Remove(txtSoTienNoToiDa.Text.Length - 1);
            }
        }

        private void txtSoLuongTonToiThieu_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoLuongTonToiThieu.Text, "[^0-9]"))
            {
                MessageBox.Show("CHỈ NHẬP SỐ", "THÔNG BÁO");
                txtSoLuongTonToiThieu.Text = txtSoLuongTonToiThieu.Text.Remove(txtSoLuongTonToiThieu.Text.Length - 1);
            }
        }

        
    }
}
