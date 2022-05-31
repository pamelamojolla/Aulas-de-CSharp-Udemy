
//arraylist

using System.Collections;

var arraylist = new ArrayList
{
    "Palavra",      //inserindo valores heterogêneos
    3,
    true,
};

arraylist.Add(3.14);

foreach (var item in arraylist) // percorrendo o arrylista
{
    Console.WriteLine("{0} => {1}", item, item.GetType()); // pedindo para mostrar os tipos dentros do array list
}
