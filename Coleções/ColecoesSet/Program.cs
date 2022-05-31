using Set;

//Lista

var livro = new Produto("Game of Throne", 49.90);

var carrinho = new HashSet<Produto>(); //HASHSET é uma estrutura que não é indexada
carrinho.Add(livro); // aqui eu estou adicionando a var livro

var combo = new HashSet<Produto>
{
    new Produto("Camisa", 29.90),
    new Produto("8º Temporada Game of Thrones", 98.8),
    new Produto("Poster", 10)
};

carrinho.UnionWith(combo);// ele aceita a união de elementos

Console.WriteLine(carrinho.Count); //aqui ele conta quantos eles elementos tem dentro do carrinho

foreach (var item in carrinho){
   
    Console.WriteLine($"{item.Nome}{item.Preco}");
  
}

carrinho.Contains(livro);// Contains  ele mostra o que é o objeto

