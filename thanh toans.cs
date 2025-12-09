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
        private void button1_Click(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime Ngaytim = dateTimePicker1.Value;
            string nameRoom = button2.Text;
     
            try
            {
                var db = DatabaseMain.GetDatabase();
                var bookingCollection = db.GetCollection<newBooking>("newBooking");
                var room = bookingCollection.Find(u => u.maPhong == nameRoom).FirstOrDefault();
                if (room == null)
                {
                    MessageBox.Show("Không có booking!!");
                    return;
                }

                    DateTime ngayDi = room.ngayDi.ToLocalTime();
                    DateTime ngayDen = room.ngayDen.ToLocalTime();
                    if ((ngayDen <= Ngaytim && Ngaytim <= ngayDi))
                {
                    MessageBox.Show("Tìm thấy booking cho phòng: " + nameRoom + " vào ngày: " + Ngaytim.ToShortDateString());
                    string coden = room.code;
                    this.Hide();
                    xemBooking main = new xemBooking(coden, nameRoom);
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy booking nào cho phòng này và ngày đã chọn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm booking: " + ex.Message);
            }

        }
       


        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)// log out 
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e) // new account
        {
    
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

   
    }
}
