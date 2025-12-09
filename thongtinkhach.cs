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