using System;

class PrintNumbers1
{
    static void Main()
    {
        Console.Title = "Print Numbers 1";

        for (int number = 1; number <= 9; number += 4)
        {
            // with the use of the PadLeft method, I want to emphasize that the printed numbers are, and should be read as bunary numbers
            string binary = Convert.ToString(number, 2).PadLeft(5);
            Console.WriteLine(binary);
        }
        Console.ReadLine();
    }
}