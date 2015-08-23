using System;

class PrintNumbers3
{
    static void Main()
    {
        string binary = (Convert.ToString(1, 2).PadLeft(15));
        Console.WriteLine(binary);

        for (int power = 2; power <= 8; power++)
        {
            int number = (int)Math.Pow(2, power);
            binary = (Convert.ToString(number + 1, 2).PadLeft(15));
            Console.WriteLine(binary);
        }
    }
}