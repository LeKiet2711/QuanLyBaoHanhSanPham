using MongoDB.Driver;
using QuanLyBaoHanhSanPham.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHanhSanPham.Service
{
    public  class KhachHangService
    {
        private readonly IMongoCollection<KhachHang> _khachHangCollection;

        public KhachHangService(IMongoDatabase database)
        {
            _khachHangCollection = database.GetCollection<KhachHang>("KhachHang");
        }

        public List<KhachHang> GetAll() => _khachHangCollection.Find(kh => true).ToList();

        public void Create(KhachHang khachHang) => _khachHangCollection.InsertOne(khachHang);

        public void DeleteByKhachHangID(int khachHangID) =>
            _khachHangCollection.DeleteOne(kh => kh.KhachHangID == khachHangID);

        public void UpdateByKhachHangID(int khachHangID, KhachHang khachHang)
        {
            var existingKhachHang = _khachHangCollection.Find(kh => kh.KhachHangID == khachHangID).FirstOrDefault();
            if (existingKhachHang != null)
            {
                khachHang.Id= existingKhachHang.Id; // Ensure the _id field remains unchanged
                _khachHangCollection.ReplaceOne(kh => kh.KhachHangID == khachHangID, khachHang);
            }
        }

    }
}
