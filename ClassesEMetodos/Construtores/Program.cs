

using Construtores;

var carro1 = new Carro();
carro1.Fabricante = "BMW";
carro1.Modelo = "325i";
carro1.Ano = 2017;
Console.WriteLine(
    $"{carro1.Fabricante}{carro1.Modelo}{carro1.Ano}");

var carro2 = new Carro("ka", "Ford", 2017);
Console.WriteLine($"{carro2.Fabricante}{carro2.Modelo}{carro2.Ano}");


    var carro3 = new Carro()
    {
        Fabricante = "fiat",
        Ano = 2019,
        Modelo = "Uno",

        Console.WriteLine($"{carro3.Fabricante}")
    };



