// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Array Multidimensional ##");

// criando um array bidimensional lembrando que o , indica isso
int[,] a;

// alocando espaço na memoria 
a = new int[2, 2];

// inicializando o array bidimensional adcionando valores
a[0, 0] = 0;
a[0, 1] = 1;
a[1, 0] = 2;
a[1, 1] = 3;

Console.WriteLine("\nArray A \n");

Console.WriteLine(a[0,0]); // 0

Console.WriteLine(a[0,1]); // 1

Console.WriteLine(a[1,0]); // 2

Console.WriteLine(a[1,1]); // 3

Console.WriteLine("\nArray B \n");



int[,] b = new int[2, 2] { {20,30 },{40,50} };

Console.WriteLine(b[0, 0]); // 20

Console.WriteLine(b[0, 1]); // 30

Console.WriteLine(b[1, 0]); // 40

Console.WriteLine(b[1, 1]); // 50

Console.ReadKey();
