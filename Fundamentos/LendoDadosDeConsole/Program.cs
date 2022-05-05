//Lendo Dados - Fundamentos
Console.WriteLine("Qual é o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o seu salário?");
double salario = double.Parse(
    Console.ReadLine());
    
Console.WriteLine($"Nome: {nome} Idade: {idade} R${salario}");
