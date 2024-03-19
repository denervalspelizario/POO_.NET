// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Construtores ##");

// criando um objeto aluno usando a classe Aluno ja com os parametros determinados pelo Construtor
Aluno aluno = new Aluno("Denerval", 36, "masculino", "S");  

Console.ReadKey();


public class Aluno  // classe aluno

{
    // Construtor com parametro
    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome; // Nome = atributo Nome, nome = parametro nome
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;

    }



    // atributos
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}