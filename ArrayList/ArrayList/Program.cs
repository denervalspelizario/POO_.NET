// See https://aka.ms/new-console-template for more information
using System.Collections; // para usar a ArrayList tem que importar o System.Collections

Console.WriteLine("## Array List ##");

// declarando uma variavel lista do tipo ArrayList
ArrayList lista;

// instanciando ela
lista = new ArrayList();


// criando uma outra variavel do tipo ArrayList mas essa de maneira unica
ArrayList lista02 = new ArrayList();

// outra maneira
var lista03 = new ArrayList();

// outra maneira
ArrayList lista04 = new();



// criando uma outra variavel do tipo ArrayList mas essa de maneira unica
ArrayList lista05 = new ArrayList(5);

// outra maneira
var lista06 = new ArrayList(5);

// outra maneira
ArrayList lista07 = new(5);


ArrayList lista08 = new();


// adicionando dados ao arraylist
lista08.Add("Paulo");
lista08.Add(4.5);
lista08.Add(true);
lista08.Add(" ");
lista08.Add(5);
lista08.Add(null);


//
var lista09 = new ArrayList() { "Paulo", 4.5, true, " ", 5, null };




