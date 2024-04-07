using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    // classe que herda dados da classe Figura
    public class Triangulo : Figura
    {
        public override void Desenhar() // metodo sobrescrito da classe Figura(override)
        {
            Console.WriteLine("Desenhando um triangulo ...");
            
            base.Desenhar();// estou chamando o metodo Desenhar da classe base(Figura)
        }
    }
}
