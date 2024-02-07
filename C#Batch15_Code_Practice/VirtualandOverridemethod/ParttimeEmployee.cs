using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualandOverridemethod
{
    public class ParttimeEmployee:Employee
    {
        public override void Print()
        {
            Console.WriteLine(FirstName + " " + LastName + " smart");
        }
    }
}
