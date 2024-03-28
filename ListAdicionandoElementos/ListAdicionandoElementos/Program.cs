// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Adicionando Elementos  ##");

var lista = new List<string>() {"Maria","Ana", "Pedro", "Carlos", "Zé" };

// está sendo adicionada no final da lista
lista.Add("Marta");

// esta sendo adicionandoa string "Bia" na posição 2 do list
lista.Insert(2, "Bia");

string[] array01 = { "Diná", "Carlos", "Pedro" };

// adicionando a list um array no final da list
lista.AddRange(array01);

// adicionando na posição 1 o array01 dentro do list
lista.InsertRange(1, array01);

// removendo itens de uma list

var lista02 = new List<int>() { 9,5,4,1,7,8,3,6,9,0};

// removendo um item especifico
lista02.Remove(7);

// removendo pelo indice
lista02.RemoveAt(4);

//removendo varios itens
lista02.RemoveRange(0,2); // primeiro item = posição, segundo item = quantos elementos


// Acessando um elemento de um list
var lista03 = new List<string>() { "Maria", "Ana", "Marcos", "Pedro" };

var primeiro = lista03[0]; // acessando o indice 0 da list

// alterando o valor pelo indice
lista03[2] = "Bruna"; // estou aletrando o indice 2 de list para "Bruna"

lista03[0] = "Silvia";

// usando for na pratica para percorrer a list

for (int i = 0; i < lista03.Count; i++)
{
    Console.Write($"{lista03[i]}  ");
}

Console.WriteLine();

// usando foreach(mais recomendado)

foreach (var nome in lista03)
{
    Console.Write($"{nome}  ");
}

