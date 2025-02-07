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
    public partial class HSDangKyKham : Form
    {
        public HSDangKyKham()
        {
            InitializeComponent();
        }

        private void btn_toathuoc_Click(object sender, EventArgs e)
        {
            if(txt_mahs.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin");
                txt_mahs.Focus();
            }    
            else
            {

            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Gán giá trị từ cột 0 và cột 1 vào các TextBox
                txt_mahs.Text = selectedRow.Cells[1].Value?.ToString(); // Cột 1
                txt_hoten.Text = selectedRow.Cells[2].Value?.ToString(); // Cột 2
                txt_sdt.Text = selectedRow.Cells[3].Value?.ToString(); // Cột 3
                txt_cccd.Text = selectedRow.Cells[4].Value?.ToString(); // Cột 4
            }
        }

        private void HSDangKyKham_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã phiếu";
            dataGridView1.Columns[2].HeaderText = "Hồ sơ bệnh nhân";
            dataGridView1.Columns[3].HeaderText = "Dịch vụ";
            dataGridView1.Columns[4].HeaderText = "Người tạo";
            dataGridView1.Columns[5].HeaderText = "Kết quả";
            dataGridView1.Columns[6].HeaderText = "Ngày tạo";
            dataGridView1.Columns[7].HeaderText = "Trạng thái";
        }
    }
}
