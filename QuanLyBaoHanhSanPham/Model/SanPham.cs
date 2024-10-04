using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHanhSanPham.Model
{
    public class SanPham
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int SanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public string SoSeri { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public decimal Gia { get; set; }
        public string Mota { get; set; }
        public string TrangThai { get; set; }
    }
}
