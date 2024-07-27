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

    public partial class FormMain : Form
    {
        string email = FormLogin.email;
        public static bool checktk;
        public FormMain()
        {
            InitializeComponent();
            customizeDesing();
            txtTenTk.Text = getNameUser().ToString();
            txtPhanQuyen.Text = getRoleUser().ToString();
            checktk = checkTaiKhoan();
            if (checkTaiKhoan()==false)
            {
                btnTaiKhoan.Enabled = false;
            }
        }

        private void customizeDesing()
        {
            panelChucNangSubmenu.Visible = false;
            panelQuanlySubmenu.Visible = false;
            panelBaoCaoSubmenu.Visible = false;
            otherpanel.Visible = true;
        }

        private void showclick()
        {
            if(otherpanel.Visible == false)
                otherpanel.Visible = true;
        }

        private void hideclick(Panel Submenu)
        {
            if (Submenu.Visible == true)
            {
                showclick();
                Submenu.Visible = false;
            }
            else
            {
                Submenu.Visible = true;
            }
        }

        private void hideSubMenu()
        {
            if (panelChucNangSubmenu.Visible == true) 
               panelChucNangSubmenu.Visible = false;
            if (panelQuanlySubmenu.Visible == true)
                panelQuanlySubmenu.Visible = false;
            if (panelBaoCaoSubmenu.Visible == true)
                panelBaoCaoSubmenu.Visible = false;
        }
        private void showSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                hideSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void btnChucNang_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelChucNangSubmenu);
        }

        private void btnQuanLy_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelQuanlySubmenu);
        }

        private void btnBaoCao_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelBaoCaoSubmenu);
        }

        private void btnQuyDinh_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormQuyDinh());
            //Backend
            hideSubMenu();
        }

        #region Chức năng Submenu
        private void btnLapPhieuNhapSach_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormLapPhieuNhapSach());
            // Backend
            hideSubMenu();
        }

        private void btnLapHoaDonBanSach_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormLapHoaDonBanSach());
            //Backend
            hideSubMenu();
        }

        private void btnLapPhieuThuTien_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormLapPhieuThuTien());
            //Backend
            hideSubMenu();
        }

        private void btnTraCuu_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormTraCuu());
            //Backend
            hideSubMenu();
        }
        
#endregion

        #region Quản lý Submenu
        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormQuanLySach());
            //Backend
            hideSubMenu();
        }
        private void btnCapNhatKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormQuanLySach());
            //Backend
            hideSubMenu();
        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormQuanLySach());
            //Backend
            hideSubMenu();
        }
        private void btnCapNhatSach_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormQuanLySach());
            //Backend
            hideSubMenu();
        }
        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormQuanLyKhachHang());
            //Backend
            hideSubMenu();
        }
        #endregion

        #region Báo cáo Submenu
        private void btnBaoCaoCongNo_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormBaoCaoCongNo());
            //Backend
            hideSubMenu();
        }

        private void btnBaoCaoTon_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormBaoCaoTon());
            //Backend
            hideSubMenu();
        }

        private void btnBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormBaoCaoDoanhSo());
            //Backend
            hideSubMenu();
        }
#endregion
       
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnQuanLyLKhachHang_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormQuanLyKhachHang());
            //Backend
            hideSubMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private object getNameUser()
        {
            string query = "select HoTen from TAIKHOAN where Email = '" + email+"'";
            object hoten;
            hoten = DataProvider.Instance.ExecuteScalar(query);
            return hoten;
        }
        private object getRoleUser()
        {
            string query = "Select TenPhanQuyen From TAIKHOAN left join PHANQUYEN " +
                "on TAIKHOAN.MaPhanQuyen = PHANQUYEN.MaPhanQuyen where Email = '" + email + "'";
            object hoten;
            hoten = DataProvider.Instance.ExecuteScalar(query);
            return hoten;
        }
        private object getIDRoleUser()
        {
            string query = "Select MaPhanQuyen From TAIKHOAN " +
                "where Email = '" + email + "'";
            object hoten;
            hoten = DataProvider.Instance.ExecuteScalar(query);
            return hoten;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmTaiKhoan());
        }

        public bool checkTaiKhoan()
        {
            if (getIDRoleUser().ToString()=="1")
            {
                return false;
            } else
            {
                return true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void txtPhanQuyen_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            hideclick(otherpanel);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
