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

namespace khachsan
{
    public partial class Form1 : Form
    {
        private string codeBooking;
        private string nameRoom;
        public Form1(string code, string name)
        {
            codeBooking = code;
            nameRoom = name;
            InitializeComponent();
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var db = DatabaseMain.GetDatabase();
                var Bookingcollection = db.GetCollection<newBooking>("newBooking");
                var PayUser = Bookingcollection.Find(u => u.code == codeBooking).FirstOrDefault();

                if (PayUser != null)
                {
                    int dem = PayUser.soDem;
                    double giaphong = PayUser.giaPhong;
                    double gia = dem * giaphong;

                    textBox1.Text = gia.ToString();
                    textBox5.Text = PayUser.maPhong.ToString();
                    //textBox2.Text = 



                }
            }
            catch
            {

            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
