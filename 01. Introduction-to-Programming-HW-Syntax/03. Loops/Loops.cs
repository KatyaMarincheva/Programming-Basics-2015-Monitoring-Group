using System;

class Loops
{
    static void Main()
    {
        // https://msdn.microsoft.com/en-us/library/32dbftby.aspx

        // print numbers from 1 to 10 using different loops

        // for loop - counts of 0 to 9 (to before 10, less than 10)
        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0} ", i + 1);
        }

        Console.WriteLine();

        // do while loop 
        // - first prints after that checks up if the condition (number < 11) is true
        int number = 1;
        do
        {
            Console.Write("{0} ", number);
            number++;
        }
        while (number < 11);

        Console.WriteLine();

        // while loop
        // - first checks up if the condition (number < 11) is true, after that prints
        int num = 1;
        while (num < 11)
        {
            Console.Write("{0} ", num);
            num++;
        }

        Console.WriteLine();

        // foreach loop - calls all the elements of a collection, one by one
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int item in numbers)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }
}