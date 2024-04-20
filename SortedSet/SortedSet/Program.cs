// See https://aka.ms/new-console-template for more information
Console.WriteLine("## SortedSet ##");

// Criando uma coleção SortedSet tipo int
var numeros = new SortedSet<int>()
{
    0, 5, 2, 4, 3, 1   // observe esta fora da ordem
}; 


foreach (var numero in numeros)
{
    Console.Write($"{numero} ");  // resposta estara na ordem 0 1 2 3 4 5
}

var frutas = new SortedSet<string>()
{
    "kiwi", "maça", "uva", "banana", "caju"  // adicionei fora de ordem
};


ExibirColecao(frutas);  // como é SortedSet será exibido em ordem

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> dados)
{
    Console.WriteLine();
    foreach (var dado in dados)
    {
        Console.WriteLine(dado);
    }
}