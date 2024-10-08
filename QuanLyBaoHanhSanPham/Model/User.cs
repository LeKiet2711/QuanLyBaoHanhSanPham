using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHanhSanPham.Model
{
  public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name {  get; set; }
        public string Pass { get; set; }
    }
}
