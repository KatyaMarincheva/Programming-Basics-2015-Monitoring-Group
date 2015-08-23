using System;
using System.Text;

class Strings
{
    static void Main()
    {
        string name1 = "Software University";
        Console.WriteLine(name1);
        // using + (concatenation) with strings is BAD practice, too slow
        string name2 = "Software" + " " + "University";
        Console.WriteLine(name2);
        // instead:

        // below we have one single string name3, 
        // and within this string we keep free spaces for the two strings "Software" and "University"
        // by means of placeholders: {0} {1}
        string name3 = string.Format("{0} {1}", "Software", "University");
        Console.WriteLine(name3);
        // we can use StringBuilder to form one long string using multiple strings, this is fast
        StringBuilder collector = new StringBuilder();
        collector.Append("Software");
        collector.Append(" ");
        collector.Append("University");

        string name4 = collector.ToString();
        Console.WriteLine(name4);
        // or
        collector.Clear(); // we are emptying the collector, so that we can re-use it
        collector.AppendFormat("{0} {1}", "Software", "University");

        string name5 = collector.ToString();
        Console.WriteLine(name5);

        // or
        collector.Clear();
        collector.AppendFormat("{0} {1}", "Software", "University").AppendLine(); // adds an extra empty lie below

        string name6 = collector.ToString();
        Console.WriteLine(name6);

        // the compiler sees the strings as an array of symbols, chars, so we can also print it with loops:

        for (int i = 0; i < name6.Length; i++)
        {
            Console.Write(name6[i]);
        }

        foreach (char ch in name6)
        {
            Console.Write(ch);
        }

        // we can also choose if we will be printing the string with small or capital letters

        string name7 = name6.ToLower();
        Console.WriteLine(name7);

        string name8 = name7.ToUpper();
        Console.WriteLine(name8);
    }
}