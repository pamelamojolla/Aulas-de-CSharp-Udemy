
using MetodosComRetorno;



var calculadoraComum = new CalculadoraComum();

var resultado = CalculadoraComum.Somar(5, 5));

Console.WriteLine(resultado);

Console.WriteLine(calculadoraComum.Subtrair(2, 7));

Console.WriteLine(calculadoraComum.Somar(4, 4));

var calculadoraCadeia = new CalculadoraCadeia();
calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
Console.WriteLine(resultado);