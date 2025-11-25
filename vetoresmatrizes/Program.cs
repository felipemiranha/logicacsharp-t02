// Declaração de dois vetores
using System.Diagnostics.CodeAnalysis;

int[] numeros = { 7, 2, 3, 34, 5 };// Vetores inteiros
string[] nomes = {"Ana", "João", "Maria","Carlos"}; //Vetor de string

//Exibindo os elementos do vetor de números com lop for
Console.WriteLine("Vetore de números (usando for)");
for  (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

//Exibindo os elementos do vetor de nomes com loop foreach

Console.WriteLine("\nVetor de Nomes com loop foreach:");
foreach (var nome  in nomes)
{
    Console.WriteLine(nome);
}

//Ordenação do vetor de números
Array.Sort(numeros);
Console.WriteLine("\nVetor de Números Ordenados:");
foreach (var n in nomes)
{
    Console.WriteLine(n);
}

int valorProcurado = 5;
int posicaoSequencial = PesquisaSequencial(numeros, valorProcurado);

if (posicaoSequencial != 1)
{
    Console.WriteLine($"\nPesquisa Squencial: valor {valorProcurado}");
}
else
{
    Console.WriteLine($"\nPesquisa Squencial: valor {valorProcurado}");
}

static int PesquisaSequencial(int[] vetor, int valor)
{
    for (int i = 0;i < vetor.Length;i++)
    {
        if (vetor[i] == valor)
            return i; // Retorna o ídice do valor encontrado
    }
    return -1; //retorna -1 se não encontrar
}

// Ordenar antes da pesquisa binária
Array.Sort(numeros);

// Pesquisa binária
int posicaobinaria = Array.BinarySearch(numeros, valorProcurado);
if (posicaobinaria >= 0)
{
    Console.WriteLine($"Pesquisa Binária: Valor {valorProcurado} encontrado na posição {posicaobinaria}");
}
else
{
    Console.WriteLine($"Pesquisa Binária: Valor {valorProcurado} não encontrada");
}

//Declaração e manipulação de uma matriz 3x2
int[,] matriz = new int[3, 2]
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};

Console.WriteLine("\nExibindo a Matriz 3x2:");
for (int i = 0; i <3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

//Manipulação: somando 10 a cada elemento
Console.WriteLine("\nMatriz após adicionar 10 a cada elemente: ");
for(int i = 0;  i < 3; i++)
{
    for (int j = 0;j < 2; j++)
    {
        matriz[i, j] += 10;
        Console.WriteLine(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}