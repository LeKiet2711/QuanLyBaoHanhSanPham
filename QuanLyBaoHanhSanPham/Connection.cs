using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QuanLyBaoHanhSanPham
{
    public class Connection
    {
        private MongoClient _client;
        private IMongoDatabase _database;

        // Constructor để khởi tạo kết nối
        public Connection()
        {
            // Chuỗi kết nối tới MongoDB (thay thế 'localhost' và 'yourDatabaseName' với thông tin của bạn)
            string connectionString = "mongodb://localhost:27017";
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("QL_BaoHanhSanPham");
        }

        // Phương thức để lấy Collection từ Database
        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return _database.GetCollection<BsonDocument>(collectionName);
        }

        // Phương thức để lấy Database
        public IMongoDatabase GetDatabase()
        {
            return _database;
        }

    }
}
