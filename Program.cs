using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv09programadeestacionamento
{
    class Program
    {
        static List<string> estacionamento = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de gerenciamento de estacionamento!");

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Estacionar");
                Console.WriteLine("2. Retirar veículo");
                Console.WriteLine("3. Listar veículos");

                int opcao;
                opcao = Int32.Parse(Console.ReadLine());
                if (opcao == 1 || opcao == 2 || opcao == 3)
                {
                    switch (opcao)
                    {
                        case 1:
                            EstacionarVeiculo();
                            break;
                        case 2:
                            RetirarVeiculo();
                            break;
                        case 3:
                            ListarVeiculos();
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                }
            }
        }

        static void EstacionarVeiculo()
        {
            Console.WriteLine("\nEstacionar veículo");
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine().ToUpper();

            if (placa.Length == 6)
            {
                if (!estacionamento.Contains(placa))
                {
                    estacionamento.Add(placa);
                    Console.WriteLine("Veículo estacionado com sucesso.");
                }
                else
                {
                    Console.WriteLine("A placa informada já está estacionada.");
                }
            }
            else
            {
                Console.WriteLine("A placa informada não possui o número correto de caracteres (6).");
            }
        }

        static void RetirarVeiculo()
        {
            Console.WriteLine("\nRetirar veículo");
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine().ToUpper();

            if (estacionamento.Contains(placa))
            {
                estacionamento.Remove(placa);
                Console.WriteLine("Veículo retirado com sucesso.");
            }
            else
            {
                Console.WriteLine("A placa informada não corresponde a nenhum veículo estacionado.");
            }
        }

        static void ListarVeiculos()
        {
            Console.WriteLine("\nVeículos estacionados:");

            if (estacionamento.Count == 0)
            {
                Console.WriteLine("[ ____ ]");
            }
            else
            {
                foreach (string placa in estacionamento)
                {
                    Console.WriteLine($"[ {placa} ]");
                }
            }
        }
    }
}
