
using GetSet;

var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

Console.WriteLine(moto1.GetMarca());
Console.WriteLine(moto1.GetCilindrada());
Console.WriteLine(moto1.GetModelo);

var moto2 = new Moto();

moto2.SetMarca("Honda");
moto2.SetCilindrada(150);
moto2.SetModelo("CG Titan");

Console.WriteLine(moto2.GetMarca() + " " +
    moto2.GetCilindrada + " " + 
    moto2.GetModelo);
    moto1.GetMarca();
