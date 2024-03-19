// See https://aka.ms/new-console-template for more information
Console.WriteLine("## this ##");

//Objeto 01
Teste t1 = new Teste(); // criando um objeto t1 que recebe a herança da classe Teste
t1.Num01 = 10; // passando dado para o atributo Num01
t1.Num02 = 20;
t1.Exibir();    // chamando o método Exibir()


//Objeto 02
Teste t2 = new Teste(); // criando um objeto t2 que recebe a herança da classe Teste
t2.Num01 = 88; // passando dado para o atributo Num01
t2.Num02 = 99;
t2.Exibir();    // chamando o método Exibir()


Console.ReadKey();


public class Teste // criando classe Teste
{
    // atributos
    public int Num01; 
    public int Num02;

    // métodos
    public void PassarParametros(Teste t) // recebe parametro um objeto t que tem como herança a classe Teste
    {
        Console.WriteLine($"\n this = {this}");
        Console.WriteLine("Num01: " + t.Num01);
        Console.WriteLine("Num02: " + t.Num02);
    }

    public void Exibir()
    {
        // passando this como um parâmetro (a classe Teste)
        PassarParametros(this);
    }
   

}