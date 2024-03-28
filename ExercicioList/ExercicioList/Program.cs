// See https://aka.ms/new-console-template for more information
using ExercicioList;

Console.WriteLine("## Exercicio List ##");

// criando uma list chamada alunos recebendo os dados de Método GetAlunos
// la da classe Fonte de dados 
List<Aluno> alunos = FonteDeDados.GetAlunos();

ExibirAlunos(alunos);

//criando um objeto bia E mario usando a base da classe Aluno
Aluno bia = new Aluno() { Nome="Bia", Nota=7.75};
Aluno mario = new Aluno() {Nome="Mario", Nota=8.95};

// adicionando na list alunos bia e mario no final da list
alunos.Add(bia);
alunos.Add(mario);

ExibirAlunos(alunos); // imprimindo depois da adição

// encontrando "Amanda na list e removendo ela"

var encontrandoAluno = alunos.Find(n => n.Nome.Equals("Amanda"));// lembrando que o Find só aceita
                                                                 // de parametro predicado neste
                                                                 // caso uma espressão lambda

// depois de achar o aluno "Amanda" removendo ele
alunos.Remove(encontrandoAluno);

ExibirAlunos(alunos);

// ordenando a list de alunos
// usando o método orderby pegando e ordenando todos os Nome atravez de uma expressão lambda
// e através doToList() estou regerando a lista
// ou seja o listaOrdenada está recebendo uma lista nova e ordenada pelo nome
var listaOrdenada = alunos.OrderBy(n =>  n.Nome).ToList();

ExibirAlunos(listaOrdenada);

// exibindo uma lista de alunos com nota superior a 8

var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8);
Console.WriteLine($"\nAlunos com nota maior que 8\n");

foreach (var aluno in alunosNotaOito)
{
    Console.WriteLine($"{aluno.Nome} {aluno.Nota} ");
}

Console.ReadKey();

// MÉTODO ESTATICO QUE EXIBE OS DADOS E COMO PARAMETRO RECEBE UM LIST
// DO TIPO DA CLASSE ALUNO OU SEJA QUE TENHA NOME E NOTA
// ELE FOI USADO PQ SERÁ USADO MAIS DE UMA VEZ ENTAO ESSE CODIGO VIROU UM METODO 
// PARA FACILITAR USO , PARA CRIAR SÓ PRECISA SELECIONAR O CODIGO >
// CLICAR NA CHAVINHA DO LADO ESQUERDO AO LADO DOS NUMEROS DAS LINHAS >
// E CLICAR EM EXTRACT LOCAL FUNCTION E CRIAR O MÉTODO ADICIONANDO NOME
// NESTE CASO FOI EXIBIR ALUNOS
static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de alunos\n");
    Console.WriteLine("\nNome\tNota");

    var somaNotas = 0.0;


    // vou imprimir todos os alunos na tela e adicionando vou pegar a soma de todas as notas
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
        somaNotas += aluno.Nota;
    }

    // fazendo a media das notas
    var mediaNotas = somaNotas / alunos.Count;

    Console.WriteLine($"\nMédia das notas : {mediaNotas}");
    Console.WriteLine($"Total de alunos : {alunos.Count()}");
}