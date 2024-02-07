using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    public class Employee
    {
        public string _FirstName;
        public string _LastName;    
        public int _Age;    
        public Employee(string FirstName,string LastName,int Age)
        {
            this._FirstName = FirstName;
            this._LastName = LastName;
            this._Age = Age;    
        }   

        public void Print()
        {
            Console.WriteLine($"{this._FirstName}{this._LastName}{this._Age}");

        }
        ~ Employee() 
        { 
        }
    }
}
