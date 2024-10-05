using MongoDB.Bson;
using MongoDB.Driver;
using QuanLyBaoHanhSanPham.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

public class SanPhamService
{
    private readonly IMongoCollection<SanPham> _sanPhamCollection;

    public SanPhamService(IMongoDatabase database)
    {
        _sanPhamCollection = database.GetCollection<SanPham>("SanPham");
    }

    public List<SanPham> GetAll() => _sanPhamCollection.Find(sp => true).ToList();

    public SanPham GetById(ObjectId id) => _sanPhamCollection.Find(sp => sp.Id == id).FirstOrDefault();

    public void Create(SanPham sanPham) => _sanPhamCollection.InsertOne(sanPham);

    public void Update(int sanphamid, SanPham sanPham)
    {
        var existingSanPham = _sanPhamCollection.Find(sp => sp.SanPhamID == sanPham.SanPhamID).FirstOrDefault();
        if (existingSanPham != null)
        {
            sanPham.Id = existingSanPham.Id; // Ensure the _id field remains unchanged
            _sanPhamCollection.ReplaceOne(sp => sp.SanPhamID==sanPham.SanPhamID, sanPham);
        }
    }

    public void Delete(int sanphamid) => _sanPhamCollection.DeleteOne(sp => sp.SanPhamID == sanphamid);
   
    public List<SanPham> SapXep()
    {
        return _sanPhamCollection.Find(sp => true)
                                 .SortBy(sp => sp.Gia)
                                 .ToList();
    }
    public List<SanPham> TimKiem(int sanPhamID)
    {
       var sanPham = _sanPhamCollection.Find(sp => sp.SanPhamID == sanPhamID).FirstOrDefault();
        if(sanPham != null)
        {
            return new List<SanPham> { sanPham };
        }
        return new List<SanPham>();
    }


    // Thêm hoặc cập nhật thông tin khách hàng

}
