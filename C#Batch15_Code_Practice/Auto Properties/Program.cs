using Auto_Properties;

public class Program
{
    public static void Main()
    { 
        Teacher teacher = new Teacher();    
        teacher.id = 1;
        teacher.name = "test";
        teacher.Teaches = "English";

        Console.WriteLine(teacher.Teaches); 
    }
}