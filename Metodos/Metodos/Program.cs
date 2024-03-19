// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Metodos ##");


MinhaClasse classePessoal = new MinhaClasse(); // criando um objeto(classePessoal)
                                               // que recebe dados da classe MinhaClasse


classePessoal.Saudacao(); // chamando o método Saudação


Console.ReadKey();

class MinhaClasse  // criando classe
{
    public void Saudacao() // criando método public(pode ser acessado)
    {
        Console.WriteLine("Bem Vindo");
        Console.WriteLine("19/03/2024");
    }
    
}