using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    // classe que herda dados da classe Figura
    public class Circulo : Figura
    {
        public override void Desenhar() // metodo sobrescrito da classe Figura(override)
        {
            Console.WriteLine("Desenhando um circulo ...");
        }
    }
}
