// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Array 02 ##");

int[] numeros;

// aloquei memoria e declarei os 10 numeros
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


// array de strings , aloquei 3 espaços na memoria e declarei eles
string[] nomes = new string[3] { "Gabi", "Pedro", "Tom" };

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Ola {nomes[i]}");
}


// laço foreach
foreach (int numero in numeros)
{
    Console.WriteLine($"Contagem regressiva em  {numero}");
}


Console.ReadKey();
