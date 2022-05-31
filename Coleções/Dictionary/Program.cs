
//Dicionário

var filmes = new Dictionary<int, string>();
{
    filmes.Add(2000, "Gladiador");
    filmes.Add(2002, "Homem-Aranha");
    filmes.Add(2004, "Os Incréveis");
    filmes.Add(2006, "O Grande Truque");

    if (filmes.ContainsKey(2004))//localizando pelo indice
    {
        Console.WriteLine("2004:" + filmes[2004]);
    }

    //percorrendo um dicionário por chave

    foreach (var chave in filmes.Keys)
    {
        Console.WriteLine(chave);
    }

    //percorrendo um dicionario por valor

    foreach(var chave in filmes.Values)
    {
        Console.WriteLine(chave);
    }

    //removendo um intem do dicionario 

    Console.WriteLine($"Remove {filmes.Remove(2004)}");

    //percorrendo um dicionario por chave e valor

    foreach (KeyValuePair<int, string> filme in filmes)
    {
        Console.WriteLine($"{filme.Value} é de {filme.Key}.");
    }

}

