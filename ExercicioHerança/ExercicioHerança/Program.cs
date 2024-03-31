// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Exercicio Herança ##");

Console.WriteLine("\nTeste da conta Corrente");
ContaCorrente contaCorrente = new ContaCorrente(456, "Denerval Silva");

Console.WriteLine($"\nCliente: {contaCorrente.NomeCliente}, conta-corrente:{contaCorrente.NumeroConta}, Saldo: {contaCorrente.Saldo}");

Console.WriteLine("Depositando 1000 na conta corrente");
contaCorrente.Depositar(1000);
contaCorrente.SaldoConta();
Console.WriteLine("Sacando o valor de 100");
contaCorrente.Sacar(100);
contaCorrente.SaldoConta();
Console.WriteLine("Fazendo saque de 2000");
contaCorrente.Sacar(2000);
contaCorrente.SaldoConta();

Console.WriteLine("\nTeste Conta Poupança ");

ContaPoupanca contaPoupanca = new ContaPoupanca(789, "Denerval Pelizario");
Console.WriteLine("Depositando 1000 na conta poupança");
contaPoupanca.Depositar(1000);
contaPoupanca.SaldoConta();
Console.WriteLine("Sacando o valor de 100");
contaPoupanca.Sacar(100);
contaPoupanca.SaldoConta();
Console.WriteLine("Fazendo saque de 2000");
contaPoupanca.Sacar(2000);
contaPoupanca.SaldoConta();


Console.WriteLine("\nTeste Conta Investimento ");
ContaInvestimento contaInvestimento = new ContaInvestimento(1012, "Francisca Pelizario");
contaInvestimento.SaldoConta();
Console.WriteLine("Depois do deposito 1000");
contaInvestimento.Depositar(1000);
contaInvestimento.SaldoConta();
Console.WriteLine("Sacando o valor 100");
contaInvestimento.Sacar(100);
contaInvestimento.SaldoConta();
Console.WriteLine("Fazendo saque de 2000");
contaInvestimento.Sacar(2000);
contaInvestimento.SaldoConta();


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

    public virtual void Depositar(double valorDeposito)
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

    public virtual void Sacar(double valorSacar)
    {
        Saldo -= valorSacar;
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

public class ContaPoupanca : ContaBase
{
    public ContaPoupanca(int numeroConta, string nomeCliente)
        : base(numeroConta, nomeCliente)
    {

    }
    public override void Depositar(double valorDeposito)
    {
        if (valorDeposito > 0)
        {
            Saldo += (valorDeposito + valorDeposito * 0.05);
        }
        else
        {
            Console.WriteLine("Valor para deposito inválido");
        }

    }
    public override void Sacar(double valorSacar)
    {
        if (valorSacar <= Saldo)
        {
            Saldo -= valorSacar;
        }
        else
        {
            Console.WriteLine("Valor a sacar superior ao saldo verifique o saldo para sacar");
        }
    }


}

public class ContaInvestimento : ContaBase
{
    public ContaInvestimento(int numeroConta, string nomeCliente)
        : base(numeroConta, nomeCliente)
    {

    }
    public override void Depositar(double valorDeposito)
    {
        if (valorDeposito > 0)
        {
            Saldo += (valorDeposito + valorDeposito * 0.09);
        }
        else
        {
            Console.WriteLine("Valor para deposito inválido");
        }

    }

    public override void Sacar(double valorSacar)
    {
        if (valorSacar <= Saldo)
        {
            Saldo -= valorSacar;
        }
        else
        {
            Console.WriteLine("Valor a sacar superior ao saldo verifique o saldo para sacar");
        }
    }


}