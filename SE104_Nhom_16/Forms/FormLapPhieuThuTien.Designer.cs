namespace SE104_Nhom_16.Forms
{
    partial class FormLapPhieuThuTien
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
            this.panelHandle = new System.Windows.Forms.Panel();
            this.checkQuyDinh = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewThuTien = new System.Windows.Forms.ListView();
            this.labelSoTienThu = new System.Windows.Forms.Label();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoTienNo = new System.Windows.Forms.Label();
            this.txtSoTienNo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblNgayThuTien = new System.Windows.Forms.Label();
            this.btnLapPhiéu = new System.Windows.Forms.Button();
            this.lblHoTenKhachHang = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTenKhachHang = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHandle.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHandle
            // 
            this.panelHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.panelHandle.Controls.Add(this.checkQuyDinh);
            this.panelHandle.Controls.Add(this.button1);
            this.panelHandle.Controls.Add(this.listViewThuTien);
            this.panelHandle.Controls.Add(this.labelSoTienThu);
            this.panelHandle.Controls.Add(this.txtSoTienThu);
            this.panelHandle.Controls.Add(this.lblDienThoai);
            this.panelHandle.Controls.Add(this.txtDienThoai);
            this.panelHandle.Controls.Add(this.lblSoTienNo);
            this.panelHandle.Controls.Add(this.txtSoTienNo);
            this.panelHandle.Controls.Add(this.lblEmail);
            this.panelHandle.Controls.Add(this.txtEmail);
            this.panelHandle.Controls.Add(this.lblMaKhachHang);
            this.panelHandle.Controls.Add(this.txtMaKhachHang);
            this.panelHandle.Controls.Add(this.dateTimePicker1);
            this.panelHandle.Controls.Add(this.lblNgayThuTien);
            this.panelHandle.Controls.Add(this.btnLapPhiéu);
            this.panelHandle.Controls.Add(this.lblHoTenKhachHang);
            this.panelHandle.Controls.Add(this.lblDiaChi);
            this.panelHandle.Controls.Add(this.txtDiaChi);
            this.panelHandle.Controls.Add(this.txtHoTenKhachHang);
            this.panelHandle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHandle.Location = new System.Drawing.Point(0, 92);
            this.panelHandle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHandle.Name = "panelHandle";
            this.panelHandle.Size = new System.Drawing.Size(1446, 589);
            this.panelHandle.TabIndex = 13;
            // 
            // checkQuyDinh
            // 
            this.checkQuyDinh.AutoSize = true;
            this.checkQuyDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.checkQuyDinh.Enabled = false;
            this.checkQuyDinh.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold);
            this.checkQuyDinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.checkQuyDinh.Location = new System.Drawing.Point(367, 153);
            this.checkQuyDinh.Margin = new System.Windows.Forms.Padding(4);
            this.checkQuyDinh.Name = "checkQuyDinh";
            this.checkQuyDinh.Size = new System.Drawing.Size(680, 40);
            this.checkQuyDinh.TabIndex = 19;
            this.checkQuyDinh.Text = "Số tiền thu không vượt quá số tiền khách hàng đang nợ";
            this.checkQuyDinh.UseVisualStyleBackColor = false;
            this.checkQuyDinh.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(916, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "CHỌN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewThuTien
            // 
            this.listViewThuTien.Font = new System.Drawing.Font("Bahnschrift", 10.8F);
            this.listViewThuTien.HideSelection = false;
            this.listViewThuTien.Location = new System.Drawing.Point(51, 218);
            this.listViewThuTien.Margin = new System.Windows.Forms.Padding(4);
            this.listViewThuTien.Name = "listViewThuTien";
            this.listViewThuTien.Size = new System.Drawing.Size(1250, 262);
            this.listViewThuTien.TabIndex = 17;
            this.listViewThuTien.UseCompatibleStateImageBehavior = false;
            this.listViewThuTien.SelectedIndexChanged += new System.EventHandler(this.listViewThuTien_SelectedIndexChanged);
            // 
            // labelSoTienThu
            // 
            this.labelSoTienThu.AutoSize = true;
            this.labelSoTienThu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelSoTienThu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoTienThu.ForeColor = System.Drawing.Color.White;
            this.labelSoTienThu.Location = new System.Drawing.Point(912, 96);
            this.labelSoTienThu.Name = "labelSoTienThu";
            this.labelSoTienThu.Size = new System.Drawing.Size(98, 24);
            this.labelSoTienThu.TabIndex = 15;
            this.labelSoTienThu.Text = "Số tiền thu:";
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienThu.Location = new System.Drawing.Point(1061, 94);
            this.txtSoTienThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(240, 27);
            this.txtSoTienThu.TabIndex = 16;
            this.txtSoTienThu.TextChanged += new System.EventHandler(this.txtSoTienThu_TextChanged);
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.ForeColor = System.Drawing.Color.White;
            this.lblDienThoai.Location = new System.Drawing.Point(493, 14);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(91, 24);
            this.lblDienThoai.TabIndex = 13;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtDienThoai.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtDienThoai.Location = new System.Drawing.Point(613, 16);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(265, 27);
            this.txtDienThoai.TabIndex = 14;
            // 
            // lblSoTienNo
            // 
            this.lblSoTienNo.AutoSize = true;
            this.lblSoTienNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSoTienNo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienNo.ForeColor = System.Drawing.Color.White;
            this.lblSoTienNo.Location = new System.Drawing.Point(493, 96);
            this.lblSoTienNo.Name = "lblSoTienNo";
            this.lblSoTienNo.Size = new System.Drawing.Size(92, 24);
            this.lblSoTienNo.TabIndex = 11;
            this.lblSoTienNo.Text = "Số tiền nợ:";
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtSoTienNo.Location = new System.Drawing.Point(640, 95);
            this.txtSoTienNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.Size = new System.Drawing.Size(239, 27);
            this.txtSoTienNo.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(493, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(563, 54);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(316, 27);
            this.txtEmail.TabIndex = 10;
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.ForeColor = System.Drawing.Color.White;
            this.lblMaKhachHang.Location = new System.Drawing.Point(60, 11);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(131, 24);
            this.lblMaKhachHang.TabIndex = 6;
            this.lblMaKhachHang.Text = "Mã khách hàng:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(244, 14);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(212, 27);
            this.txtMaKhachHang.TabIndex = 7;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtMaKhachHang_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1061, 54);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lblNgayThuTien
            // 
            this.lblNgayThuTien.AutoSize = true;
            this.lblNgayThuTien.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThuTien.ForeColor = System.Drawing.Color.White;
            this.lblNgayThuTien.Location = new System.Drawing.Point(912, 53);
            this.lblNgayThuTien.Name = "lblNgayThuTien";
            this.lblNgayThuTien.Size = new System.Drawing.Size(117, 24);
            this.lblNgayThuTien.TabIndex = 1;
            this.lblNgayThuTien.Text = "Ngày thu tiền:";
            // 
            // btnLapPhiéu
            // 
            this.btnLapPhiéu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLapPhiéu.FlatAppearance.BorderSize = 0;
            this.btnLapPhiéu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhiéu.Font = new System.Drawing.Font("Bahnschrift", 15.2F, System.Drawing.FontStyle.Bold);
            this.btnLapPhiéu.ForeColor = System.Drawing.Color.Black;
            this.btnLapPhiéu.Location = new System.Drawing.Point(588, 513);
            this.btnLapPhiéu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLapPhiéu.Name = "btnLapPhiéu";
            this.btnLapPhiéu.Size = new System.Drawing.Size(220, 43);
            this.btnLapPhiéu.TabIndex = 4;
            this.btnLapPhiéu.Text = "Lập phiếu";
            this.btnLapPhiéu.UseVisualStyleBackColor = false;
            this.btnLapPhiéu.Click += new System.EventHandler(this.btnLapPhiéu_Click);
            // 
            // lblHoTenKhachHang
            // 
            this.lblHoTenKhachHang.AutoSize = true;
            this.lblHoTenKhachHang.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenKhachHang.ForeColor = System.Drawing.Color.White;
            this.lblHoTenKhachHang.Location = new System.Drawing.Point(60, 48);
            this.lblHoTenKhachHang.Name = "lblHoTenKhachHang";
            this.lblHoTenKhachHang.Size = new System.Drawing.Size(159, 24);
            this.lblHoTenKhachHang.TabIndex = 1;
            this.lblHoTenKhachHang.Text = "Họ tên khách hàng:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.White;
            this.lblDiaChi.Location = new System.Drawing.Point(65, 95);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(66, 24);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtDiaChi.Location = new System.Drawing.Point(151, 94);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(305, 27);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(244, 53);
            this.txtHoTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.ReadOnly = true;
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(212, 27);
            this.txtHoTenKhachHang.TabIndex = 3;
           
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1446, 92);
            this.panelTitle.TabIndex = 12;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.labelTitle.Location = new System.Drawing.Point(578, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(314, 58);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Lập phiếu thu tiền";
            // 
            // FormLapPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1446, 681);
            this.Controls.Add(this.panelHandle);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1680, 728);
            this.Name = "FormLapPhieuThuTien";
            this.Text = "Lập phiếu thu tiền";
            this.Load += new System.EventHandler(this.FormLapPhieuThuTien_Load);
            this.panelHandle.ResumeLayout(false);
            this.panelHandle.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHandle;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblNgayThuTien;
        private System.Windows.Forms.Button btnLapPhiéu;
        private System.Windows.Forms.Label lblHoTenKhachHang;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTenKhachHang;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblSoTienNo;
        private System.Windows.Forms.TextBox txtSoTienNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label labelSoTienThu;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.ListView listViewThuTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkQuyDinh;
    }
}