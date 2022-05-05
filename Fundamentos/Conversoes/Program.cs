//Conversoes

int inteiro = 10;
double quebrado = inteiro;
Console.WriteLine(quebrado);

double nota = 9.7;
int notaTruncada = (int)nota; //conversação explicita com perda de informação
Console.WriteLine("Nota truncada: {0}", notaTruncada);

Console.WriteLine("Digite sua idade");
string idadeString = Console.ReadLine();
int idadeInteiro = int.Parse(idadeString);//conversao de string para numero
Console.WriteLine("Idade inserida: {0} ", idadeInteiro);

idadeInteiro= Convert.ToInt32(idadeString);
Console.WriteLine("Resultado {0}", idadeInteiro);

Console.WriteLine("Digite um número");
string palavra = Console.ReadLine();
int numero;
int.TryParse(palavra, out numero);// converta variavel palavra e jogue dentro da variavel numero
Console.WriteLine("Resultado: {0}", numero);


//otimizando o código de cima
Console.WriteLine("Digite o segundo número");
int.TryParse(Console.ReadLine(), out int numero2); //nesse caso eu declarei uma variavel no mesmo momento de conversão
Console.WriteLine("Resultado 2: {0}", numero2);