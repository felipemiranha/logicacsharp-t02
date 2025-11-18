/*
 1. Faça um programa para verificação de estoque 
Um sistema de gerenciamento de estoque precisa notificar os funcionários 
quando for hora de reabastecer um produto. 

Escreva um código que verifique a quantidade de um produto em estoque. Se a 
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor, 
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.".  
 */

Console.WriteLine("Exercícios com if, else e elseif:\n");
Console.WriteLine("\nExercício 1\n");
Console.WriteLine("------ verificação de estoque ------\n");
Console.WriteLine("Atualizando o estoque");
Console.Write("Quantos Notebooks temos no estoque?: ");
int Estoque = int.Parse(Console.ReadLine());

if (Estoque < 5)
{
    Console.WriteLine("Alerta: Baixo estoque. Por favor, reabasteça este produto.");
}
else
{
    Console.WriteLine("Estoque suficiente.");
}

/*
 2. Faça um programa de desconto 
Uma loja oferece um desconto para compras acima de um certo valor como parte 
de uma promoção de vendas.

Escreva um código que determine o valor total da 
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um 
desconto de 10% e exiba: "Desconto de 10% aplicado!". Se o valor total for R$ 
200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um 
desconto de 10%.".  
 */

Console.WriteLine("\nExercício 2\n");
Console.Write("Qual foi o valor total da sua compra?: ");
float compra = float.Parse(Console.ReadLine());

if (compra <= 200)
{
    Console.WriteLine($"O valor total da compra ficou por R${compra}, adicione mais itens ao carrinho para ganhar um desconto de 10% ");
}
else
{
    Console.WriteLine($"O valor total da compra ficou por R${compra - (compra * 0.10):F2} com o desconto de 10% aplicado!");
}

/*
 1. Faça um programa que determine o dia da semana 
O programa deve receber um número de 1 a 7, representando um dia da semana, 
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 = 
"Segunda-feira", etc.).
 */


Console.WriteLine("\nExercícios com switch:\n");
Console.WriteLine("\nExercício 1\n");

Console.Write("De 1 a 7, que dia é hoje?: ");
int dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("Hoje é domingo");
        break;
    case 2:
        Console.WriteLine("Hoje é segunda-feira");
        break;
    case 3:
        Console.WriteLine("Hoje é terça-feira");
        break;
    case 4:
        Console.WriteLine("Hoje é quarta-feira");
        break;
    case 5:
        Console.WriteLine("Hoje é quinta-feira");
        break;
    case 6:
        Console.WriteLine("Hoje é sexta-feira");
        break;
    case 7:
        Console.WriteLine("Hoje é sábado");
        break;
    default:
        Console.WriteLine("Você não digitou um número entre 1 a 7");
        break;
}

/*
 2. Faça um programa que calcule o preço final de um produto com base em um 
código de desconto 
O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto 
correspondente ao preço do produto. 
o Código 1: 10% de desconto 
o Código 2: 20% de desconto 
o Código 3: 30% de desconto 
o Se o código for inválido, deve mostrar uma mensagem de erro. 
 */

Console.WriteLine("\nExercício 2\n");
float preco = 500f;
Console.Write($"O preço ficou por R${preco}, digite o código que você recebeu: ");
int codigo = int.Parse(Console.ReadLine());

switch (codigo)
{
    case 1:
        Console.WriteLine($"Você recebeu 10% de desconto e o preço final ficou por {preco - (preco * 0.10)}");
        break;
    case 2:
        Console.WriteLine($"Você recebeu 20% de desconto e o preço final ficou por {preco - (preco * 0.20)}");
        break;
    case 3:
        Console.WriteLine($"Você recebeu 30% de desconto e o preço final ficou por {preco - (preco * 0.30)}");
        break;
    default:
        Console.WriteLine("Você não digitou um código entre 1 a 3");
        break;
}

Console.WriteLine("\nExercícios com for: \n");

/*
 1. Faça um programa de tabuada de multiplicação  
Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de 
repetição for. 

O programa deve exibir, para cada número de 7, a multiplicação desse número 
pelos valores de 1 a 10.
 */

Console.WriteLine("\nExercício 1\n");
Console.WriteLine("------ Tabuada do 7 ------\n");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"7x{i}= {7 * i}");
}

/*
 2. Faça um programa para calcular a média 
Crie um programa que receba 10 números inteiros e calcule a média desses 
números. Utilize o laço for para ler os números e calcular a média. 
 */

Console.WriteLine("\nExercício 2\n");

int soma = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Digite o {i}º número: ");
    int numero = int.Parse(Console.ReadLine());
    soma += numero;
}

float media = soma / 10f;

Console.WriteLine($"\nA média dos números é: {media}");

Console.WriteLine("\nExercícios com while:\n");

/*
 1. Faça um programa contador de visitantes 
Desenvolva um código que simula a entrada X visitantes aleatoriamente no 
museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar" 
cada visitante até que a capacidade máxima seja atingida. A cada visitante 
adicional, exiba o número total de visitantes até o momento.
 */

Console.WriteLine("\nExercício 1\n");

Random rnd = new Random();
int totalVisitantes = 0;

while (totalVisitantes < 50)
{
    int visitantesAgora = rnd.Next(1, 6); // de 1 até 5 visitantes entrando
    totalVisitantes += visitantesAgora;

    Console.WriteLine($"Entraram {visitantesAgora} visitantes. Total: {totalVisitantes}");
}

Console.WriteLine("\nCapacidade máxima atingida. Entrada encerrada.");

/*
 2. Faça um programa de sistema de login
Um sistema de login precisa verificar a autenticidade do usuário, permitindo 
múltiplas tentativas até que as credenciais corretas sejam fornecidas.
Desenvolva um código que simule um sistema de login usando um loop while. O 
usuário tem um máximo de 3 tentativas para inserir a senha correta. Se a senha 
correta ("senha123") for inserida, exiba "Login bem-sucedido!". Se o limite de 
tentativas for atingido, mostre "Conta bloqueada por excesso de tentativas."
 */


Console.WriteLine("\nExercício 2\n");

string senhaCorreta = "senha123";
int tentativas = 0;
int maxTentativas = 3;

while (tentativas < maxTentativas)
{
    Console.Write("Digite sua senha: ");
    string senha = Console.ReadLine();

    if (senha == senhaCorreta)
    {
        Console.WriteLine("Login bem-sucedido!");
        break;
    }
    else
    {
        tentativas++;
        Console.WriteLine($"Senha incorreta. Tentativas restantes: {maxTentativas - tentativas}");
    }

    if (tentativas == maxTentativas)
    {
        Console.WriteLine("Conta bloqueada por excesso de tentativas.");
    }
}