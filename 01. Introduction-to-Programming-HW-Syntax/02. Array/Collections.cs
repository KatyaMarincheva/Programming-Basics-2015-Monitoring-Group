using System;
using System.Collections.Generic;

class Array
{
    static void Main()
    {
        // Arrays

        // an array is a collection of elements, all of the same type
        // the length of an array cannot be changed after the array is once initialized
        // both arrays below have a length = 6

        // the length of the first array is set with the number of elements stored in it
        int[] numbers1 = { 1, 2, 3, 4, 5, 6 };

        // the length of the second array is predefined [6] 
        // - this is an empty array which has exactly 6 free places to store elements
        int[] numbers2 = new int[6];

        // adding elements to an empty array
        // one by one
        numbers2[0] = 1;
        numbers2[1] = 2;

        // using a loop
        for (int i = 2; i < 6; i++)
        {
            numbers2[i] = i + 1;
        }

        // printing the elements of the array

        foreach (int number in numbers1)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        for (int i = 0; i < numbers2.Length; i++)
        {
            Console.WriteLine(numbers2[i]);
        }

        Console.WriteLine();

        for (int i = 0; i < numbers2.Length; i++)
        {
            Console.WriteLine("{0} ", numbers2[i]);
        }

        Console.WriteLine();
        string arrayElements = string.Join(" ", numbers2);
        Console.WriteLine(arrayElements);

        Console.WriteLine();

        foreach (int number in numbers1)
        {
            Console.Write("{0} ", number);
        }

        Console.WriteLine();
        Console.WriteLine();

        // Lists

        // a list is a collection of elements, all of the same type
        // the count of items in a list is not restricted

        // two ways of initializing a list
        List<int> numbers3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string listElements3 = string.Join(" ", numbers3);
        Console.WriteLine(listElements3);

        List<int> numbers4 = new List<int>();

        // adding elements to an empty list
        // one by one
        numbers4.Add(1);
        numbers4.Add(2);

        // using a loop
        for (int i = 2; i < 10; i++)
        {
            numbers4.Add(i + 1);
        }

        // all ways of printing the arrays apply here as well
        string listElements4 = string.Join(" ", numbers4);
        Console.WriteLine(listElements4);
    }
}