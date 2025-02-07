using QLHSBN.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSBN
{
    public partial class Home : Form
    {
        private string userRole;
        common cm = new common();
        public Home(string rule)
        {
            InitializeComponent();
            userRole = rule;
        }
        private void load_bn_nhapvien()
        {
            string query = @"select * from  view_hsbn  where Trang_thai = N'Đang nhập viện'";
            dataGridView1.DataSource = cm.load_data_query(query);
        }
        private void load_bn_kham()
        {
            string query = @"select * from  view_hsbn  where Trang_thai = N'Đang sử dụng'";
            dataGridView1.DataSource = cm.load_data_query(query);
        }
        private void load_phongkham()
        {
            string query = @"Select * from view_phongkham where trangthai = N'Đang hoạt động'";
            cbb_phongkham.DataSource = cm.load_data_query(query);
        }
        private void Home_Load(object sender, EventArgs e)
        {
            load_bn_nhapvien();
            load_phongkham();
            load_bn_kham();
            cbb_filter.SelectedIndex = 0;
            if(userRole == "Y tá")
            {
                thanhToánToolStripMenuItem.Visible = false;
                hồSơKhámBệnhToolStripMenuItem.Visible = false;
                bácSỉToolStripMenuItem.Visible = false;
            }  
            else if(userRole == "Thu ngân")
            {
                xétNghiệmToolStripMenuItem.Visible = false;
                dịchVụToolStripMenuItem.Visible = false;
                phòngKhámToolStripMenuItem.Visible = false;
                bácSỉToolStripMenuItem.Visible = false;
            }
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã hồ sơ";
            dataGridView1.Columns[2].HeaderText = "Họ Tên";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Số bảo hiểm";
            dataGridView1.Columns[5].HeaderText = "Số điện thoại";
            dataGridView1.Columns[6].HeaderText = "Căn cước";
            dataGridView1.Columns[7].HeaderText = "Địa chỉ";
            dataGridView1.Columns[8].HeaderText = "Giới tính";
            dataGridView1.Columns[9].HeaderText = "Ngày tạo";
            dataGridView1.Columns[10].HeaderText = "Người tạo";
            dataGridView1.Columns[11].HeaderText = "Trạng thái";
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            var search = txt_search.Text;
            if (txt_search.Text != "")
            {
                if(cbb_filter.Text == "Tên bệnh nhân")
                {
                    // 0 = khóa , 1 = hoạt động, 2 = đang khám, 3 nhập viện
                    string query = @"select * from view_hsbn where hoten like '%" + search + "%' and Trang_thai = N'Đang nhập viện'";
                    dataGridView1.DataSource = cm.load_data_query(query);
                }
                else if(cbb_filter.Text == "Căn cước công dân")
                {
                    string query = @"select * from view_hsbn where cccd like '%" + search + "%' and Trang_thai = N'Đang nhập viện'";
                    dataGridView1.DataSource = cm.load_data_query(query);
                }
                else if(cbb_filter.Text == "Số điện thoại")
                {
                    string query = @"select * from view_hsbn where sdt like '%" + search + "%' and Trang_thai = N'Đang nhập viện'";
                    dataGridView1.DataSource = cm.load_data_query(query);
                }
            }   
            else
            {
                load_bn_nhapvien();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            load_bn_kham();
        }

      

        private void bácSỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.ShowDialog();
        }

        private void tạoHồSơMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hsbn hsm = new Hsbn();
            hsm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void danhSáchĐăngKýKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSDangKyKham hsdk = new HSDangKyKham();
            hsdk.ShowDialog();
        }
    }
}
