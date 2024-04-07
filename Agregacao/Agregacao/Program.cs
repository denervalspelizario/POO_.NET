// See https://aka.ms/new-console-template for more information
using Agregacao;

Console.WriteLine("## Agregação ##");

// criando objetos instanciando a classe Professor que tem que receber 2 parametros(Nome e Disciplina)
Professor prof01 = new Professor("Denerval", "Desenvolvimento Back-End");
Professor prof02 = new Professor("Teresa", "Desenvolvimento Front-End");
Professor prof03 = new Professor("Antonia", "Devops");
Professor prof04 = new Professor("Ludmilla", "Análise de dados");


// criando um objeto dep01 instanciado com a classe Departamento que tem que receber 1 parametro(Nome)
Departamento dep01 = new Departamento("Exatas");

dep01.IncluirProfessor(prof01); // adicionando professor ao metodo IncluirProfessor
                                // lembrando que o parametro deste metodo é objeto 
                                // do tipo Professor

dep01.IncluirProfessor(prof04);


dep01.ListaProfessores(); // chamando o metodo ListaProfessores que vai listar os 
                          // os professores listados

// criando um objeto dep01 instanciado com a classe Departamento que tem que receber 1 parametro(Nome)
Departamento dep02 = new Departamento("Humanas");
dep02.IncluirProfessor(prof02);
dep02.IncluirProfessor(prof03);

dep02.ListaProfessores();




Console.ReadKey();
