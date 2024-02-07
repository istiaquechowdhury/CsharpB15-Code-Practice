using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    public interface ICar3 : ICar2,IVehicle
    {
        string Name { get; set; }
    }
}
