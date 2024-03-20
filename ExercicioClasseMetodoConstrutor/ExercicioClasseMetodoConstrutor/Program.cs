// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Exercicio Construtor Metodo e Classes");


Carro chevrolet = new Carro(); // criando um objeto chevrolet usando a herança da classe Carro

chevrolet.Modelo = "Sedan";
chevrolet.Montadora = "Chevrolet";
chevrolet.Marca = "Onix";
chevrolet.Ano = 2020;
chevrolet.Potencia = 110;



Carro ford = new Carro(); // criando um objeto ford usando a herança da classe Carro

ford.Modelo = "SUV";
ford.Montadora = "Ford";
ford.Marca = "EcoSport";
ford.Ano = 2018;
ford.Potencia = 120 ;


ford.Acelerar("Ford");


Carro carro01 = new Carro("Corrida", "Ferrari", "488 berlinetta", 2020, 600);


Console.WriteLine($"\n{carro01.Marca}\n{carro01.Montadora}\n{carro01.Modelo}\n{carro01.Ano}\n{carro01.Potencia} ");
carro01.Acelerar(carro01.Marca);


Console.ReadKey();

// criando a classe carro
public class Carro
{

    // criando os atributos
    //modelo, montadora, marca, ano e potencia
    public string Modelo;
    public string Montadora;
    public string Marca;
    public int Ano;
    public int Potencia;


    // criando um construtor
    public Carro()
    {

    }
    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia= potencia;
    }

    

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando...{marca}");
    }

}