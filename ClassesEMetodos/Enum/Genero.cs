using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum Genero
    {
        Acao, Aventura, Terror, Animacao, Comedia
    }

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
}
