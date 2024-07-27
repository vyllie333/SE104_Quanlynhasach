
namespace SE104_Nhom_16
{
    partial class frmThemKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblMaTacGia = new System.Windows.Forms.Label();
            this.lblTenLinhVuc = new System.Windows.Forms.Label();
            this.numericUpDownTienNo = new System.Windows.Forms.NumericUpDown();
            this.lblGiaMua = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTienNo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(313, 46);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(284, 22);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMaSach.ForeColor = System.Drawing.Color.White;
            this.lblMaSach.Location = new System.Drawing.Point(84, 46);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(126, 21);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã khách hàng:";
            this.lblMaSach.Click += new System.EventHandler(this.lblMaSach_Click);
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenKH.Location = new System.Drawing.Point(313, 89);
            this.txtHoTenKH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(284, 26);
            this.txtHoTenKH.TabIndex = 2;
            this.txtHoTenKH.TextChanged += new System.EventHandler(this.txbTenSach_TextChanged);
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTenSach.ForeColor = System.Drawing.Color.White;
            this.lblTenSach.Location = new System.Drawing.Point(84, 90);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(177, 21);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Họ và tên khách hàng:";
            // 
            // lblMaTacGia
            // 
            this.lblMaTacGia.AutoSize = true;
            this.lblMaTacGia.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMaTacGia.ForeColor = System.Drawing.Color.White;
            this.lblMaTacGia.Location = new System.Drawing.Point(84, 133);
            this.lblMaTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaTacGia.Name = "lblMaTacGia";
            this.lblMaTacGia.Size = new System.Drawing.Size(65, 21);
            this.lblMaTacGia.TabIndex = 0;
            this.lblMaTacGia.Text = "Địa chỉ:";
            // 
            // lblTenLinhVuc
            // 
            this.lblTenLinhVuc.AutoSize = true;
            this.lblTenLinhVuc.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTenLinhVuc.ForeColor = System.Drawing.Color.White;
            this.lblTenLinhVuc.Location = new System.Drawing.Point(84, 178);
            this.lblTenLinhVuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenLinhVuc.Name = "lblTenLinhVuc";
            this.lblTenLinhVuc.Size = new System.Drawing.Size(90, 21);
            this.lblTenLinhVuc.TabIndex = 0;
            this.lblTenLinhVuc.Text = "Điện thoại:";
            this.lblTenLinhVuc.Click += new System.EventHandler(this.lblTenLinhVuc_Click);
            // 
            // numericUpDownTienNo
            // 
            this.numericUpDownTienNo.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.numericUpDownTienNo.Location = new System.Drawing.Point(205, 270);
            this.numericUpDownTienNo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numericUpDownTienNo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownTienNo.Name = "numericUpDownTienNo";
            this.numericUpDownTienNo.Size = new System.Drawing.Size(392, 26);
            this.numericUpDownTienNo.TabIndex = 6;
            this.numericUpDownTienNo.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTienNo.ValueChanged += new System.EventHandler(this.numericUpDownGiaMua_ValueChanged);
            // 
            // lblGiaMua
            // 
            this.lblGiaMua.AutoSize = true;
            this.lblGiaMua.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblGiaMua.ForeColor = System.Drawing.Color.White;
            this.lblGiaMua.Location = new System.Drawing.Point(85, 270);
            this.lblGiaMua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaMua.Name = "lblGiaMua";
            this.lblGiaMua.Size = new System.Drawing.Size(89, 21);
            this.lblGiaMua.TabIndex = 0;
            this.lblGiaMua.Text = "Số tiền nợ:";
            this.lblGiaMua.Click += new System.EventHandler(this.lblGiaMua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Bahnschrift", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(236, 319);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(185, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.txtDiaChi.Location = new System.Drawing.Point(205, 134);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(392, 26);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.txtDienThoai.Location = new System.Drawing.Point(205, 178);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(392, 26);
            this.txtDienThoai.TabIndex = 4;
            this.txtDienThoai.TextChanged += new System.EventHandler(this.txtDienThoai_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.txtEmail.Location = new System.Drawing.Point(205, 226);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(392, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // frmThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 364);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblMaSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.numericUpDownTienNo);
            this.Controls.Add(this.lblGiaMua);
            this.Controls.Add(this.lblTenLinhVuc);
            this.Controls.Add(this.lblMaTacGia);
            this.Controls.Add(this.txtHoTenKH);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmThemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmThemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTienNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblMaTacGia;
        private System.Windows.Forms.Label lblTenLinhVuc;
        private System.Windows.Forms.NumericUpDown numericUpDownTienNo;
        private System.Windows.Forms.Label lblGiaMua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
    }
}