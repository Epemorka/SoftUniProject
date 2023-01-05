using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            //  Град         0 ≤ s ≤ 500       500 < s ≤ 1 000      1 000 < s ≤ 10 000     s > 10 000
            //Sofia          5 %                 7 %                 8 %                    12 %
            //Varna          4.5 %               7.5 %               10 %                   13 %
            //Plovdiv        5.5 %               8 %                 12 %                   14.5 %
            double totalProfit = 0;
            double percent = 0;

            switch (cityName)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        percent = 0.05;
                        totalProfit = sales * percent;
                        
                    }
                    else if (sales > 500 && sales <= 1000 )
                    {
                        percent = 0.07;
                        totalProfit = sales * percent;
                    }
                    else if ( sales > 1000 && sales <= 10000)
                    {
                        percent = 0.08;
                        totalProfit = sales * percent;
                    }
                    else if (sales > 10000)
                    {
                        percent = 0.12;
                        totalProfit = sales * percent;
                    }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        percent = 0.045;
                        totalProfit = sales * percent;

                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percent = 0.075;
                        totalProfit = sales * percent;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percent = 0.10;
                        totalProfit = sales * percent;
                    }
                    else if (sales > 10000)
                    {
                        percent = 0.13;
                        totalProfit = sales * percent;
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        percent = 0.055;
                        totalProfit = sales * percent;

                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percent = 0.08;
                        totalProfit = sales * percent;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percent = 0.12;
                        totalProfit = sales * percent;
                    }
                    else if (sales > 10000)
                    {
                        percent = 0.145;
                        totalProfit = sales * percent;
                    }
                    break;


                default:
                    break;
            }
            if (totalProfit > 0)
            {
                Console.WriteLine($"{totalProfit:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            

        }
    }
}
