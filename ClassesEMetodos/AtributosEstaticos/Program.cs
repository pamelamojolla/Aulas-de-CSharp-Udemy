

using AtributosEstaticos;

var produto1 = new Produto("Caneta", 3.2, 0.1);

var produto2 = new Produto()
{
    Nome = "Borracha",
    Preco = 5.3,
    Desconto = 0.1
};

Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto);
Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto);
