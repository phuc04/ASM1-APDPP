using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDP
{
    public class Department
    {
        // Sử dụng thuộc tính để đóng gói trường dữ liệu
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }

        // Sử dụng chỉ số để truy cập đến các giáo viên trong phòng ban
        public Teacher this[int index]
        {
            get { return Teachers[index]; }
            set { Teachers[index] = value; }
        }

        // Phương thức để hiển thị thông tin của phòng ban
        public void ShowInfo()
        {
            Console.WriteLine("Department: {0}", Name);
            Console.WriteLine("Teachers:");
            foreach (var teacher in Teachers)
            {
                Console.WriteLine("- {0}", teacher.Name);
            }
        }
    }
}
