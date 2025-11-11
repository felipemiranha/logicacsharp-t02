/*1. Saudação com Nome
Objetivo: Declarar variáveis, usar concatenação e interpolação.
 
Descrição: Crie um script que declare uma variável para o nome de
uma pessoa e exiba uma saudação personalizada, por exemplo: "Olá,
João! Bem - vindo ao nosso site!".
 
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de
uma string com aspas duplas. */

Console.WriteLine("Exercício 1\n");

string nome = "Felipe";

Console.WriteLine($"Olá, {nome}! Bem - vindo ao nosso site!");
Console.WriteLine("Olá, " + nome + "! Bem - vindo ao nosso site!");

/*2. Conversão de Temperatura (Celsius para Fahrenheit)
Objetivo: Trabalhar com cálculos matemáticos e variáveis.
 
Descrição: Crie um script que converta uma temperatura em Celsius
para Fahrenheit. A fórmula para conversão é:
 
Dica: Declare uma constante para armazenar o valor 9/5 e faça o
cálculo com a variável fornecida.
 */

Console.WriteLine("\nExercício 2\n");

float Celsius = 36.6f;
const float calculo = 9f / 5f;
float Fahrenheit = Celsius * calculo + 32;

Console.WriteLine($"{Celsius}°C convertido em Fahrenheit fica {Fahrenheit}°F");

/*3. Impressão de Dados do Usuário
Objetivo: Concatenar e interpolar dados.
 
Descrição: Crie um script que solicite ao usuário seu nome, idade e
cidade e depois mostre uma mensagem com essas informações.
 
Exemplo: "Meu nome é João, tenho 25 anos e moro em São Paulo".
Dica: Use tanto concatenação quanto interpolação.
  */

Console.WriteLine("\nExercício 3\n");


Console.Write("Digite seu nome: ");
string Nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int Idade = int.Parse(Console.ReadLine());

Console.Write("Digite a cidade em qual você mora: ");
string Cidade = Console.ReadLine();


Console.WriteLine($"\nMeu nome é {Nome}, tenho {Idade} anos e moro em {Cidade}");
Console.WriteLine("Meu nome é " + Nome + ", tenho " + Idade + " anos e moro em " + Cidade);

/*4. Empréstimo Bancário
Objetivo: Cálculos financeiros e declaração de variáveis.
 
Descrição: Crie um script que calcule o valor de uma parcela de um
empréstimo, dado o valor total do empréstimo, a taxa de juros e o
número de parcelas.
 
Exemplo de fórmula:  
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o
número de parcelas.
 */

Console.WriteLine("\nExercício 4\n");

float emprestimo = 1000f;
float taxaDeJuros = 0.5f;
int parcelas = 6;
float resultado = emprestimo * (1 + taxaDeJuros) / parcelas;

Console.WriteLine($"O empréstimo de R${emprestimo} dividido em {parcelas} parcelas, com taxa de juros de {taxaDeJuros * 100}% ao total, resulta em parcelas de R${resultado}.");


/*5. Conversor de Moeda
Objetivo: Trabalhar com variáveis, operadores e arredondamento.
 
Descrição: Crie um script que converta uma quantia em reais para
dólares, com base em uma taxa de câmbio fornecida. Mostre o valor
convertido com 2 casas decimais.
 
Dica: Use round() para arredondar o valor para 2 casas decimais.
 */

Console.WriteLine("\nExercício 5\n");

decimal reais = 1000m;
decimal taxaCambio = 5.33m;
decimal dolares = Math.Round(reais / taxaCambio, 2);

Console.WriteLine($"No dia 09/11, R${reais} em dolares é US${dolares}");

/*6 . Calculadora de Desconto
Objetivo: Cálculos matemáticos e uso de variáveis.
 
Descrição: Crie um script que calcule o valor do desconto de um
produto, dado o preço original e a porcentagem de desconto. Exemplo
de fórmula:  
 
Dica: Use variáveis para armazenar o preço e a porcentagem do
desconto e calcule o valor final.
 */

Console.WriteLine("\nExercício 6\n");

float preco = 1000f;
float desconto = 0.9f;
float valorFinal = preco - (preco * desconto);

Console.WriteLine($"a mochila de R${preco} está com deconto de {desconto * 100}% e está ficando por R${valorFinal}");
