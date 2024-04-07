using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacao
{
    internal class Professor
    {
        // propriedades
        public string? Nome { get; set; }
        public string? Disciplina { get; set; }
        
        // construtor
        public Professor(string? nome, string? disciplina) 
        {
            Nome= nome;
            Disciplina= disciplina;
        }
    }
}
