// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Interface ##");

IControle d = new Demo(); // criei uma instancia do tipo IControle d
                          // que herda dados da classe Demo e da interface IControle
                          // neste caso não consegue herdar os dados do tipo IGrafico

d.Desenhar();
d.Name = "Vaval";
d.Exibir();
Console.WriteLine(d.Name);

Console.ReadKey();

// interface é como se fosse uma classe abstrata que nao pode ser instanciada apenas derivada
interface IControle // interface (inicia com letra I como convenção)
{
    string Name { get; set; }
    void Desenhar(); // metodo abstrato sem implementação
    public void Exibir() // metodo com implementação que não precisa de implementação na herança
    {
        Console.WriteLine("Método não abstrato ...");
    }
}

interface IGrafico
{
    void Pintar(); // metrodo abstrato sem implementação se for herdado
                   // quem herdar precisa fazer a implementação desse método asssim
                   // como foi feito no metodo Desenhar() da interface IControle
}

// adicionei a classe Demo a interface que recebe 2 interfaces Icontrole e Igrafico
public class Demo : IControle, IGrafico 
{
    public string Name { get; set; } = string.Empty; //deixando vazio apenas para tirar o alerta

    public void Desenhar() // como Desenhar na interface não tem implementação aqui tem que ter
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando....");
    }
}
