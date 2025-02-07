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
    public partial class Phieunhapvien : Form
    {
        public Phieunhapvien()
        {
            InitializeComponent();
        }
        common cm = new common();
        private void Phieunhapvien_Load(object sender, EventArgs e)
        {
            dtp_1.MaxDate = DateTime.Now.Date;
            dtp_nhapvien.MaxDate = DateTime.Now.Date;
            dtp_2.MaxDate = DateTime.Now.Date;
            load_data();
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Họ tên bệnh nhân";
            dataGridView1.Columns[2].HeaderText = "Ngày nhập viện";
            dataGridView1.Columns[3].HeaderText = "Tên phòng";
            dataGridView1.Columns[4].HeaderText = "Ngày xuất viện";
            dataGridView1.Columns[5].HeaderText = "Người lập";
            dataGridView1.Columns[6].HeaderText = "Trạng thái";

            

            
        }
        private void load_data()
        {
            string query = @"select * from view_nhapvien";
            dataGridView1.DataSource = cm.load_data_query(query);

            string query2 = @"select * from view_dichvu where trangthai = N'Đang hoạt động'";
            cbb_dichvu.DataSource = cm.load_data_query(query2);
            cbb_dichvu.DisplayMember = "ten_dichvu";
            cbb_dichvu.ValueMember = "dichvu_id";

            string query3 = @"select * from view_hsbn where trangthai != N'Đã khóa' and trangthai != N'Đang nhập viện'";
            cbb_hsbenh.DataSource = cm.load_data_query(query3);
            cbb_hsbenh.DisplayMember = "hoten";
            cbb_hsbenh.ValueMember = "hs_id";

            // Load dữ liệu từ database
            DataTable dt = cm.load_data_query("SELECT STT, tenphongbenh, loaiphongbenh FROM view_phongbenh WHERE trangthai = N'Còn trống'");

            // Thêm cột mới để hiển thị
            dt.Columns.Add("tenphongbenh_display", typeof(string));

            // Duyệt từng dòng để cập nhật dữ liệu hiển thị
            foreach (DataRow row in dt.Rows)
            {
                if (row["loaiphongbenh"].ToString() == "Dịch vụ")
                {
                    row["tenphongbenh_display"] = row["tenphongbenh"].ToString() + " Dịch vụ";
                }
                else
                {
                    row["tenphongbenh_display"] = row["tenphongbenh"].ToString();
                }
            }

            // Gán vào ComboBox
            cbb_phongbenh.DataSource = dt;
            cbb_phongbenh.DisplayMember = "tenphongbenh_display";  // Hiển thị tên đã chỉnh sửa
            cbb_phongbenh.ValueMember = "STT";  // Lấy giá trị là  phòng id

        }
        private void load_data_follow_id()
        {
            string query = @"exec pro_chitiet_nhapvien " + txt_stt.Text;
            dataGridView2.DataSource = cm.load_data_query(query);
            if (dataGridView2.DataSource != null)
            {
                dataGridView2.Columns[0].HeaderText = "Mã";
                dataGridView2.Columns[1].HeaderText = "Tên dịch vụ";
                dataGridView2.Columns[2].HeaderText = "Giá tiền";
                dataGridView2.Columns[3].HeaderText = "Ghi chú";
            }
                
        }
        private void load_data_xetnghiem_follow_id()
        {
            string query = @"exec pro_chitiet_nhapvien_xetnghiem " + txt_stt.Text;
            dataGridView3.DataSource = cm.load_data_query(query);
            if(dataGridView3.DataSource != null)
            {
                dataGridView3.Columns[0].HeaderText = "Mã phiếu";
                dataGridView3.Columns[1].HeaderText = "Ngày tạo";
                dataGridView3.Columns[2].HeaderText = "Bệnh nhân";
                dataGridView3.Columns[3].HeaderText = "Dịch vụ";
                dataGridView3.Columns[4].HeaderText = "Người lập";
                dataGridView3.Columns[5].HeaderText = "Kết quả";
                dataGridView3.Columns[6].HeaderText = "Trạng thái";
            }    
            
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txt_stt.Text = selectedRow.Cells[0].Value?.ToString();
                txt_benhnhan.Text = selectedRow.Cells[1].Value?.ToString();
                dtp_nhapvien.Text = selectedRow.Cells[2].Value?.ToString();
                cbb_phongbenh.Text = selectedRow.Cells[3].Value?.ToString();
                if(txt_stt.Text != "")
                {
                    load_data_follow_id();
                    load_data_xetnghiem_follow_id();
                }    
            }
            
        }

        private void cbb_hsbenh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = cm.load_data_query("SELECT cccd, bhyt FROM view_hsbn WHERE hs_id ="+ cbb_hsbenh.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                txt_cccd.Text = dt.Rows[0]["cccd"].ToString();  // Lấy giá trị cccd từ dòng đầu tiên
                txt_bhyt.Text = dt.Rows[0]["bhyt"].ToString();  // Nếu có bhyt, lấy giá trị bhyt
            }
            else
            {
                txt_cccd.Text = "";
                txt_bhyt.Text = "";
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            load_data();
            txt_stt.Text = "";
            txt_cccd.Text = "";
            txt_bhyt.Text = "";
            richTextBox1.Text = "";
            txt_benhnhan.Text = "";
            dataGridView2.DataSource = "";
            dataGridView3.DataSource = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            int phong = Convert.ToInt32(cbb_phongbenh.SelectedValue);
                            int benhnhan = Convert.ToInt32(cbb_hsbenh.SelectedValue);

                            // Cập nhật phòng mới cho bệnh nhân trong bảng `phieunhapvien`
                            string query = "UPDATE phieunhapvien SET phong_id = @phong_id WHERE hs_id = @hs_id";
                            using (SqlCommand cmdUpdatePhieu = new SqlCommand(query, connection, transaction))
                            {
                                cmdUpdatePhieu.Parameters.AddWithValue("@phong_id", phong);
                                cmdUpdatePhieu.Parameters.AddWithValue("@hs_id", benhnhan);
                                cmdUpdatePhieu.ExecuteNonQuery();
                            }

                            // Cập nhật `ngayra` cho lịch sử phòng cũ trong `lichsunamvien`
                            string updateHistory = "UPDATE lichsunamvien SET ngayra = @ngayra WHERE trangthai != 2 AND hs_id = @hs_id AND ngayra IS NULL";
                            using (SqlCommand cmdUpdateHistory = new SqlCommand(updateHistory, connection, transaction))
                            {
                                cmdUpdateHistory.Parameters.AddWithValue("@ngayra", DateTime.Now.Date);
                                cmdUpdateHistory.Parameters.AddWithValue("@hs_id", benhnhan);
                                cmdUpdateHistory.ExecuteNonQuery();
                            }

                            // Thêm lịch sử mới vào `lichsunamvien` với phòng mới
                            string insertHistory = @"INSERT INTO lichsunamvien (hs_id, phong_id, ngayvao) 
                                         VALUES (@hs_id, @phong_id, @ngayvao)";
                            using (SqlCommand cmdInsertHistory = new SqlCommand(insertHistory, connection, transaction))
                            {
                                cmdInsertHistory.Parameters.AddWithValue("@hs_id", benhnhan);
                                cmdInsertHistory.Parameters.AddWithValue("@phong_id", phong);
                                cmdInsertHistory.Parameters.AddWithValue("@ngayvao", DateTime.Now.Date);
                                cmdInsertHistory.ExecuteNonQuery();
                            }

                            // Commit Transaction nếu tất cả thành công
                            transaction.Commit();
                            MessageBox.Show("Cập nhật phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_data();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Lỗi khi đổi phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối CSDL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string query = @"insert into chitiet_nhapvien  (nhapvien_id, dichvu_id, ghichu, giatien )
                                                values (@nhapvien_id, @dichvu_id, @ghichu, @giatien )";
            // phải conver sang int truoc khi them, int parse ko sai duoc thi trytoconver
            var nhapvien = int.Parse(txt_stt.Text);
            var dichvu = int.Parse(cbb_dichvu.SelectedValue.ToString());
            var giatien = int.Parse(label8.Text);
            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL 
                        command.Parameters.AddWithValue("@nhapvien_id", nhapvien);
                        command.Parameters.AddWithValue("@dichvu_id", dichvu);
                        command.Parameters.AddWithValue("@ghichu", richTextBox1.Text);
                        command.Parameters.AddWithValue("@giatien", giatien);

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

        private void cbb_dichvu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var code = int.Parse(cbb_dichvu.SelectedValue.ToString());
            DataTable dt = cm.load_data_query("select gia_dichvu from view_dichvu where dichvu_id="+code);
            if(dt.Rows.Count > 0)
            {
                label8.Text = dt.Rows[0]["gia_dichvu"].ToString();
            }    
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    // Bắt đầu Transaction
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Chuyển đổi dữ liệu từ ComboBox
                            int benhnhan = Convert.ToInt32(cbb_hsbenh.SelectedValue);
                            int phong = Convert.ToInt32(cbb_phongbenh.SelectedValue);
                            int nhanvien = 1; // Giả định từ Session.user_id

                            // Câu lệnh INSERT vào phieunhapvien
                            string query = @"INSERT INTO phieunhapvien (hs_id, nhanvien_id, phong_id, ngaytao, ngaynhapvien, trangthai)
                                VALUES (@hs_id, @nhanvien_id, @phong_id, @ngaytao, @ngaynhapvien, 1)";

                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@hs_id", benhnhan);
                                command.Parameters.AddWithValue("@nhanvien_id", nhanvien);
                                command.Parameters.AddWithValue("@phong_id", phong);
                                command.Parameters.AddWithValue("@ngaytao", DateTime.Now.Date);
                                command.Parameters.AddWithValue("@ngaynhapvien", dtp_nhapvien.Value);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Câu lệnh UPDATE trạng thái bệnh nhân
                                    string query_update = "UPDATE hsbn SET trangthai = 3 WHERE hs_id = @hs_id";
                                    using (SqlCommand cm_update = new SqlCommand(query_update, connection, transaction))
                                    {
                                        cm_update.Parameters.AddWithValue("@hs_id", benhnhan);
                                        cm_update.ExecuteNonQuery();
                                    }

                                    // Câu lệnh INSERT vào lichsunamvien
                                    string query_history = @"INSERT INTO lichsunamvien (hs_id, phong_id, ngayvao) 
                                                 VALUES (@hs_id, @phong_id, @ngaynhapvien)";
                                    using (SqlCommand cmm = new SqlCommand(query_history, connection, transaction))
                                    {
                                        cmm.Parameters.AddWithValue("@hs_id", benhnhan);
                                        cmm.Parameters.AddWithValue("@phong_id", phong);
                                        cmm.Parameters.AddWithValue("@ngaynhapvien", dtp_nhapvien.Value);
                                        cmm.ExecuteNonQuery();
                                    }

                                    // Xác nhận Transaction
                                    transaction.Commit();
                                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    load_data();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Không thể thêm, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                richTextBox1.Text = "";
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                richTextBox1.Text = selectedRow.Cells[0].Value?.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(richTextBox1.Text);

                // Kiểm tra xem chitiet_id có tồn tại trong bảng không
                string checkExistQuery = "SELECT COUNT(1) FROM chitiet_nhapvien WHERE chitiet_id = @chitiet_id";

                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmdCheckExist = new SqlCommand(checkExistQuery, connection))
                    {
                        cmdCheckExist.Parameters.AddWithValue("@chitiet_id", code);

                        int count = Convert.ToInt32(cmdCheckExist.ExecuteScalar());

                        if (count > 0)
                        {
                            // Nếu có, thực hiện lệnh DELETE
                            string deleteQuery = "DELETE FROM chitiet_nhapvien WHERE chitiet_id = @chitiet_id";
                            using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, connection))
                            {
                                cmdDelete.Parameters.AddWithValue("@chitiet_id", code);
                                cmdDelete.ExecuteNonQuery();
                                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy chitiet_id để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ DateTimePicker
                DateTime ngayNhapVienStart = dtp_1.Value;
                DateTime ngayNhapVienEnd = dtp_2.Value;

                // Sử dụng parameters để truyền giá trị vào câu lệnh SQL
                string query = @"SELECT * FROM view_nhapvien where ngaynhapvien BETWEEN '" + ngayNhapVienStart+"' AND '"+ngayNhapVienEnd+"'";

                // Gọi phương thức để tải dữ liệu vào DataGridView
                dataGridView1.DataSource = cm.load_data_query(query);
                MessageBox.Show("Đã lọc dữ liệu");
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi truy vấn dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
