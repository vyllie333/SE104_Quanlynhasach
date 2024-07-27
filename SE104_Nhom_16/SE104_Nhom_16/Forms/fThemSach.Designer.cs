
namespace SE104_Nhom_16
{
    partial class frmThemSach
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
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblMaTacGia = new System.Windows.Forms.Label();
            this.lblTenLinhVuc = new System.Windows.Forms.Label();
            this.numericUpDownGiaMua = new System.Windows.Forms.NumericUpDown();
            this.lblGiaMua = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaMua)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(179, 37);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(349, 22);
            this.txtMaSach.TabIndex = 0;
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMaSach.ForeColor = System.Drawing.Color.White;
            this.lblMaSach.Location = new System.Drawing.Point(56, 37);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(76, 21);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.txtTenSach.Location = new System.Drawing.Point(179, 86);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(349, 26);
            this.txtTenSach.TabIndex = 1;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txbTenSach_TextChanged);
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTenSach.ForeColor = System.Drawing.Color.White;
            this.lblTenSach.Location = new System.Drawing.Point(56, 85);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(79, 21);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // lblMaTacGia
            // 
            this.lblMaTacGia.AutoSize = true;
            this.lblMaTacGia.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMaTacGia.ForeColor = System.Drawing.Color.White;
            this.lblMaTacGia.Location = new System.Drawing.Point(56, 133);
            this.lblMaTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaTacGia.Name = "lblMaTacGia";
            this.lblMaTacGia.Size = new System.Drawing.Size(72, 21);
            this.lblMaTacGia.TabIndex = 0;
            this.lblMaTacGia.Text = "Thể loại:";
            // 
            // lblTenLinhVuc
            // 
            this.lblTenLinhVuc.AutoSize = true;
            this.lblTenLinhVuc.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTenLinhVuc.ForeColor = System.Drawing.Color.White;
            this.lblTenLinhVuc.Location = new System.Drawing.Point(56, 180);
            this.lblTenLinhVuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenLinhVuc.Name = "lblTenLinhVuc";
            this.lblTenLinhVuc.Size = new System.Drawing.Size(65, 21);
            this.lblTenLinhVuc.TabIndex = 0;
            this.lblTenLinhVuc.Text = "Tác giả:";
            // 
            // numericUpDownGiaMua
            // 
            this.numericUpDownGiaMua.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.numericUpDownGiaMua.Location = new System.Drawing.Point(179, 229);
            this.numericUpDownGiaMua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.numericUpDownGiaMua.Size = new System.Drawing.Size(349, 26);
            this.numericUpDownGiaMua.TabIndex = 4;
            this.numericUpDownGiaMua.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownGiaMua.ValueChanged += new System.EventHandler(this.numericUpDownGiaMua_ValueChanged);
            // 
            // lblGiaMua
            // 
            this.lblGiaMua.AutoSize = true;
            this.lblGiaMua.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblGiaMua.ForeColor = System.Drawing.Color.White;
            this.lblGiaMua.Location = new System.Drawing.Point(55, 229);
            this.lblGiaMua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaMua.Name = "lblGiaMua";
            this.lblGiaMua.Size = new System.Drawing.Size(74, 21);
            this.lblGiaMua.TabIndex = 0;
            this.lblGiaMua.Text = "Giá Mua:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Bahnschrift", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(204, 284);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(185, 34);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.txtTheLoai.Location = new System.Drawing.Point(179, 134);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(349, 26);
            this.txtTheLoai.TabIndex = 2;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.txtTacGia.Location = new System.Drawing.Point(179, 181);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(349, 26);
            this.txtTacGia.TabIndex = 3;
            // 
            // frmThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(613, 343);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.lblMaSach);
            this.Controls.Add(this.txtTheLoai);
            this.Controls.Add(this.numericUpDownGiaMua);
            this.Controls.Add(this.lblGiaMua);
            this.Controls.Add(this.lblTenLinhVuc);
            this.Controls.Add(this.lblMaTacGia);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmThemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM SÁCH";
            this.Load += new System.EventHandler(this.frmThemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaMua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblMaTacGia;
        private System.Windows.Forms.Label lblTenLinhVuc;
        private System.Windows.Forms.NumericUpDown numericUpDownGiaMua;
        private System.Windows.Forms.Label lblGiaMua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtTacGia;
    }
}