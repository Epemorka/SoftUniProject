﻿using System;

namespace _08.CinemaTickt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Monday    Tuesday    Wednesday   Thursday     Friday   Saturday    Sunday
            //  12        12          14         14          12         16         16

            string weekDay = Console.ReadLine();

            int price = 0;

            switch (weekDay)
            {
                case "Monday":
                    price = 12;
                    break;
                case "Tuesday":
                    price = 12;
                    break;
                case "Wednesday":
                    price = 14;
                    break;
                case "Thursday":
                    price = 14;
                    break;
                case "Friday":
                    price = 12;
                    break;
                case "Saturday":
                    price = 16;
                    break;
                case "Sunday":
                    price = 16;
                    break;

                    



            }
            Console.WriteLine(price);
        }
    }
}
