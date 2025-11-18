// Declaração de dois vetores
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