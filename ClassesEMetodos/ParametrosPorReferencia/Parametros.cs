using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosPorReferencia
{
    public static int AlterarRef(ref int numero)//palavra ref deixa mais explicito a passagem de uma referencia
    {
        numero = 0;
        numero = numero + 1000;
    }

    public static int AlterarOut(int numero)
    {
        numero = numero + 15;
    }
}
