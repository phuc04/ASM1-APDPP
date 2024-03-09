using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDP
{
    public abstract class Person
    {
        // Sử dụng thuộc tính để đóng gói các trường dữ liệu
        public string Name { get; set; }
        public int Age { get; set; }

        // Phương thức trừu tượng để hiển thị thông tin của đối tượng
        public abstract void ShowInfo();
    }
}
