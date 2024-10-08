using MongoDB.Driver;
using QuanLyBaoHanhSanPham.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Reporting;

namespace QuanLyBaoHanhSanPham.Service
{
    public class UserService
    {
        private readonly IMongoCollection<User> _UserCollection;
       
        public UserService(IMongoDatabase database)
        {
            _UserCollection = database.GetCollection<User>("User");
        }
        public async Task<User> GetUserAsync(string username, string password)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Name, username) &
                         Builders<User>.Filter.Eq(u => u.Pass, password);

            return await _UserCollection.Find(filter).FirstOrDefaultAsync();
        }
    }

}
