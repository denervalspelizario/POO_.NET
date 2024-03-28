// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("## ArrayList 02 ##");


// criando um arrayList chamado lista já com valores adicionando

var lista = new ArrayList() {"Maria", 5, true, " ", null };

lista.Add(3.5); // adicionando valor double  a arraylist lista que será adicionado no final da lista

lista.Insert(2, "Paulo"); // adicionando na posição 2 a string "Paulo" usando o Insert

/////

// criando uma arraylist chamamda lista02 ja adicionando o valor
var lista02 = new ArrayList() { "Maria", 5, true };

int[] array1 = { 1, 2, 3 }; // array de inteiros ja com valor


// estou adicionando array1 no final da arraylist lista
lista.AddRange(array1);

// estou adicionando na posição 2 da arraylist lista o valor de array1
lista.InsertRange(2, array1);

