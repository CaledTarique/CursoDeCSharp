using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaAulaModificadoresdeParamsRefeOut
{
    internal class Calculadora
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void TripleOut(int x, out int result)
        {
           result = x * 3;
        }
    }
}
