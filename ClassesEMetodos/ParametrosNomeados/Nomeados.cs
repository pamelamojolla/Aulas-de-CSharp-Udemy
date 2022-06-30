using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosNomeados
{
    internal class Nomeados
    {
        public static void Formatar (int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano); // D2 coloca o dois digitos a esquerda
        }
    }
}
