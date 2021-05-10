using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatDz
{
    class UserInput
    {
        public int GetIntIznos(string userMessage)
        {
            int rezultat;
            do
            {
                try
                {
                    Console.Write(userMessage);
                    rezultat = Convert.ToInt32(Console.ReadLine());
                    if ((rezultat >= 500) && ((rezultat % 500) == 0)) break;
                    else Console.WriteLine("Niste uneli ispravan celobrojni iznos!");
                }
                catch 
                {
                    Console.WriteLine("Niste uneli ispravan celobrojni iznos!");
                }
            } while (true);
            return rezultat;
        }
        public int GetIntBr(string userMessage)
        {
            int rezultat;
            do
            {
                try
                {
                    Console.Write(userMessage);
                    rezultat = Convert.ToInt32(Console.ReadLine());
                    if (rezultat>=0) break;
                }
                catch
                {
                    Console.WriteLine("Niste uneli ispravan celobrojni iznos!");
                }
            } while (true);
            return rezultat;
        }
    }
}
