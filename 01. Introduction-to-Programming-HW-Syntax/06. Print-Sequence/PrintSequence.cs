using System;
using System.Collections.Generic;

class PrintSequence
{
    static void Main()
    {
        List<int> numbers1 = new List<int>();

        // four ways of printing a sequence of numbers with alternating signs
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                numbers1.Add(i);
            }
            else
            {
                numbers1.Add(-i);
            }
        }

        string sequence = string.Join(", ", numbers1.ToArray());
        Console.WriteLine(sequence);

        List<int> numbers2 = new List<int>();
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                numbers2.Add(i);
            }
            else
            {
                numbers2.Add(~i + 1);
            }
        }

        sequence = string.Join(", ", numbers2.ToArray());
        Console.WriteLine(sequence);

        List<int> numbers3 = new List<int>();
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                numbers3.Add(i);
            }
            else
            {
                numbers3.Add((i ^ -1) + 1);
            }
        }

        sequence = string.Join(", ", numbers3.ToArray());
        Console.WriteLine(sequence);

        List<int> numbers4 = new List<int>();
        for (int i = 2, j = -3; i < 11; i += 2, j -= 2)
        {
            numbers4.Add(i);
            numbers4.Add(j);
        }

        sequence = string.Join(", ", numbers4.ToArray());
        Console.WriteLine(sequence);
    }
}