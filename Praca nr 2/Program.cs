using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_nr_2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var Rand = new Random().Next(0, 100);

                Console.WriteLine("Podaj liczbe od 0 do 100.");
                var Entered = int.Parse(Console.ReadLine());
                var CountingAttempts = 0;

                while (Entered != Rand)
                {
                    if (Entered > Rand)
                    {
                        Console.WriteLine($"Podaj mniejsza liczbe od {Entered}");
                    }
                    else
                    {
                        Console.WriteLine($"Podaj Wieksza liczbe od {Entered}");
                    }
                    CountingAttempts++;
                    Entered = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Liczba Losowa to {Rand} \n Gracz Trafił tą liczbę po {CountingAttempts} próbie/próbach.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
