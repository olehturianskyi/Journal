using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    internal class StudentClass
    {
        List<Student> students = new List<Student>();
        public Student Student { get; set; }
        public StudentClass(List<Student> students)
        {
            this.students = students;
            StudentClass student = new StudentClass(students);
        }
        
        
        public void ShowStudentClass() 
        {
            foreach (Student student in students)
            {                
                Console.WriteLine(students.ToString());
            }
        }
        public void AddStudent()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            string secondName = Console.ReadLine();
            List<int> rating = new List<int>();
            Student student = new Student(id, name, secondName, rating);
            student.Name = student.Name;
            students.Prepend(students[0]); 
        }
    }
}
