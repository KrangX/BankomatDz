using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatDz
{
    class Bankomat
    {

        private int totalCash500 { get; set;}
        private int totalCash1000 { get; set; }
        private int totalCash2000 { get; set; }
        private int totalCash5000 { get; set; }
        private string[,] racuni = new string[,] { {"1111", "160 - 11111 - 55", "5500.46" }, {"2222", "160 - 22222 - 66", "9500" }, {"3333","160 - 33333 - 77","500" } };
        public Bankomat(int totalCash500, int totalCash1000, int totalCash2000, int totalCash5000)
        {
            this.totalCash500 = totalCash500;
            this.totalCash1000 = totalCash1000;
            this.totalCash2000 = totalCash2000;
            this.totalCash5000 = totalCash5000;
        }
         public void Uplati()
         {
            UserInput ui = new UserInput();
            int tc500 = ui.GetIntBr("Unesi broj novcanica od 500 RSD za uplatu: ");
            int tc1000= ui.GetIntBr("Unesi broj novcanica od 1000 RSD za uplatu: ");
            int tc2000= ui.GetIntBr("Unesi broj novcanica od 2000 RSD za uplatu: ");
            int tc5000 = ui.GetIntBr("Unesi broj novcanica od 5000 RSD za uplatu: ");
            totalCash500 = totalCash500 + tc500;
            totalCash1000 = totalCash500 + tc1000;
            totalCash2000 = totalCash500 + tc2000;
            totalCash5000 = totalCash500 + tc5000;
            int ukupnaUplata = tc500 * 500 + tc1000 * 1000 + tc2000 * 2000 + tc5000 * 5000;

        }
        /* public double Podigni()
         {

         }*/
         
        public string UnesiPin(string pinCode)
        {
            for (int j = 0; j < racuni.GetLength(1); j++)
            {
                if (racuni[0, j] == pinCode) return racuni[1, j];
            }
            return null;
        }
        public string GetIznos(string zr) {
            for (int j = 0; j < racuni.GetLength(1); j++)
            {
                if (racuni[1, j] == zr) return racuni[2,j];
            }
            return null;
        }
        public void SetIznos(string zr, string iznos)
        {
            for (int j = 0; j < racuni.GetLength(1); j++)
            {
                if (racuni[1, j] == zr) {
                    racuni[2,j]= Convert.ToString(Convert.ToDouble(racuni[2, j])+Convert.ToDouble(iznos));
                }
            }
        }

    }
}
