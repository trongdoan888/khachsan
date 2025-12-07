using khachsan.Database;
using khachsan.Model;
using MongoDB.Driver;
namespace khachsan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {
            //
        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            //
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var db = DatabaseMain.GetDatabase();
            var usersCollection = db.GetCollection<UserDatabase>("users");
            var users = usersCollection.Find(_ => true).ToList();
            if(users.Count > 0)
            {
                foreach(var user in users)
                {
                    MessageBox.Show($"Mã NV: {user.maNV}, Tài khoản: {user.taiKhoan}, Mật khẩu: {user.matKhau}");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng nào trong cơ sở dữ liệu.");
            }
        }
    }
}
