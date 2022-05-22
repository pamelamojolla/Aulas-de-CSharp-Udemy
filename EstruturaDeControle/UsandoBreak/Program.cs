//Usando Break

//Break está associado a um laço de repetição for/while/dowhile/shitch

Random numeroAleatorio = new Random();
int numero = numeroAleatorio.Next(1, 51);

Console.WriteLine("O numero que queremos é {0}.", numero);

for(int i = 1; i <= 50; i++)
{
    Console.Write("{0} é o numero que queremos?", numero);
    if(i == numero)
    {
        Console.WriteLine("Sim!");
        break;
    }
    else
    {
        Console.WriteLine("Não!");
    }
}
Console.WriteLine("Fim!");

