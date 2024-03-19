// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Métodos com parametros");

MinhaClasse classePessoal = new MinhaClasse(); // criando um objeto com base na classe MinhaClasse


string dataAtual = DateTime.Now.ToShortDateString(); // pegando a data atual


classePessoal.Saudacao("Denerval", dataAtual);  // passando os parametros para o objeto classePessoal


Console.ReadKey();


public class MinhaClasse  // classe
{
    public void Saudacao(string nome, string data) // método com parametro
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}