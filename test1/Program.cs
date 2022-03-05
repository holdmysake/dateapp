using System;

class main
{
    public static void Main()
    {
        int variaw = 0; //var controlling 
        int day, hour, minute;
        TimeSpan ts;
        DateTime newDate;
        DateTime Date;
        do
        {
            Date = DateTime.Now;
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Display current time and date");
            Console.WriteLine("2. Add to date");
            Console.WriteLine("3. Substract from date");
            Console.WriteLine("0. Quit");
            variaw = Convert.ToInt32(Console.ReadLine());
            switch (variaw)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Date now: {Date} \n");
                    Console.ResetColor();
                    break;
                case 2:
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

                    break;
                case 3:
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
                    break;
                default:                    
                    break;
            }
        } while (variaw!= 0) ;
    }
}