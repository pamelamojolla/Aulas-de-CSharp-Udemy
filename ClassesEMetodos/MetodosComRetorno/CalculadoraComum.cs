using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComRetorno
{
    public class CalculadoraComum
    {
        public int Somar(int a, int b) // quando o metodo é declarado o tipo ele tem que retornar o mesmo tipo
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return b - a;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
}
