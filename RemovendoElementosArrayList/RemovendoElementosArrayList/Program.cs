// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("## Removendo Elementos ArrayList");

// criando uma arraylist com nome de lista
var lista = new ArrayList() {"Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0 };

// removendo item null da arraylist lista
lista.Remove(null); 

// removendo um item pela posição
lista.RemoveAt(4);

// removendo mais de 1 itens apartir de uma posição
lista.RemoveRange(0, 2); // removendo 2 itens apartir da posição 0


//

// criando uma arraylista chamada lista06
var lista06 = new ArrayList() {"Maria", 5, true, 4.5, null, DateTime.Now };
var lista07 = new ArrayList() { "Maria","Ana", "Zilda", "Carlos", "Dina" };

// verificar se um elemento existe na coleção

var respostar01 = lista06.Contains(5); // true 

bool resposta02 = lista.Contains("Mari"); // false

// ordenando o arraylist
lista07.Sort();
foreach (var list in lista07)
{ 
    Console.Write($"{list} ,"); // Ana ,Carlos ,Dina ,Maria ,Zilda
}

// apagando todos os elementos de um arraylist

lista07.Clear();
