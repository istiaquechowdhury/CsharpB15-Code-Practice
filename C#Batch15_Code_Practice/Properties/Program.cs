using Properties;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Student student = new Student();
        student.ID = 1;
        student.Name = "istiaque";
        student.Age = 23; 

        Console.WriteLine(student.ID);
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Age);     
        
    }
}