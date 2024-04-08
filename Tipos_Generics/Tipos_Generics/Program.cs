// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Generics  ##");

Teste teste = new Teste(); // criando um objeto instanciado da classe Teste

Teste02<int, int> teste02 = new Teste02<int, int>(); // criando um objeto instanciado da classe
                                                     // genérica Teste02

int i1 = 10; 
int i2 = 10;

float f1 = 10; 
float f2 = 10;


string s1 = "10";
string s2 = "10";



// chamando metodo comparar que recebe tipo generics ou seja o tipo é generico
teste.Comparar(i1, i2); 
teste.Comparar(f1, f2); 
teste.Comparar(s1, s2); 

// chamando o método comparar do objeto teste02
teste.Comparar(i1, i2); // neste caso como ela foi tipada como <int, int>
                        // só pode ser instanciada como inteiro 

Console.ReadKey();

public class Teste // classe Teste
{
    // método Comparar
    // o <T> estou indicando que o parametro vai ser tipo generico ou seja 
    // pode variar  neste caso não estou especificando
    // observação está T mas pode ser Tvalue ou outros
    public void Comparar<T>(T p1, T p2)
    {
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}");
    } 
        
}

public class Teste02<T1, T2> // classe Teste02 do tipo genérica
{
        
    // neste método estou usando 2 tipos genericos que no caso será uma
    // comparação de tipos diferentes
    public void Comparar<T1, T2>(T1 p1, T2 p2)
    {
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}");
    }
}
