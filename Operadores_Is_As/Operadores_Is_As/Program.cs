// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Operadores IS e AS ##");

// instanciando um objeto com a classe carro ou seja de Object para Carro
Object carroObj = new Carro();

/*
try
{
    // tentando de Carro para string e no caso vai dar erro
    var x = (string)carroObj; // exception
}
catch(Exception ex) // erro
{
    Console.WriteLine("\nConversão falhou...");
    Console.WriteLine(ex.Message);
}
*/

// usando o operador AS
var y = carroObj as string; // ou seja de Carro para string se não der certo ele manda um null

if(y == null)
{
    Console.WriteLine("não foi possivel a conversão");
}
Console.WriteLine(y);

Console.ReadKey();

class Carro
{

}