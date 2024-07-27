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
    public partial class Form1 : Form
    {
        string email = FormLogin.email;
        public Form1()
        {
            InitializeComponent();
            
        }
        private object getNameUser()
        {
            string query = "select HoTen from TAIKHOAN where Email = '" + email + "'";
            object hoten;
            hoten = DataProvider.Instance.ExecuteScalar(query);
            return hoten;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
