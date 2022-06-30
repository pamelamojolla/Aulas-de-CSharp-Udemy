
using Enum;

int id = (int)Genero.Animacao; //convertendo enum em um numero inteiro
Console.WriteLine(id);

var filmeParaFamilia = new Filme();
filmeParaFamilia.Titulo = "Froozen";
filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);

