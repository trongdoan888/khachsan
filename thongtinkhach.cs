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
                var BookingUser = Bookingcollection.Find(u => u.code == "323232").FirstOrDefault();
                if (BookingUser != null)
                {
                    textBox1.Text = BookingUser.emailNguoiDat;
                }
            }
            catch
            {

            }
        }
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
    }
}
