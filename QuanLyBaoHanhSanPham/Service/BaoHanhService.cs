using MongoDB.Driver;
using QuanLyBaoHanhSanPham.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.ObjectModel;
using System.Collections;

namespace QuanLyBaoHanhSanPham.Service
{
    public class BaoHanhService
    {
        private readonly IMongoCollection<BaoHanh> _baoHanhCollection;

        public BaoHanhService(IMongoDatabase database)
        {
            _baoHanhCollection = database.GetCollection<BaoHanh>("BaoHanh");
        }

        public List<BaoHanh> GetAll() => _baoHanhCollection.Find(sp => true).ToList();

        public BaoHanh GetById(ObjectId id) => _baoHanhCollection.Find(sp => sp.Id == id).FirstOrDefault();

        public void Create(BaoHanh baoHanh) => _baoHanhCollection.InsertOne(baoHanh);

        public void Update(int sanphamid, BaoHanh baoHanh)
        {
            var existingSanPham = _baoHanhCollection.Find(bh => bh.SanPhamID == baoHanh.SanPhamID).FirstOrDefault();
            if (existingSanPham != null)
            {
                baoHanh.Id = existingSanPham.Id; // Ensure the _id field remains unchanged
                _baoHanhCollection.ReplaceOne(sp => sp.SanPhamID == baoHanh.SanPhamID, baoHanh);
            }
        }

        public void Delete(int sanphamid) => _baoHanhCollection.DeleteOne(sp => sp.SanPhamID == sanphamid);

        public List<BaoHanh> SapXep()
        {
            return _baoHanhCollection.Find(sp => true)
                                     .SortBy(sp => sp.ThoiGianBaoHanh)
                                     .ToList();
        }
        public List<BaoHanh> TimKiem(int sanPhamID)
        {
            if (sanPhamID == 9999)
            {
                List<BaoHanh> sanPham = _baoHanhCollection.Find(sp => true).ToList();
                if (sanPham != null)
                {
                    return sanPham;
                }
            }
            else
            {
                List<BaoHanh> sanPham = _baoHanhCollection.Find(sp => sp.SanPhamID == sanPhamID).ToList();
                if (sanPham != null)
                {
                    return sanPham;
                }
            }
            return new List<BaoHanh>();
        }

    }
}
