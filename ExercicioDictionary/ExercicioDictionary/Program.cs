// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Exercicio Dictionary");

Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>();

Aluno aluno1 = new Aluno("Maria", 7);
Aluno aluno2 = new Aluno("Eric", 8);
Aluno aluno3 = new Aluno("Ana", 9);
Aluno aluno4 = new Aluno("alex", 6);
Aluno aluno5 = new Aluno("Diná", 5);

alunos.Add(1,aluno1);
alunos.Add(2,aluno2);
alunos.Add(3,aluno3);
alunos.Add(4,aluno4);
alunos.Add(5,aluno5);

foreach (var i in alunos)
{
    Console.WriteLine($"{i.Value.Nome} - {i.Value.Nota}");
}



Console.ReadKey();

public class Aluno
{
    public string? Nome { get; set; }
    public int Nota { get; set; }
    
    
    public Aluno (string nome,int nota)
    {
        Nome = nome;        
        Nota = nota;
    }
}
