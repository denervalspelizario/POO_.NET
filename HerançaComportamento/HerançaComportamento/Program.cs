// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Herança Comportamento ##");

// instanciando um objeto estudoClasse que recebe todos os dados da classe ClasseDerivada
ClasseDerivada estudoClasse = new();

estudoClasse.VerificaAcesso(); // chamando metodo verifica acesso

Console.ReadKey();
// usando a estrutura da ClasseBase na ClasseDerivada atravez do conceito de herança
public class ClasseDerivada : ClasseBase
{
    // metodo
    public void VerificaAcesso() // que chamaa todos os metodos da ClasseBase
    {
        Public_Membro();
        Protected_Membro();
        Internal_Membro();
        Protected_Internal_Membro();
        //Private_Membro();   não da para acessar pq é privado

        Console.WriteLine("\nAcesso ao campo private_var usando uma propriedade GET");
        // para acessar o private_Var tive que acessar pelo GET da propriedade Private_var
        // não da para acessar diretamente
        int soma = public_var + protected_var + internal_var + Private_var;
        Console.WriteLine("\nTotal de soma : " + soma);
    }
}
public class ClasseBase
{
    // campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;

    //propriedade para acessar o private_var(ENCAPSULAMENTO )
    public int Private_var
    {
        get { return private_var; }
        set { private_var = value; }
    }

    // metodos public, protect e void
    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }
    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }
    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Internal");
    }
    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected Internal");
    }
    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método Privated");
    }
}