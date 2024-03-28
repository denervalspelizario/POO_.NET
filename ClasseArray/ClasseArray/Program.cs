// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Classe Array");



string[] nomes = {"Ana", "Beatriz", "Denerval","Carolina", "Tom", "Gabi","Pedro" };


Console.WriteLine("\n\nExibindo o array original");

ExibirArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do array");

// usando a classe Array com metodo Reverse 
Array.Reverse(nomes);

ExibirArray(nomes);

Console.WriteLine("\n\nOrdenando o array");
Array.Sort(nomes);

ExibirArray(nomes);

Console.WriteLine("\n\nLocalizando um valor em um array");
Console.WriteLine("Infomeo nome buscado");

string nome = Console.ReadLine(); // recebendo o nome buscado

var indice = Array.BinarySearch(nomes, nome);

if(indice >= 0)
{
    Console.WriteLine($"\n{nome} foi encontrado com indice = {indice}");
}
else
{
    Console.WriteLine($"\n{nome} não foi encontrado");
}


Console.ReadKey();



// metodo statico que retorna um for each
static void ExibirArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.Write($"{nome}, ");
    }
}