using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khachsan.Model
{
    internal class account
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string maNV { get; set; }
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }
    }
}
