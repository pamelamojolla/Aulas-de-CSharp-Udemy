using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas
{
    internal class Pessoa
    {
        public string Nome; // atributo publico - primeira letra Maiuscula - não pode ter espaço
        public int Idade; // string tem valor padrao null e int tem valor padrao 0


        public string Apresentar()//método - comportamento
        {
            return String.Format
                ($"Olá! Me chamo {Nome} e tenho {Idade} anos");
        }

        public void ApresentarNoConsole() // método - comportamento
        {
            Console.WriteLine(Apresentar());
        }
    }
}
