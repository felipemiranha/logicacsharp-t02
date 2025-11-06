using System;
using System.Net.Mail;

int a = 10;
int b = 5;

//operadores relacionais
bool maiorQue = a > b;
bool menorQue = a < b;
bool igual = a == b;
bool diferente = a != b;
bool mairoOuIgual = a >= b;
bool menorOuIgual = a <= b;

//exibindo resultados dos operadore relacionais
Console.WriteLine("\noperadores relacionais:");
Console.WriteLine($"{a} > {b}: {maiorQue} ");
Console.WriteLine($"{a} > {b}: {menorQue}");
Console.WriteLine($"{a} > {b}: {igual} ");
Console.WriteLine($"{a} > {b}: {diferente}");
Console.WriteLine($"{a} > {b}: {mairoOuIgual} ");
Console.WriteLine($"{a} > {b}: {menorOuIgual}");