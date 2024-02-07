using Enum;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Student student = new Student();    
        student.Id = 1;
        student.Name = "Test";
        
        
        GenderInfo(student.Gender);
        
    }

    public static void GenderInfo(Gender gender)
    {
        if (gender == Gender.male)
        {
            Console.WriteLine("he is a male");

        }
        else if (gender == Gender.female)
        {
            Console.WriteLine("She is a female");
        }
        else
        {
            Console.WriteLine("can not recognised");
        }
    }

}