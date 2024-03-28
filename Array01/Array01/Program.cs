// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ## Array ##");

// declaração do array

int[] numeros; 

// aloquei memoria e declarei os 10 numeros
numeros = new int[10] { 1,2,3,4,5,6,7,8,9,10};


// array de strings , aloquei 3 espaços na memoria e declarei eles
string[] nomes = new string[3] { "Gabi", "Pedro", "Tom"};

// omitindo tamanho
string[] nomes02 = new string[] { "Gabi", "Pedro", "Tom" };

// maneira simplificada
string[] nomes03 = { "Gabi", "Pedro", "Tom" };

// acessando valor de um array
Console.WriteLine(nomes03[0]); // Gabi


// declarando um array

int[] numeros1;

numeros1 = new int[3];

// adicionando valor
numeros1[0] = 1;

Console.WriteLine(numeros1[0]); //1