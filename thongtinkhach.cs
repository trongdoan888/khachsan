using khachsan.Database;
using khachsan.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace khachsan
{
    public partial class thongtinkhach : Form
    {
        private string codeBooking;
        private string nameRoom;
        private string quoctich;
        private string gioitinh;
        private string congty;
        public thongtinkhach(string code, string name)
        {
            codeBooking = code;
            nameRoom = name;
            InitializeComponent();
        }

        public thongtinkhach(DateTime ngaytim, string nameRoom)
        {
            this.nameRoom = nameRoom;
        }

        public thongtinkhach()
        {
        }

        private void thongtinkhach_Load(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin Booking: " + ex.Message, "Lỗi");
            }
        }

        private int GetGT(string gioitinh)
        {

            switch (gioitinh)
            {
                case "Nam": return 0;
                case "Nữ": return 1;
                default: return -1;
            }
        }
        private int GetQuocTichIndex(string quoctich)
        {

            switch (quoctich)
            {
                case "Việt Nam": return 0;
                case "Trung Quốc": return 1;
                case "USA": return 2;
                case "Nhật": return 3;
                default: return -1;
            }
        }

        private int GetCompAgentIndex(string Comp)
        {

            switch (Comp)
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
            // Kiểm tra xem mã Booking đã được tải chưa
            Close();

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
    }
}