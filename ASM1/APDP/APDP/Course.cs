using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDP
{
    public class Course
    {
        // Sử dụng thuộc tính để đóng gói trường dữ liệu
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        // Sử dụng chỉ số để truy cập đến các sinh viên trong khóa học
        public Student this[int index]
        {
            get { return Students[index]; }
            set { Students[index] = value; }
        }

        // Phương thức để hiển thị thông tin của khóa học
        public void ShowInfo()
        {
            Console.WriteLine("Course: {0}", Name);
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine("- {0}", student.Name);
            }
        }
    }
}
