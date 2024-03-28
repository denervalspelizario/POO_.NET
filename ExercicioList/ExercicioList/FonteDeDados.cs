using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioList
{
    public class FonteDeDados // classe 
    {
        // método estatico GetAlunos do tipo List
        // que usa a base da classe Aluno(que tem nome e nota )
        public static List<Aluno> GetAlunos() 
        {
            // criando a list de alunos usando como tipo a classe Aluno
            List<Aluno> alunos = new()
            {
                new Aluno() { Nome= "Maria", Nota = 8.75 },
                new Aluno() { Nome= "Manoel", Nota = 6.95 },
                new Aluno() { Nome= "Amanda", Nota = 7.25 },
                new Aluno() { Nome= "Carlos", Nota = 6.55 },
                new Aluno() { Nome= "Jaime", Nota = 8.50 },
                new Aluno() { Nome= "Debora", Nota = 5.95 },
                new Aluno() { Nome= "Alicia", Nota = 9.25 },
                new Aluno() { Nome= "Sandra", Nota = 5.55 },
                new Aluno() { Nome= "Marta", Nota = 7.85 },
                new Aluno() { Nome= "Sueli", Nota = 9.15 },
            };

            return alunos; // retornando alunos
        
        }

    }
}
