using khachsan.Database;
using khachsan.Model;
using MongoDB.Driver;
using System;
using System.Collections.Concurrent;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Lấy ngày và tên phòng từ giao diện
            DateTime Ngaytim = dateTimePicker1.Value.Date; // chỉ lấy phần Date
            string nameRoom = button2.Text;
            int nameroom = int.Parse(nameRoom);
            // mã phòng
            MessageBox.Show("Tìm booking cho phòng: " + nameRoom + " vào ngày: " + Ngaytim.ToShortDateString());
            try
            {
                var db = DatabaseMain.GetDatabase();
                var bookingCollection = db.GetCollection<newBooking>("newBooking");
                var allBookings = bookingCollection.Find(u => true).ToList();
                int count = allBookings.Count;

                for (int i = 0; i < count; i++)
                {
                    if (allBookings[i].maPhong == nameroom && allBookings[i].ngayDen.Date == Ngaytim)
                    {
                        string coden = allBookings[i].code;
                        this.Hide();
                        xemBooking main = new xemBooking(coden, nameRoom);
                        main.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy booking nào cho phòng này và ngày đã chọn!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm booking: " + ex.Message);
            }

        }
       
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy ngày và tên phòng từ giao diện
            DateTime Ngaytim = dateTimePicker1.Value.Date; // chỉ lấy phần Date
            string nameRoom = button1.Text;
            int nameroom = int.Parse(nameRoom);
            // mã phòng
            MessageBox.Show("Tìm booking cho phòng: " + nameRoom + " vào ngày: " + Ngaytim.ToShortDateString());
            try
            {
                var db = DatabaseMain.GetDatabase();
                var bookingCollection = db.GetCollection<newBooking>("newBooking");
                var allBookings = bookingCollection.Find(u => true).ToList();
                int count = allBookings.Count;

                for (int i = 0; i < count; i++)
                {
                    if (allBookings[i].maPhong == nameroom && allBookings[i].ngayDen.Date == Ngaytim)
                    {
                        string coden = allBookings[i].code;
                        this.Hide();
                        xemBooking main = new xemBooking(coden, nameRoom);
                        main.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy booking nào cho phòng này và ngày đã chọn!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm booking: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Lấy ngày và tên phòng từ giao diện
            DateTime Ngaytim = dateTimePicker1.Value.Date; // chỉ lấy phần Date
            string nameRoom = button8.Text;
            int nameroom = int.Parse(nameRoom);
            // mã phòng
            MessageBox.Show("Tìm booking cho phòng: " + nameRoom + " vào ngày: " + Ngaytim.ToShortDateString());
            try
            {
                var db = DatabaseMain.GetDatabase();
                var bookingCollection = db.GetCollection<newBooking>("newBooking");
                var allBookings = bookingCollection.Find(u => true).ToList();
                int count = allBookings.Count;

                for (int i = 0; i < count; i++)
                {
                    if (allBookings[i].maPhong == nameroom && allBookings[i].ngayDen.Date == Ngaytim)
                    {
                        string coden = allBookings[i].code;
                        this.Hide();
                        xemBooking main = new xemBooking(coden, nameRoom);
                        main.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy booking nào cho phòng này và ngày đã chọn!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm booking: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Lấy ngày và tên phòng từ giao diện
            DateTime Ngaytim = dateTimePicker1.Value.Date; // chỉ lấy phần Date
            string nameRoom = button3.Text;
            int nameroom = int.Parse(nameRoom);
            // mã phòng
            MessageBox.Show("Tìm booking cho phòng: " + nameRoom + " vào ngày: " + Ngaytim.ToShortDateString());
            try
            {
                var db = DatabaseMain.GetDatabase();
                var bookingCollection = db.GetCollection<newBooking>("newBooking");
                var allBookings = bookingCollection.Find(u => true).ToList();
                int count = allBookings.Count;

                for (int i = 0; i < count; i++)
                {
                    if (allBookings[i].maPhong == nameroom && allBookings[i].ngayDen.Date == Ngaytim)
                    {
                        string coden = allBookings[i].code;
                        this.Hide();
                        xemBooking main = new xemBooking(coden, nameRoom);
                        main.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy booking nào cho phòng này và ngày đã chọn!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm booking: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Lấy ngày và tên phòng từ giao diện
            DateTime Ngaytim = dateTimePicker1.Value.Date; // chỉ lấy phần Date
            string nameRoom = button4.Text;
            int nameroom = int.Parse(nameRoom);
            // mã phòng
            MessageBox.Show("Tìm booking cho phòng: " + nameRoom + " vào ngày: " + Ngaytim.ToShortDateString());
            try
            {
                var db = DatabaseMain.GetDatabase();
                var bookingCollection = db.GetCollection<newBooking>("newBooking");
                var allBookings = bookingCollection.Find(u => true).ToList();
                int count = allBookings.Count;

                for (int i = 0; i < count; i++)
                {
                    if (allBookings[i].maPhong == nameroom && allBookings[i].ngayDen.Date == Ngaytim)
                    {
                        string coden = allBookings[i].code;
                        this.Hide();
                        xemBooking main = new xemBooking(coden, nameRoom);
                        main.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy booking nào cho phòng này và ngày đã chọn!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm booking: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Lấy ngày và tên phòng từ giao diện
            DateTime Ngaytim = dateTimePicker1.Value.Date; // chỉ lấy phần Date
            string nameRoom = button5.Text;
            int nameroom = int.Parse(nameRoom);
            // mã phòng
            MessageBox.Show("Tìm booking cho phòng: " + nameRoom + " vào ngày: " + Ngaytim.ToShortDateString());
            try
            {
                var db = DatabaseMain.GetDatabase();
                var bookingCollection = db.GetCollection<newBooking>("newBooking");
                var allBookings = bookingCollection.Find(u => true).ToList();
                int count = allBookings.Count;

                for (int i = 0; i < count; i++)
                {
                    if (allBookings[i].maPhong == nameroom && allBookings[i].ngayDen.Date == Ngaytim)
                    {
                        string coden = allBookings[i].code;
                        this.Hide();
                        xemBooking main = new xemBooking(coden, nameRoom);
                        main.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy booking nào cho phòng này và ngày đã chọn!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm booking: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Lấy ngày và tên phòng từ giao diện
            DateTime Ngaytim = dateTimePicker1.Value.Date; // chỉ lấy phần Date
            string nameRoom = button6.Text;
            int nameroom = int.Parse(nameRoom);
            // mã phòng
            MessageBox.Show("Tìm booking cho phòng: " + nameRoom + " vào ngày: " + Ngaytim.ToShortDateString());
            try
            {
                var db = DatabaseMain.GetDatabase();
                var bookingCollection = db.GetCollection<newBooking>("newBooking");
                var allBookings = bookingCollection.Find(u => true).ToList();
                int count = allBookings.Count;

                for (int i = 0; i < count; i++)
                {
                    if (allBookings[i].maPhong == nameroom && allBookings[i].ngayDen.Date == Ngaytim)
                    {
                        string coden = allBookings[i].code;
                        this.Hide();
                        xemBooking main = new xemBooking(coden, nameRoom);
                        main.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy booking nào cho phòng này và ngày đã chọn!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm booking: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Lấy ngày và tên phòng từ giao diện
            DateTime Ngaytim = dateTimePicker1.Value.Date; // chỉ lấy phần Date
            string nameRoom = button7.Text;
            int nameroom = int.Parse(nameRoom);
            // mã phòng
            MessageBox.Show("Tìm booking cho phòng: " + nameRoom + " vào ngày: " + Ngaytim.ToShortDateString());
            try
            {
                var db = DatabaseMain.GetDatabase();
                var bookingCollection = db.GetCollection<newBooking>("newBooking");
                var allBookings = bookingCollection.Find(u => true).ToList();
                int count = allBookings.Count;

                for (int i = 0; i < count; i++)
                {
                    if (allBookings[i].maPhong == nameroom && allBookings[i].ngayDen.Date == Ngaytim)
                    {
                        string coden = allBookings[i].code;
                        this.Hide();
                        xemBooking main = new xemBooking(coden, nameRoom);
                        main.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy booking nào cho phòng này và ngày đã chọn!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm booking: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                thembooking main = new thembooking();
                main.ShowDialog();
                this.Show();
            }
            catch
            {

            }
        }
    }
}
