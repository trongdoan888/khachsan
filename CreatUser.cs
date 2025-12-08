using khachsan.Model;
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
using khachsan.Database;


namespace khachsan
{
    public partial class CreatUser : Form
    {
        public CreatUser()
        {
            InitializeComponent();
        }

        private void lblpassagain_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string mnv = textBox1.Text.Trim().ToString();
            string taiKhoan = textBox2.Text.Trim().ToString();
            string matKhau = textBox3.Text.Trim().ToString();
            string passAgain = textBox4.Text.Trim().ToString();


            // 1. Kiểm tra không được bỏ trống
            if (string.IsNullOrEmpty(mnv) ||
                string.IsNullOrEmpty(taiKhoan) ||
                string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(passAgain))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả các thông tin!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra tài khoản không có ký tự đặc biệt
            // Chỉ cho phép chữ + số
            if (!taiKhoan.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Tài khoản không được chứa ký tự đặc biệt!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Kiểm tra độ dài mật khẩu
            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Kiểm tra 2 mật khẩu có trùng nhau không
            if (matKhau != passAgain)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var db = DatabaseMain.GetDatabase();
                var accountCollection = db.GetCollection<account>("account");

                var filter = Builders<account>.Filter.Or(
                    Builders<account>.Filter.Eq(a => a.matKhau, matKhau),
                    Builders<account>.Filter.Eq(a => a.taiKhoan, taiKhoan)
                );

                var existingAccount = accountCollection.Find(filter).FirstOrDefault();

                if (existingAccount != null)
                {
                    if (existingAccount.maNV == mnv)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác!", "Lỗi Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else // existingAccount.taikhoan == taikhoan
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng nhập tên khác!", "Lỗi Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                account newAccount = new account()
                {
                    // Id sẽ được MongoDB tự động tạo
                    maNV = mnv,
                    taiKhoan = taiKhoan,
                    matKhau = matKhau // KHUYẾN NGHỊ: Nên dùng hàm băm (hashing) ở đây để bảo mật!
                };

                accountCollection.InsertOne(newAccount);

                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Dọn dẹp TextBox
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản vào database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void CreatUser_Load(object sender, EventArgs e)
        {

        }
    }
}