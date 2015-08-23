using System;

class HelloCSharp
{
    static void Main()
    {
        // four ways of going to the next line after printing
        // the Console.WriteLine() method prints and goes to a new line after printing:
        // Console.WriteLine, \n, Environment.NewLine, an extra empty Console.WriteLine() below the printing one
        Console.WriteLine("Hello, C#!");

        Console.Write("Hello, C#!{0}", Environment.NewLine);

        Console.Write("Hello, C#!\n");

        Console.Write("Hello, C#!");
        Console.WriteLine();

        Console.WriteLine();
        // four ways of adding an extra empty line after the printed one

        Console.WriteLine("Hello, C#!");
        Console.WriteLine();

        Console.Write("Hello, C#!{0}{1}", Environment.NewLine, Environment.NewLine);

        Console.Write("Hello, C#!\n\n");

        Console.WriteLine("Hello, C#!{0}", Environment.NewLine); // most professional way
    }
}