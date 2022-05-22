//Estrutura ForEach


var palavra = "Opa";

foreach(var letra in palavra) //ele percorre cada letra da variavel palavra
{
    Console.WriteLine(letra);
}

var alunos = new string[] { "Ana", "Bia", "Carlos" };

foreach(string aluno in alunos)
{
    Console.WriteLine(aluno); // ele percorre cada intem do array
}