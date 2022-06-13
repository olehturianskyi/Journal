using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    internal class Student
    {
        int id;
        string name;
        string secondName;
        List<int> raiting = new List<int>();

        public int Id { get; set; }
        public string Name { get { return name; } set { name = value; } }
        public string SecondName { get { return secondName; } set { secondName = value; } }
        public List<int> Rating
        {
            get { return raiting; }
            set { raiting = value; }
        }

       public Student(int id, string name, string secondName, List<int> raiting)
        {            
            this.id = id;
            this.name = name;
            this.secondName = secondName;
            this.raiting = raiting;
            Student student = new Student(id, name, secondName, raiting);
        }

    }
}
