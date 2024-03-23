// See https://aka.ms/new-console-template for more information
Console.WriteLine("##  Argumentos por referencia - out ##");


Console.WriteLine("Informe o valor do raio do circulo");

double raio = Convert.ToDouble(Console.ReadLine()); // recendo do user o valor do raio

Circulo circulo = new Circulo(); // criando um objeto circulo usando a classe Circulo


double perimetro = circulo.CalculaAreaPerimetro(raio, out double area);



Console.WriteLine("Perímetro da Circunferência " + perimetro);

Console.WriteLine("Área da circunferência : " + area);


Console.ReadKey();  

// classe circulo
public class Circulo
{
    // metodo CalculaAreaPerimetro
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2); // calculando area
        double perimetro = 2 * Math.PI * raio; // calculando perimetro
        return perimetro;
    }

    

}
