// See https://aka.ms/new-console-template for more information
using ClasseAbstrata;

Console.WriteLine("## Classe Abstrata ##");


Quadrado q = new Quadrado(); // criando uma instancia q recendo dados da classe quadrado
Console.WriteLine(q.Descricao()); //chamndo o metodo Descricao

Console.WriteLine("\nInfome a cor da figura");
q.Cor = Console.ReadLine(); //recebendo o dado de cor

Console.WriteLine("\nInfome o valor do lado do quadrado");
q.Lado = Convert.ToInt32(Console.ReadLine()); // recebendo o lado

q.CalcularArea(); // chamando o metodo que calcula area
q.CalcularPerimetro(); // chamando o metodo que calcula o perimetro

Console.WriteLine($"\nÁrea do quadrado : {q.Area} m2");
Console.WriteLine($"\nPerimetro do quadrado : {q.Perimetro} m");

Console.WriteLine($"\nO quadrado tem a cor : {q.Cor} m");

Console.ReadKey();