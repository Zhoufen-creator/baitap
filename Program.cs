using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace demo_C_
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
            {
                new Student(1, "Khang", 20),
                new Student(2, "Nguyen", 22),
                new Student(3, "Luan", 18),
                new Student(4, "Anh", 21),
                new Student(5, "Minh", 16)
            };
            // In ra danh sach toan bo hoc sinh
            var query = from student in list
                        select student;
            query.ToList().ForEach(s => Console.WriteLine(s));

            // Tim va in ra danh sach hoc sinh co tuoi tu 15 den 18
            var query2 = from student in list
                         where student.Age >= 15 && student.Age <= 18
                         select student;
            query2.ToList().ForEach(s => Console.WriteLine(s));

            // Tim va in ra danh sach hoc sinh co ten bat dau bang chu 'A'
            var query3 = from student in list
                         where student.Name.StartsWith("A")
                         select student;
            query3.ToList().ForEach(s => Console.WriteLine(s));

            // Tinh tong so tuoi cua toan bo hoc sinh
            var toltalAge = (from student in list select student.Age).Sum();
            Console.WriteLine($"Tong so tuoi cua toan bo hoc sinh: {toltalAge}");

            // Tim va in ra hoc sinh co tuoi lon nhat
            var maxAge = (from student in list select student.Age).Max();
            var studentMaxAge = from student in list
                                where student.Age == maxAge
                                select student;
            studentMaxAge.ToList().ForEach(s => Console.WriteLine(s));

            // Sap xep danh sach hoc sinh theo tuoi tang dan va in ra danh sach sau khi sap xep
            var  query4 = from student in list
                          orderby student.Age
                          select student;
             query4.ToList().ForEach(s => Console.WriteLine( s));             

          
        }
    }
}