using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Сформувати список певної кількості учнів класу. Кожен учень має певну кількість оцінок з предмету "Інформатика". 
 * Реалізувати можливість 
 *              - відтворення списку учнів з результатами успішності учнів з предмету
 *              - додавання учня до списку та видалення із списку
 *              - додавання оцінки
 */
namespace Journal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student(0, "", "", null);
            List<Student> students = new List<Student>();
            StudentClass student = new StudentClass(students);

            student.AddStudent();
            Console.ReadLine();
            student.ShowStudentClass();
            Console.ReadLine();
        }
    }
}
