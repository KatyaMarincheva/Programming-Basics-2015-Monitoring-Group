using System;
using System.Globalization;

class DateTimeExamples
{
    static void Main()
    {
        // three ways of printing today's date
        DateTime today1 = DateTime.Now.Date;
        Console.WriteLine(today1.ToString("d"));

        DateTime today2 = DateTime.Today.Date;
        Console.WriteLine(today2.ToString("d"));

        DateTime today3 = new DateTime(2015, 8, 23).Date; // enter correct year, month, and day
        Console.WriteLine(today3.ToString("d"));

        // read date from the console
        Console.Write("Please enter your date of birth: ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("bg-BG"));

        // two way of calculating the time elapsed between your date of birth and today
        TimeSpan span = today1.Subtract(dateOfBirth);
        span = today1 - dateOfBirth;

        Console.Write("Your age now is: ");

        // three ways of calculating age using the span variable
        DateTime zeroTime = new DateTime(1, 1, 1);
        int age = (zeroTime + span).Year - 1; 
        Console.WriteLine(age);

        age = (DateTime.MinValue + span).Year - 1;
        Console.WriteLine(age);

        age = (int)(span.TotalDays / 365.255);
        Console.WriteLine(age);

        Console.WriteLine("Your age in 10 years will be: {0}", age + 10);
    }
}