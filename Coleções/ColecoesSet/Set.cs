using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    public class Produto // classe Produto terá dois atributos Nome e Preço
    {
        public string Nome;
        public double Preco;


        public Produto(string nome, double preco) //criando o construtor
        {
            Nome = nome;
            Preco = preco;
        }
    }

}