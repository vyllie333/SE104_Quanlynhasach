using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

using SE104_Nhom_16.DAO;


namespace SE104_Nhom_16.Forms
{
    public partial class FormBaoCaoTon : Form
    {
        public FormBaoCaoTon()
        {
            InitializeComponent();
            
            this.dataGridView1.DefaultCellStyle.Font = new Font("Bahnschrift", 9);
        }
        Class1 kn = new Class1();
        private void FormBaoCaoTon_Load(object sender, EventArgs e)
        {
            kn.myconnect();
            string sql = "SELECT b.MaSach as 'Mã Sách', k.TenSach as 'Tên sách',b.Thang as 'Tháng', b.Nam as 'Năm',b.TonDau as 'Tồn đầu', b.Ton" +
                "PhatSinh as 'Tồn phát sinh', b.TonCuoi as 'Tồn cuối' FROM BAOCAOTON b,SACH k WHERE b.MaSach=k.MaSach order by MaChiTietTon desc";
            dataGridView1.DataSource = kn.taobang(sql);

        }
        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            string s1 = "SELECT b.MaSach, k.TenSach,b.TonDau, b.Ton" +
                "PhatSinh, b.TonCuoi FROM BAOCAOTON b,SACH k WHERE b.MaSach=k.MaSach and (b.Thang=" + txtThang.Text + ") and (b.Nam=" + txtNam.Text + ")";
            dataGridView1.DataSource = kn.taobang(s1);
            kn.myclose();

        }

        private void btnXuatRaExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


                ToExcel(dataGridView1, saveFileDialog1.FileName);
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Báo Cáo Tồn";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnXuatRaExcel_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


                ToExcel(dataGridView1, saveFileDialog1.FileName);
            }
        }

        private void btnLapBaoCao_Click_1(object sender, EventArgs e)
        {

            if (txtThang.Text == "")
            {
                MessageBox.Show("NHẬP THÁNG", "THÔNG BÁO");
            }
            else if (txtNam.Text == "")
            {
                MessageBox.Show("NHẬP NĂM", "THÔNG BÁO");
            }
            else
            {
                string s1 = "SELECT b.MaSach as 'Mã Sách', k.TenSach as 'Tên sách',b.Thang as 'Tháng', b.Nam as 'Năm',b.TonDau as 'Tồn đầu', b.Ton" +
       "PhatSinh as 'Tồn phát sinh', b.TonCuoi as 'Tồn cuối' FROM BAOCAOTON b,SACH k WHERE b.MaSach=k.MaSach and (b.Thang=" + txtThang.Text + ") and (b.Nam=" + txtNam.Text + ")";
                dataGridView1.DataSource = kn.taobang(s1);
                kn.myclose();

            }

        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNam.Text, "[^0-9]"))
            {
                MessageBox.Show("THÁNG LÀ SỐ NGUYÊN", "THÔNG BÁO");
                txtNam.Text = txtNam.Text.Remove(txtNam.Text.Length - 1);
            }
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNam.Text, "[^0-9]"))
            {
                MessageBox.Show("NĂM LÀ SỐ NGUYÊN", "THÔNG BÁO");
                txtNam.Text = txtNam.Text.Remove(txtNam.Text.Length - 1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
