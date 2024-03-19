// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Classes e Métodos ##\n");

int x = 100;

Pessoa pessoa01 = new Pessoa(); // criando uma pessoa usando a classe Pessoa

pessoa01.nome = "Dener"; // adicionando dados a essa pessoa nome, idade e sexo

pessoa01.idade = 36;

pessoa01.sexo = "Masculino";


Console.WriteLine($"{pessoa01.nome} tem {pessoa01.idade} de idade e seu sexo é {pessoa01.sexo}");

Console.ReadKey();

class Pessoa
{
    // atibutos
    public string? nome;
    public int idade;
    public string? sexo;
}