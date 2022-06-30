using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    internal class Moto
    {
        //uint - não aceita inteiro negativo

        private string Marca; //as propiedade ou atributos
        private string Modelo;
        private uint Cilindrada;

        //construtor

        public Moto(string marca, string modelo, uint cilindrada) //parametros
        {
            Marca = marca;   //setando as propriedades ou atributos
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        //criando o segundo contrutor padrao

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public string SetModelo(string modelo) => Modelo = modelo;

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            Cilindrada = cilindrada;
        }
    }
}
