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
    public partial class Form_BaoHanh : Form
    {
        private readonly BaoHanhService _baoHanhService;
        public Form_BaoHanh()
        {
            InitializeComponent();
            var database = new Connection().GetDatabase();
            _baoHanhService = new BaoHanhService(database);
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadBaoHanhData();
            bind();
        }

        private void bind()
        {
            idkhachhang.DataBindings.Clear();
            idkhachhang.DataBindings.Add("text", dulieu.DataSource, "KhachHangID");
            idsanpham.DataBindings.Clear();
            idsanpham.DataBindings.Add("text", dulieu.DataSource, "SanPhamID");
            ngaymua.DataBindings.Clear();
            ngaymua.DataBindings.Add("text", dulieu.DataSource, "ngaymua");
            thoigianbaohanh.DataBindings.Clear();
            thoigianbaohanh.DataBindings.Add("text", dulieu.DataSource, "thoigianbaohanh");
            trangthai.DataBindings.Clear();
            trangthai.DataBindings.Add("text", dulieu.DataSource, "trangthai");
            danhgia.DataBindings.Clear();
            danhgia.DataBindings.Add("text", dulieu.DataSource, "danhgia");
            motasuco.DataBindings.Clear();
            motasuco.DataBindings.Add("text", dulieu.DataSource, "motasuco");
            ngaybaohanhgannhat.DataBindings.Clear();
            ngaybaohanhgannhat.DataBindings.Add("text", dulieu.DataSource, "ngaybaohanhgannhat");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            try
            {
                int sanPhamID;
                if (int.TryParse(tim.Text, out sanPhamID))
                {
                    List<BaoHanh> sanPhamList = _baoHanhService.TimKiem(sanPhamID);
                    if (sanPhamList.Count > 0)
                    {
                        dulieu.DataSource = sanPhamList;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bảo hành với ID này.");
                        dulieu.DataSource = null;
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(tim.Text))
                    {
                        sanPhamID = 9999;
                        List<BaoHanh> sanPhamList = _baoHanhService.TimKiem(sanPhamID);
                        if (sanPhamList.Count > 0)
                        {
                            dulieu.DataSource = sanPhamList;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập ID hợp lệ.");
                        dulieu.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm bảo hành: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBaoHanhData()
        {
            var sanphams = _baoHanhService.GetAll();
            dulieu.DataSource = sanphams;
        }

        private void btn_tai_Click(object sender, EventArgs e)
        {
            LoadBaoHanhData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string khachHangID = idkhachhang.Text.Trim();
            string sanPhamID = idsanpham.Text.Trim();
            string ngayMua = ngaymua.Text.Trim();
            DateTime NgayMua = DateTime.ParseExact(ngayMua, "M/d/yyyy h:mm:ss tt", null);
            string thoiGianBaoHanh = thoigianbaohanh.Text.Trim();
            string trangThai = trangthai.Text.Trim();
            string danhGia = danhgia.Text.Trim();
            string moTaSuCo = motasuco.Text.Trim();
            string ngayBaoHanhGanNhat = ngaybaohanhgannhat.Text.Trim();
            DateTime ngayBH = DateTime.ParseExact(ngayBaoHanhGanNhat, "M/d/yyyy h:mm:ss tt", null);

            if (khachHangID.Length > 0 && sanPhamID.Length > 0 && ngayMua.Length > 0 && thoiGianBaoHanh.Length > 0 && trangThai.Length > 0 && danhGia.Length > 0 && moTaSuCo.Length > 0 && ngayBaoHanhGanNhat.Length > 0)
            {
                try
                {
                    var baoHanh = new BaoHanh()
                    {
                        KhachHangID = int.Parse(khachHangID),
                        SanPhamID = int.Parse(sanPhamID),
                        NgayMua = NgayMua,
                        ThoiGianBaoHanh = int.Parse(thoiGianBaoHanh),
                        TrangThai = trangThai,
                        DanhGia = danhGia,
                        MoTaSuCo = moTaSuCo,
                        NgayBaoHanhGanNhat = ngayBH
                    };
                    _baoHanhService.Create(baoHanh);
                    MessageBox.Show("Thêm thành công");
                    LoadBaoHanhData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tạo bảo hành: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Vui lòng nhập đầy đủ thông tin!!!");
            }
        }

        private void dulieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bind();
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            string khachHangID = idkhachhang.Text.Trim();
            string sanPhamID = idsanpham.Text.Trim();
            string ngayMua = ngaymua.Text.Trim();
            DateTime NgayMua = DateTime.ParseExact(ngayMua, "M/d/yyyy h:mm:ss tt", null);
            string thoiGianBaoHanh = thoigianbaohanh.Text.Trim();
            string trangThai = trangthai.Text.Trim();
            string danhGia = danhgia.Text.Trim();
            string moTaSuCo = motasuco.Text.Trim();
            string ngayBaoHanhGanNhat = ngaybaohanhgannhat.Text.Trim();
            DateTime ngayBH = DateTime.ParseExact(ngayBaoHanhGanNhat, "M/d/yyyy h:mm:ss tt", null);

            if (khachHangID.Length > 0 && sanPhamID.Length > 0 && ngayMua.Length > 0 && thoiGianBaoHanh.Length > 0 && trangThai.Length > 0 && danhGia.Length > 0 && moTaSuCo.Length > 0 && ngayBaoHanhGanNhat.Length > 0)
            {
                try
                {
                    var baoHanh = new BaoHanh()
                    {
                        KhachHangID = int.Parse(khachHangID),
                        SanPhamID = int.Parse(sanPhamID),
                        NgayMua = NgayMua,
                        ThoiGianBaoHanh = int.Parse(thoiGianBaoHanh),
                        TrangThai = trangThai,
                        DanhGia = danhGia,
                        MoTaSuCo = moTaSuCo,
                        NgayBaoHanhGanNhat = ngayBH
                    };
                    _baoHanhService.Update(baoHanh.SanPhamID,baoHanh);
                    MessageBox.Show("Cập nhật thành công!");
                    LoadBaoHanhData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật bảo hành: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Vui lòng nhập đầy đủ thông tin!!!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sanPhamID = idsanpham.Text.Trim();
            if (sanPhamID.Length > 0)
            {
                try
                {
                    var sanphamId = int.Parse(sanPhamID);
                    _baoHanhService.Delete(sanphamId);
                    MessageBox.Show("Xóa thành công");
                    LoadBaoHanhData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa bảo hành: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Vui lòng Chọn bảo hành để xóa!!!");
            }
        }

    }
}
