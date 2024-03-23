// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Structs ##");

Cliente cliente = new Cliente(); // criando um objeto cliente recebendo dados
                                 // da struct Cliente
cliente.Nome = "Vaval";
cliente.Idade = 36;


Console.WriteLine($"{cliente.Nome} - {cliente.Idade}");



Console.ReadKey();


// criando um struct
public struct Cliente
{
    // propriedades
    public string? Nome { get; set; }
    public int Idade { get; set; }
    
    // construtor
    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        idade = idade;
    }
}