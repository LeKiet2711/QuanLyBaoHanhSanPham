using MongoDB.Bson;
using MongoDB.Driver;
using QuanLyBaoHanhSanPham.Model;
using System.Collections.Generic;

public class SanPhamService
{
    private readonly IMongoCollection<BaoHanh> _sanPhamCollection;

    public SanPhamService(IMongoDatabase database)
    {
        _sanPhamCollection = database.GetCollection<BaoHanh>("BaoHanh");
    }

    public List<BaoHanh> GetAll() => _sanPhamCollection.Find(sp => true).ToList();

    public BaoHanh GetById(ObjectId id) => _sanPhamCollection.Find(sp => sp.Id == id).FirstOrDefault();

    public void Create(BaoHanh sanPham) => _sanPhamCollection.InsertOne(sanPham);

    public void Update(ObjectId id, BaoHanh sanPham) => _sanPhamCollection.ReplaceOne(sp => sp.Id == id, sanPham);

    public void Delete(ObjectId id) => _sanPhamCollection.DeleteOne(sp => sp.Id == id);

    // Thêm hoặc cập nhật thông tin khách hàng
    
}
