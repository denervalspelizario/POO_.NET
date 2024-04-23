// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;

Console.WriteLine("## ReadyOblyCollection ##");


// criando uma lista de string e ja adicionando  os dados

var planetas = new List<string>()
{
    "Mercurio", "Venus", "Terra", "Marte"
};


// criando uma colecao ReadOnlyCollection tipo string e adicionando a lista planetas sobre ela
var listaPlanetas = new ReadOnlyCollection<string>(planetas);

var novaLista = planetas.AsReadOnly();

Console.WriteLine("\nPlanetas não gasosos do sitema solar");
// Listando planetas
foreach (var planeta in listaPlanetas)
{
    Console.WriteLine($"{planeta}");
}

// verificando a quantidade de itens na coleção
Console.WriteLine($"\n\nPlanetas na coleção: {listaPlanetas.Count()}");


// verificando se um item especifico esta na coleção
Console.WriteLine($"Marte esta na coleção? {listaPlanetas.Contains("Marte")}"); // true

// verificando o indice de um item especifico
Console.WriteLine($"Marte esta na posicao {listaPlanetas.IndexOf("Marte") + 1} da coleçao listaPlanetas");

Console.ReadKey();
