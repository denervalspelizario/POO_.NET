// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Herança e Object");

Nada nada = new();

Aluno aluno = new();
aluno.Nome = "Dener";
aluno.Curso = "ADS";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();


public class Nada
{

}

public class Classe01
{

}
public class Classe02
{

}

public class ClasseDerivada : Classe01
{

}

class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, eu sou o(a) {Nome}";
}
class Aluno : Pessoa 
{
    public string? Curso { get; set; }
    public string Saudacao() => $"Oi, eu sou o(a) {Nome} do curso de : {Curso}";
    // Saudação() de aluno esta ficando no lugar de Saudação() de Pessoa
    // este é o comportamento default quando tem 2 metodos iguais entre classe
    // base e derivada
}
