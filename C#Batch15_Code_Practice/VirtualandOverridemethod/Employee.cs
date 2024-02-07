using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualandOverridemethod
{
    public  class  Employee
    {
        public string FirstName { get; set; }    
        public string LastName { get; set; }    
        public virtual void Print()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
