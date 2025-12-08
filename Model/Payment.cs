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
        public string maBooking { get; set; }
        public int stt { get; set; }
        public string taiKhoan { get; set; }
        public string moTa { get; set; }
        public string donVi { get; set; }
        public double donGia { get; set; }
        public int soLuong { get; set; }
        public double vat { get; set; }
        public double thanhTien { get; set; }
        public double soTienPhaiTra { get; set; }
        public double soTienDaTra { get; set; }
        public double soTienConLai { get; set; }
        public double giamGia { get; set; }
        public string TaiKoanThu { get; set; }
    }
}
