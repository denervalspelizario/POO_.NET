using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downcasting_Upcasting
{
    public class Forma
    {
        protected int xpos, ypos; // propriedade

        public Forma() { } // construtor

        public Forma(int x, int y) // construtor que recebe 2 parametros
        {
            xpos = x;
            ypos = y;
        }

        public virtual void Desenhar() // metodo que retorna uma string
        {
            Console.WriteLine($"Desenhar - Forma na posição : ({xpos},{ypos})");
        }
    }
}
