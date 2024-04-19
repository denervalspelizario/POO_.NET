// See https://aka.ms/new-console-template for more information
Console.WriteLine("## HashSet ##");

// criação coleção hashset com itens
var numeros = new HashSet<int>() { 1,2,3,4,5};


var frutas = new HashSet<string>() { "abacaxi", "melao", "melancia", "uva"};


HashSet<int> pares = new HashSet<int>();

pares.Add(2);
pares.Add(4);
pares.Add(6);
pares.Add(8);

foreach (var i in pares)
{
    Console.WriteLine(i);
}



Console.ReadKey();