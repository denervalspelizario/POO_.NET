using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacao
{
    internal class Departamento
    {
        public string? Nome { get; set; }

        // Inicialize a lista de professores no construtor
        private List<Professor> professores { get; set; } = new List<Professor>();

        public Departamento(string? nome)
        {
            Nome = nome;
        }

        public void IncluirProfessor(Professor professor)
        {
            professores.Add(professor); // Agora a lista de professores está inicializada e
                                        // pronta para ser usada.
        }

        public void ListaProfessores()
        {
            Console.WriteLine($"\nDepartamento de : {Nome}\n");

            foreach (var prof in professores)
            {
                Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
            }
        }
    }

}
