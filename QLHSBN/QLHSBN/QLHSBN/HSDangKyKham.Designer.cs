
namespace QLHSBN
{
    partial class HSDangKyKham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mahs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nhapvien = new System.Windows.Forms.Button();
            this.btn_toathuoc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_toathuoc = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 489);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hồ sơ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1115, 464);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cccd);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_hoten);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_mahs);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 125);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hồ sơ";
            // 
            // txt_cccd
            // 
            this.txt_cccd.Location = new System.Drawing.Point(162, 89);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.ReadOnly = true;
            this.txt_cccd.Size = new System.Drawing.Size(100, 20);
            this.txt_cccd.TabIndex = 1;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(21, 89);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.ReadOnly = true;
            this.txt_sdt.Size = new System.Drawing.Size(100, 20);
            this.txt_sdt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "căn cước";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số điện thoại";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(162, 42);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.ReadOnly = true;
            this.txt_hoten.Size = new System.Drawing.Size(100, 20);
            this.txt_hoten.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // txt_mahs
            // 
            this.txt_mahs.Location = new System.Drawing.Point(21, 42);
            this.txt_mahs.Name = "txt_mahs";
            this.txt_mahs.ReadOnly = true;
            this.txt_mahs.Size = new System.Drawing.Size(100, 20);
            this.txt_mahs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hồ sơ";
            // 
            // btn_nhapvien
            // 
            this.btn_nhapvien.Location = new System.Drawing.Point(993, 28);
            this.btn_nhapvien.Name = "btn_nhapvien";
            this.btn_nhapvien.Size = new System.Drawing.Size(146, 23);
            this.btn_nhapvien.TabIndex = 16;
            this.btn_nhapvien.Text = "Nhập viện";
            this.btn_nhapvien.UseVisualStyleBackColor = true;
            // 
            // btn_toathuoc
            // 
            this.btn_toathuoc.Location = new System.Drawing.Point(993, 73);
            this.btn_toathuoc.Name = "btn_toathuoc";
            this.btn_toathuoc.Size = new System.Drawing.Size(146, 23);
            this.btn_toathuoc.TabIndex = 16;
            this.btn_toathuoc.Text = "Đã khám và cho toa thuốc";
            this.btn_toathuoc.UseVisualStyleBackColor = true;
            this.btn_toathuoc.Click += new System.EventHandler(this.btn_toathuoc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_toathuoc);
            this.groupBox3.Location = new System.Drawing.Point(322, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 125);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toa thuốc";
            // 
            // txt_toathuoc
            // 
            this.txt_toathuoc.Location = new System.Drawing.Point(6, 19);
            this.txt_toathuoc.Name = "txt_toathuoc";
            this.txt_toathuoc.Size = new System.Drawing.Size(653, 98);
            this.txt_toathuoc.TabIndex = 18;
            this.txt_toathuoc.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(993, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HSDangKyKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_toathuoc);
            this.Controls.Add(this.btn_nhapvien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HSDangKyKham";
            this.Text = "HSDangKyKham";
            this.Load += new System.EventHandler(this.HSDangKyKham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mahs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nhapvien;
        private System.Windows.Forms.Button btn_toathuoc;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txt_toathuoc;
        private System.Windows.Forms.Button button1;
    }
}