

using Struct_Vs_Classes;


//Struct
SPonto ponto1 = new SPonto { X = 1, Y = 3 };

SPonto copiaPonto1 = ponto1; //atribuicao por valor, mantem a original é feita uma cópia
ponto1.X = 3;

Console.WriteLine("$ Ponto 1 X" + ponto1);
Console.WriteLine("$ Copia Ponto1" + copiaPonto1);

//Classe

Cponto ponto2 = new Cponto { X = 2, Y = 4 }; //como eles apontam para o mesmo local de memoria, ambos são alterados
Cponto copiaPonto2 = ponto2;
ponto2.X = 4; //Atribuição por referencia

Console.WriteLine("$ Ponto 2 X" + ponto2);
Console.WriteLine("$ Copia Ponto2" + copiaPonto2);
