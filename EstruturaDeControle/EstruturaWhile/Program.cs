//Estrutura While


int palpite = 0;
Random valorAleatorio = new Random(); //classe que gera um número aleatorio

int numeroSecreto = valorAleatorio.Next(1, 16); //aqui colocamos que queremos numeros aleatorio de 1 a 16
bool numeroEncontrado = false;
int tentativasRestantes = 5; // só tem cinco tentativa para acertar o número
int tentativas = 0; // aqui vai ficar armazenado o número de tentativas

while(tentativasRestantes > 0 && !numeroEncontrado)
{
    Console.WriteLine("Insira o seu palpite: ");
    string entrada = Console.ReadLine();
    int.TryParse(entrada, out palpite);

    tentativas++; // aqui ele soma + 1 as tentativas do usuario
    tentativasRestantes--; // aqui ele subtrai uma tentativa 

    if(numeroSecreto == palpite)
    {
        numeroEncontrado = true;
        var corAnterior = Console.BackgroundColor; // aqui você está guardando a atual cor quando você printa o console
        Console.BackgroundColor = ConsoleColor.Blue; // aqui você escolhe a cor, no caso azul
        Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
        Console.BackgroundColor=corAnterior; // aqui volta a cor anterior
    }else if (palpite > numeroSecreto)
    {
        Console.WriteLine("Menor... Tente novamente!");
        Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
    }
    else
    {
        Console.WriteLine("Maior...Tente novamente!");
        Console.WriteLine("Tentativas Restantes {0}", tentativasRestantes);
    }
}
