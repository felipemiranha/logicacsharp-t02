//condicional
string nome = "Ana";

if (nome == "Ana")
{
    Console.WriteLine("Olá ana");
}
string texto = "A";
if (string.IsNullOrEmpty(texto));
{
    Console.WriteLine("A string está vazia");
}

// condicional IF/ELSE  
int idade = 16;

if (idade >=18)
{
    Console.WriteLine("Você é maior de idade");
}
else
{
    Console.WriteLine("Você é menor de idade");
}
int numero = 2000;

if (numero % 2 == 0) // o resto da divisão de 7 dividido por 2
{
    Console.WriteLine("é par");
}
else
{
    Console.WriteLine("é ímpar");
}

double nota = 6.5;
if (nota >= 9.0)
{
    Console.WriteLine("Execelente nota! aprovado com distinção");
}
else if (nota >= 7)
{
    Console.WriteLine("Você está aprovado");
}
else if (nota >= 5)
{
    Console.WriteLine("Você está em recupeção");
}
else if (nota >= 3)
{
    Console.WriteLine("Você está com risco de recuperação");
}
else
{
    Console.WriteLine("Você foi reprovado");
}

// Condicional switch
double pontuacao = 8.5;

// Arredondando a nota para o inteiro mais próximo (para baixo)
int faixaNota = (int)Math.Round(pontuacao);

Console.WriteLine(faixaNota);

switch (faixaNota)
{
    case 10:
        Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");
        break;
    case 9:
    case 8:
        Console.WriteLine("Você está aprovado.");
        break;
    case 7:
    case 6:
        Console.WriteLine("Você está em recuperação.");
        break;
    case 5:
    case 4:
    case 3:
        Console.WriteLine("Você está com risco de reprovação.");
        break;
    default:
        Console.WriteLine("Você foi reprovado.");
        break;
}