using System.Diagnostics.CodeAnalysis;

public class Program
{
    public static void Main()
    {
        string Name = "Istiaque";

        string LastName = Console.ReadLine();

        string FullName = Console.ReadLine();

        Console.Write(Name);
        Console.WriteLine(LastName);
        Console.WriteLine($"{Name} fullname is {FullName}");


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        

        string Name1 = Console.ReadLine();

        int Number = int.Parse(Console.ReadLine());

        double FractionNumber = double.Parse(Console.ReadLine());

        long LongNumber = long.Parse(Console.ReadLine());

        uint Uint = uint.Parse(Console.ReadLine());

        char c = char.Parse(Console.ReadLine());

        ulong Ulong = ulong.Parse(Console.ReadLine());

        Console.WriteLine($"{Name1},{Number},{FractionNumber},{LongNumber},{Uint},{c},{Ulong}");

        int Read = Console.Read();

        Console.WriteLine(Read);

        char Read1 =(char) Console.Read();

        Console.WriteLine(Read1);

        ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        Console.WriteLine(consoleKeyInfo);



        
    }
}