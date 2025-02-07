
namespace QLHSBN
{
    partial class TaoPXN
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
            this.cbb_hs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_xn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_thutien = new System.Windows.Forms.Button();
            this.lb_gia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_cccd = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maphieu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbb_trangthai = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_hs
            // 
            this.cbb_hs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hs.FormattingEnabled = true;
            this.cbb_hs.Location = new System.Drawing.Point(24, 80);
            this.cbb_hs.Name = "cbb_hs";
            this.cbb_hs.Size = new System.Drawing.Size(177, 21);
            this.cbb_hs.TabIndex = 0;
            this.cbb_hs.SelectionChangeCommitted += new System.EventHandler(this.cbb_hs_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn hồ sơ";
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(488, 80);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(250, 20);
            this.txt_kq.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả";
            // 
            // cbb_xn
            // 
            this.cbb_xn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_xn.FormattingEnabled = true;
            this.cbb_xn.Location = new System.Drawing.Point(239, 80);
            this.cbb_xn.Name = "cbb_xn";
            this.cbb_xn.Size = new System.Drawing.Size(184, 21);
            this.cbb_xn.TabIndex = 0;
            this.cbb_xn.SelectionChangeCommitted += new System.EventHandler(this.cbb_xn_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(24, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 397);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu xét nghiệm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(957, 372);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(239, 147);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(184, 40);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa phiếu xét nghiệm";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(30, 147);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(171, 40);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Đăng ký xét nghiệm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_thutien
            // 
            this.btn_thutien.Location = new System.Drawing.Point(630, 147);
            this.btn_thutien.Name = "btn_thutien";
            this.btn_thutien.Size = new System.Drawing.Size(108, 40);
            this.btn_thutien.TabIndex = 16;
            this.btn_thutien.Text = "Đã thu tiền";
            this.btn_thutien.UseVisualStyleBackColor = true;
            this.btn_thutien.Click += new System.EventHandler(this.btn_thutien_Click);
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Location = new System.Drawing.Point(236, 118);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(26, 13);
            this.lb_gia.TabIndex = 1;
            this.lb_gia.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Căn cước:";
            // 
            // lb_cccd
            // 
            this.lb_cccd.AutoSize = true;
            this.lb_cccd.Location = new System.Drawing.Point(89, 118);
            this.lb_cccd.Name = "lb_cccd";
            this.lb_cccd.Size = new System.Drawing.Size(10, 13);
            this.lb_cccd.TabIndex = 1;
            this.lb_cccd.Text = ".";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(268, 118);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(10, 13);
            this.lb_price.TabIndex = 1;
            this.lb_price.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã phiếu xét nghiệm";
            // 
            // txt_maphieu
            // 
            this.txt_maphieu.Location = new System.Drawing.Point(149, 18);
            this.txt_maphieu.Name = "txt_maphieu";
            this.txt_maphieu.Size = new System.Drawing.Size(250, 20);
            this.txt_maphieu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(888, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_trangthai.FormattingEnabled = true;
            this.cbb_trangthai.Items.AddRange(new object[] {
            "===Chọn trạng thái===",
            "Đã thu tiền",
            "Chưa thu tiền",
            "Hủy kết quả"});
            this.cbb_trangthai.Location = new System.Drawing.Point(793, 79);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Size = new System.Drawing.Size(194, 21);
            this.cbb_trangthai.TabIndex = 18;
            this.cbb_trangthai.SelectionChangeCommitted += new System.EventHandler(this.cbb_trangthai_SelectionChangeCommitted);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "In phiếu xét nghiệm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TaoPXN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 622);
            this.Controls.Add(this.cbb_trangthai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_thutien);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_maphieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_cccd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_gia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_xn);
            this.Controls.Add(this.cbb_hs);
            this.Name = "TaoPXN";
            this.Text = "TaoPXN";
            this.Load += new System.EventHandler(this.TaoPXN_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_hs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_xn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_thutien;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_cccd;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maphieu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbb_trangthai;
        private System.Windows.Forms.Button button2;
    }
}