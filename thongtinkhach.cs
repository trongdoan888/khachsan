using khachsan.Database;
using khachsan.Model;
using MongoDB.Driver;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace khachsan
{
    public partial class thongtinkhach : Form
    {
        private string codeBooking;
        private string namekhach;
        private string Email;
        private string Gioitinh;
        private string Congty;
        private string Quoctich;
        private string Passport;
        private string SoDienthoai;
        private string Ghichu;
        public thongtinkhach(string name,string email,string passport,string sdt,string code,string ghichu,string gioitinhIndex,string congtyIndex,string quoctichIndex)
        {
            codeBooking = code;
            namekhach = name;
            Email = email;
            SoDienthoai = sdt;
            Gioitinh = gioitinhIndex;
            Congty = congtyIndex;
            Quoctich = quoctichIndex;
            Passport = passport;
            Ghichu = ghichu;
            InitializeComponent();
        }

        public thongtinkhach()
        {
            InitializeComponent();
            
        }

        private void thongtinkhach_Load_1(object sender, EventArgs e)
        {
            try
            {
                var db = DatabaseMain.GetDatabase();
                var Bookingcollection = db.GetCollection<newBooking>("newBooking");
                var BookingUser = Bookingcollection.Find(u => u.code == codeBooking).FirstOrDefault();
                if (BookingUser != null)
                {
                    textBox1.Text = BookingUser.tenKhach;
                    textBox3.Text = BookingUser.emailNguoiDat;
                    textBox5.Text = BookingUser.passport;
                    textBox7.Text = BookingUser.soDienThoaiNguoiDat;
                    textBox11.Text = BookingUser.ghiChu;
                    
                    comboBox1.SelectedIndex = GetQuocTichIndex(BookingUser.quocTich);
                    comboBox2.SelectedIndex = GetGT(BookingUser.gioiTinh);
                    comboBox3.SelectedIndex = GetCompAgentIndex(BookingUser.congty);

                }

                if (BookingUser == null)
                {
                    MessageBox.Show("Không tìm thấy booking với mã: " + codeBooking);
                    return;
                }
                MessageBox.Show("Tìm thấy booking: " + BookingUser.tenKhach);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin Booking: " + ex.Message, "Lỗi");
            }
        }
        

        private int GetGT(string gioiTinh)
        {

            switch (gioiTinh)
            {
                case "Nam": return 0;
                case "Nữ": return 1;
                default: return -1;
            }
        }
        private int GetQuocTichIndex(string quocTich)
        {

            switch (quocTich)
            {
                case "Việt Nam": return 0;
                case "Trung Quốc": return 1;
                case "USA": return 2;
                case "Nhật": return 3;
                default: return -1;
            }
        }

        private int GetCompAgentIndex(string congty)
        {

            switch (congty)
            {
                case "Agoda": return 0;
                case "Travelloca": return 1;
                case "Trip": return 2;

                default:
                    return -1;
            }
        }

        // --- Các sự kiện khác (Giữ nguyên) ---

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // --- Trong file thongtinkhach.cs, thay thế nội dung hàm button3_Click ---

        private void button3_Click(object sender, EventArgs e)
        {
            string upname = textBox1.Text;
            string upemail = textBox3.Text;
            string uppassport = textBox5.Text;
            string upsdt = textBox7.Text;
            string upghichu = textBox11.Text;
            string upquoctich = comboBox1.SelectedItem?.ToString();
            string upgioitinh = comboBox2.SelectedItem?.ToString();
            string upcongty = comboBox3.SelectedItem?.ToString();
            try
            {
                var db = DatabaseMain.GetDatabase();
                var Paymentcollection = db.GetCollection<newBooking>("newBooking");
                var filter = Builders<newBooking>.Filter.Eq(p => p.code, codeBooking);

                var update = Builders<newBooking>.Update
                    .Set(p => p.tenKhach, upname)
                    .Set(p => p.emailNguoiDat, upemail)
                    .Set(p => p.passport, uppassport)
                    .Set(p => p.soDienThoaiNguoiDat, upsdt)
                    .Set(p => p.ghiChu, upghichu)
                    .Set(p => p.quocTich, upquoctich)
                    .Set(p => p.gioiTinh, upgioitinh)
                    .Set(p => p.congty, upcongty);

                var result = Paymentcollection.UpdateOne(
                    filter,
                    update,
                    new UpdateOptions { IsUpsert = true } // insert nếu chưa có
                );

                if (result.MatchedCount > 0)
                {
                    MessageBox.Show("Cập nhật thanh toán thành công!");
                }
                else if (result.UpsertedId != null)
                {
                    MessageBox.Show("Bản ghi mới đã được tạo!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật Payment: " + ex.Message);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}