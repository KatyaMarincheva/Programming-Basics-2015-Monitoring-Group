using System;

class PrintNumbers2
{
    static void Main(string[] args)
    {
        // at each step of the for loop we increase the power of 10 by 1
        for (int i = 0; i < 3; i++)
        {
            // for the first member of the sequence only, we print just the power of 10
            if (i == 0)
            {
                Console.WriteLine(Math.Pow(10, i));
            }
            // for every next member of the sequence - we write the digit "1" after the power of 10
            else
            {
                Console.WriteLine("{0}{1}", Math.Pow(10, i), 1);
                // Console.WriteLine("{0}" + 1, Math.Pow(10, i)); // you can uncomment and test this as well
            }
        }
    }
}