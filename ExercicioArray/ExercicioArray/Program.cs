// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Exercicio Array ##");

Console.WriteLine("Ola td bem?");
Console.WriteLine("Digite 5 nomes dos alunos para fazer o processamento");
string nome = Console.ReadLine();
string nome02 = Console.ReadLine();
string nome03 = Console.ReadLine();
string nome04 = Console.ReadLine();
string nome05 = Console.ReadLine();

string[] nomes;
nomes = new string[] { nome, nome02, nome03, nome04, nome05};

Console.WriteLine("Digite as notas dos alunos");
double nota01 = Convert.ToDouble(Console.ReadLine());
double nota02 = Convert.ToDouble(Console.ReadLine());
double nota03 = Convert.ToDouble(Console.ReadLine());
double nota04 = Convert.ToDouble(Console.ReadLine());
double nota05 = Convert.ToDouble(Console.ReadLine());


double[] notas = new double[] {nota01, nota02, nota03, nota04, nota05};

foreach (string nomeDigitado in nomes)
{
    Console.Write($"{nomeDigitado} ");
}


Console.WriteLine("\n");

foreach(double notaDigitada in notas)
{
    Console.Write($"{notaDigitada} ");
}


Console.WriteLine("\n");


double valorTotalNotas = 0;

for (int i = 0; i < notas.Length; i++)
{
    valorTotalNotas += notas[i];
}

double mediaNotas = valorTotalNotas / notas.Length;

Console.WriteLine($"A média geral das notas foi {mediaNotas}");

Console.ReadKey();  
