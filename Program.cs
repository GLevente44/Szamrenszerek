using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamrendszerek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek, adj meg egy egész számot a tízes számrendszerben:");
            int szam = int.Parse(Console.ReadLine());

            string kettesSzamrendszer = Atvaltas(szam);

            Console.WriteLine($"A {szam} szám kettes számrendszerben: {kettesSzamrendszer}");
        }

        static string Atvaltas(int szam)
        {
            if (szam == 0)
                Console.WriteLine("0");

            List<int> maradek = new List<int>();
            while (szam > 0)
            {
                maradek.Add(szam % 2); 
                szam /= 2; 
            }

            return string.Join("", maradek);
        }
    }
}
    

