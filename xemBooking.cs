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
        public xemBooking(string code, string name)
        {
            codeBooking = code;
            nameRoom = name;
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void xemBooking_Load(object sender, EventArgs e)
        {
            //SUP
            //DLX
            //EXE
            //APT
            textBox1.Text = nameRoom;
            textBox2.Text = namePrice;

            try
            {
                var db = DatabaseMain.GetDatabase();
                var Bookingcollection = db.GetCollection<newBooking>("newBooking");
                var BookingUser = Bookingcollection.Find(u => u.code == codeBooking).FirstOrDefault();
                if (BookingUser != null)
                {
                    comboBox1.SelectedIndex = GetRoomType(BookingUser.loaiPhong); // room type

                    comboBox2.SelectedIndex = GetPriceType(BookingUser.maGia);// rate code

                    comboBox6.SelectedIndex = GetAppType(BookingUser.congty); // congty

                    comboBox5.SelectedIndex = GetCtType(BookingUser.loaiBooking); // type

                    comboBox3.SelectedIndex = GetPyType(BookingUser.hinhThucThanhToan); // payment

                    comboBox4.SelectedIndex = GetSource(BookingUser.nguon); // source

                    dateTimePicker1.Value = BookingUser.ngayDen;
                    dateTimePicker2.Value = BookingUser.ngayDi;
                    textBox2.Text = BookingUser.soDem.ToString(); // Night
                    tbAdults.Text = BookingUser.soNguoiLon.ToString(); // adult
                    textBox4.Text = BookingUser.soTreEm.ToString(); // children
                    textBox5.Text = BookingUser.giaPhong.ToString(); // rate
                    textBox6.Text = BookingUser.code; // code
                    textBox11.Text = BookingUser.ghiChu; // comment
                    textBox9.Text = BookingUser.emailNguoiDat; // email
                    textBox8.Text = BookingUser.soDienThoaiNguoiDat; // tel
                    textBox7.Text = BookingUser.datBoi; // by
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
            catch
            {

            }
        }
        private int GetRoomType(string nameRoom) //  room type
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
        private int GetAppType(string namePrice) // copm/agent
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void D_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
