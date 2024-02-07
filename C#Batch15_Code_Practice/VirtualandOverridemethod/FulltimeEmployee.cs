using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualandOverridemethod
{
    public class FulltimeEmployee:Employee
    {
        public override void Print()
        {
            Console.WriteLine(FirstName + " " + LastName + "  dashing");
        }
    }
}
