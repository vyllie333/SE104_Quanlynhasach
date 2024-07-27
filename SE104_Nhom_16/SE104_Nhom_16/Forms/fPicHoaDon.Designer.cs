
namespace SE104_Nhom_16.Forms
{
    partial class frmBaoCaoHoaDon
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblLoiNhuan = new System.Windows.Forms.Label();
            this.txtKhachTra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 10);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(763, 249);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.White;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(53, 309);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(83, 24);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "Tổng tiền:";
            this.lblTongDoanhThu.Click += new System.EventHandler(this.lblTongDoanhThu_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.SystemColors.Window;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.Location = new System.Drawing.Point(147, 308);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(216, 25);
            this.txtTongTien.TabIndex = 2;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txbTongDoanhThu_TextChanged);
            // 
            // lblLoiNhuan
            // 
            this.lblLoiNhuan.AutoSize = true;
            this.lblLoiNhuan.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoiNhuan.ForeColor = System.Drawing.Color.White;
            this.lblLoiNhuan.Location = new System.Drawing.Point(445, 274);
            this.lblLoiNhuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoiNhuan.Name = "lblLoiNhuan";
            this.lblLoiNhuan.Size = new System.Drawing.Size(90, 24);
            this.lblLoiNhuan.TabIndex = 3;
            this.lblLoiNhuan.Text = "Khách trả:";
            // 
            // txtKhachTra
            // 
            this.txtKhachTra.BackColor = System.Drawing.SystemColors.Window;
            this.txtKhachTra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKhachTra.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.txtKhachTra.ForeColor = System.Drawing.Color.Black;
            this.txtKhachTra.Location = new System.Drawing.Point(553, 274);
            this.txtKhachTra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtKhachTra.Name = "txtKhachTra";
            this.txtKhachTra.Size = new System.Drawing.Size(216, 25);
            this.txtKhachTra.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Khách hàng:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKhachHang.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.txtKhachHang.ForeColor = System.Drawing.Color.Black;
            this.txtKhachHang.Location = new System.Drawing.Point(147, 276);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(216, 25);
            this.txtKhachHang.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(440, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tiền trả lại:";
            // 
            // txtTienThua
            // 
            this.txtTienThua.BackColor = System.Drawing.SystemColors.Window;
            this.txtTienThua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienThua.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.txtTienThua.ForeColor = System.Drawing.Color.Black;
            this.txtTienThua.Location = new System.Drawing.Point(553, 306);
            this.txtTienThua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(216, 25);
            this.txtTienThua.TabIndex = 9;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLuuHD.FlatAppearance.BorderSize = 0;
            this.btnLuuHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHD.Font = new System.Drawing.Font("Bahnschrift", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnLuuHD.ForeColor = System.Drawing.Color.Black;
            this.btnLuuHD.Location = new System.Drawing.Point(323, 346);
            this.btnLuuHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(141, 34);
            this.btnLuuHD.TabIndex = 10;
            this.btnLuuHD.Text = "Lưu ";
            this.btnLuuHD.UseVisualStyleBackColor = false;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // frmBaoCaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(820, 412);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.txtTienThua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKhachTra);
            this.Controls.Add(this.lblLoiNhuan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmBaoCaoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblLoiNhuan;
        private System.Windows.Forms.TextBox txtKhachTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.Button btnLuuHD;
    }
}