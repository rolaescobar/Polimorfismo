using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cuadrado : IFigura
    {

        public double Lado { get; set; }

        public Cuadrado(double lado) 
        { 
            Lado = lado;
        
        }

        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
