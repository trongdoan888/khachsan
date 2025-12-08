using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

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
            string codePhong = "10001";
            string nameRoom = button2.Text;
            try
            {
                this.Hide();
                xemBooking main = new xemBooking(codePhong, nameRoom);
                main.ShowDialog();
                this.Show();
            }
            catch
            {

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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Login main = new Login();
                main.ShowDialog();
                this.Show();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string codePhong = "10002";
            string nameRoom = button3.Text;
            try
            {
                this.Hide();
                xemBooking main = new xemBooking(codePhong, nameRoom);
                main.ShowDialog();
                this.Show();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string codePhong = "10003";
            string nameRoom = button4.Text;
            try
            {
                this.Hide();
                xemBooking main = new xemBooking(codePhong, nameRoom);
                main.ShowDialog();
                this.Show();
            }
            catch
            {


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string codePhong = "10004";
            string nameRoom = button5.Text;
            try
            {
                this.Hide();
                xemBooking main = new xemBooking(codePhong, nameRoom);
                main.ShowDialog();
                this.Show();
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string codePhong = "10005";
            string nameRoom = button6.Text;
            try
            {
                this.Hide();
                xemBooking main = new xemBooking(codePhong, nameRoom);
                main.ShowDialog();
                this.Show();
            }
            catch
            {


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string codePhong = "10006";
            string nameRoom = button7.Text;
            try
            {
                this.Hide();
                xemBooking main = new xemBooking(codePhong, nameRoom);
                main.ShowDialog();
                this.Show();
            }
            catch
            {


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
            //try
            //{
            //    this.Hi
            //}
            //catch { }
        }
    }
}
