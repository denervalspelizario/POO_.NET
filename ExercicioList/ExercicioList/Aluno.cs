using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioList
{
    // classe Aluno que tem 2 atributos publicos Nome e Nota
    // essa classe será a base de estrutura de cada aluno 
    public class Aluno
    {
        public string Nome { get; set; } = string.Empty;
        public double Nota { get; set; }
    }
}
