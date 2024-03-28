// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Modificador Params ##");

int[] valores = { 1, 2, 3 };

var resultado = Calcular.Soma(valores);


Console.WriteLine(resultado);


// passando so valores de maneira direta
var resultado02 = Calcular.Soma(10,20,30,40,50);

Console.WriteLine(resultado02);



Console.ReadKey();

// Classe Calcular
public class Calcular
{
    // metodo estático Soma
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros) 
        {
            total += numero;
        }
        return total;
    }
}
