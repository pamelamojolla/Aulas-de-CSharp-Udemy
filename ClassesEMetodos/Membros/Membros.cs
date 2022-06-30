// Classes e Metodos 

//Instaciando através de classes ou criando objetos atraves de classes

using ClassesEMetodos;


// criando um novo objeto do tipo Pessoa

Pessoa sicrano = new Pessoa();  // chamando a classe pessoa, dando um identificador e criando um construtor
{
    sicrano.Nome = "Pamela"; // dando atributos ao objeto criado pela classe
    sicrano.Idade = 21;

    // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos. ");

    sicrano.ApresentarNoConsole();

    var fulano = new Pessoa();
    fulano.Nome = "Beto";
    fulano.Idade = 22;
    fulano.ApresentarNoConsole();


