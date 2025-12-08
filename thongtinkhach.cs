using khachsan.Database;
using khachsan.Model;
using MongoDB.Driver; // Cần thiết cho thao tác MongoDB
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace khachsan
{
    public partial class thongtinkhach : Form
    {
        private string _codeBooking; // Biến lưu trữ mã Booking được truyền vào

        // Các biến private khác của bạn (Giữ nguyên)

        private string qt;
        private string gt;
        private string Comp;

        // Constructor mới nhận mã code
        public thongtinkhach(string code)
        {
            InitializeComponent();
            this._codeBooking = code;
        }

        // *** THÊM CONSTRUCTOR MẶC ĐỊNH (Quan trọng nếu Form được gọi không tham số) ***
        public thongtinkhach()
        {
            InitializeComponent();
        }

        private void thongtinkhach_Load(object sender, EventArgs e)
        {


            try
            {
                var db = DatabaseMain.GetDatabase();
                var Bookingcollection = db.GetCollection<newBooking>("newBooking");


                var BookingUser = Bookingcollection.Find(u => u.code == _codeBooking).FirstOrDefault();

                if (BookingUser != null)
                {

                    textBox1.Text = BookingUser.tenKhach;        // Name
                    textBox3.Text = BookingUser.emailNguoiDat;   // Email
                    textBox5.Text = BookingUser.passport;        // Passport
                    textBox11.Text = BookingUser.ghiChu;         // Comments
                    textBox7.Text = BookingUser.soDienThoaiNguoiDat;

                    comboBox2.SelectedIndex = GetGT(BookingUser.gioiTinh); // Giới tính


                    comboBox1.SelectedIndex = GetQuocTichIndex(BookingUser.quocTich);
                    comboBox3.SelectedIndex = GetCompAgentIndex(BookingUser.congty);

                }
                else
                {
                    MessageBox.Show($"Không tìm thấy Booking với mã: {_codeBooking}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin khách: " + ex.Message, "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private int GetGT(string gt) 
        {

            switch (gt)
            {
                case "Nam": return 0;
                case "Nữ": return 1;
                default: return -1;
            }
        }
        private int GetQuocTichIndex(string qt) 
        {

            switch (qt)
            {
                case "Việt Nam": return 0;
                case "Lào": return 1;
                case "Bỉ": return 2;
                default: return -1;
            }
        }

        private int GetCompAgentIndex(string Comp) 
        {

            switch (Comp)
            {
                case "Agoda": return 0;
                case "Traveloka": return 1;
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
            if (string.IsNullOrEmpty(_codeBooking))
            {
                MessageBox.Show("Không có mã Booking để cập nhật. Vui lòng kiểm tra lại.", "Lỗi");
                return;
            }

            try
            {
                var db = DatabaseMain.GetDatabase();
                var Bookingcollection = db.GetCollection<newBooking>("newBooking");

                // 1. Tạo Filter để tìm đúng tài liệu cần cập nhật
                var filter = Builders<newBooking>.Filter.Eq(u => u.code, _codeBooking);

                // 2. Tạo Update Definition: Cập nhật các trường thông tin khách hàng
                var update = Builders<newBooking>.Update
                    .Set(u => u.tenKhach, textBox1.Text.Trim())
                    .Set(u => u.emailNguoiDat, textBox3.Text.Trim())
                    .Set(u => u.passport, textBox5.Text.Trim())
                    .Set(u => u.ghiChu, textBox11.Text.Trim())
                    .Set(u => u.soDienThoaiNguoiDat, textBox7.Text.Trim())

                    // LƯU Ý: Lấy giá trị chuỗi (string) từ ComboBox đã chọn
                    .Set(u => u.quocTich, comboBox1.SelectedItem.ToString())
                    .Set(u => u.congty, comboBox3.SelectedItem.ToString());

                // 3. Thực hiện Cập nhật
                var result = Bookingcollection.UpdateOne(filter, update);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thành công");
                    this.Close();
                }
                else if (result.MatchedCount > 0 && result.ModifiedCount == 0)
                {
                    MessageBox.Show("Không có thay đổi nào được lưu.", "Lưu ý");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Booking để cập nhật.", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin khách: " + ex.Message, "Lỗi MongoDB");
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
    }
}