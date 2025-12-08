using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace khachsan.Model
{
    internal class Guest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string diaChi { get; set; }
        public string hoChieu { get; set; }
        public string Visa { get; set; }
        public int soDienThoai { get; set; }

    }

}