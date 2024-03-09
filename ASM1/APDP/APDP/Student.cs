using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APDP
{
    public class Student : Person
    {
        // Sử dụng thuộc tính để đóng gói trường dữ liệu
        public Course Course { get; set; }
        public List<Subject> Subjects { get; set; }

        // Phương thức ghi đè để hiển thị thông tin của sinh viên
        public override void ShowInfo()
        {
            Console.WriteLine("Student: {0}, Age: {1}, Course: {2}", Name, Age, Course?.Name);
            Console.WriteLine("Subjects:");
            foreach (var subject in Subjects)
            {
                Console.WriteLine("- {0}", subject.Name);
            }
        }
    }
}
