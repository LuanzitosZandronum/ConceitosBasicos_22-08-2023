using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos
{
    public class CalculadoraIMC
    {
        public double IMC(double altura, double peso)
        {
            return peso / (altura*altura);
        }
    }
}
