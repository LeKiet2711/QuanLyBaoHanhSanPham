using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using QuanLyBaoHanhSanPham.Model;
using QuanLyBaoHanhSanPham.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoHanhSanPham
{
    public partial class Form1 : Form
    {

        private readonly KhachHangService _khachHangService;
        public Form1()
        {
            InitializeComponent();
            var database = new Connection().GetDatabase();
            _khachHangService = new KhachHangService(database);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

       
        private void LoadKhachHangData()
        {
            var khachHangs = _khachHangService.GetAll();
            dataGridView1.DataSource = khachHangs;
        }

       

      
   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtKhachHangID.Text = row.Cells["KhachHangID"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }

        }

       

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                var khachHang = new KhachHang
                {
                    KhachHangID = int.Parse(txtKhachHangID.Text),
                    TenKhachHang = txtTenKhachHang.Text,
                    DiaChi = txtDiaChi.Text,
                    SoDienThoai = txtSDT.Text,
                    Email = txtEmail.Text
                };
                _khachHangService.Create(khachHang);
                MessageBox.Show("Thêm thanh cong");
                LoadKhachHangData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo mới khách hàng: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                var khachHangID = int.Parse(txtKhachHangID.Text);
                _khachHangService.DeleteByKhachHangID(khachHangID);
                MessageBox.Show("Xóa thanh cong");
                LoadKhachHangData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            try
            {
                var khachHang = new KhachHang
                {
                    KhachHangID = int.Parse(txtKhachHangID.Text),
                    TenKhachHang = txtTenKhachHang.Text,
                    DiaChi = txtDiaChi.Text,
                    SoDienThoai = txtSDT.Text,
                    Email = txtEmail.Text
                };
                _khachHangService.UpdateByKhachHangID(khachHang.KhachHangID, khachHang);
                MessageBox.Show("Update thanh cong");
                LoadKhachHangData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"lỗi khi update khách hàng: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoadKhachHangData();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtKhachHangID.Text = "";
            txtSDT.Text = "";
            txtTenKhachHang.Text = "";
            
        }
    }
}
