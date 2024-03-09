namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestObjectsInformation()
        {
            // Arrange
            Teacher t1 = new Teacher() { Name = "Nguyen Van A", Age = 40, Department = "Information Technology" };
            Teacher t2 = new Teacher() { Name = "Tran Thi B", Age = 35, Department = "Mathematics" };
            Teacher t3 = new Teacher() { Name = "Le Van C", Age = 38, Department = "Physics" };

            Student s1 = new Student() { Name = "Pham Thi D", Age = 20, Course = null, Subjects = new List<Subject>() };
            Student s2 = new Student() { Name = "Nguyen Van E", Age = 21, Course = null, Subjects = new List<Subject>() };
            Student s3 = new Student() { Name = "Tran Thi F", Age = 19, Course = null, Subjects = new List<Subject>() };

            Department d1 = new Department() { Name = "Information Technology", Teachers = new List<Teacher>() { t1 } };
            Department d2 = new Department() { Name = "Mathematics", Teachers = new List<Teacher>() { t2 } };
            Department d3 = new Department() { Name = "Physics", Teachers = new List<Teacher>() { t3 } };

            Course c1 = new Course() { Name = "C# .NET", Students = new List<Student>() { s1, s2 } };
            Course c2 = new Course() { Name = "Java", Students = new List<Student>() { s3 } };

            Subject sub1 = new Subject() { Name = "Object-Oriented Programming", Teacher = t1 };
            Subject sub2 = new Subject() { Name = "Calculus", Teacher = t2 };
            Subject sub3 = new Subject() { Name = "Electronics", Teacher = t3 };

            // Act and Assert
            Assert.Equal("Nguyen Van A", t1.Name);
            Assert.Equal(40, t1.Age);
            Assert.Equal("Information Technology", t1.Department);

            Assert.Equal("Tran Thi B", t2.Name);
            Assert.Equal(35, t2.Age);
            Assert.Equal("Mathematics", t2.Department);

            Assert.Equal("Le Van C", t3.Name);
            Assert.Equal(38, t3.Age);
            Assert.Equal("Physics", t3.Department);

            Assert.Equal("Pham Thi D", s1.Name);
            Assert.Equal(20, s1.Age);
            Assert.Null(s1.Course);
            Assert.Empty(s1.Subjects);

            Assert.Equal("Nguyen Van E", s2.Name);
            Assert.Equal(21, s2.Age);
            Assert.Null(s2.Course);
            Assert.Empty(s2.Subjects);

            Assert.Equal("Tran Thi F", s3.Name);
            Assert.Equal(19, s3.Age);
            Assert.Null(s3.Course);
            Assert.Empty(s3.Subjects);

            Assert.Equal("Information Technology", d1.Name);
            Assert.Single(d1.Teachers);
            Assert.Contains(t1, d1.Teachers);

            Assert.Equal("Mathematics", d2.Name);
            Assert.Single(d2.Teachers);
            Assert.Contains(t2, d2.Teachers);

            Assert.Equal("Physics", d3.Name);
            Assert.Single(d3.Teachers);
            Assert.Contains(t3, d3.Teachers);

            Assert.Equal("C# .NET", c1.Name);
            Assert.Equal(2, c1.Students.Count);
            Assert.Contains(s1, c1.Students);
            Assert.Contains(s2, c1.Students);

            Assert.Equal("Java", c2.Name);
            Assert.Single(c2.Students);
            Assert.Contains(s3, c2.Students);

            Assert.Equal("Object-Oriented Programming", sub1.Name);
            Assert.Equal(t1, sub1.Teacher);

            Assert.Equal("Calculus", sub2.Name);
            Assert.Equal(t2, sub2.Teacher);

            Assert.Equal("Electronics", sub3.Name);
            Assert.Equal(t3, sub3.Teacher);
        }
        [Fact]
        public void TestMethod()
        {
            Console.WriteLine("This will be printed in the Output Window.");
            Assert.True(true);
        }
    }

    internal class Subject
    {
        internal string Name;
        internal Teacher Teacher;
    }

    internal class Course
    {
        internal string Name;
        internal List<Student> Students;
    }

    internal class Department
    {
        internal string Name;
        internal List<Teacher> Teachers;
    }

    internal class Student
    {
        internal string Name;
        internal int Age;
        internal List<Subject> Subjects;

        public object Course { get; internal set; }
    }

    internal class Teacher
    {
        internal string Name;
        internal int Age;
        internal string Department;
    }
}