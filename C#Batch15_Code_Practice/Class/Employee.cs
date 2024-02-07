using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int age { get; set; }

        public string Address {get; set; }  

        public Employee()
            : this(0,"No name", 0,"No address")
        {
            
        }


        public Employee(int id,string name,int age,string address)
        {
            this.Id = id;
            this.Name = name;
            this.age = age;
            this.Address = address; 
        }

        public void Print()
        {
            Console.WriteLine($"{this.Id} {this.Name} {this.age} {this.Address}"); 
        }
    }
}
