using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    public class Student
    {
        public int id;
        public string name;
        public int age;
        public string UniversityName;

        public Student(int id, string name, int age, string UniversityName) 
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.UniversityName = UniversityName;
        
        }    

        public void PrintInfo()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.UniversityName);

        }
    }
}
