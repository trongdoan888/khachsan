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
    internal class Booking
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string maBooking { get; set; }
        public string code { get; set; }
        public string tenKhach { get; set; }
        public DateTime ngayDen { get; set; }
        public DateTime ngayDi { get; set; }
        public int soNguoiLon { get; set; }
        public int soTreEm { get; set; }
        public double giaPhong { get; set; }
        public enum maGia { get; set; }
        public enum hinhThucThanhToan { get; set; }
        public enum trangthai { get; set; }
        public string ghiChu { get; set; }
        public enum loaiBooking { get; set; }



    }
}