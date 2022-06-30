using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Carro
    {
        // os três atributos criados
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {  // criando os contrutores // duas formas de construir obj
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() { }// construtor implicito // duas formas de construir obj

    }
}
