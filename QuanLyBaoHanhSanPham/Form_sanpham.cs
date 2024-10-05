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
    public partial class Form_sanpham : Form
    {
        private readonly SanPhamService _sanPhamService;
        public Form_sanpham()
        {
            InitializeComponent();
            var database = new Connection().GetDatabase();
            _sanPhamService = new SanPhamService(database);
        }
        private void LoadsanPhamData()
        {
            var sanphams = _sanPhamService.GetAll();
            dataGridView1.DataSource = sanphams;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var sanPham = new SanPham();
            {
                sanPham.SanPhamID = int.Parse(txtid.Text);
                sanPham.TenSanPham = txttensp.Text;
                sanPham.Mota = txtmota.Text;    
                sanPham.Gia = int.Parse(txtgia.Text);
                sanPham .SoSeri = txtsoseri.Text;
                sanPham.TrangThai = txttrangthai.Text;  
            };
            _sanPhamService.Create(sanPham);
            MessageBox.Show("Them thanh cong");
            LoadsanPhamData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var sanphamId = int.Parse(txtid.Text);
            _sanPhamService.Delete(sanphamId);
            MessageBox.Show("Xoa thanh cong");
            LoadsanPhamData ();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            LoadsanPhamData();  
        }

        private void Form_sanpham_Load(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var sanPham = new SanPham();
            {
                sanPham.SanPhamID = int.Parse(txtid.Text);
                sanPham.TenSanPham = txttensp.Text;
                sanPham.Mota = txtmota.Text;
                sanPham.Gia = int.Parse(txtgia.Text);
                sanPham.SoSeri = txtsoseri.Text;
                sanPham.TrangThai = txttrangthai.Text;
            };
            _sanPhamService.Update(sanPham.SanPhamID,sanPham);
            MessageBox.Show("Sua thanh cong");
            LoadsanPhamData();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells["SanPhamID"].Value.ToString();
                txttensp.Text = row.Cells["TenSanPham"].Value.ToString();
                txtsoseri.Text = row.Cells["SoSeri"].Value.ToString();
                txtgia.Text = row.Cells["Gia"].Value.ToString();
                txtmota.Text = row.Cells["Mota"].Value.ToString();
                txttrangthai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }

        private void btnlammmoi_Click(object sender, EventArgs e)
        {
            txttrangthai.Text = "";
            txttensp.Text = "";
            txtid.Text = "";
            txtmota.Text = "";
            txtsoseri.Text = "";
            txtgia.Text = "";
            txtid.Focus();
        }

        private void btn_sapxep_Click(object sender, EventArgs e)
        {
            List<SanPham> sanPhamList = _sanPhamService.SapXep();

            // Tải dữ liệu sản phẩm đã sắp xếp vào DataGridView hoặc phương thức hiển thị dữ liệu khác
            dataGridView1.DataSource = sanPhamList;

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            int sanPhamID;

            // Kiểm tra xem ID có hợp lệ không
            if (int.TryParse(txt_timkiemid.Text, out sanPhamID))
            {
                // Gọi phương thức tìm kiếm
                List<SanPham> sanPhamList = _sanPhamService.TimKiem(sanPhamID);

                if (sanPhamList.Count > 0)
                {
                    // Hiển thị sản phẩm trong DataGridView
                    dataGridView2.DataSource = sanPhamList;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm với ID này.");
                    dataGridView2.DataSource = null; // Xóa nguồn dữ liệu để tránh hiển thị thông tin cũ
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID hợp lệ.");
                dataGridView2.DataSource = null; // Xóa nguồn dữ liệu để tránh hiển thị thông tin cũ
            }
        }
    }
}
