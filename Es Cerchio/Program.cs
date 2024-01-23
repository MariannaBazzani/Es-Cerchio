using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Cerchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio cerchio = new Cerchio();
            Console.WriteLine("Inserisci raggio: ");
            cerchio.Raggio = int.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + cerchio.Area());
            Console.WriteLine("Perimetro: " + cerchio.Perimetro());
        }
    }
}
