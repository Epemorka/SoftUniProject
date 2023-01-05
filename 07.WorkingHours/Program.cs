using System;

namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();

            if (hours >=10 && hours <=18) 
            {
                switch (weekDay)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":

                        Console.WriteLine("open");
                        break;

                    default:
                        Console.WriteLine("closed");
                        break;
                }

            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
