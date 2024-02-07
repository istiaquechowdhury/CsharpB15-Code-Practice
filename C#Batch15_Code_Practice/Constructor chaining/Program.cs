using System;

class MyClass
{
    private int value1;
    private int value2;

    // Constructor with two parameters
    public MyClass(int v1, int v2)
    {
        value1 = v1;
        value2 = v2;
        Console.WriteLine("Two-parameter constructor called.");
    }

    // Constructor chaining using "this" keyword
    public MyClass(int v1) : this(v1, 0)
    {
        Console.WriteLine("Single-parameter constructor called.");
    }

    // Default constructor chaining to the two-parameter constructor
    public MyClass() : this(0)
    {
        Console.WriteLine("Default constructor called.");
    }

    public void DisplayValues()
    {
        Console.WriteLine($"Value1: {value1}, Value2: {value2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10, 20); // Calls the two-parameter constructor
        obj1.DisplayValues();

        MyClass obj2 = new MyClass(5); // Calls the single-parameter constructor
        obj2.DisplayValues();

        MyClass obj3 = new MyClass(); // Calls the default constructor
        obj3.DisplayValues();
    }
}
