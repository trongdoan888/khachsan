using khachsan.Database;
using khachsan.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khachsan
{
    public partial class thembooking : Form
    {
        public thembooking()
        {
            InitializeComponent();
        }

        private void thembooking_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim().ToString();
            string gioitinh = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(gioitinh))
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            DateTime Ngayden = dateTimePicker1.Value;
            DateTime Ngaydi = dateTimePicker2.Value;
            int sodem = (int)(Ngaydi - Ngayden).TotalDays;
            string Nguoilon = textBox3.Text.Trim().ToString();
            string Treem = textBox4.Text.Trim().ToString();

            string typephong = comboBox5.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(typephong))
            {
                MessageBox.Show("Vui lòng chọn Loại phòng!");
                return;
            }
            string nguon = comboBox4.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nguon))
            {
                MessageBox.Show("Vui lòng chọn Nguồn khách!");
                return;
            }

            string loaiphong = comboBox7.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(loaiphong))
            {
                MessageBox.Show("Vui lòng chọn Loại hình đặt phòng!");
                return;
            }

            string magia = comboBox2.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(magia))
            {
                MessageBox.Show("Vui lòng chọn Mã giá!");
                return;
            }

            double gia = textBox5.Text.Trim().ToString() != "" ? Convert.ToDouble(textBox5.Text.Trim().ToString()) : 0;
            int soluongphong = textBox12.Text.Trim().ToString() != "" ? Convert.ToInt32(textBox6.Text.Trim().ToString()) : 0;
            int sophong = textBox13.Text.Trim().ToString() != "" ? Convert.ToInt32(textBox6.Text.Trim().ToString()) : 0;
            string phuogthucthanhtoan = comboBox3.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(phuogthucthanhtoan))
            {
                MessageBox.Show("Vui lòng chọn Phương thức thanh toán!");
                return;
            }

            string quocgia = comboBox8.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(quocgia))
            {
                MessageBox.Show("Vui lòng chọn Quốc gia!");
                return;
            }

            string congty = comboBox6.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(congty))
            {
                MessageBox.Show("Vui lòng chọn Công ty!");
                return;
            }

            string ghichu = textBox11.Text.Trim().ToString();
            string nguoidat = textBox7.Text.Trim().ToString();
            string sodienthoainguoidat = textBox8.Text.Trim().ToString();
            string emailnguoidat = textBox9.Text.Trim().ToString();
            string code = textBox6.Text.Trim().ToString();

            // kiểm tra xem biến code có rỗng không
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Vui lòng nhập Mã đặt phòng!");
                return;
            }

            try
            {
                var db = DatabaseMain.GetDatabase();
                var newBookingCollection = db.GetCollection<newBooking>("newBooking");

                var filter = Builders<newBooking>.Filter.Or(
                    Builders<newBooking>.Filter.Eq(a => a.code, code)
                );

                var existingAccount = newBookingCollection.Find(filter).FirstOrDefault();

                if (existingAccount != null)
                {
                    if (existingAccount.code == code)
                    {
                        MessageBox.Show("Mã code đã tồn tại", "Lỗi Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                newBooking newBX = new newBooking()
                {
                    code = code,
                    tenKhach = name,
                    gioiTinh = gioitinh,
                    ngayDen = Ngayden,
                    ngayDi = Ngaydi,
                    soNguoiLon = Convert.ToInt32(Nguoilon),
                    soTreEm = Convert.ToInt32(Treem),
                    soDem = sodem,
                    giaPhong = gia,
                    hinhThucThanhToan = phuogthucthanhtoan,
                    ghiChu = ghichu,
                    loaiBooking = typephong,
                    soluong = soluongphong,
                    soPhong = sophong,
                    nguon = nguon,
                    loaiPhong = loaiphong,
                    maGia = magia,
                    quocTich = quocgia,
                    congty = congty,
                    datBoi = nguoidat,
                    soDienThoaiNguoiDat = sodienthoainguoidat,
                    emailNguoiDat = emailnguoidat
                };
                newBookingCollection.InsertOne(newBX);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm booking: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
