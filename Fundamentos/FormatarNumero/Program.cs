//Formatando Numeros

using System.Globalization;

double valor = 15.175;

Console.WriteLine(valor.ToString("F1")); //valor com uma casa decimal depois da virgula, arredondamento

Console.WriteLine(valor.ToString("C")); //coloca o valor moeda que está na maquina

Console.WriteLine(valor.ToString("P")); //ele transorforma em percentual o valor além de multiplicar por 100

Console.WriteLine(valor.ToString("#.##")); //ele coloca virgula da moeda real

CultureInfo cultura = new CultureInfo("pt-BR");
Console.WriteLine(valor.ToString("C3", cultura )); // aqui ele transforma os numeros em reais C3 com 3 casas depois da virgula

int inteiro = 256;
Console.WriteLine(inteiro.ToString("D10"));//colocar 0 a esquerda

