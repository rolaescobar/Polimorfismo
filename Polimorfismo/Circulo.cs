using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Circulo : IFigura
    {

        public double Radio { get; set; }

        public Circulo(double radio)
        { 
            Radio = radio;
        
        }


        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
