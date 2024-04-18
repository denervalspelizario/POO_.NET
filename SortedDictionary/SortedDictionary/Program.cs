// See https://aka.ms/new-console-template for more information
Console.WriteLine("## SortedDictionary ##");
// criando um SotedDictionary  chave = int  -  value = string 
// ja adicionando os dados na inicialização
var brics = new SortedDictionary<int, string>()
{
    { 20, "Brasil"},  // não precisa adicionar na ordem pois ele faz isso automaticamente
    { 10, "China"},
    { 40, "India"},
    { 30, "URSS"}
};

Console.WriteLine("\n-Incluindo o elemento de chave=70 e valor=Africa do Sul");

// validando se a chave ja existe na lista
if(brics.ContainsKey(70))
{
    Console.WriteLine("Chave já existe");
}
else
{
    brics.Add(70, "Africa do Sul");
}

Console.WriteLine($"\n-Numero de pares de chaves(elementos) no dictionary : {brics.Count}");

// maneiras de acessar elementos pela chave
var valor = brics[20];
Console.WriteLine($"Chave 20 = {brics[20]}");

// alterando um valor
brics[20] = "Argentina";

// removendo um valor
brics.Remove(20);

// verificando se uma chave ou valor existe no dictionary
brics.ContainsKey(10); // true
brics.ContainsValue("China"); // true

Console.ReadKey();