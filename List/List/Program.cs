// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Uso do List ##");

// declarar uma coleção do tipo List<t> de string
List<string> lista;

lista = new List<string>(); //inicializando a list lista


// uma outra maneira ja declarando e inicializando
List<int> lista02 = new List<int>();

// outra maneira seria
var lista03 = new List<float>();

// e uma maneira mais usada e mais enxuta seria
List<double> lista04 = new();

// todas essas maneiras são equivalentes

// adicionando nomes
List<string> nomes = new();

nomes.Add("Vaval");
nomes.Add("Gabi");
nomes.Add("Pedro");

foreach (var nome in nomes)
{
    Console.Write($"{nome} ");
}


Console.ReadKey();
