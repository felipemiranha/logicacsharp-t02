using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        //adicionando elementos

        nomes.Add("Ana");
        nomes.Add("Bruno");
        nomes.Add("Carlos");

        Console.WriteLine(nomes[0]); //Ana
        Console.WriteLine(nomes[1]); //Bruno
        Console.WriteLine(nomes[2]); //Carlos
        
        Console.WriteLine("Lista após adiconar elementeos");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        //Adiciona novo nome
        nomes.Add("Daniel");
        Console.WriteLine("\nLista após adicionar'Daniel':");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        nomes.Remove("Bruno");

        Console.WriteLine("\nLista após remover 'Bruno':");
        foreach(string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        nomes.RemoveAt(0); //remove o primeiro (Ana)

        Console.WriteLine("\nLista após remover 'ana':");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        //Limapando toda a lista
        nomes.Clear();

        Console.WriteLine("\nLista após Clear ():");
        Console.WriteLine("Quantidade de elementos: " + nomes.Count);
    }

}