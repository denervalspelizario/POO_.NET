using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Composição
{
    public class Homem : Animal
    {
        // a propriedade é privada e somente leitura para não poder ser alterada após receber a
        // instancia no construtor , esta classe recebe como herança a classe ComportamentoAndar
        private readonly ComportamentoAndar _comportamentoAndar;

        // construtor que recebe como parametro a classe comportamentoAndar
        // como a propriedade ComportamentoAndar esta private precisa deste
        // construtor para poder acessa-lo e vc acessa ele atravez do _comportamentoAndar
        public Homem(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao() // metodo
        {
            Console.WriteLine(nameof(Homem)); // nameof é quando quero imprimir o nome da variavel
                                               // no formato de string 
            _comportamentoAndar.Andar(); // e também chamo o metodo Andar()

        }
    }
}
