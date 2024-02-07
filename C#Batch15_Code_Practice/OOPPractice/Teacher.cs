using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    public class Teacher
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Teaches;

        public Teacher(int id, string FirstName,string lastname,string Teaches)
        {
            this.FirstName = FirstName; 
            this.LastName = lastname;   
            this.Id = id;
            this.Teaches = Teaches; 

        }

        public void PrintInfo()
        {
            Console.WriteLine(this.FirstName);
            Console.WriteLine(this.LastName);
            Console.WriteLine(this.Id);
            Console.WriteLine(this.Teaches);
        }


       

    }
}
