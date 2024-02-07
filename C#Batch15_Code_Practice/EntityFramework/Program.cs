using EntityFramework;

public class Program
{
    public static void Main()
    {
        Student student = new Student();    

       
        student.Name = "Test";
        student.Cgpa = 3.5;
        student.DateOfBirth = DateTime.Now;

        ApplicationDbContext context = new ApplicationDbContext();
        context.Students.Add(student);

        context.SaveChanges();
    }
}