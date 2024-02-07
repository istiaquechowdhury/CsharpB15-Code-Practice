

using System.Runtime.CompilerServices;

namespace OOPPractice
{
    public class Customer : ICar3
    {
         public string _firstname;
         public string _lastname;

        public string Name { get; set; }

        public Customer()
        {

        }

        public Customer(string FirstName, string LastName)
        {
            this._firstname = FirstName;
            this. _lastname = LastName;

        }

        public void Print()
        {
            Console.WriteLine($"{this._firstname},{this._lastname}");        
        }

        public void ChasisNo()
        {
            throw new NotImplementedException();
        }

        public void Sound(string message)
        {
            throw new NotImplementedException();
        }

        public void anything(string message)
        {
            throw new NotImplementedException();
        }

        ~Customer()
        {
            throw new NotImplementedException();
        }
    }
}
