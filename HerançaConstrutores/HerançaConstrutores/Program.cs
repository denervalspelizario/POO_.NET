// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Construtores ##");

Aluno aluno01 = new();
Aluno aluno02 = new("gabi");


Console.ReadKey();


// classe base
class Pessoa
{
    public Pessoa() // construtor
    {
        Console.WriteLine("construtor da classe Pessoa");
    }
    public Pessoa(string nome) // construtor
    {
        Console.WriteLine("construtor da classe Pessoa com parametro");
    }
}
// classe derivada
class Aluno : Pessoa
{
    // contrutor
    public Aluno() : base() // base() estou chamando o construtor sem parametro da classe Pessoa
    {
        Console.WriteLine("construtor da classe Aluno");
    }
    // construtor
    public Aluno(string nome) : base(nome) // base(nome) estou chamando construtor Pessoa que recebe(nome) 
    {
        Console.WriteLine("construtor da classe Aluno com parametro");
    }
}

/* resultado
construtor da classe Pessoa
construtor da classe Aluno
construtor da classe Pessoa com parametro
construtor da classe Aluno com parametro */