//Operadores Relacionais

//double nota = 6.0;

Console.WriteLine("Digite sua nota:");
double.TryParse(Console.ReadLine(), out double nota);

double notaDeCorte = 7.0;

Console.WriteLine("Nota inválida ? {0}", nota > 10.0); // > maior

Console.WriteLine("nota inválida? {0}", nota < 0.0); //  < menor

Console.WriteLine("Perfeito? {0}", nota == 10.0); // extremamente igual

Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); // diferente

Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte); // >= maior ou igual

Console.WriteLine("Recuperação? {0}", nota < notaDeCorte); // < menor

Console.WriteLine("Reprovado? {0}", nota <= 3.0); // <= menor ou igual

