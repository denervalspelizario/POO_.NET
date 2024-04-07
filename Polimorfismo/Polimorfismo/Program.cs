// See https://aka.ms/new-console-template for more information
using Polimorfismo;

Console.WriteLine("## Polimorfismo Dinamico ##");

// Este polimorfismo usado com classes abstratas

// criando uma variável figura que será instanciada um List(lista) de classe Figura
// ou seja nesta variavel terá uma List de classes Figura 
var figuras = new List<Figura>
{
    new Triangulo(), // criando 2 instancias 1 do tipo Circulo e outro tipo Triangulo
    new Circulo()
};

foreach (var figura in figuras) // percorrendo figuras
{
    figura.Desenhar(); // vai percorrer Triangulo e Circulo
}
// o resultado deste foreach vai ser
/*
  Desenhando um triangulo ...
  Executando Desenhar na classe base
  Desenhando um circulo ...
 */


// este exemplo de cima seria a mesma coisa que fazer o exemplo abaixo
Figura figura1 = new Circulo();
Figura figura2 = new Triangulo();

Console.WriteLine();


// Polimorfismo em tempo de Execução usando sobrecarga de método

Calcular calcular = new Calcular();
Console.WriteLine(calcular.Somar(30,20)); // 50
Console.WriteLine(calcular.Somar(30,20,10)); //60

class Calcular
{
    // 2 metodos com sobrecarga (nomes iguais mas parametros diferentes)
    public int Somar(int num1, int num2) 

    {
        return num1 + num2;
    }
    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}