using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
namespace khachsan.Database
{
    internal class DatabaseMain
    {
        public static MongoClient _mongoDBClient = new MongoClient("mongodb+srv://trong111:111@cluster0.f16pvhs.mongodb.net/");
        private const string DatabaseName = "khachsan";
        public static IMongoDatabase GetDatabase()
        {
            try
            {
                Console.WriteLine("Kết nối thành công");
                return _mongoDBClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi kết nối MongoDB Server: {ex.Message}");
                throw new InvalidOperationException("KHÔNG THỂ KẾT NỐI ĐẾN MONGODB. VUI LÒNG KIỂM TRA SERVER.", ex);
            }
        }
    }
}
