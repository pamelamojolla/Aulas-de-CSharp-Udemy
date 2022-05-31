
var fila = new Queue<string>();//criando fila do tipo string

fila.Enqueue("Fulano");
fila.Enqueue("Sicrano");
fila.Enqueue("Beltrano");
fila.Enqueue("Pamela");

Console.WriteLine(fila.Peek); //Peek ele mostra o primeiro a sair da fila
Console.WriteLine(fila.Count); //vai contar os elementos da fila

Console.WriteLine(fila.Dequeue()); //Dequeue desenfileirar
Console.WriteLine(fila.Count);

foreach (var pessoa in fila)
{
    Console.WriteLine(pessoa);
}
