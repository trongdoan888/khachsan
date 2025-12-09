using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khachsan.Model
{
    internal class Payment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string code { get; set; }
        public double thanhTien { get; set; }
        public double soTienDaTra { get; set; }
        public double soTienConLai { get; set; }
        public string tenNguoiTra { get; set; }
    }
}
