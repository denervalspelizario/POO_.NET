using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    // criando uma classe abstrata que serve apenas como classe base não pode ser instanciada 
    public abstract class Forma
    {
        // criando as propriedades
        public string? Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        // métodos abstratos neste caso eles não tem implementação
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        // metodo comum
        public string Descricao()
        {
            return "Sou a classe abstrata Forma";
        }
    }
}
