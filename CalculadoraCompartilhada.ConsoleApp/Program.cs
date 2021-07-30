﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompartilhada.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] operacoesRealizadas = new string[100];
            string opcao = "";
            int contadorOperacoesRealizadas = 0;

            while (true)
            {
                MenuInicialCalculadora();

                opcao = Console.ReadLine();

                if (EhOpcaoInvalida(opcao))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Opcao Invalida! Tente novamente.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (opcao == "5")
                {
                    Console.WriteLine();

                    if (contadorOperacoesRealizadas == 0)
                    {
                        Console.WriteLine("Nenhuma conta foi feita!");
                    }
                    else
                    {

                        for (int i = 0; i < operacoesRealizadas.Length; i++)
                        {
                            if (operacoesRealizadas[i] != null)
                                Console.WriteLine(operacoesRealizadas[i]);
                        }
                    }

                    Console.ReadLine();

                    Console.Clear();
                    continue;
                }

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                double primeiroNumero, segundoNumero;

                Console.Write("Digite o primeiro número: ");
                primeiroNumero = Convert.ToDouble(Console.ReadLine());



                do
                {
                    Console.Write("Digite o segundo número: ");
                    segundoNumero = Convert.ToDouble(Console.ReadLine());


                    if (opcao == "4" && segundoNumero == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Numero errado! Tente outro");
                        Console.ResetColor();
                        Console.ReadLine();
                    }

                } while (segundoNumero == 0);

                double resultado = 0;

                string simboloOperacao = "";
            }
        }

        private static bool EhOpcaoInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3" &&
                                opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s";
        }

        private static void MenuInicialCalculadora()
        {
            Console.WriteLine("Calculadora 1.1");

            Console.WriteLine("Digite 1 para somar");

            Console.WriteLine("Digite 2 para subtrair");

            Console.WriteLine("Digite 3 para multiplicar");

            Console.WriteLine("Digite 4 para dividir");

            Console.WriteLine("Digite 5 para apresentar as operacoes");

            Console.WriteLine("Digite S para sair");
        }
    }
}
