using System;

class main
{
    public static void Main()
    {
        int variaw = 0; //var controlling 

        TimeSpan ts = new TimeSpan(0); //TimeSpan object
        DateTime newDate; 
        DateTime Date;
        do
        {
            Date = DateTime.Now;//Date refreshes every time do..while ends its iteration
            newDate = DateTime.Now;
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Display current time and date");
            Console.WriteLine("2. Add to date");
            Console.WriteLine("3. Substract from date");
            Console.WriteLine("0. Quit");
            variaw = Convert.ToInt32(Console.ReadLine());
            switch (variaw)
            {
                case 1://Displaying current date and time
                    displayDate(Date);
                    break;
                case 2://Adds to Date
                    addDate(Date, newDate, ts);
                    break;
                case 3://Substracts from Date
                    subDate(Date, newDate, ts);
                    break;
                case 4:

                    break;
                default:
                    break;
            }
        } while (variaw != 0);//Gives an exception when enter is pressed and nothing is in the buffer
    }
    public static void displayDate(DateTime Date)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Date now: {Date} \n");
        Console.ResetColor();
    }
    public static void addDate(DateTime Date, DateTime newDate, TimeSpan ts)
    {
        int day, hour, minute; //variables for adding abd substracting
        Console.Clear();
        Console.Write("Days: ");
        day = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hours: ");
        hour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Minutes: ");
        minute = Convert.ToInt32(Console.ReadLine());
        ts = new TimeSpan(day, hour, minute, 0, 0);
        newDate = Date.Add(ts);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{newDate}\n");
        Console.ResetColor();
    }
    public static void subDate(DateTime Date, DateTime newDate, TimeSpan ts)
    {
        int day, hour, minute; //variables for adding abd substracting
        Console.Clear();
        Console.Write("Days: ");
        day = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hours: ");
        hour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Minutes: ");
        minute = Convert.ToInt32(Console.ReadLine());
        ts = new TimeSpan(day, hour, minute, 0, 0);
        newDate = Date.Subtract(ts);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{newDate}\n");
        Console.ResetColor();
    }
}