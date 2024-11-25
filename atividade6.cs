using System;

namespace Atividade6
{
    internal class Program
    {
        static void Main()
        {
            while (true) // Permite repetir até o usuário inserir uma opção válida ou sair
            {
                // Exibe o menu de bebidas
                Console.WriteLine("\nEscolha uma bebida pelo número:");
                Console.WriteLine("1 - Café");
                Console.WriteLine("2 - Chá");
                Console.WriteLine("3 - Suco");
                Console.WriteLine("4 - Refrigerante");
                Console.WriteLine("5 - Sair");

                // Lê a escolha do usuário
                Console.Write("Digite sua escolha: ");
                if (!int.TryParse(Console.ReadLine(), out int escolha))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número entre 1 e 5.");
                    continue;
                }

                // Exibe a bebida escolhida
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Você escolheu: Café.");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu: Chá.");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu: Suco.");
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu: Refrigerante.");
                        break;
                    case 5:
                        Console.WriteLine("Saindo... Obrigado por usar o programa!");
                        return; // Encerra o programa
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 5.");
                        break;
                }
            }
        }
    }
}

