using AbstractClass;
using System.Security.Cryptography.X509Certificates;

public class Program: Car
{
    public override void Print()
    {
        Console.WriteLine("hello");
    }

    public override void Even()
    {
        Console.WriteLine("hello2");    
    }
    public static void Main()
    {
       Car c = new Program();   
       

    }
}