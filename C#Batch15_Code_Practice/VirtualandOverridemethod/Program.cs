using VirtualandOverridemethod;

public class Program
{
    public static void Main()
    {


        Employee[] el = new Employee[3];

        el[0] = new Employee();
        el[1] = new ParttimeEmployee();
        el[2] = new FulltimeEmployee();
       
        foreach (Employee e in el)
        {
            e.FirstName = "istiaque";
            e.LastName = "chowdhrury";
            e.Print();
        }


    }
}