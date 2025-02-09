
namespace QLHSBN
{
    partial class PhieuThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbBenhNhan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoNgayPhongThuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGiaPhongThuong = new System.Windows.Forms.TextBox();
            this.txtTongTienPhongThuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoNgayPhongDichVu = new System.Windows.Forms.TextBox();
            this.txtDonGiaPhongDichVu = new System.Windows.Forms.TextBox();
            this.txtTongTienPhongDichVu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTongTienDichVu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSPhieuThu = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuThu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu thu";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bệnh nhân:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng tiền phòng thường:";
            // 
            // cbbBenhNhan
            // 
            this.cbbBenhNhan.FormattingEnabled = true;
            this.cbbBenhNhan.Location = new System.Drawing.Point(101, 50);
            this.cbbBenhNhan.Name = "cbbBenhNhan";
            this.cbbBenhNhan.Size = new System.Drawing.Size(283, 21);
            this.cbbBenhNhan.TabIndex = 18;
            this.cbbBenhNhan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbbBenhNhan.SelectionChangeCommitted += new System.EventHandler(this.cbbBenhNhan_SelectionChangeCommitted);
            this.cbbBenhNhan.SelectedValueChanged += new System.EventHandler(this.cbbBenhNhan_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(278, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "=";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoNgayPhongThuong
            // 
            this.txtSoNgayPhongThuong.Enabled = false;
            this.txtSoNgayPhongThuong.Location = new System.Drawing.Point(122, 106);
            this.txtSoNgayPhongThuong.Name = "txtSoNgayPhongThuong";
            this.txtSoNgayPhongThuong.Size = new System.Drawing.Size(37, 20);
            this.txtSoNgayPhongThuong.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(165, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDonGiaPhongThuong
            // 
            this.txtDonGiaPhongThuong.Enabled = false;
            this.txtDonGiaPhongThuong.Location = new System.Drawing.Point(185, 106);
            this.txtDonGiaPhongThuong.Name = "txtDonGiaPhongThuong";
            this.txtDonGiaPhongThuong.Size = new System.Drawing.Size(87, 20);
            this.txtDonGiaPhongThuong.TabIndex = 19;
            // 
            // txtTongTienPhongThuong
            // 
            this.txtTongTienPhongThuong.Enabled = false;
            this.txtTongTienPhongThuong.Location = new System.Drawing.Point(297, 106);
            this.txtTongTienPhongThuong.Name = "txtTongTienPhongThuong";
            this.txtTongTienPhongThuong.Size = new System.Drawing.Size(87, 20);
            this.txtTongTienPhongThuong.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "vnđ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tổng tiền phòng dịch vụ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(278, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "=";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(165, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "vnđ";
            // 
            // txtSoNgayPhongDichVu
            // 
            this.txtSoNgayPhongDichVu.Enabled = false;
            this.txtSoNgayPhongDichVu.Location = new System.Drawing.Point(122, 167);
            this.txtSoNgayPhongDichVu.Name = "txtSoNgayPhongDichVu";
            this.txtSoNgayPhongDichVu.Size = new System.Drawing.Size(37, 20);
            this.txtSoNgayPhongDichVu.TabIndex = 19;
            // 
            // txtDonGiaPhongDichVu
            // 
            this.txtDonGiaPhongDichVu.Enabled = false;
            this.txtDonGiaPhongDichVu.Location = new System.Drawing.Point(185, 167);
            this.txtDonGiaPhongDichVu.Name = "txtDonGiaPhongDichVu";
            this.txtDonGiaPhongDichVu.Size = new System.Drawing.Size(87, 20);
            this.txtDonGiaPhongDichVu.TabIndex = 19;
            // 
            // txtTongTienPhongDichVu
            // 
            this.txtTongTienPhongDichVu.Enabled = false;
            this.txtTongTienPhongDichVu.Location = new System.Drawing.Point(297, 167);
            this.txtTongTienPhongDichVu.Name = "txtTongTienPhongDichVu";
            this.txtTongTienPhongDichVu.Size = new System.Drawing.Size(87, 20);
            this.txtTongTienPhongDichVu.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Số ngày: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Số ngày: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Tổng tiền dịch vụ:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(215, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "vnđ";
            // 
            // txtTongTienDichVu
            // 
            this.txtTongTienDichVu.Enabled = false;
            this.txtTongTienDichVu.Location = new System.Drawing.Point(122, 202);
            this.txtTongTienDichVu.Name = "txtTongTienDichVu";
            this.txtTongTienDichVu.Size = new System.Drawing.Size(87, 20);
            this.txtTongTienDichVu.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSPhieuThu);
            this.groupBox1.Location = new System.Drawing.Point(12, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 207);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu thu";
            // 
            // dgvDSPhieuThu
            // 
            this.dgvDSPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuThu.Location = new System.Drawing.Point(6, 19);
            this.dgvDSPhieuThu.Name = "dgvDSPhieuThu";
            this.dgvDSPhieuThu.Size = new System.Drawing.Size(588, 182);
            this.dgvDSPhieuThu.TabIndex = 0;
            this.dgvDSPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieuThu_CellClick);
            this.dgvDSPhieuThu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDSPhieuThu_MouseDoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(323, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tổng tiền phiếu thu:";
            this.label13.Click += new System.EventHandler(this.label16_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(586, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "vnđ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(468, 205);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(112, 20);
            this.txtTongTien.TabIndex = 19;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(428, 167);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 27);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(6, 19);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(178, 84);
            this.rtxtGhiChu.TabIndex = 22;
            this.rtxtGhiChu.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtGhiChu);
            this.groupBox2.Location = new System.Drawing.Point(422, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 115);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ghi chú";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // PhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTongTienDichVu);
            this.Controls.Add(this.txtTongTienPhongDichVu);
            this.Controls.Add(this.txtTongTienPhongThuong);
            this.Controls.Add(this.txtDonGiaPhongDichVu);
            this.Controls.Add(this.txtSoNgayPhongDichVu);
            this.Controls.Add(this.txtDonGiaPhongThuong);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSoNgayPhongThuong);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbBenhNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhieuThu";
            this.ShowInTaskbar = false;
            this.Text = "PhieuThu";
            this.Load += new System.EventHandler(this.PhieuThu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuThu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbBenhNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoNgayPhongThuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGiaPhongThuong;
        private System.Windows.Forms.TextBox txtTongTienPhongThuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoNgayPhongDichVu;
        private System.Windows.Forms.TextBox txtDonGiaPhongDichVu;
        private System.Windows.Forms.TextBox txtTongTienPhongDichVu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTongTienDichVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSPhieuThu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}