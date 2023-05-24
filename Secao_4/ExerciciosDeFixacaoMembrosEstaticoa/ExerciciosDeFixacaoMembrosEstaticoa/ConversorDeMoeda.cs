using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeFixacaoMembrosEstaticoa
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double DolarParaReal(double cotacaoDolar, double quantia)
        {
            quantia = (quantia * cotacaoDolar) * (1 + IOF/100) ;
            return quantia;
        }
    }
}
