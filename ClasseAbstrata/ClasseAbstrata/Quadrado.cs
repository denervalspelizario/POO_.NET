using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    // classe uadrado que herda tipo Forma
    public class Quadrado : Forma
    {
        // propriedades
        public double Lado { get; set; }

        // metodos la do Forma
        public override void CalcularArea()
        {
            Area = Lado * Lado;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 4 * Lado;
        }
    }
}
