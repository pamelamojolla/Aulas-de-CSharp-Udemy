//Operadores Aritmeticos

//preço com desconto

var preco = 1000.0; //inferencia, ele entente pela inicialização da variavel que ela é do tipo inteiro
var imposto = 355;
var desconto = 0.1;

double total = preco + imposto;
var totalComDesconto = total - (total * desconto);

Console.WriteLine("O preco final é {0}", totalComDesconto);

//imc

double peso = 91.5;
double altura = 1.82;
double imc = peso / Math.Pow(altura, 2);
Console.WriteLine($"Seu IMC é: {imc}");

//numero par e impar
int par = 24;
int impar = 55;
Console.WriteLine("{0}/2 tem resto {1} ", par, par % 2);
Console.WriteLine("{0}/2 tem resto {1} ", impar, impar % 2);    