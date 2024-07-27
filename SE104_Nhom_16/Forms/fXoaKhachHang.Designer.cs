
using System.Windows.Forms;

namespace SE104_Nhom_16
{
    partial class frmXoaKhachHang
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F));
            this.btnXoa = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.dgvXoaSach = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Bahnschrift", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(135, 393);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 41);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa khách hàng";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // fThoat
            // 
            this.fThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.fThoat.FlatAppearance.BorderSize = 0;
            this.fThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fThoat.Font = new System.Drawing.Font("Bahnschrift", 12.2F, System.Drawing.FontStyle.Bold);
            this.fThoat.ForeColor = System.Drawing.Color.Black;
            this.fThoat.Location = new System.Drawing.Point(655, 393);
            this.fThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(168, 41);
            this.fThoat.TabIndex = 14;
            this.fThoat.Text = "Thoát";
            this.fThoat.UseVisualStyleBackColor = false;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // dgvXoaSach
            // 
            this.dgvXoaSach.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXoaSach.FullRowSelect = true;
            this.dgvXoaSach.GridLines = true;
            this.dgvXoaSach.HideSelection = false;
            this.dgvXoaSach.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.dgvXoaSach.Location = new System.Drawing.Point(27, 21);
            this.dgvXoaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvXoaSach.Name = "dgvXoaSach";
            this.dgvXoaSach.Size = new System.Drawing.Size(920, 352);
            this.dgvXoaSach.TabIndex = 15;
            this.dgvXoaSach.UseCompatibleStateImageBehavior = false;
            this.dgvXoaSach.View = System.Windows.Forms.View.Details;
            // 
            // frmXoaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(972, 447);
            this.Controls.Add(this.dgvXoaSach);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.btnXoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmXoaKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XÓA KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmXoaSach_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.ListView dgvXoaSach;


    }
}