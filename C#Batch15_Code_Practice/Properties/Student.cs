using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private int id; 
        private string name;
        private int age;

        public int ID
        {
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Id cannot be negative");
                }
                this.id = value;    
            }
            get
            {
                return this.id;
            }
        }
        public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("name cannot be null or empty");
                }
                this.name = value;
            }
            get
            {
                return this.name;   
            }
        }

        public int Age
        {
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("age cannot be negative");
                }
                this.age = value;    
            }
            get 
            {

                return this.age; 
            }
        }

    }
}
