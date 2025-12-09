using khachsan.Database;
using khachsan.Model;
using MongoDB.Bson.IO;
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
        private float TotalMoney;
        private float TienCoc;
        private string nameKhach;
        private string nameRoom;
        public Form1(string maphong, float totalMoney, float coc, string datboi, string code)
        {
            codeBooking = code;
            TotalMoney = totalMoney;
            TienCoc = coc;
            nameKhach = datboi;
            nameRoom = maphong;
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
                var Paymentcollection = db.GetCollection<Payment>("Payment");
                var PayUser = Paymentcollection.Find(u => u.code == codeBooking).FirstOrDefault();
                if (PayUser != null)
                {

                    comboBox1.SelectedIndex = 1;

                    textBox6.Text = PayUser.tenNguoiTra;
                    textBox5.Text = PayUser.maPhong;
                    textBox1.Text = PayUser.thanhTien.ToString();
                    textBox2.Text = PayUser.soTienDaTra.ToString();
                    textBox3.Text = PayUser.soTienConLai.ToString();
                }
                else
                {
                    comboBox1.SelectedIndex = 0;
                    textBox1.Text = TotalMoney.ToString();
                    textBox2.Text = TienCoc.ToString();
                    textBox3.Text = (TotalMoney - TienCoc).ToString();
                    textBox5.Text = nameRoom;
                    textBox6.Text = nameKhach;

                }
            }
            catch
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double uptotal = textBox1.Text.Trim().ToString() != "" ? Convert.ToDouble(textBox1.Text.Trim().ToString()) : 0;
            double upcoc = textBox2.Text.Trim().ToString() != "" ? Convert.ToDouble(textBox2.Text.Trim().ToString()) : 0;
            string upname = textBox6.Text.Trim().ToString();
            try
            {
                var db = DatabaseMain.GetDatabase();
                var Paymentcollection = db.GetCollection<Payment>("Payment");
                var filter = Builders<Payment>.Filter.Eq(p => p.code, codeBooking);

                var update = Builders<Payment>.Update
                    .Set(p => p.thanhTien, uptotal)
                    .Set(p => p.soTienDaTra, upcoc)
                    .Set(p => p.soTienConLai, TotalMoney - TienCoc)
                    .Set(p => p.tenNguoiTra, upname);

                var result = Paymentcollection.UpdateOne(
                    filter,
                    update,
                    new UpdateOptions { IsUpsert = true } // insert nếu chưa có
                );

                if (result.MatchedCount > 0)
                {
                    MessageBox.Show("Cập nhật thanh toán thành công!");
                }
                else if (result.UpsertedId != null)
                {
                    MessageBox.Show("Bản ghi mới đã được tạo!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật Payment: " + ex.Message);
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


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
