//Estrura IF/Else/IF

Console.WriteLine("Digite a nota do aluno, usando somente virgula: ");

string entrada = Console.ReadLine();
double.TryParse(entrada, out double nota);


if (nota >= 9.0)
{
    Console.WriteLine("Quadro de honra!");

}
else if (nota >= 7.0 && nota < 9.0)
{
    Console.WriteLine("Aprovado!");

}
else if (nota >= 5.0 && nota < 7.0)
{
    Console.WriteLine("Recuperação!");
}
else
{
    Console.WriteLine("Te vejo na prxoxima...");
}

Console.WriteLine("Fim!!");