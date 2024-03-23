// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Enum ##");

// acessando o ENUM
Console.WriteLine(DiasDaSemana.Segunda);

Console.WriteLine(DiasDaSemana02.Segunda);


Console.ReadKey();


enum DiasDaSemana // enum com valores padrão
{
    Segunda, // 0
    Terça,   // 1
    Quarta,  // 2
    Quinta,  // 3
    Sexta,   // 4
    Sabado,  // 5
    Domingo  // 6
}


enum DiasDaSemana02 // enum com valores definidos
{
    Segunda = 10, // 0
    Terça = 20,   // 1
    Quarta = 50,  // 2
    Quinta = 60,  // 3
    Sexta = 70,   // 4
    Sabado = 80,  // 5
    Domingo = 90  // 6
}