using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Months of the year:");
        Console.WriteLine("1-January\n" +
            "2-February\n" + 
            "3-March\n"+
            "4-April\n" +
            "5-May\n" +
            "6-June\n" +
            "7-July\n" +
            "8-August\n" +
            "9-September\n" +
            "10-October\n" +
            "11-November\n" +
            "12-December");
        Console.WriteLine();

        // Prompt user for input
        Console.Write("Choose a month (1-12): ");

        // Define a string named "UserInput"
        string UserInput;

        // Assign "UserInput" to Console.ReadLine() to allow he user to enter the month
        UserInput = Console.ReadLine();

        int Month;

        Month = int.Parse(UserInput);

        switch (Month)
        {
            case 1:
                Console.WriteLine("January has 31 days");
                break;
            case 2:
                Console.WriteLine("February has 28 days (29 during leap years)");
                break;
            case 3:
                Console.WriteLine("March has 31 days");
                break;
            case 4:
                Console.WriteLine("April has 30 days");
                break;
            case 5:
                Console.WriteLine("May has 31 days");
                break;
            case 6:
                Console.WriteLine("June has 30 days");
                break;
            case 7:
                Console.WriteLine("July has 31 days");
                break;
            case 8:
                Console.WriteLine("August has 31 days");
                break;
            case 9:
                Console.WriteLine("September has 30 days");
                break;
            case 10:
                Console.WriteLine("October has 31 days");
                break;
            case 11:
                Console.WriteLine("November has 30 days");
                break;
            case 12:
                Console.WriteLine("December has 31 days");
                break;
        }

        Console.ReadLine();
    }
}
