using System;
using System.IO;

namespace AulaRegistrosArquivos
{
    public struct Cliente
    {
        public string Nome;
        public int Idade;
        public string Email;
    }


    class Progam
    {
         static void Main(string[] args)
         {
            // Declaração e uso básico de registros
            Cliente Cliente1;
            Cliente1.Nome = "João";
            Cliente1.Idade = 30;
            Cliente1.Email = "joao@exmple.com";

            Console.WriteLine("=== Cliente 1 ===");
            Console.WriteLine("Nome: " + Cliente1.Nome);
            Console.WriteLine("Idade: " + Cliente1.Idade);
            Console.WriteLine("Email: " + Cliente1.Email);
            Console.WriteLine();

            // Segunda gravação e exibindo de informações
            Cliente Cliente2;
            Cliente2.Nome = "Maria";
            Cliente2.Idade = 25;
            Cliente2.Email = "maria@exmple.com";

            Console.WriteLine("=== Cliente 1 ===");
            Console.WriteLine("Nome: " + Cliente2.Nome);
            Console.WriteLine("Idade: " + Cliente2.Idade);
            Console.WriteLine("Email: " + Cliente2.Email);
            Console.WriteLine();

            // Organização de dados em tabela (vetor de registros)
            Cliente[] clientes = new Cliente[2];
            clientes[0].Nome = "João";
            clientes[0].Idade = 30;
            clientes[0].Email = "joao@example.com";
            clientes[1].Nome = "Maria";
            clientes[1].Idade = 25;
            clientes[1].Email = "maria@example.com";

            Console.WriteLine("=== Tabela de Clientes ===");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("Idade: " + cliente.Idade);
                Console.WriteLine("Email: " + cliente.Email);
                Console.WriteLine();

                // === Gravação de dados em arquivo ===
                Cliente cliente3;
                cliente3.Nome = "Carlos";
                cliente3.Idade = 40;
                cliente3.Email = "carlos@example.com";

                string caminhoArquivo = "clientes.txt";

                using (StreamWriter sw = new StreamWriter(caminhoArquivo))
                {
                    sw.WriteLine("=== Cliente 3 ===");
                    sw.WriteLine("Nome: " + cliente3.Nome);
                    sw.WriteLine("Idade: " + cliente3.Idade);
                    sw.WriteLine("Email: " + cliente3.Email);
                }

                Console.WriteLine("=== Gravação em Arquivo ===");
                Console.WriteLine($"Informações de {cliente3.Nome} gravadas em '{caminhoArquivo}'.");
                Console.WriteLine();

                //Leitura do arquivo gravado
                Console.WriteLine(" === Conteúdo do Arquivo");
                string conteudo = File.ReadAllText(caminhoArquivo);
                Console.WriteLine(conteudo);

                Console.WriteLine("\n === fim da execução ===");
            }
        }
    }
}