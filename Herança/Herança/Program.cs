// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Herança ##");

// criando um objeto herdando dados da classe Funcionario
Funcionario funcionario01 = new();
funcionario01.Nome = "Denerval";
funcionario01.Email = "eu@email.com";
funcionario01.Empresa = "DevWorld";
funcionario01.Salario = 37.000;


Console.WriteLine("Funcionario");
Console.WriteLine(funcionario01.Empresa);
Console.WriteLine(funcionario01.Nome);
Console.WriteLine(funcionario01.Email);
Console.WriteLine(funcionario01.Salario);


// criando um objeto herdando dados da classe Aluno
Aluno aluno01 = new();
aluno01.Nome = "Denerval";
aluno01.Email = "eu@email.com";
aluno01.Curso = "ADS";
aluno01.Nota = 8;


Console.WriteLine("Aluno");
Console.WriteLine(aluno01.Nome);
Console.WriteLine(aluno01.Email);
Console.WriteLine(aluno01.Curso);
Console.WriteLine(aluno01.Nota);


Console.ReadLine();

// classe Pessoa
public class Pessoa 
{
    // atributos
    public string? Nome { get; set; }
    public string? Email { get; set; }

    // método
    public void Identificar() 
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

//classe Funcionario que também herda a estrutura da classe Pessoa(Nome, Email e metodo Identificar)
public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public double Salario { get; set; }

}


//classe Aluno que também herda a estrutura da classe Pessoa(Nome, Email e metodo Identificar)
public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }

}


