// See https://aka.ms/new-console-template for more information
using Heranca_Composição;

Console.WriteLine("## Herança e Composição ##");

// criando objeto recebendo de herança a classe ComportamentoAndar
ComportamentoAndar andar = new ComportamentoAndar();

ComportamentoNadar nadar = new ComportamentoNadar();

// criando um objeto homem que recebe de herança a classe Homem
// esta classe Homem como formatado pelo construtor dele precisa
// receber como parametro uma classe do tipo ComportamentoAndar(olhar o contrutor)
// por isso antes de criar o objeto homem precisa criar o objeto andar pq esse andar
// que vai preencher o parametro da Classe Homem que é feito de maneira obrigatoria
// ou seja toda vez que for criar um objeto que instancia Homem precisa de um objeto instanciado
// por ComportamentoAndar
var homem = new Homem(andar);
homem.Locomocao(); // chamando o metodo Locomocao();


var macaco = new Macaco(andar); // aqui é a mesma ideia que homem
macaco.Locomocao();

var sardinha = new Sardinha(nadar); // aqui é  mesma ideia que homem
sardinha.Locomocao();



Console.ReadKey();
