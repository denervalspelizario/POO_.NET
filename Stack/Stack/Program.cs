// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Stack  ##");

// criando uma coleçãod e numeros tipo stack
// Observação esse tipo de lista nao suporta que vc ja adicione quando cria
// primeiro você cria depois voce adiciona os dados com o Push
Stack<int> numerosStack = new Stack<int>();

// Adicionando Dados
numerosStack.Push(0);


// Adicionando um array de inteiros em uma lista tipo stack
int[] array1 = new int[5] { 1,2,3,4,5};

Stack<int> pilha1 = new Stack<int>(array1);   


// criando uma lista stack inicialmente com  3 itens
var impares = new Stack<int>(3);


impares.Push(5);
impares.Push(7);
impares.Push(8);

ExibirDados(impares);

// quantidade de elementos
Console.WriteLine(impares.Count());

// Obtendo ultimo item da lista - 8
Console.WriteLine("\n" + impares.Peek());

// Removendo ultimo item da lista - 8
Console.WriteLine("\n" + impares.Pop());


ExibirDados(impares); // exibindo lista com ultimo item removido - 8


Console.ReadKey();

// Método Estatico que receb um tipo de lista generica(neste caso será sempre Stack)
static void ExibirDados<T>(IEnumerable<T> dadosLista)
{
    Console.WriteLine();
    foreach (var dadoLista in dadosLista)
    {
        Console.WriteLine(dadoLista);
    }
}