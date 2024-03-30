// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Exercicio Herança ##");

Console.WriteLine("\nTeste da conta Corrente");
ContaCorrente contaCorrente = new ContaCorrente(456, "Denerval Silva");

Console.WriteLine($"\nCliente: {contaCorrente.NomeCliente}, conta-corrente:{contaCorrente.NumeroConta}, Saldo: {contaCorrente.Saldo}");

contaCorrente.Depositar(100);
contaCorrente.SaldoConta();

contaCorrente.Sacar(75);
contaCorrente.SaldoConta();

Console.WriteLine("\nTeste Conta Poupança ");


Console.ReadKey();

public class ContaBase
{
    // propriedades
    public int NumeroConta { get; set; }
    public string? NomeCliente { get; set; }
    public double? Saldo { get; set;}
    // construtor
    public ContaBase(int numeroConta, string nomeCliente) 
    { 
        NumeroConta = numeroConta;
        NomeCliente = nomeCliente;
        Saldo = 0;
    }
    // metodos
    public void SaldoConta()
    {

        Console.WriteLine($"Valor do saldo R$ : {Saldo}"); 

    }

    public void Depositar(double valorDeposito)
    {
        if(valorDeposito > 0)
        {
            Saldo += valorDeposito;
        }
        else
        {
            Console.WriteLine("Valor para deposito inválido");
        }
        
    }

    public void Sacar(double valorSacar)
    {
        if(valorSacar < Saldo)
        {
            Saldo -= valorSacar;
        }
        else
        {
            Console.WriteLine("Valor a sacar superior ao saldo verifiue o saldo para sacar");
        }
    }
}
// criando a classe ContaCorrente herandando a classe da ContaBase
public class ContaCorrente : ContaBase
{
    // chamando o contrutor da classe base
    public ContaCorrente(int numeroConta, string nomeCliente)
        : base(numeroConta, nomeCliente)
    {
    }
}