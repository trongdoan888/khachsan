using khachsan.Database;
using khachsan.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace khachsan
{
    public partial class xemBooking : Form
    {
        private string codeBooking;
        private string nameRoom;
        private string namePrice;
        private string nameapp;
        private string nameBooking;
        private string nameSource;
        private string namepay;
        private string namect;
        private newBooking BookingGlobal;
        // Constructor nhận mã code
        public xemBooking(string code, string name)
        {
            codeBooking = code;
            nameRoom = name;
            InitializeComponent();
        }

        public xemBooking()
        {
            InitializeComponent();
        }

        private void xemBooking_Load(object sender, EventArgs e)
        {
            try
            {
                var db = DatabaseMain.GetDatabase();
                var Bookingcollection = db.GetCollection<newBooking>("newBooking");
                var BookingUser = Bookingcollection.Find(u => u.code == codeBooking).FirstOrDefault();

                if (BookingUser != null)
                {
                    BookingGlobal = BookingUser;
                    comboBox1.SelectedIndex = GetRoomType(BookingUser.loaiPhong); // room type
                    comboBox2.SelectedIndex = GetPriceType(BookingUser.maGia);// rate code
                    comboBox6.SelectedIndex = GetAppType(BookingUser.congty); // congty
                    comboBox5.SelectedIndex = GetCtType(BookingUser.loaiBooking); // type
                    comboBox3.SelectedIndex = GetPyType(BookingUser.hinhThucThanhToan); // payment
                    comboBox4.SelectedIndex = GetSource(BookingUser.nguon); // source

                    dateTimePicker1.Value = BookingUser.ngayDen;
                    dateTimePicker2.Value = BookingUser.ngayDi;
                    textBox1.Text = BookingUser.maPhong; // so phong
                    textBox2.Text = BookingUser.soDem.ToString(); // Night
                    tbAdults.Text = BookingUser.soNguoiLon.ToString(); // adult
                    textBox4.Text = BookingUser.soTreEm.ToString(); // children
                    textBox5.Text = BookingUser.giaPhong.ToString(); // rate
                    textBox6.Text = BookingUser.code; // code
                    textBox11.Text = BookingUser.ghiChu; // comment
                    textBox10.Text = BookingUser.tenKhach;
                    textBox9.Text = BookingUser.emailNguoiDat; // email
                    textBox8.Text = BookingUser.soDienThoaiNguoiDat; // tel
                    textBox7.Text = BookingUser.datBoi; // by
                    textBox3.Text = BookingUser.coc.ToString();

                    // Logic kiểm tra trạng thái Booking
                    if (BookingUser.code != null)
                    {
                        textBox12.Text = "In House";
                    }
                    else
                    {
                        textBox12.Text = "No Show";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin Booking: " + ex.Message, "Lỗi");
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // xem thong tin khach
        {
            string name = BookingGlobal.datBoi;
            string email = BookingGlobal.emailNguoiDat;
            string passport = BookingGlobal.passport;
            string sdt = BookingGlobal.soDienThoaiNguoiDat;
            string ghichu = BookingGlobal.ghiChu;
            string code = BookingGlobal.code;
            string quoctichIndex = comboBox1.SelectedIndex.ToString();
            string gioitinhIndex = comboBox2.SelectedIndex.ToString();
            string congtyIndex = comboBox3.SelectedIndex.ToString();
            try
            {
                this.Hide();
                thongtinkhach main = new thongtinkhach(name, email, passport, sdt, code, ghichu,gioitinhIndex,congtyIndex,quoctichIndex);
                main.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở thanh toán: " + ex.Message, "Lỗi");
            }

        }
        private int GetRoomType(string nameRoom) // room type
        {
            switch (nameRoom)
            {
                case "SUP":
                    return 0;
                case "DLX":
                    return 1;
                case "EXE":
                    return 2;
                case "APT":
                    return 3;
                default:
                    return -1;
            }
        }

        private int GetPriceType(string namePrice) // ma gia (rate code)
        {
            switch (namePrice)
            {
                case "FO":
                    return 0;
                case "Sale":
                    return 1;
                case "Company":
                    return 2;
                default:
                    return -1;
            }
        }
        private int GetAppType(string namePrice) // comp/agent
        {
            switch (namePrice)
            {
                case "Agoda":
                    return 0;
                case "Travelloca":
                    return 1;
                case "Trip":
                    return 2;
                default:
                    return -1;
            }
        }

        private int GetCtType(string nameapp) // type
        {
            switch (nameapp)
            {
                case "Walk-In":
                    return 0;
                case "Online":
                    return 1;
                case "Comporate":
                    return 2;
                case "Sale":
                    return 3;
                default:
                    return -1;
            }
        }

        private int GetSource(string nameSource) // source
        {
            switch (nameSource)
            {
                case "FO":
                    return 0;
                case "Sale":
                    return 1;
                case "comporate":
                    return 2;
                case "Facebook":
                    return 3;
                default:
                    return -1;
            }
        }

        private int GetPyType(string namepay) // payment
        {
            switch (namepay)
            {
                case "Bank":
                    return 0;
                case "Card":
                    return 1;
                case "Cash":
                    return 2;
                default:
                    return -1;
            }
        }

        // --- CÁC HÀM XỬ LÝ SỰ KIỆN KHÁC (GIỮ NGUYÊN) ---

        private void label7_Click(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
        private void label20_Click(object sender, EventArgs e) { }
        private void label18_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void D_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void button6_Click(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox12_TextChanged(object sender, EventArgs e) { }
        private void textBox11_TextChanged(object sender, EventArgs e) { }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string maphong = BookingGlobal.maPhong;
            TimeSpan songay = BookingGlobal.ngayDi - BookingGlobal.ngayDen;
            float TotalMoney = (float)(Math.Ceiling(songay.TotalDays) * BookingGlobal.giaPhong);
            float coc = (float)BookingGlobal.coc;
            string namekhach = BookingGlobal.tenKhach;
            string code = BookingGlobal.code;
            try
            {
                this.Hide();
                Form1 main = new Form1(maphong, TotalMoney, coc, namekhach, code);
                main.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở thanh toán: " + ex.Message, "Lỗi");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string uproom = textBox1.Text;
            double upodem = textBox2.Text.Trim().ToString() != "" ? Convert.ToDouble(textBox2.Text.Trim().ToString()) : 0;
            double upadult = tbAdults.Text.Trim().ToString() != "" ? Convert.ToDouble(tbAdults.Text.Trim().ToString()) : 0;
            double uptreem = textBox4.Text.Trim().ToString() != "" ? Convert.ToDouble(textBox4.Text.Trim().ToString()) : 0;
            string upprice = textBox5.Text;
            string upcode = textBox6.Text;
            string upby = textBox7.Text;
            string uptel = textBox8.Text;
            string upemail = textBox9.Text;
            string upname = textBox10.Text;
            double upcoc = textBox3.Text.Trim().ToString() != "" ? Convert.ToDouble(textBox3.Text.Trim().ToString()) : 0;
            string upghichu = textBox11.Text;
            DateTime upNde = dateTimePicker1.Value;
            DateTime upNdi = dateTimePicker2.Value;
            string uploaiphong = comboBox1.SelectedItem?.ToString();
            string upmagia = comboBox2.SelectedIndex.ToString();
            string upptth = comboBox3.SelectedItem?.ToString();
            string upnguon = comboBox4.SelectedItem?.ToString();
            string uploaiBooking = comboBox5.SelectedItem?.ToString();
            string upcongty = comboBox6.SelectedItem?.ToString();


            try
            {
                var db = DatabaseMain.GetDatabase();
                var Paymentcollection = db.GetCollection<newBooking>("newBooking");
                var filter = Builders<newBooking>.Filter.Eq(p => p.code, codeBooking);

                var update = Builders<newBooking>.Update
                    .Set(p => p.maPhong, uproom)
                    .Set(p => p.soDem, upodem)
                    .Set(p => p.soNguoiLon, upadult)
                    .Set(p => p.soTreEm, uptreem)
                    .Set(p => p.giaPhong, Convert.ToDouble(upprice))
                    .Set(p => p.datBoi, upby)
                    .Set(p => p.soDienThoaiNguoiDat, uptel)
                    .Set(p => p.emailNguoiDat, upemail)
                    .Set(p => p.tenKhach, upname)
                    .Set(p => p.coc, upcoc)
                    .Set(p => p.ghiChu, upghichu)
                    .Set(p => p.ngayDen, upNde)
                    .Set(p => p.ngayDi, upNdi)
                    .Set(p => p.loaiPhong, uploaiphong)
                    .Set(p => p.maGia, upmagia)
                    .Set(p => p.hinhThucThanhToan, upptth)
                    .Set(p => p.nguon, upnguon)
                    .Set(p => p.loaiBooking, uploaiBooking)
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

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }

}
