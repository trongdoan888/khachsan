using khachsan.Database;
using khachsan.Model;
using khachsan.Properties;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToString();
            string password = textBox2.Text.Trim().ToString();

            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var db = DatabaseMain.GetDatabase();
                var Usercollection = db.GetCollection<account>("account");
                var user = Usercollection.Find(acc => acc.taiKhoan == username && acc.matKhau == password).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                else
                {

                    MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";

                    try
                    {

                        this.Hide();
                        Form2 main = new Form2();
                        main.ShowDialog();
                        this.Show();
                    }
                    catch
                    {

                    }
                }


            }
            catch
            {

            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
