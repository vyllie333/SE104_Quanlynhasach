namespace SE104_Nhom_16.Forms
{
    partial class FormLapPhieuNhapSach
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHandle = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.txtSoLuongTonToiDa = new System.Windows.Forms.TextBox();
            this.lblSoLuongTonToiDa = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSoLuongNhap = new System.Windows.Forms.Label();
            this.txtSoLuongNhapItNhat = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.lblSoLuongNhapItNhat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.listPhieuNhap = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.panelHandle.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panelData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1383, 71);
            this.panelTitle.TabIndex = 6;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.labelTitle.Location = new System.Drawing.Point(462, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(353, 58);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Lập phiếu nhập sách";
            // 
            // panelHandle
            // 
            this.panelHandle.Controls.Add(this.panel4);
            this.panelHandle.Controls.Add(this.panel3);
            this.panelHandle.Controls.Add(this.panel2);
            this.panelHandle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHandle.Location = new System.Drawing.Point(0, 71);
            this.panelHandle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHandle.Name = "panelHandle";
            this.panelHandle.Size = new System.Drawing.Size(1383, 113);
            this.panelHandle.TabIndex = 7;
            this.panelHandle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHandle_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.panel4.Controls.Add(this.btnThemPhieu);
            this.panel4.Controls.Add(this.txtSoLuongTonToiDa);
            this.panel4.Controls.Add(this.lblSoLuongTonToiDa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(890, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 113);
            this.panel4.TabIndex = 10;
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnThemPhieu.FlatAppearance.BorderSize = 0;
            this.btnThemPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhieu.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhieu.ForeColor = System.Drawing.Color.Black;
            this.btnThemPhieu.Location = new System.Drawing.Point(23, 57);
            this.btnThemPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(171, 31);
            this.btnThemPhieu.TabIndex = 10;
            this.btnThemPhieu.Text = "Thêm vào phiếu";
            this.btnThemPhieu.UseVisualStyleBackColor = false;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // txtSoLuongTonToiDa
            // 
            this.txtSoLuongTonToiDa.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuongTonToiDa.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtSoLuongTonToiDa.Location = new System.Drawing.Point(328, 25);
            this.txtSoLuongTonToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongTonToiDa.Name = "txtSoLuongTonToiDa";
            this.txtSoLuongTonToiDa.ReadOnly = true;
            this.txtSoLuongTonToiDa.Size = new System.Drawing.Size(145, 27);
            this.txtSoLuongTonToiDa.TabIndex = 3;
            this.txtSoLuongTonToiDa.TextChanged += new System.EventHandler(this.txtSoLuongTonToiDa_TextChanged);
            // 
            // lblSoLuongTonToiDa
            // 
            this.lblSoLuongTonToiDa.AutoSize = true;
            this.lblSoLuongTonToiDa.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTonToiDa.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongTonToiDa.Location = new System.Drawing.Point(19, 21);
            this.lblSoLuongTonToiDa.Name = "lblSoLuongTonToiDa";
            this.lblSoLuongTonToiDa.Size = new System.Drawing.Size(279, 24);
            this.lblSoLuongTonToiDa.TabIndex = 1;
            this.lblSoLuongTonToiDa.Text = "Số lượng tồn tối đa trước khi nhập:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.panel3.Controls.Add(this.lblSoLuongNhap);
            this.panel3.Controls.Add(this.txtSoLuongNhapItNhat);
            this.panel3.Controls.Add(this.txtSoLuongNhap);
            this.panel3.Controls.Add(this.lblSoLuongNhapItNhat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(391, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(992, 113);
            this.panel3.TabIndex = 10;
            // 
            // lblSoLuongNhap
            // 
            this.lblSoLuongNhap.AutoSize = true;
            this.lblSoLuongNhap.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongNhap.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongNhap.Location = new System.Drawing.Point(67, 66);
            this.lblSoLuongNhap.Name = "lblSoLuongNhap";
            this.lblSoLuongNhap.Size = new System.Drawing.Size(126, 24);
            this.lblSoLuongNhap.TabIndex = 8;
            this.lblSoLuongNhap.Text = "Số lượng nhập:";
            this.lblSoLuongNhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoLuongNhapItNhat
            // 
            this.txtSoLuongNhapItNhat.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuongNhapItNhat.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtSoLuongNhapItNhat.Location = new System.Drawing.Point(223, 22);
            this.txtSoLuongNhapItNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongNhapItNhat.Name = "txtSoLuongNhapItNhat";
            this.txtSoLuongNhapItNhat.ReadOnly = true;
            this.txtSoLuongNhapItNhat.Size = new System.Drawing.Size(159, 27);
            this.txtSoLuongNhapItNhat.TabIndex = 3;
            this.txtSoLuongNhapItNhat.TextChanged += new System.EventHandler(this.txtSoLuongNhapItNhat_TextChanged);
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(223, 66);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(159, 27);
            this.txtSoLuongNhap.TabIndex = 9;
            this.txtSoLuongNhap.TextChanged += new System.EventHandler(this.txtSoLuongNhap_TextChanged);
            // 
            // lblSoLuongNhapItNhat
            // 
            this.lblSoLuongNhapItNhat.AutoSize = true;
            this.lblSoLuongNhapItNhat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongNhapItNhat.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongNhapItNhat.Location = new System.Drawing.Point(11, 18);
            this.lblSoLuongNhapItNhat.Name = "lblSoLuongNhapItNhat";
            this.lblSoLuongNhapItNhat.Size = new System.Drawing.Size(181, 24);
            this.lblSoLuongNhapItNhat.TabIndex = 1;
            this.lblSoLuongNhapItNhat.Text = "Số lượng nhập ít nhất:";
            this.lblSoLuongNhapItNhat.Click += new System.EventHandler(this.lblSoLuongNhapItNhat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.panel2.Controls.Add(this.lblNgayNhap);
            this.panel2.Controls.Add(this.txtMaSach);
            this.panel2.Controls.Add(this.lblMaSach);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btnTimSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 113);
            this.panel2.TabIndex = 1;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.ForeColor = System.Drawing.Color.White;
            this.lblNgayNhap.Location = new System.Drawing.Point(26, 21);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(95, 24);
            this.lblNgayNhap.TabIndex = 1;
            this.lblNgayNhap.Text = "Ngày nhập:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSach.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(149, 68);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(115, 27);
            this.txtMaSach.TabIndex = 3;
            this.txtMaSach.TextChanged += new System.EventHandler(this.txtMaSach_TextChanged);
            // 
            // lblMaSach
            // 
            this.lblMaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.ForeColor = System.Drawing.Color.White;
            this.lblMaSach.Location = new System.Drawing.Point(43, 64);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(77, 24);
            this.lblMaSach.TabIndex = 1;
            this.lblMaSach.Text = "Mã sách:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 22);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnTimSach
            // 
            this.btnTimSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnTimSach.FlatAppearance.BorderSize = 0;
            this.btnTimSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimSach.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSach.ForeColor = System.Drawing.Color.Black;
            this.btnTimSach.Location = new System.Drawing.Point(275, 65);
            this.btnTimSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(99, 31);
            this.btnTimSach.TabIndex = 4;
            this.btnTimSach.Text = "Tìm sách";
            this.btnTimSach.UseVisualStyleBackColor = false;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.Color.DarkGreen;
            this.dataGridView3.Location = new System.Drawing.Point(13, 7);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1358, 84);
            this.dataGridView3.TabIndex = 7;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLapPhieu.FlatAppearance.BorderSize = 0;
            this.btnLapPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieu.Font = new System.Drawing.Font("Bahnschrift", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnLapPhieu.ForeColor = System.Drawing.Color.Black;
            this.btnLapPhieu.Location = new System.Drawing.Point(187, 14);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(155, 34);
            this.btnLapPhieu.TabIndex = 4;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.panelData.Controls.Add(this.dataGridView3);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData.Location = new System.Drawing.Point(0, 184);
            this.panelData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1383, 101);
            this.panelData.TabIndex = 8;
            this.panelData.Paint += new System.Windows.Forms.PaintEventHandler(this.panelData_Paint);
            // 
            // listPhieuNhap
            // 
            this.listPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listPhieuNhap.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPhieuNhap.ForeColor = System.Drawing.Color.Black;
            this.listPhieuNhap.HideSelection = false;
            this.listPhieuNhap.Location = new System.Drawing.Point(13, 57);
            this.listPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.listPhieuNhap.Name = "listPhieuNhap";
            this.listPhieuNhap.Size = new System.Drawing.Size(1357, 310);
            this.listPhieuNhap.TabIndex = 9;
            this.listPhieuNhap.UseCompatibleStateImageBehavior = false;
            this.listPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.listPhieuNhap_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phiếu nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.listPhieuNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLapPhieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 396);
            this.panel1.TabIndex = 11;
            // 
            // FormLapPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1383, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelHandle);
            this.Controls.Add(this.panelTitle);
            this.Location = new System.Drawing.Point(1648, 906);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1680, 728);
            this.Name = "FormLapPhieuNhapSach";
            this.Text = "Lập phiếu nhập sách";
            this.Load += new System.EventHandler(this.FormLapPhieuNhapSach_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelHandle.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelHandle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label lblSoLuongNhapItNhat;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblSoLuongTonToiDa;
        private System.Windows.Forms.TextBox txtSoLuongTonToiDa;
        private System.Windows.Forms.TextBox txtSoLuongNhapItNhat;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblSoLuongNhap;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.ListView listPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}