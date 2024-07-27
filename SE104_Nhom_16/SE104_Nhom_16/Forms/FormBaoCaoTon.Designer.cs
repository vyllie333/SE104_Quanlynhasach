namespace SE104_Nhom_16.Forms
{
    partial class FormBaoCaoTon
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
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.lblHoTenKhachHang = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelHandle.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHandle
            // 
            this.panelHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.panelHandle.Controls.Add(this.txtNam);
            this.panelHandle.Controls.Add(this.label1);
            this.panelHandle.Controls.Add(this.btnXuatRaExcel);
            this.panelHandle.Controls.Add(this.btnLapBaoCao);
            this.panelHandle.Controls.Add(this.lblHoTenKhachHang);
            this.panelHandle.Controls.Add(this.txtThang);
            this.panelHandle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHandle.Location = new System.Drawing.Point(0, 92);
            this.panelHandle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHandle.Name = "panelHandle";
            this.panelHandle.Size = new System.Drawing.Size(1662, 159);
            this.panelHandle.TabIndex = 15;
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(801, 33);
            this.txtNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(161, 27);
            this.txtNam.TabIndex = 10;
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(741, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Năm:";
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnXuatRaExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatRaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatRaExcel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatRaExcel.ForeColor = System.Drawing.Color.Black;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(747, 98);
            this.btnXuatRaExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(135, 31);
            this.btnXuatRaExcel.TabIndex = 8;
            this.btnXuatRaExcel.Text = "Xuất ra Excel";
            this.btnXuatRaExcel.UseVisualStyleBackColor = false;
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click_1);
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLapBaoCao.FlatAppearance.BorderSize = 0;
            this.btnLapBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapBaoCao.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapBaoCao.ForeColor = System.Drawing.Color.Black;
            this.btnLapBaoCao.Location = new System.Drawing.Point(544, 98);
            this.btnLapBaoCao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(129, 31);
            this.btnLapBaoCao.TabIndex = 4;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            this.btnLapBaoCao.UseVisualStyleBackColor = false;
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click_1);
            // 
            // lblHoTenKhachHang
            // 
            this.lblHoTenKhachHang.AutoSize = true;
            this.lblHoTenKhachHang.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenKhachHang.ForeColor = System.Drawing.Color.White;
            this.lblHoTenKhachHang.Location = new System.Drawing.Point(424, 36);
            this.lblHoTenKhachHang.Name = "lblHoTenKhachHang";
            this.lblHoTenKhachHang.Size = new System.Drawing.Size(60, 24);
            this.lblHoTenKhachHang.TabIndex = 1;
            this.lblHoTenKhachHang.Text = "Tháng:";
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(511, 34);
            this.txtThang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(161, 27);
            this.txtThang.TabIndex = 3;
            this.txtThang.TextChanged += new System.EventHandler(this.txtThang_TextChanged);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1662, 92);
            this.panelTitle.TabIndex = 14;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.labelTitle.Location = new System.Drawing.Point(555, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(268, 57);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Lập báo cáo tồn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 251);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1662, 430);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1662, 430);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1662, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHandle);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1680, 728);
            this.Name = "FormBaoCaoTon";
            this.Text = "Báo cáo tồn";
            this.Load += new System.EventHandler(this.FormBaoCaoTon_Load);
            this.panelHandle.ResumeLayout(false);
            this.panelHandle.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHandle;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.Button btnLapBaoCao;
        private System.Windows.Forms.Label lblHoTenKhachHang;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label1;
    }
}