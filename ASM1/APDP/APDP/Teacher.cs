using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDP
{
    public class Teacher : Person
    {
        // Sử dụng thuộc tính để đóng gói trường dữ liệu
        public string Department { get; set; }

        // Phương thức ghi đè để hiển thị thông tin của giáo viên
        public override void ShowInfo()
        {
            Console.WriteLine("Teacher: {0}, Age: {1}, Department: {2}", Name, Age, Department);
        }
    }
}
