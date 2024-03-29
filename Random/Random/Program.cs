// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Random ##");

Random random = new Random(); // criando um objeto random usando a Classe Random

Console.WriteLine(random.Next());
Console.WriteLine(random.Next(20));// valor aleatorio entre 0 e 19
Console.WriteLine(random.Next(10,20));// valor aleatorio entre 10 e 19
Console.WriteLine(random.NextDouble());// valor aleatorio entre 0 e 1


// prenchendo um array com numeros aleatorios
Console.WriteLine("\n## Array de bytes Aleatorios ##");

// criando um array de bytes com 10 posiçoes
byte[] arrayDeBytesAleatorios = new byte[10];

// criando um objeto random
Random valoresRandom = new Random();

// adicionando os valores random de bytes (NextBytes) no array de bytes(arrayDeBytesAleatorios) 
valoresRandom.NextBytes(arrayDeBytesAleatorios);

// imprimindo os valores aleatorios
foreach(var array in arrayDeBytesAleatorios)
{
    Console.WriteLine(array);
}



Console.ReadKey();
