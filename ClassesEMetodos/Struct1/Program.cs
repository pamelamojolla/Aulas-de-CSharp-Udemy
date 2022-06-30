


using Struct;

Coordenada coordenadaInicial;
coordenadaInicial.X = 2;
coordenadaInicial.Y = 2;

Console.WriteLine("Coordenada Inicial: ");
Console.WriteLine("X = {0}", coordenadaInicial.X);
Console.WriteLine("Y = {0}", coordenadaInicial.Y);

var coordenadaFinal = new Coordenada (x:9, y:1);
coordenadaFinal.MoverNaDiagonal(10);

Console.WriteLine("Coordenada Final:");
Console.WriteLine("X = {0}", coordenadaFinal.X);
Console.WriteLine("Y = {0}", coordenadaFinal.Y);


