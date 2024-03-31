// See https://aka.ms/new-console-template for more information
using Downcasting_Upcasting;

Console.WriteLine("## Downcasting e Upcasting ##");

// criando um objeto que recebe os dados da classe Forma e também os dados da classe Circulo
Forma circulo = new Circulo(10,20);// upcasting
Forma forma = circulo; // outra forma de fazer um upcasting

circulo.Desenhar();

Console.WriteLine(forma == circulo); // true

Console.WriteLine("\nFazendo Downcasting");

Circulo ciruculo01 = new Circulo(20,20);
Forma forma01 = ciruculo01; // upcasting

Circulo c = (Circulo)forma01; // downcasting

c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == forma01); // true
Console.WriteLine(c == ciruculo01); // true
Console.ReadKey();