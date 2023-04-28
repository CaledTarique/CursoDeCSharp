using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOrientacaoAObjetos_3
{
    public class Aluno
    {
        public string Nome;
        public int Nota_1;
        public int Nota_2;
        public int Nota_3;
        public int NotaFinal;
        public int Media()
        {
           return NotaFinal =  Nota_1 + Nota_2 + Nota_3;          
        }

        public override string ToString()
        {
            Media();
            if (NotaFinal >= 60)
            {
                return "Nota final = "
                   + NotaFinal
                   + "\r\n Aprovado";
            }

            else
            {
                return
                    "Nota final = "
                    + NotaFinal
                    + "\r\n Reprovado"
                    + "\r\n Faltaram "
                    + (60 - NotaFinal)
                    + " Pontos";
            }
                
        }

    }
}
