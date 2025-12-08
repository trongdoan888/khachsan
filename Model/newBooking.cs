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
        public string maBooking { get; set; }
        public string code { get; set; }
        public GioiTinh gioiTinh { get; set; }
        public string tenKhach { get; set; }
        public DateTime ngayDen { get; set; }
        public DateTime ngayDi { get; set; }
        public int soNguoiLon { get; set; }
        public int soTreEm { get; set; }
        public double soDem { get; set; }
        public double giaPhong { get; set; }
        public maGia maGia { get; set; }
        public hinhThucThanhToan hinhThucThanhToan { get; set; }
        public string ghiChu { get; set; }
        public loaiBooking loaiBooking { get; set; }
        public nguon nguon { get; set; }
        public congty congty { get; set; }
        public int soPhong { get; set; }
        public string datBoi { get; set; }
        public int soDienThoaiNguoiDat { get; set; }
        public string emailNguoiDat { get; set; }
        public quocTich quocTich { get; set; }
        public LoaiPhong loaiPhong { get; set; }
    }

    internal enum GioiTinh
    {
        Nam,
        Nu,
        Khac
    }

    internal enum LoaiPhong
    {
        Direct,
        Online,
        Agent
    }

    internal enum quocTich
    {
        VietNam,
        USA,
        UK,
        Canada,
        Australia,
        Other
    }

    internal enum congty
    {
        None,
        CompanyA,
        CompanyB,
        CompanyC
    }

    internal enum nguon
    {
        WalkIn,
        OnlineBooking,
        TravelAgency,
        Corporate
    }

    internal enum loaiBooking
    {
        Individual,
        Group,
        Corporate
    }

    internal enum hinhThucThanhToan
    {
        Cash,
        CreditCard,
        BankTransfer,
        OnlinePayment
    }

    internal enum maGia
    {
        Standard,
        Deluxe,
        Suite,
        Promotional
    }
}
