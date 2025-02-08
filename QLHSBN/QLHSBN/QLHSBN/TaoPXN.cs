using QLHSBN.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSBN
{
    public partial class TaoPXN : Form
    {
        public TaoPXN()
        {
            InitializeComponent();
            cbb_trangthai.SelectedIndex = 0;
        }
        common cm = new common();
        private void TaoPXN_Load(object sender, EventArgs e)
        {
            load_data();
            cbb_xn.SelectionChangeCommitted += cbb_xn_SelectionChangeCommitted;
            // 0 la hủy, 1 chưa thu tiền, 2 đã thu tiền
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã phiếu";
            dataGridView1.Columns[2].HeaderText = "Hồ sơ bệnh nhân";
            dataGridView1.Columns[3].HeaderText = "Dịch vụ";
            dataGridView1.Columns[4].HeaderText = "Người tạo";
            dataGridView1.Columns[5].HeaderText = "Kết quả";
            dataGridView1.Columns[6].HeaderText = "Ngày tạo";
            dataGridView1.Columns[7].HeaderText = "Trạng thái";
        }
        private void load_data()
        {
           
            string query = @"Select * from view_phieuxetnghiem";
            dataGridView1.DataSource = cm.load_data_query(query);

            string _que = @"select hs_id, hoten, cccd from view_hsbn where trangthai = N'Đang nhập viện'";
            cbb_hs.DataSource = cm.load_data_query(_que);
            cbb_hs.DisplayMember = "hoten";
            cbb_hs.ValueMember = "hs_id";

            string _que_ = @"select ten_dichvu, dichvu_id, gia_dichvu from view_dichvu where trangthai= N'Đang hoạt động'";
            cbb_xn.DataSource = cm.load_data_query(_que_);
            cbb_xn.DisplayMember = "ten_dichvu";
            cbb_xn.ValueMember = "dichvu_id";

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            var kq = txt_kq.Text;
            var mahs = cbb_hs.SelectedValue;
            var dichvu = cbb_xn.SelectedValue;
            var code = txt_maphieu.Text;
            if (kq == "" || code == "" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_kq.Focus();
            }
            else if(cm.CheckDuplicate("phieuxetnghiem", "ma_phieu", code) == true)
            {
                MessageBox.Show("Mã phiếu này đã có rồi");
                txt_maphieu.Focus();
            }    
            else
            {
                string query = @"insert into phieuxetnghiem (ma_phieu, hs_id, dichvu_id, ketqua, ngaytao, nhanvien_id, trangthai)  values (@ma_phieu, @mahs ,@dichvu, @kq, @ngaytao, @manv, 1) ";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            Session.user_id = 1;
                            command.Parameters.AddWithValue("@ma_phieu", code);
                            command.Parameters.AddWithValue("@mahs", mahs);
                            command.Parameters.AddWithValue("@dichvu", dichvu);
                            command.Parameters.AddWithValue("@kq", kq);
                            command.Parameters.AddWithValue("@ngaytao", DateTime.Now.Date);
                            command.Parameters.AddWithValue("@manv", Session.user_id);
                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_data();
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var kq = txt_kq.Text;
            var mahs = cbb_hs.SelectedValue;
            var dichvu = cbb_xn.SelectedValue;
            var code = txt_maphieu.Text;
            if (kq == "" || code == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_kq.Focus();
            }
            else if (cm.Checktripple("phieuxetnghiem", "ma_phieu", code) == true)
            {
                MessageBox.Show("Mã phiếu này đã có rồi");
                txt_maphieu.Focus();
            }
            else
            {
                string query = @"update phieuxetnghiem set hs_id = @mahs, dichvu_id = @dichvu, ketqua = @kq ";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ma_phieu", code);
                            command.Parameters.AddWithValue("@mahs", mahs);
                            command.Parameters.AddWithValue("@dichvu", dichvu);
                            command.Parameters.AddWithValue("@kq", kq);
                            command.Parameters.AddWithValue("@ngaytao", DateTime.Now.Date);
                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_data();
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Gán giá trị từ cột 0 và cột 1 vào các TextBox
                txt_maphieu.Text = selectedRow.Cells[1].Value?.ToString(); // Cột 1
                cbb_hs.Text = selectedRow.Cells[2].Value?.ToString(); // Cột 2
                cbb_xn.Text = selectedRow.Cells[3].Value?.ToString(); // Cột 3
                txt_kq.Text = selectedRow.Cells[4].Value?.ToString(); // Cột 4
            }
        }


        private void cbb_xn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = cm.load_data_table("dichvu");

            // Kiểm tra nếu DataTable có dữ liệu
            if (dt != null && dt.Rows.Count > 0)
            {
                lb_price.Text = dt.Rows[3]["Gia_dichvu"]?.ToString() + " VND";
            }
            
        }

        private void cbb_hs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = cm.load_data_table("hsbn");

            // Kiểm tra nếu DataTable có dữ liệu
            if (dt != null && dt.Rows.Count > 0)
            {
                lb_cccd.Text = dt.Rows[3]["CCCD"]?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thutien_Click(object sender, EventArgs e)
        {
            var code = txt_maphieu.Text;
            if (code != "")
            {
                DialogResult result = MessageBox.Show("Xác nhận đã thu tiền?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE phieuxetnghiem SET trangthai = 2 WHERE ma_phieu = @ma_phieu";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(cm.connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Sử dụng tham số hóa để tránh SQL Injection
                                command.Parameters.AddWithValue("@ma_phieu", code);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    load_data();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy thông tin cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbb_trangthai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbb_trangthai.Text == "Đã thu tiền")
            {
                dataGridView1.DataSource = cm.load_data_query("select * from view_phieuxetnghiem where trangthai = N'Đã thu tiền'");
            }
            else if (cbb_trangthai.Text == "Chưa thu tiền")
            {
                dataGridView1.DataSource = cm.load_data_query("select * from view_phieuxetnghiem where trangthai = N'Chưa thu tiền'");
            }
            
            else
            {
                load_data();
            }    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbb_hs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
