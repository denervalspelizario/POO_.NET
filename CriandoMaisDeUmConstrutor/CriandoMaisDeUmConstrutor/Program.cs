// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Usando Mais de 1 Construtor ##");

// criando um objeto aluno usando a classe Aluno ja com os parametros determinados pelo Construtor
Aluno aluno = new Aluno( 36, "masculino", "S");





Console.ReadKey();

public class Aluno  // classe aluno

{
    //Construtor 02
    public Aluno(string nome)
    {
        Nome = nome; // Nome = atributo Nome, nome = parametro nome
    }


    // Construtor com parametro 01
    public Aluno( int idade, string sexo, string aprovado)
    {
        Idade = idade; // Idade = atributo Idade, idade = parametro idade
        Sexo = sexo;
        Aprovado = aprovado;
    }

    // atributos
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}
