using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int mainChoice, years, months, days, hours, minutes, seconds;

            while (true) 
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("       COUNTDOWN");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("[1] Tahmin Et");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Bu bir eğlence oyunudur ve gerçeklik payı yoktur,");
                Console.WriteLine("        hiçbir sorumluluk kabul edilmez.");
                Console.ResetColor();
                Console.WriteLine("");
                Console.Write("> ");
                mainChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (mainChoice == 1)
                {
                    years = rnd.Next(0, 62);
                    months = rnd.Next(0, 12);
                    days = rnd.Next(0, 30);
                    hours = rnd.Next(0, 24);
                    minutes = rnd.Next(0, 60);
                    seconds = rnd.Next(0, 60);

                    for (; ; )
                    {
                        Console.WriteLine("Years: " + years);
                        Console.WriteLine("Months: " + months);
                        Console.WriteLine("Days: " + days);
                        Console.WriteLine("Hours: " + hours);
                        Console.WriteLine("Minutes: " + minutes);
                        Console.WriteLine("Seconds: " + seconds);

                        seconds--;

                        if (seconds == -1)
                        {
                            seconds = 60;
                            minutes--;

                            if (minutes == -1)
                            {
                                minutes = 60;
                                hours--;

                                if (hours == -1)
                                {
                                    hours = 24;
                                    days--;

                                    if (days == -1)
                                    {
                                        days = 30;
                                        months--;

                                        if (months == -1)
                                        {
                                            months = 12;
                                            years--;

                                            if (years == -1)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }
                }

                else
                {
                    Console.Write("(!) Seçenekler harici bir tuş girdiniz.");
                    System.Threading.Thread.Sleep(3000);
                }
            }

        }
    }
}
