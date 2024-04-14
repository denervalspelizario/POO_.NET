// See https://aka.ms/new-console-template for more information
Console.WriteLine("## GetHashCode e Equals ##");

// criado objeto pessoa01 instanciado da classe Pessoa
var pessoa1 = new Pessoa(123456, "Erica");
var pessoa2 = new Pessoa(123456, "Erica");
var pessoa3 = new Pessoa(987654, "Erica");


Console.WriteLine("pessoa1 -> Cpf = 123456  Nome = Erica");
Console.WriteLine("pessoa2 -> Cpf = 123456  Nome = Erica");
Console.WriteLine("pessoa3 -> Cpf = 987654  Nome = Erica");

Console.WriteLine("\nComparando objetos Pessoa - GetHashCode");

Console.WriteLine("pessoa1 = " + pessoa1.GetHashCode());
Console.WriteLine("pessoa2 = " + pessoa2.GetHashCode());
Console.WriteLine("pessoa3 = " + pessoa3.GetHashCode());


Console.WriteLine("\nComparando objetos Pessoa - Equals");

Console.WriteLine("pessoa1 = " + pessoa1.Equals(pessoa2)); // false
Console.WriteLine("pessoa2 = " + pessoa2.Equals(pessoa3)); // false

Console.ReadKey();


public class Pessoa
{
    // construtor
    public Pessoa(int cpf, string? nome)
    {
        Cpf = cpf;
        Nome = nome;
    }
    

    // propriedade
    public int Cpf { get; set; }
    public string? Nome { get; set; }

    // metodo tipo bool que sobrescreve(override) o metodo Equals
    // ele recebe de parametro um tipo object padrão
    public override bool Equals(object? obj)
    {
        // se o objeto for null então retorna false
        if(obj == null)  
        {
            return false;  
        }

        // se objeto não for do tipo Pessoa já retorna false também
            if (obj is not Pessoa)
        { 
            return false; // retorna false
        }

        // agora sabendo que recebeu um objeto não nulo e do tipo Pessoa
        // vou adicionar em uma variavel e vou fazer a comparação
        var other = (Pessoa)obj;

        // estou comparando o Cpf do meu objeto( de Pessoa)
        // com o Cpf do objeto de other que esta sendo usado como parametro 
        return Cpf.Equals(other.Cpf);

    }

    // se vc sobrescreve o Equals como foi o caso acima
    // de regra vc tb tem que sobreescrever o GetHashCode
    public override int GetHashCode()
    {
        return Cpf.GetHashCode(); // vou sempre fazer a comparação do Cpf
    }
}