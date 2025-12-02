using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        /*
        Exercícios com array e foreach:
 
        1. Faça um programa de listas de peças de carro
        Crie um programa que tenha um array de nomes de 10 peças de carro e imprima
        todos os nomes em uma lista.
        */
        string[] pecasCarro = {
            "Motor", "Caixa de câmbio", "Radiador", "Bateria",
            "Filtro de ar", "Velas de ignição", "Amortecedor",
            "Disco de freio", "Parachoque", "Retrovisor"
        };

        Console.WriteLine("Lista de peças do carro:");
        foreach (string peca in pecasCarro)
        {
            Console.WriteLine("- " + peca);
        }

        Console.WriteLine("\n----------------------\n");

        /*
        2. Faça um programa de desconto
        Crie um programa que tenha um array associativo com dados de um gato que
        chegou no petshop, como chave e seu valor. Utilize o foreach para imprimir os
        nomes dos dados do gato.
        */
        Dictionary<string, string> dadosGato = new Dictionary<string, string>()
        {
            { "Nome", "Mingau" },
            { "Raça", "Persa" },
            { "Idade", "3 anos" },
            { "Peso", "4 kg" },
            { "Cor", "Branco" }
        };

        Console.WriteLine("Dados do gato no petshop:");
        foreach (KeyValuePair<string, string> dado in dadosGato)
        {
            Console.WriteLine($"{dado.Key}: {dado.Value}");
        }

        Console.WriteLine("\n======================\n");

        /*
        Exercícios com Do while:
 
        1. Faça um programa que pergunte se a pessoa quer continuar
        O programa pergunta se o usuário quer continuar digitando.
        Enquanto ele responder “s”, o programa repete.
        */
        string resposta;
        do
        {
            Console.Write("Quer continuar digitando? (s/n): ");
            resposta = Console.ReadLine().ToLower();
        } while (resposta == "s");

        Console.WriteLine("\n----------------------\n");

        /*
        2. Faça um programa de tabuada do 3
        Crie um programa em C# que mostre a tabuada do número 3 de 1 a 10.
        Use a estrutura do...while e declare a variável do contador já na mesma linha em
        que ela é criada.
        O programa deve exibir o resultado da multiplicação a cada repetição.
        */
        int contador = 1;
        Console.WriteLine("Tabuada do 3:");
        do
        {
            Console.WriteLine($"3 x {contador} = {3 * contador}");
            contador++;
        } while (contador <= 10);
    }
}