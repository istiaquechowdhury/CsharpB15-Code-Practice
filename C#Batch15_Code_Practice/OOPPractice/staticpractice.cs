using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    public static class staticpractice
    {

        public static double pi;
        public static int radius;

        

        static staticpractice()
        {
           
            staticpractice.pi = 3.1416;
            staticpractice.radius = 5;
        }

        public static double Calculate()
        {
            return pi * radius * radius;
        }

 



    }

}
