

using Props;

var op1 = new CarroOpcional("Ar Condicional", 3499.90);
Console.WriteLine(op1.PrecoComDesconto);

var op2 = new CarroOpcional();
op2.Nome = "Direção Elétrica";
op2.Preco = 2349.9;

Console.WriteLine(op1.Nome);
Console.WriteLine(op1.Preco);

Console.WriteLine(op2.Nome);
Console.WriteLine(op2.Preco);
Console.WriteLine(op2.PrecoComDesconto);