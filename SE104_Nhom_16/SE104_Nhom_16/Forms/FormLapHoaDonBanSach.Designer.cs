namespace SE104_Nhom_16.Forms
{
    partial class FormLapHoaDonBanSach
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
            this.panelData = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvChiTietHoaDon = new System.Windows.Forms.ListView();
            this.btnChiTietHD = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.ListView();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKhachTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.None = new System.Windows.Forms.Label();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.panelHandle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewSach = new System.Windows.Forms.ListView();
            this.txtSoTienNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblSoTienNoToiDa = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.txtSoTienNoToiDa = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblSoLuongTonToiThieu = new System.Windows.Forms.Label();
            this.lblHoTenKhachHang = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSoLuongTonToiThieu = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTenKhachHang = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelHandle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.tableLayoutPanel1);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData.Location = new System.Drawing.Point(0, 428);
            this.panelData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1383, 258);
            this.panelData.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 584F));
            this.tableLayoutPanel1.Controls.Add(this.dgvChiTietHoaDon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChiTietHD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvHoaDon, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1383, 258);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvChiTietHoaDon.Font = new System.Drawing.Font("Bahnschrift", 10.8F);
            this.dgvChiTietHoaDon.HideSelection = false;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(803, 4);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(519, 250);
            this.dgvChiTietHoaDon.TabIndex = 13;
            this.dgvChiTietHoaDon.UseCompatibleStateImageBehavior = false;
            this.dgvChiTietHoaDon.SelectedIndexChanged += new System.EventHandler(this.dgvChiTietHoaDon_SelectedIndexChanged);
            // 
            // btnChiTietHD
            // 
            this.btnChiTietHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnChiTietHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChiTietHD.FlatAppearance.BorderSize = 0;
            this.btnChiTietHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietHD.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietHD.ForeColor = System.Drawing.Color.Black;
            this.btnChiTietHD.Location = new System.Drawing.Point(634, 4);
            this.btnChiTietHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChiTietHD.Name = "btnChiTietHD";
            this.btnChiTietHD.Size = new System.Drawing.Size(162, 31);
            this.btnChiTietHD.TabIndex = 17;
            this.btnChiTietHD.Text = "Chi Tiết";
            this.btnChiTietHD.UseVisualStyleBackColor = false;
            this.btnChiTietHD.Click += new System.EventHandler(this.btnChiTietHD_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvHoaDon.Font = new System.Drawing.Font("Bahnschrift", 10.8F);
            this.dgvHoaDon.HideSelection = false;
            this.dgvHoaDon.Location = new System.Drawing.Point(4, 4);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(623, 250);
            this.dgvHoaDon.TabIndex = 12;
            this.dgvHoaDon.UseCompatibleStateImageBehavior = false;
            this.dgvHoaDon.SelectedIndexChanged += new System.EventHandler(this.dgvHoaDon_SelectedIndexChanged);
            // 
            // txtTienThua
            // 
            this.txtTienThua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienThua.BackColor = System.Drawing.SystemColors.Window;
            this.txtTienThua.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThua.Location = new System.Drawing.Point(784, 25);
            this.txtTienThua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.ReadOnly = true;
            this.txtTienThua.Size = new System.Drawing.Size(167, 27);
            this.txtTienThua.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(685, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tiền thừa:";
            // 
            // txtKhachTra
            // 
            this.txtKhachTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKhachTra.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachTra.Location = new System.Drawing.Point(464, 25);
            this.txtKhachTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhachTra.Name = "txtKhachTra";
            this.txtKhachTra.Size = new System.Drawing.Size(167, 27);
            this.txtKhachTra.TabIndex = 19;
            this.txtKhachTra.TextChanged += new System.EventHandler(this.txtKhachTra_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(353, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Khách trả:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTongTien.BackColor = System.Drawing.SystemColors.Window;
            this.txtTongTien.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(145, 24);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(167, 27);
            this.txtTongTien.TabIndex = 6;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // None
            // 
            this.None.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.None.AutoSize = true;
            this.None.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.None.ForeColor = System.Drawing.Color.White;
            this.None.Location = new System.Drawing.Point(47, 20);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(83, 24);
            this.None.TabIndex = 11;
            this.None.Text = "Tổng tiền:";
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLapHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLapHoaDon.FlatAppearance.BorderSize = 0;
            this.btnLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHoaDon.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnLapHoaDon.Location = new System.Drawing.Point(980, 25);
            this.btnLapHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(172, 31);
            this.btnLapHoaDon.TabIndex = 4;
            this.btnLapHoaDon.Text = "Lập hóa đơn";
            this.btnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // panelHandle
            // 
            this.panelHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.panelHandle.Controls.Add(this.label3);
            this.panelHandle.Controls.Add(this.txtMaHoaDon);
            this.panelHandle.Controls.Add(this.btnThem);
            this.panelHandle.Controls.Add(this.numericUpDownSoLuong);
            this.panelHandle.Controls.Add(this.label2);
            this.panelHandle.Controls.Add(this.listViewSach);
            this.panelHandle.Controls.Add(this.txtSoTienNo);
            this.panelHandle.Controls.Add(this.label1);
            this.panelHandle.Controls.Add(this.btnTim);
            this.panelHandle.Controls.Add(this.lblSoTienNoToiDa);
            this.panelHandle.Controls.Add(this.lblMaKhachHang);
            this.panelHandle.Controls.Add(this.txtSoTienNoToiDa);
            this.panelHandle.Controls.Add(this.txtMaKhachHang);
            this.panelHandle.Controls.Add(this.dateTimePickerNgayLap);
            this.panelHandle.Controls.Add(this.lblNgayNhap);
            this.panelHandle.Controls.Add(this.lblSoLuongTonToiThieu);
            this.panelHandle.Controls.Add(this.lblHoTenKhachHang);
            this.panelHandle.Controls.Add(this.lblDiaChi);
            this.panelHandle.Controls.Add(this.txtSoLuongTonToiThieu);
            this.panelHandle.Controls.Add(this.txtDiaChi);
            this.panelHandle.Controls.Add(this.txtHoTenKhachHang);
            this.panelHandle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHandle.Location = new System.Drawing.Point(0, 89);
            this.panelHandle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHandle.Name = "panelHandle";
            this.panelHandle.Size = new System.Drawing.Size(1383, 339);
            this.panelHandle.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(491, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã Hóa Đơn:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtMaHoaDon.Location = new System.Drawing.Point(624, 306);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(132, 27);
            this.txtMaHoaDon.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(341, 298);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 34);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Chọn";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(159, 303);
            this.numericUpDownSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownSoLuong.TabIndex = 13;
            this.numericUpDownSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSoLuong.ValueChanged += new System.EventHandler(this.numericUpDownSoLuong_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số lượng: ";
            // 
            // listViewSach
            // 
            this.listViewSach.Font = new System.Drawing.Font("Bahnschrift", 10.8F);
            this.listViewSach.HideSelection = false;
            this.listViewSach.Location = new System.Drawing.Point(4, 125);
            this.listViewSach.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSach.Name = "listViewSach";
            this.listViewSach.Size = new System.Drawing.Size(1261, 165);
            this.listViewSach.TabIndex = 11;
            this.listViewSach.UseCompatibleStateImageBehavior = false;
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtSoTienNo.Location = new System.Drawing.Point(1129, 58);
            this.txtSoTienNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.Size = new System.Drawing.Size(135, 27);
            this.txtSoTienNo.TabIndex = 10;
            this.txtSoTienNo.TextChanged += new System.EventHandler(this.txtSoTienNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1023, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số tiền nợ:";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(345, 50);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(99, 31);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblSoTienNoToiDa
            // 
            this.lblSoTienNoToiDa.AutoSize = true;
            this.lblSoTienNoToiDa.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienNoToiDa.ForeColor = System.Drawing.Color.White;
            this.lblSoTienNoToiDa.Location = new System.Drawing.Point(976, 7);
            this.lblSoTienNoToiDa.Name = "lblSoTienNoToiDa";
            this.lblSoTienNoToiDa.Size = new System.Drawing.Size(139, 24);
            this.lblSoTienNoToiDa.TabIndex = 6;
            this.lblSoTienNoToiDa.Text = "Số tiền nợ tối đa:";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.ForeColor = System.Drawing.Color.White;
            this.lblMaKhachHang.Location = new System.Drawing.Point(31, 50);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(131, 24);
            this.lblMaKhachHang.TabIndex = 6;
            this.lblMaKhachHang.Text = "Mã khách hàng:";
            this.lblMaKhachHang.Click += new System.EventHandler(this.lblMaKhachHang_Click);
            // 
            // txtSoTienNoToiDa
            // 
            this.txtSoTienNoToiDa.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoTienNoToiDa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTienNoToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienNoToiDa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoTienNoToiDa.Location = new System.Drawing.Point(1129, 9);
            this.txtSoTienNoToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTienNoToiDa.Name = "txtSoTienNoToiDa";
            this.txtSoTienNoToiDa.ReadOnly = true;
            this.txtSoTienNoToiDa.Size = new System.Drawing.Size(132, 22);
            this.txtSoTienNoToiDa.TabIndex = 7;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(181, 53);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(159, 27);
            this.txtMaKhachHang.TabIndex = 7;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtMaKhachHang_TextChanged);
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(180, 9);
            this.dateTimePickerNgayLap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerNgayLap.TabIndex = 5;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.ForeColor = System.Drawing.Color.White;
            this.lblNgayNhap.Location = new System.Drawing.Point(15, 9);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(147, 24);
            this.lblNgayNhap.TabIndex = 1;
            this.lblNgayNhap.Text = "Ngày lập hóa đơn:";
            this.lblNgayNhap.Click += new System.EventHandler(this.lblNgayNhap_Click);
            // 
            // lblSoLuongTonToiThieu
            // 
            this.lblSoLuongTonToiThieu.AutoSize = true;
            this.lblSoLuongTonToiThieu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTonToiThieu.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongTonToiThieu.Location = new System.Drawing.Point(480, 9);
            this.lblSoLuongTonToiThieu.Name = "lblSoLuongTonToiThieu";
            this.lblSoLuongTonToiThieu.Size = new System.Drawing.Size(274, 24);
            this.lblSoLuongTonToiThieu.TabIndex = 1;
            this.lblSoLuongTonToiThieu.Text = "Số lượng tồn tối thiểu sau khi bán:";
            this.lblSoLuongTonToiThieu.Click += new System.EventHandler(this.lblSoLuongTonToiThieu_Click);
            // 
            // lblHoTenKhachHang
            // 
            this.lblHoTenKhachHang.AutoSize = true;
            this.lblHoTenKhachHang.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenKhachHang.ForeColor = System.Drawing.Color.White;
            this.lblHoTenKhachHang.Location = new System.Drawing.Point(480, 47);
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
            this.lblDiaChi.Location = new System.Drawing.Point(480, 85);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(66, 24);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtSoLuongTonToiThieu
            // 
            this.txtSoLuongTonToiThieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuongTonToiThieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuongTonToiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTonToiThieu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoLuongTonToiThieu.Location = new System.Drawing.Point(796, 9);
            this.txtSoLuongTonToiThieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongTonToiThieu.Name = "txtSoLuongTonToiThieu";
            this.txtSoLuongTonToiThieu.ReadOnly = true;
            this.txtSoLuongTonToiThieu.Size = new System.Drawing.Size(133, 22);
            this.txtSoLuongTonToiThieu.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtDiaChi.Location = new System.Drawing.Point(561, 87);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(367, 27);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(661, 50);
            this.txtHoTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(265, 27);
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
            this.panelTitle.Size = new System.Drawing.Size(1383, 89);
            this.panelTitle.TabIndex = 9;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.labelTitle.Location = new System.Drawing.Point(500, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(373, 58);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Lập hóa đơn bán sách";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.btnLapHoaDon);
            this.panel1.Controls.Add(this.txtTienThua);
            this.panel1.Controls.Add(this.None);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtKhachTra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 593);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 88);
            this.panel1.TabIndex = 22;
            // 
            // FormLapHoaDonBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1383, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelHandle);
            this.Controls.Add(this.panelTitle);
            this.Location = new System.Drawing.Point(1648, 906);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1680, 728);
            this.Name = "FormLapHoaDonBanSach";
            this.Text = "Lập hóa đơn bán sách";
            this.Load += new System.EventHandler(this.FormLapHoaDonBanSach_Load);
            this.panelData.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelHandle.ResumeLayout(false);
            this.panelHandle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelHandle;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Label lblHoTenKhachHang;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTenKhachHang;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lblSoLuongTonToiThieu;
        private System.Windows.Forms.TextBox txtSoLuongTonToiThieu;
        private System.Windows.Forms.Label lblSoTienNoToiDa;
        private System.Windows.Forms.TextBox txtSoTienNoToiDa;
        private System.Windows.Forms.TextBox txtSoTienNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label None;
        private System.Windows.Forms.ListView dgvHoaDon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Button btnChiTietHD;
        private System.Windows.Forms.ListView dgvChiTietHoaDon;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtKhachTra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}