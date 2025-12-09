using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khachsan.Model
{
    internal class newBooking
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string maPhong { get; set; }
        public string code { get; set; }
        public string gioiTinh { get; set; }
        public string tenKhach { get; set; }
        public DateTime ngayDen { get; set; }
        public DateTime ngayDi { get; set; }
        public int soNguoiLon { get; set; }
        public int soTreEm { get; set; }
        public int soDem { get; set; }
        public double giaPhong { get; set; }
        public string maGia { get; set; }
        public string hinhThucThanhToan { get; set; }
        public  string ghiChu { get; set; }
        public string loaiBooking { get; set; }
        public string nguon { get; set; }
        public string congty { get; set; }
        public string datBoi { get; set; }
        public string soDienThoaiNguoiDat { get; set; }
        public string emailNguoiDat { get; set; }
        public string quocTich { get; set; }
        public string loaiPhong { get; set; }
        public int soluong { get; set; }
        public string passport { get; set; }
    }
}
