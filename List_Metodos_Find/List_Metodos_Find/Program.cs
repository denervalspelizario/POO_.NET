// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Métodos FIND");

List<string> frutas = new () {"Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"};

// Predicado como uma função
var fruta01 = frutas.Find(Procura); // no caso o retorno será que Banana tem "n" 

Console.WriteLine($"\nPredicado => {fruta01}");

//Usando a expressão lambda
var fruta02 = frutas.Find(i => i.Contains("n"));

Console.WriteLine($"\n expressão lambda => {fruta02}");

// metodo findlast()
var fruta03 = frutas.FindLast(i => i.Contains("n")); // ultimo item que tenha "n"
Console.WriteLine($"\n FindLast => {fruta03}");

// metodo FindIndex

var fruta04 = frutas.FindIndex(i => i.Contains("n")); // retorna o valor do primeiro indice que tem "n"
Console.WriteLine($"\n FindIndex => {fruta04}");


// metodo FindLastIndex

var fruta05 = frutas.FindLastIndex(i => i.Contains("n")); // retorna o valor do último indice que tem "n"
Console.WriteLine($"\n FindIndex => {fruta05}");


// metodo FindAll

var fruta06 = frutas.FindAll(i => i.Contains("n")); // retorna todos que tem "n"
                                                    // neste caso uma lista de string
foreach(var fruta in fruta06)
{
    Console.Write($"{fruta} ");
}

Console.ReadKey();


// método estatico
static bool Procura(string item)
{
    return item.Contains("n"); // verifica se "n" existe no parametro item
}