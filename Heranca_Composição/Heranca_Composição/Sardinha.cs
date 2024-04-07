using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Composição
{
    public class Sardinha : Animal
    {
        // a propriedade é privada e somente leitura para não poder ser alterada após receber a
        // instancia no construtor , esta classe recebe como herança a classe ComportamentoNadar
        private readonly ComportamentoNadar _comportamentoNadar;

        // construtor que recebe como parametro a classe comportamentoNadar
        // como a propriedade ComportamentoNadar esta private precisa deste
        // construtor para poder acessa-lo e vc acessa ele atravez do _comportamentoNadar
        public Sardinha(ComportamentoNadar comportamentoNadar)
        {
            _comportamentoNadar = comportamentoNadar;
        }

        public void Locomocao() // metodo
        {
            Console.WriteLine(nameof(Sardinha)); // nameof é quando quero imprimir o nome da variavel
                                                 // no formato de string 
            _comportamentoNadar.Nadar();         // e também chamo o metodo Nadar()

        }
    }
}
