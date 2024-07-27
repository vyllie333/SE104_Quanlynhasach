
namespace SE104_Nhom_16
{
    partial class frmSuaSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.lblTenLinhVuc = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.lblMaLoaiSach = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numericUpDownGiaMua = new System.Windows.Forms.NumericUpDown();
            this.lblGiaMua = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvSuaSach = new System.Windows.Forms.ListView();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.NoteForUser = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaMua)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenSach);
            this.panel1.Controls.Add(this.lblTenSach);
            this.panel1.Location = new System.Drawing.Point(49, 412);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 32);
            this.panel1.TabIndex = 4;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(99, 5);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(239, 26);
            this.txtTenSach.TabIndex = 1;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTenSach.ForeColor = System.Drawing.Color.White;
            this.lblTenSach.Location = new System.Drawing.Point(5, 4);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(79, 21);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTheLoai);
            this.panel4.Controls.Add(this.lblTenLinhVuc);
            this.panel4.Location = new System.Drawing.Point(503, 356);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 32);
            this.panel4.TabIndex = 6;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(133, 5);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(184, 26);
            this.txtTheLoai.TabIndex = 3;
            // 
            // lblTenLinhVuc
            // 
            this.lblTenLinhVuc.AutoSize = true;
            this.lblTenLinhVuc.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTenLinhVuc.ForeColor = System.Drawing.Color.White;
            this.lblTenLinhVuc.Location = new System.Drawing.Point(5, 5);
            this.lblTenLinhVuc.Name = "lblTenLinhVuc";
            this.lblTenLinhVuc.Size = new System.Drawing.Size(72, 21);
            this.lblTenLinhVuc.TabIndex = 0;
            this.lblTenLinhVuc.Text = "Thể loại:";
            this.lblTenLinhVuc.Click += new System.EventHandler(this.lblTenLinhVuc_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtSoLuongTon);
            this.panel9.Controls.Add(this.lblMaLoaiSach);
            this.panel9.Location = new System.Drawing.Point(503, 414);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(336, 31);
            this.panel9.TabIndex = 7;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(133, 4);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(184, 26);
            this.txtSoLuongTon.TabIndex = 4;
            this.txtSoLuongTon.TextChanged += new System.EventHandler(this.txtSoLuongTon_TextChanged);
            // 
            // lblMaLoaiSach
            // 
            this.lblMaLoaiSach.AutoSize = true;
            this.lblMaLoaiSach.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMaLoaiSach.ForeColor = System.Drawing.Color.White;
            this.lblMaLoaiSach.Location = new System.Drawing.Point(5, 2);
            this.lblMaLoaiSach.Name = "lblMaLoaiSach";
            this.lblMaLoaiSach.Size = new System.Drawing.Size(110, 21);
            this.lblMaLoaiSach.TabIndex = 0;
            this.lblMaLoaiSach.Text = "Số lượng tồn:";
            this.lblMaLoaiSach.Click += new System.EventHandler(this.lblMaLoaiSach_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.numericUpDownGiaMua);
            this.panel5.Controls.Add(this.lblGiaMua);
            this.panel5.Location = new System.Drawing.Point(503, 471);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(335, 32);
            this.panel5.TabIndex = 8;
            // 
            // numericUpDownGiaMua
            // 
            this.numericUpDownGiaMua.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownGiaMua.Location = new System.Drawing.Point(133, 5);
            this.numericUpDownGiaMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownGiaMua.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownGiaMua.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownGiaMua.Name = "numericUpDownGiaMua";
            this.numericUpDownGiaMua.Size = new System.Drawing.Size(184, 26);
            this.numericUpDownGiaMua.TabIndex = 5;
            this.numericUpDownGiaMua.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblGiaMua
            // 
            this.lblGiaMua.AutoSize = true;
            this.lblGiaMua.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblGiaMua.ForeColor = System.Drawing.Color.White;
            this.lblGiaMua.Location = new System.Drawing.Point(5, 2);
            this.lblGiaMua.Name = "lblGiaMua";
            this.lblGiaMua.Size = new System.Drawing.Size(76, 21);
            this.lblGiaMua.TabIndex = 0;
            this.lblGiaMua.Text = "Giá mua:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Bahnschrift", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(365, 510);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(217, 37);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.bbLuu_Click);
            // 
            // dgvSuaSach
            // 
            this.dgvSuaSach.Font = new System.Drawing.Font("Bahnschrift", 10.8F);
            this.dgvSuaSach.HideSelection = false;
            this.dgvSuaSach.Location = new System.Drawing.Point(36, 11);
            this.dgvSuaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSuaSach.Name = "dgvSuaSach";
            this.dgvSuaSach.Size = new System.Drawing.Size(905, 287);
            this.dgvSuaSach.TabIndex = 16;
            this.dgvSuaSach.UseCompatibleStateImageBehavior = false;
            this.dgvSuaSach.SelectedIndexChanged += new System.EventHandler(this.dgvSuaSach_SelectedIndexChanged);
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTenTacGia.ForeColor = System.Drawing.Color.White;
            this.lblTenTacGia.Location = new System.Drawing.Point(5, 2);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(65, 21);
            this.lblTenTacGia.TabIndex = 0;
            this.lblTenTacGia.Text = "Tác giả:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTacGia);
            this.panel3.Controls.Add(this.lblTenTacGia);
            this.panel3.Location = new System.Drawing.Point(49, 473);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 28);
            this.panel3.TabIndex = 5;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(99, 2);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(239, 26);
            this.txtTacGia.TabIndex = 2;
            // 
            // NoteForUser
            // 
            this.NoteForUser.AutoSize = true;
            this.NoteForUser.BackColor = System.Drawing.SystemColors.Control;
            this.NoteForUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.NoteForUser.Location = new System.Drawing.Point(9, 7);
            this.NoteForUser.Name = "NoteForUser";
            this.NoteForUser.Size = new System.Drawing.Size(0, 24);
            this.NoteForUser.TabIndex = 7;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnChon.FlatAppearance.BorderSize = 0;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Bahnschrift", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnChon.ForeColor = System.Drawing.Color.Black;
            this.btnChon.Location = new System.Drawing.Point(36, 306);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(196, 34);
            this.btnChon.TabIndex = 17;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.bbChon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaSach);
            this.panel2.Controls.Add(this.lblMaSach);
            this.panel2.Location = new System.Drawing.Point(49, 354);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 33);
            this.panel2.TabIndex = 18;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(99, 5);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(239, 22);
            this.txtMaSach.TabIndex = 0;
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMaSach.ForeColor = System.Drawing.Color.White;
            this.lblMaSach.Location = new System.Drawing.Point(5, 4);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(76, 21);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách:";
            // 
            // frmSuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(977, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.NoteForUser);
            this.Controls.Add(this.dgvSuaSach);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSuaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA SÁCH";
            this.Load += new System.EventHandler(this.frmSuaSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaMua)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTenLinhVuc;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblMaLoaiSach;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numericUpDownGiaMua;
        private System.Windows.Forms.Label lblGiaMua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ListView dgvSuaSach;
        private System.Windows.Forms.Label lblTenTacGia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label NoteForUser;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtTacGia;
    }
}