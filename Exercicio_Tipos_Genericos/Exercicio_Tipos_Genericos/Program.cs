// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Exercicio Tipos Genericos");

// CRIANDO UMA INSTANCIA DA CLASSEGENERICA
// LEMBRANDO QUE COMO É UMA CLASSE GENERICA TEM QUE INDICAR O TIPO NA HORA DE INSTANCIAR     
ClasseGenerica<int> ObjetoInteiro = new ClasseGenerica<int>();

// ADICIONANDO ELEMENTOS
ObjetoInteiro.Adicionar(10);
ObjetoInteiro.Adicionar(20);
ObjetoInteiro.Adicionar(30);
ObjetoInteiro.Adicionar(40);
ObjetoInteiro.Adicionar(50);


Console.WriteLine("Classe ClasseGenerica<T> de objetos int");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(ObjetoInteiro[i]);
}



Console.ReadKey();

// CRIANDO UMA CLASSE GENÉRICA
public class ClasseGenerica<T>
{
    // CRIANDO UM ARRAY GENERICO  COM LIMITE DE 5 ELEMENTOS
    T[] objeto = new T[5];

    int contador = 0;

    // CRIANDO O METODO QUE VAI ADICIONAR QUALQUER DADO NO ARRAY GENERICO
    // O PARAMETRO DO METODO SERÁ UMA DADO GENERICO(T item)
    public void Adicionar(T item)
    {
        if(contador < 5) // se contador for menor que 5 ou seja ainda ah espaço na array
        {
            objeto[contador] = item; // adiciono o item ao objeto na posição do numero do contador
                                     // que será entre 0 - 4 obrigatoriamente
        }
        contador++;
    }

    // CRIANDO UM INDEXADOR
    // OBS LEMBRANDO QUE O INDEXADOR FAZ COM QUE VC ACESSE QUALQUER DADO NESTE CASO A CLASSE
    // ClasseGenerica COMO SE FOSSE UM ARRAY
    public T this[int index]
    {
        get { return objeto[index]; } // IRÁ RETORNAR O ELEMENTO QUE ESTVER NA POSIÇÃO DO NUMERO DO INDEX
        set { objeto[index] = value; } // IRÁ ATRIBUIR O VALOR NA POSIÇÃO DO NUMERO DO INDEX
    }

}