using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            плод banana  apple   orange   grapefruit    kiwi     pineapple    grapes
            //цена               2.50    1.20    0.85       1.45         2.70     5.50        3.85
            //Събота и неделя магазинът работи на по - високи цени:
            //            плод    banana    apple     orange   grapefruit   kiwi    pineapple    grapes
            //цена                    2.70    1.25      0.90       1.60      3.00        5.60      4.20

            string fruit = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50 * quantity;
                        break;
                    case "apple":
                        price = 1.20 * quantity;
                        break;
                    case "orange":
                        price = 0.85 * quantity;
                        break;
                    case "grapefruit":
                        price = 1.45 * quantity;
                        break;
                    case "kiwi":
                        price = 2.70 * quantity;
                        break;
                    case "pineapple":
                        price = 5.50 * quantity;
                        break;
                    case "grapes":
                        price = 3.85 * quantity;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }

            }
            else if (weekDay == "Saturday" || weekDay == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70 * quantity;
                        break;
                    case "apple":
                        price = 1.25 * quantity;
                        break;
                    case "orange":
                        price = 0.90 * quantity;
                        break;
                    case "grapefruit":
                        price = 1.60 * quantity;
                        break;
                    case "kiwi":
                        price = 3.0 * quantity;
                        break;
                    case "pineapple":
                        price = 5.60 * quantity;
                        break;
                    case "grapes":
                        price = 4.20 * quantity;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;



                }

            }
            else
            {
                Console.WriteLine("error");
            }

            if (price > 0)
            {
                Console.WriteLine($"{price:F2}");
            }



        }
    }
}
