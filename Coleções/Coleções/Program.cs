
//declarando array

string[] alunos = new string[5]; //aqui você sempre coloca o nome em plural pois, ele irá receber vários dados.
alunos[0] = "Anderson";
alunos[1] = "Bia";
alunos[2] = "Carlos";
alunos[3] = "Daniela";
alunos[4] = "Emanual"; //Aqui você está salvado os dados dentro dos indices

//para percorrer um array o melhor sempre é o forech

foreach (var aluno in alunos) //aqui a variavel aluno no singular vai percorrer o array alunos
{
    Console.WriteLine(aluno);
}

//outro exemplo
double somatorio = 0;
double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 }; //aqui criamos uma array do tipo double e já atribuimos valores no caso notas

foreach(var nota in notas)
{
    somatorio += nota; //aqui todas as notas do array são somadas e gravadas na variavel somatorio
}

double media = somatorio / notas.Length; // aqui usamos o atributo length que significa tamanho para falar quantos indice tem o array

Console.WriteLine(media);

//outro exemplo

char[] letras = { 'A', 'r', 'r', 'a', 'y' }; //aqui criamos um array só de caracteres
string palavra = new string(letras); // aqui podemos criar uma variavel de string usando um array de char
Console.WriteLine(palavra);                                     
