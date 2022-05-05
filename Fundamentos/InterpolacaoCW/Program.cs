
//INTERPOLAÇÃO CW

string nome = "Notebook Gamer";
string marca = "Dell";
double preco = 5800.00;

Console.WriteLine("O" + nome + "da marca" + marca + "custa" + preco + ".");
//nesse caso contatenação com sinal +

Console.WriteLine("O {0} da marca {1} custa{2}.", nome, marca, preco);
//nesse caso com interpolação {}

Console.WriteLine($"A marca {marca} é legal");
//segunda opçãp de interpolação com o sinal de $

