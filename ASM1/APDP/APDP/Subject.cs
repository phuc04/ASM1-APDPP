using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDP
{
    public class Subject
    {
        // Sử dụng thuộc tính để đóng gói trường dữ liệu
        public string Name { get; set; }
        public Teacher Teacher { get; set; }

        // Phương thức để hiển thị thông tin của môn học
        public void ShowInfo()
        {
            Console.WriteLine("Subject: {0}, Teacher: {1}", Name, Teacher?.Name);
        }
    }
}
