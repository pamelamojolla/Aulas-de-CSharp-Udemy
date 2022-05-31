using List;

//Lista

var livro = new Produto("Game of Throne", 49.90);

var carrinho = new List<Produto>(); // aqui estou informando que minha lista vai ter só objetos Produto
carrinho.Add(livro); // aqui eu estou adicionando a var livro

var combo = new List<Produto>//aqui ele criou uma nova lista e adicionou esses itens
{
    new Produto("Camisa", 29.90),
    new Produto("8º Temporada Game of Thrones", 98.8),
    new Produto("Poster", 10)
};

carrinho.AddRange(combo); //aqui ele colocou dentro da lista carrinho a lista combo 
Console.WriteLine(carrinho.Count); //aqui ele conta quantos eles elementos tem dentro do carrinho
carrinho.RemoveAt(3); //aqui ele vai remover o indice 3 da lista, lembrando que começa do 0 

foreach (var item in carrinho)
{
    Console.WriteLine(carrinho.IndexOf(item)); //aqui o foreach vai percorrer todos os itens dentros da lista carrinho
    Console.WriteLine($"{item.Nome}{item.Preco}");
    Console.WriteLine(carrinho.LastIndexOf(item));//mostra o último índice de sua lista
}

carrinho.Contains(livro);// Contains  ele mostra o que é o objeto

