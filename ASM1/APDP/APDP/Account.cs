using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDP
{
    public class Account
    {
        // Sử dụng thuộc tính để đóng gói trường dữ liệu
        public string Username { get; set; }
        public string Password { get; set; }

        // Phương thức để kiểm tra đăng nhập
        public bool Login(string username, string password)
        {
            return username == Username && password == Password;
        }
    }
}
