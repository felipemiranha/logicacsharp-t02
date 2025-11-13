// Loop for: imprime números de 1 a 10
for (int a = 1; a <= 10; a++)
{
    Console.WriteLine(a);
}
Console.WriteLine("\n");
// Soma dos números de 1 a 100
int soma = 0;
for (int s = 1; s <= 100; s++)
{
    soma += s;
}
Console.WriteLine("A soma dos números de 1 a 100 é: " + soma);
Console.WriteLine("\n");

// Loop while: imprime números de 1 a 5
int contador = 1;
while (contador <= 5)
{
    Console.WriteLine(contador);
    contador++;
}
Console.WriteLine("\n");
// Loop do while: imprime números de 2 a 5
int novocontador = 2;
do
{
    Console.WriteLine (novocontador);
    novocontador++;
} while (novocontador <= 5);

// Exemplo de loop infinito (comentado)
/*
for (;;)
{
    Console.WriteLine("Não para!!!!!");
}

while (true)
{
    Console.WriteLine("Fala mano");
}
*/
Console.WriteLine("\n");
//loop foreach
//uma lista de string
List<string> nomes = new List<string> { "felipe", "miranda", "martins" };
//usando foreach para percorrer a lista
foreach (string nome in nomes) 
{
    Console.WriteLine(nome);
}

// um vetor de números inteiros
int[] numeros = { 1, 2, 3, 4, 5 };

//usando o foreach para percorrer o vetor
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
