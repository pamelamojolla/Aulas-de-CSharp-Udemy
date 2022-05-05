
//VARIAVEIS E CONSTANTES
//area da circunferência
            double raio = 4.5; //tipo double aceita numerais e aceita casa decimais 
const double PI = 3.14;

double area = PI * raio * raio;
Console.WriteLine(area);
Console.WriteLine("Área é " + area);

//Tipos Internos

bool estaChovendo = true; //booleano verdadeiro ou falso
Console.WriteLine("Está chovendo " + estaChovendo);

//Valores Inteiros

byte idade = 45; //um único byte ou seja 8 bites esse tipo não aceita sinal
Console.WriteLine("Idade " + idade);

sbyte saldoDeGols = sbyte.MinValue; //ele é um tipo que aceita sinal MinValue é o menor valor // esse aceita sinal
Console.WriteLine("Saldo de Gols " + saldoDeGols);

short salario = short.MaxValue; //ele recebe até dois bytes
Console.WriteLine("Salário " + salario);

int menorValorInt = int.MinValue;//mais usados dos inteiros, ele recebe até quatro bytes//esse aceita sinal
Console.WriteLine("Menor int " + menorValorInt);

uint populacaoBrasileira = 207_600_000; //esse não aceita sinal
Console.WriteLine("População Brasileira " + populacaoBrasileira);

long menorValorLong = long.MinValue;// oito bytesk
Console.WriteLine("Menor long " + menorValorLong);

ulong populacaoMundial = 7_600_000_000;// não aceita sinal 
Console.WriteLine("Populacao Mundial" + populacaoMundial);

//Ponto Flutuantes
float precoComputador = 1299.99f // valores reais
            Console.WriteLine("Preço do Computador " + precoComputador);

double valorDeMarcadoDaApple = 100000000000.00; //mais usado dos reais
Console.WriteLine("Valor Apple " + valorDeMarcadoDaApple);

decimal distanciaEntreEstrelas = decimal.MaxValue
            Console.WriteLine("Distancia entre Estrelas " + distanciaEntreEstrelas);

char letra = 'b'; //recebe uma letra
Console.WriteLine("Letra " + letra);

string texto = "Seja bem vindo ao curso de C#!";
Console.WriteLine(texto);






