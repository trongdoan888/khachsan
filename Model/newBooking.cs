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
        public required string maBooking { get; set; }
        public required string code { get; set; }
        public GioiTinh gioiTinh { get; set; }
        public required string tenKhach { get; set; }
        public DateTime ngayDen { get; set; }
        public DateTime ngayDi { get; set; }
        public int soNguoiLon { get; set; }
        public int soTreEm { get; set; }
        public double soDem { get; set; }
        public double giaPhong { get; set; }
        public MaGia maGia { get; set; }
        public HinhThucThanhToan hinhThucThanhToan { get; set; }
        public required string ghiChu { get; set; }
        public LoaiBooking loaiBooking { get; set; }
        public Nguon nguon { get; set; }
        public Congty congty { get; set; }
        public int soPhong { get; set; }
        public string datBoi { get; set; }
        public int soDienThoaiNguoiDat { get; set; }
        public string emailNguoiDat { get; set; }
        public QuocTich quocTich { get; set; }
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

    internal enum QuocTich
    {
        VietNam,
        USA,
        UK,
        Canada,
        Australia,
        Other
    }

    internal enum Congty
    {
        None,
        CompanyA,
        CompanyB,
        CompanyC
    }

    internal enum Nguon
    {
        WalkIn,
        OnlineBooking,
        TravelAgency,
        Corporate
    }

    internal enum LoaiBooking
    {
        Individual,
        Group,
        Corporate
    }

    internal enum HinhThucThanhToan
    {
        Cash,
        CreditCard,
        BankTransfer,
        OnlinePayment
    }

    internal enum MaGia
    {
        Standard,
        Deluxe,
        Suite,
        Promotional
    }
}
