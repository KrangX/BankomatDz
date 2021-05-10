using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatDz
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput ui = new UserInput();
            Bankomat ban = new Bankomat(1000, 500, 200, 100);
            Console.Write("Unesite PIN: ");
            string zr = ban.UnesiPin(Console.ReadLine());
            if (zr == null)
            {
                Console.WriteLine("Uneli ste neispravan PIN!");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            Console.Write("Unesite zeljenu operaciju '+' za uplatu, '-' za isplatu, '~' za pregled stanja (bilo koji drugi karakter za izlaz): ");
            string operacija = Console.ReadLine();
            switch (operacija)
            {
                case "+":
                    ban.Uplati();
                    break;
                case "-":
                    break;
                case "~":
                    break;
                default:
                    break;
            }
            Console.WriteLine("Ukupan iznos je: {0}",ban.GetIznos(zr));
            Console.ReadKey();
           /* do
            {
                Console.WriteLine("Iznos koji ste uneli je: {0}",ui.GetIntIznos("Unesite iznos"));
                Console.ReadKey();
                Console.Clear();
            } while (true);*/
        }
    }
}
