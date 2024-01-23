using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Cerchio
{
    internal class Cerchio
    {
        public int Raggio { get; set; }
        
        public double Area()
        {
            return Raggio * Raggio * Math.PI;
        }

        public double Perimetro()
        {
            return 2 * Math.PI * Raggio;
        }
    }
}
