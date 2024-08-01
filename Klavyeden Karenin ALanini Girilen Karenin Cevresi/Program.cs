using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_Karenin_ALanini_Girilen_Karenin_Cevresi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar, cevre;

            Console.WriteLine("Karenin bir kenarını giriniz");
            kenar = Int32.Parse(Console.ReadLine());

            cevre = kenar * 4;

            Console.WriteLine("Karenin Cevresi = " + cevre);
            Console.ReadLine();

        }
    }
}
