using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHanhSanPham.Model
{
    public class BaoHanh
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int KhachHangID { get; set; }
        public int SanPhamID { get; set; }
        public DateTime NgayMua { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public string TrangThai { get; set; }
        public string DanhGia { get; set; }
        public string MoTaSuCo { get; set; }
        public DateTime NgayBaoHanhGanNhat { get; set; }
    }
}
