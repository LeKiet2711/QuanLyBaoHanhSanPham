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
            try
            {
                var sanPham = new SanPham
                {
                    SanPhamID = int.Parse(txtid.Text),
                    TenSanPham = txttensp.Text,
                    Mota = txtmota.Text,
                    Gia = int.Parse(txtgia.Text),
                    SoSeri = txtsoseri.Text,
                    TrangThai = txttrangthai.Text
                };
                _sanPhamService.Create(sanPham);
                MessageBox.Show("Thêm thành công");
                LoadsanPhamData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo mới sản phẩm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                var sanphamId = int.Parse(txtid.Text);
                _sanPhamService.Delete(sanphamId);
                MessageBox.Show("Xóa thành công");
                LoadsanPhamData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                var sanPham = new SanPham
                {
                    SanPhamID = int.Parse(txtid.Text),
                    TenSanPham = txttensp.Text,
                    Mota = txtmota.Text,
                    Gia = int.Parse(txtgia.Text),
                    SoSeri = txtsoseri.Text,
                    TrangThai = txttrangthai.Text
                };
                _sanPhamService.Update(sanPham.SanPhamID, sanPham);
                MessageBox.Show("Sửa thành công");
                LoadsanPhamData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sản phẩm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                List<SanPham> sanPhamList = _sanPhamService.SapXep();
                dataGridView1.DataSource = sanPhamList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sắp xếp sản phẩm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                int sanPhamID;
                if (int.TryParse(txt_timkiemid.Text, out sanPhamID))
                {
                    List<SanPham> sanPhamList = _sanPhamService.TimKiem(sanPhamID);
                    if (sanPhamList.Count > 0)
                    {
                        dataGridView2.DataSource = sanPhamList;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm với ID này.");
                        dataGridView2.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ID hợp lệ.");
                    dataGridView2.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm sản phẩm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
