// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Exercicio Interface");


SalvarXml salvarXml = new SalvarXml(); // criando objeto salvarXml com instanciação da classe SalvarXml
salvarXml.Salvar(); // acessando so metodos
salvarXml.Nome();

SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();


// para acessar o emtodo compactar da interface ISalvar
// para instanciar neste caso será primeiro a interface depois a classe
ISalvar salvando = new SalvarJson();

salvando.Compactar(); 


Console.ReadKey();

interface ISalvar // interface salvar
{
    void Salvar(); // metodo abstrato Salvar(será implementado para quem herdar)
    public void Compactar() // metodo não abstrato já implementado
    {
        Console.WriteLine("\nCompactando arquivo...");
    }
}

public abstract class ArquivoBase // classe abstrata(não pode ser instanciada)
{
    public virtual void Nome() // metodo Nome(que vai ser reescrito(virtual))
    {

    }
}

public class SalvarXml : ArquivoBase, ISalvar // recebe a classe base ArquivoBase e a interface ISalvar
{
    public override void Nome()
    {
        Console.WriteLine($"Usuario esta salvando o arquivo xml  ");
    }
    public void Salvar() // como salvar não foi implementada na interface aqui tem que ser
    {
        Console.WriteLine("Salvando XML ..."); 
    }
}
public class SalvarJson : ArquivoBase, ISalvar // recebe a classe base ArquivoBase e a interface ISalvar
{
    public override void Nome()
    {
        Console.WriteLine($"Usuario esta salando o arquivo json  ");
    }
    public void Salvar() // como salvar não foi implementada na interface aqui tem que ser
    {
        Console.WriteLine("Salvando Json ..."); 
    }
}


