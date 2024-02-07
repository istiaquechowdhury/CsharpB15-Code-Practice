using EntityFrameWorkExample;

public class Program
{
    public static void Main()
    {

        //Teacher teacher = new Teacher();
        //teacher.Name = "Test";
        //teacher.Teaches = "Bangla";
        

        //ApplicationDbContext ap = new ApplicationDbContext();   

        //ap.Teachers.Add(teacher);
        //ap.SaveChanges();

        Teacher teacher = new Teacher();

        teacher.Name = Console.ReadLine();
        teacher.Teaches = Console.ReadLine();

        ApplicationDbContext ap = new ApplicationDbContext();   

        ap.Teachers.Add(teacher);
        ap.SaveChanges();

        Console.WriteLine($"{teacher.Name} added Successfully");
        Console.WriteLine($"{teacher.Teaches}added Successfully");

    }
}