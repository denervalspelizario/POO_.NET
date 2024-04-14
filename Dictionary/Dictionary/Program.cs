// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Dictionary ##");

// Criando um coleção generica dictionary
// as chaves tipo int e o valores tipo int também
Dictionary<int, int> dic01 = new Dictionary<int, int>();

// uma outra maneira de criar poderia ser assim tanto faz
var dic02 = new Dictionary<int, int>();


// adicionando um valor a coleção dictionary
dic02.Add(2, 100); // a chave valor 2, e o value valor 100
dic02.Add(4, 400);
dic02.Add(3, 300);

// outa forma de criar um dictionary e atribuir valor 
var dic03 = new Dictionary<int, int>()
{
    {1,100},
    {2,200},
    {3,300}
};

// gerando um erro proposital 
try
{
    dic03.Add(3, 300); // estou gerando erro proposital pq ja tem um dado chave 3 valor 300
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);   // exibindo mensagem de erro resumida
    Console.WriteLine(ex.ToString()); // mensagemd e erro detalhada
}


// outra maneira de adicionar  ja tratando possivel erro
// o TryAdd ele tenta adicionar se não conseguir ele retorna um false
var resultado = dic03.TryAdd(3, 333);
Console.WriteLine("\nElemento foi incluido ?" + resultado + "\n");



Console.WriteLine("\n-Incluindo o Elemento com chave 7 e valor 700");

// outra possivel maneira de tentar adicionar o dado ja tatando o erro seria
// usando o metodo ContainsKey qeu verifica se chave esta adicionada na coleção
if (!dic03.ContainsKey(7)) // neste caso não tem essa chave 7
{
    dic03.Add(7, 700); // se nao tiver entao adiciono o dado
}

// agora vou verificar se de fato foi adicionado a chave e o value(7,700) na coleção dic03
Console.WriteLine(dic03[7]);


Console.WriteLine("\n-Usando ContainsValue");

if (dic03.ContainsValue(700)) // se dic03 contem um value de 700
{
    Console.WriteLine("O valor existe no Dicionário");
}


// ALTERANDO VALOR DA CHAVE
Console.WriteLine("\n-Alterando o valor do elemento com chave 7");

if(dic03.ContainsKey(7)) // verificando se dic03 tem  a chave 7
{
    dic03[7] = 7777;   // adicionando uma nova chave(777) no lugar da chave 7
}


Console.WriteLine("Valor alterado do item " + dic03[7]);


// TENTANDO ACESSAR UMA CHAVE INEXISTENTE
try
{
    Console.WriteLine(dic03[5]); // acessando uma chave que não existe
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);   // msg de erro curta
    Console.WriteLine(ex.ToString()); // msg de erro longa
}

// usando o método TryGetValue()
if(dic03.TryGetValue(5, out int valor)) // TryGetValue tenta acessar chave 5 se achar joga no valor
{                                       // senão achar  ele adiciona essa chave                                 

    Console.WriteLine("Valor para a chave = " + valor);
}
else  // não achou a chave 5
{
    Console.WriteLine("Chave não encontrada"); 
}

Console.WriteLine("\n-Percorrendo o dicionario e exibindo os itens (foreach) ");
dic03.Add(6, 666);
dic03.Add(4, 444);

foreach (var item in dic03)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine("\n-Ordenando um Dictionary");

// criando um novo dictionary  porem de modo ordenadoe ja com os dados
// neste caso vem os dados do dic03
var dic03Ordenado = new SortedDictionary<int, int>(dic03);

foreach (var item in dic03Ordenado)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine("\n-Ordenando pelo LINQ");

// criando um novo dictionary com os dados de dic03 mas ordenado usado o metodo OrderBy
// e como parametro a função lambda indicando que quero ordernar por chave(Key)
var dic03OrdenandoLinq = dic03.OrderBy(x => x.Key); 

Console.ReadKey();
