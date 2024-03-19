// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("## Passando Parametros entre Classes ##");


Aluno aluno = new Aluno(); // criando um objeto aluno da Classe Aluno

Console.WriteLine("Digite o nome do Aluno");
aluno.Nome = Console.ReadLine();  // recendo dados e jogando no atributo nome do objeto aluno

Console.WriteLine("Digite a idade do Aluno");
aluno.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o sexo do Aluno");
aluno.Sexo = Console.ReadLine();

Console.WriteLine("Digite se o Aluno foi aprovado (S/N)");
aluno.Aprovado = Console.ReadLine();


Curso curso = new Curso(); // criando um objeto curso usando a classe Curso

// passando para o metodo resultado os parametros com os atributos preenchidos do objeto aluno
curso.Resultado(aluno);




Console.ReadKey();


public class Aluno  // classe aluno
{
    // atributos
    public string? Nome; 
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

// classe curso
public class Curso
{
    // metodo Resultado com 4 parametros
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"O aluno {aluno.Nome}, sexo {aluno.Sexo} com idade {aluno.Idade}");
        if(aluno.Aprovado == "S" || aluno.Aprovado == "s")
        {
            Console.WriteLine("\n foi aprovado");
        }
        else
        {
            Console.WriteLine("\n foi Reprovado");
        }
    }
}