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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKhachHangData();
        }

        private void button1_Click(object sender, EventArgs e)
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
                LoadKhachHangData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo mới khách hàng: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKhachHangData()
        {
            var khachHangs = _khachHangService.GetAll();
            dataGridView1.DataSource = khachHangs;
        }

        private void btnSua_Click(object sender, EventArgs e)
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
                LoadKhachHangData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"lỗi khi update khách hàng: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var khachHangID = int.Parse(txtKhachHangID.Text);
                _khachHangService.DeleteByKhachHangID(khachHangID);
                LoadKhachHangData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtKhachHangID.Text = "";
            txtTenKhachHang.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtKhachHangID.Focus();
        }
    }
}
