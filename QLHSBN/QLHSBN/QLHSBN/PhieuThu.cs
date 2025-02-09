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
    public partial class PhieuThu : Form
    {
        public PhieuThu()
        {
            InitializeComponent();
        }

        common cm = new common();

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void load_cbb_BenhNhan()
        {
            string query = @"select pnv.nhapvien_id, hs.hoten
                            from phieunhapvien pnv, hsbn hs
                            where pnv.hs_id = hs.hs_id and pnv.trangthai = 1";
            cbbBenhNhan.DataSource = cm.load_data_query(query);
            cbbBenhNhan.DisplayMember = "hoten";
            cbbBenhNhan.ValueMember = "nhapvien_id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PhieuThu_Load(object sender, EventArgs e)
        {
            load_cbb_BenhNhan();
            load_DSPhieuThu();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cbbBenhNhan_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbBenhNhan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(cbbBenhNhan.SelectedValue);
            int tongTienPhongThuong = 0, tongTienPhongDichVu = 0;

            string query = @"SELECT hs_id FROM phieunhapvien WHERE nhapvien_id=" + code;
            DataTable dt = cm.load_data_query(query);

            if (dt.Rows.Count == 0 || dt.Rows[0]["hs_id"] == DBNull.Value)
            {
                MessageBox.Show("Không tìm thấy hồ sơ bệnh nhân.");
                return;
            }

            int hs_id = Convert.ToInt32(dt.Rows[0]["hs_id"]);

            // Lấy thông tin phòng bệnh
            string queryPhongThuong = @"SELECT ls.so_ngay, pn.gia 
                                FROM phieunhapvien pnv
                                JOIN hsbn hs ON pnv.hs_id = hs.hs_id
                                JOIN phongbenh pn ON pnv.phong_id = pn.phong_id
                                JOIN lichsunamvien ls ON pnv.hs_id = ls.hs_id
                                WHERE hs.hs_id = " + hs_id + @" 
                                AND pn.loaiphongbenh = N'Thường'
                                AND (phieuthu_id IS NULL OR phieuthu_id = '');";

            string queryPhongDichVu = @"SELECT ls.so_ngay, pn.gia 
                                FROM phieunhapvien pnv
                                JOIN hsbn hs ON pnv.hs_id = hs.hs_id
                                JOIN phongbenh pn ON pnv.phong_id = pn.phong_id
                                JOIN lichsunamvien ls ON pnv.hs_id = ls.hs_id
                                WHERE hs.hs_id = " + hs_id + @" 
                                AND pn.loaiphongbenh = N'Dịch vụ'
                                AND (phieuthu_id IS NULL OR phieuthu_id = '');";

            DataTable dtPhongThuong = cm.load_data_query(queryPhongThuong);
            DataTable dtPhongDichVu = cm.load_data_query(queryPhongDichVu);

            if (dtPhongThuong.Rows.Count > 0)
            {
                int soNgay = dtPhongThuong.Rows[0]["so_ngay"] != DBNull.Value ? Convert.ToInt32(dtPhongThuong.Rows[0]["so_ngay"]) : 0;
                int gia = dtPhongThuong.Rows[0]["gia"] != DBNull.Value ? Convert.ToInt32(dtPhongThuong.Rows[0]["gia"]) : 0;
                tongTienPhongThuong = soNgay * gia;

                txtSoNgayPhongThuong.Text = soNgay.ToString();
                txtDonGiaPhongThuong.Text = gia.ToString();
                txtTongTienPhongThuong.Text = tongTienPhongThuong.ToString();
            }
            else
            {
                txtSoNgayPhongThuong.Text = "0";
                txtDonGiaPhongThuong.Text = "0";
                txtTongTienPhongThuong.Text = "0";
            }

            if (dtPhongDichVu.Rows.Count > 0)
            {
                int soNgay = dtPhongDichVu.Rows[0]["so_ngay"] != DBNull.Value ? Convert.ToInt32(dtPhongDichVu.Rows[0]["so_ngay"]) : 0;
                int gia = dtPhongDichVu.Rows[0]["gia"] != DBNull.Value ? Convert.ToInt32(dtPhongDichVu.Rows[0]["gia"]) : 0;
                tongTienPhongDichVu = soNgay * gia;

                txtSoNgayPhongDichVu.Text = soNgay.ToString();
                txtDonGiaPhongDichVu.Text = gia.ToString();
                txtTongTienPhongDichVu.Text = tongTienPhongDichVu.ToString();
            }
            else
            {
                txtSoNgayPhongDichVu.Text = "0";
                txtDonGiaPhongDichVu.Text = "0";
                txtTongTienPhongDichVu.Text = "0";
            }

            // Tính tổng tiền dịch vụ
            string tongDV = @"SELECT SUM(giatien) AS Gia FROM chitiet_nhapvien WHERE nhapvien_id=" + code;
            DataTable dv = cm.load_data_query(tongDV);
            int tongTienDichVu = 0;

            if (dv.Rows.Count > 0 && dv.Rows[0]["Gia"] != DBNull.Value)
            {
                tongTienDichVu = Convert.ToInt32(dv.Rows[0]["Gia"]);
                txtTongTienDichVu.Text = tongTienDichVu.ToString();
            }
            else
            {
                txtTongTienDichVu.Text = "0";
            }

            // Tính tổng tiền
            int tongTien = tongTienPhongThuong + tongTienPhongDichVu + tongTienDichVu;
            txtTongTien.Text = tongTien.ToString();
        }

        private void load_DSPhieuThu()
        {
            string query = @"SELECT        dbo.phieuthu.phieuthu_id, dbo.hsbn.hs_id, dbo.hsbn.hoten as 'Benh nhan', dbo.nhanvien.hoten AS 'Bac si', dbo.phieuthu.ngaytao as 'Ngay tao', dbo.phieuthu.ngaythu as 'Ngay thu', dbo.phieuthu.sotien as 'So tien', dbo.phieuthu.trangthai
                            FROM            dbo.hsbn INNER JOIN
                                dbo.nhanvien ON dbo.hsbn.nhanvien_id = dbo.nhanvien.nhanvien_id INNER JOIN
                                dbo.phieuthu ON dbo.hsbn.hs_id = dbo.phieuthu.hs_id AND dbo.nhanvien.nhanvien_id = dbo.phieuthu.nhanvien_id
                            WHERE dbo.phieuthu.trangthai = 0";
            dgvDSPhieuThu.DataSource = cm.load_data_query(query);

            dgvDSPhieuThu.Columns[0].Visible = false;
            dgvDSPhieuThu.Columns[1].Visible = false;
            dgvDSPhieuThu.Columns[2].HeaderText = "Bệnh nhân";
            dgvDSPhieuThu.Columns[3].HeaderText = "Bác sĩ";
            dgvDSPhieuThu.Columns[4].HeaderText = "Ngày tạo";
            dgvDSPhieuThu.Columns[5].HeaderText = "Ngày thu";
            dgvDSPhieuThu.Columns[6].HeaderText = "Tổng tiền";
            dgvDSPhieuThu.Columns[7].Visible = false;

            if (dgvDSPhieuThu.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.Text = "Xóa";
                btnDelete.HeaderText = "";
                btnDelete.UseColumnTextForButtonValue = true;
                dgvDSPhieuThu.Columns.Add(btnDelete);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var nhapvien_id = cbbBenhNhan.SelectedValue;
            int hs_id = 0; // Biến để lưu hs.hs_id
            int nhanvien_id = 0; // Biến để lưu hs.hs_id
            string queryGetHS_ID = @"SELECT pnv.nhanvien_id, hs.hs_id FROM phieunhapvien pnv, hsbn hs WHERE hs.hs_id = pnv.hs_id AND pnv.nhapvien_id = " + nhapvien_id;

            using (SqlConnection conn = new SqlConnection(cm.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(queryGetHS_ID, conn))
                {
                    object result = cmd.ExecuteScalar(); // Lấy giá trị đầu tiên của cột đầu tiên

                    if (result != null && result != DBNull.Value)
                    {
                        hs_id = Convert.ToInt32(result);
                        nhanvien_id = Convert.ToInt32(result);
                    }
                }
            }

            string updatQuery = @"INSERT INTO phieuthu (nhanvien_id, hs_id, ngaytao, ngaythu, sotien, ghichu, trangthai)
                                  VALUES (@nhanvien_id, @hs_id, @ngaytao, @ngaythu, @sotien, @ghichu, 0);";

            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updatQuery, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL 
                        command.Parameters.AddWithValue("@nhanvien_id", nhanvien_id);
                        command.Parameters.AddWithValue("@hs_id", hs_id);
                        command.Parameters.AddWithValue("@ngaytao", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@ngaythu", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@sotien", Convert.ToInt32(txtTongTien.Text));
                        command.Parameters.AddWithValue("@ghichu", rtxtGhiChu.Text);


                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_DSPhieuThu();
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        private void dgvDSPhieuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDSPhieuThu.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                int phieuthu_id = Convert.ToInt32(dgvDSPhieuThu.Rows[e.RowIndex].Cells["phieuthu_id"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM phieuthu WHERE phieuthu_id = @phieuthu_id";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@phieuthu_id", phieuthu_id);

                    cm.load_data_query(deleteQuery);
                    MessageBox.Show("Xóa thành công!");

                    // Load lại danh sách sau khi xóa
                    load_DSPhieuThu();
                }
            }
        }

        private void dgvDSPhieuThu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
    }
}
