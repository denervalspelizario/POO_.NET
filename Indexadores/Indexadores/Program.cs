// See https://aka.ms/new-console-template for more information
using Indexadores;

Console.WriteLine("## Indexadores ##");

// criando um objeto time usando como base a classe Time
Time time = new Time();

// atibuindo valores ao indexador
time[1] = "Palmeiras";
time[3] = "Santos";
time[5] = "São Paulo";
time[7] = "Vasco";
time[-1] = "Flamengo"; // erros pq esta adicionando a um indece que não existe
time[1000] = "Bahia"; // erro pq esta adicionando a um indece que não existe

// obtendo valor de um indexador

string valor01 = time[1];
string valor02 = time[3];
string valor03 = time[5];
string valor04 = time[7];

Console.WriteLine(valor01);
Console.WriteLine(valor02);
Console.WriteLine(valor03);
Console.WriteLine(valor04);



Console.ReadKey();
