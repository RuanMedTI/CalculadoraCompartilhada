using System;
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
                MenuOpcoesDeCalculos();

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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nenhuma conta foi feita!");
                        Console.ResetColor();
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

                switch (opcao)
                {
                    case "1":
                        resultado = primeiroNumero + segundoNumero;
                        simboloOperacao = "+";
                        break;

                    case "2":
                        resultado = primeiroNumero - segundoNumero;
                        simboloOperacao = "-";
                        break;
                    case "3":
                        resultado = primeiroNumero * segundoNumero;
                        simboloOperacao = "*";
                        break;
                    case "4":
                        resultado = primeiroNumero / segundoNumero;
                        simboloOperacao = "/";
                        break;

                    default:
                        break;
                }

                string operacaoRealizada =
                    primeiroNumero.ToString() + simboloOperacao +
                    segundoNumero.ToString() + " = " + resultado.ToString();

                operacoesRealizadas[contadorOperacoesRealizadas] = operacaoRealizada;
                contadorOperacoesRealizadas++;

                Console.WriteLine(resultado);

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();
            }
        }

        private static bool EhOpcaoInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3" &&
                                opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s";
        }

        private static void MenuOpcoesDeCalculos()
        {
            Console.WriteLine("      ╔═════════════════╗");
            Console.WriteLine("      ║ Calculadora 1.1 ║");
            Console.WriteLine("╔═════════════════════════════╗");
            Console.WriteLine("║                             ║");
            Console.WriteLine("║           Digite:           ║");
            Console.WriteLine("║                             ║");
            Console.WriteLine("║        1: Somar             ║");
            Console.WriteLine("║        2: Subtrair          ║");
            Console.WriteLine("║        3: Multiplicar       ║");
            Console.WriteLine("║        4: Dividir           ║");
            Console.WriteLine("║                             ║");
            Console.WriteLine("║  5: Historico de Operacoes  ║");
            Console.WriteLine("║                             ║");
            Console.WriteLine("║═════════════════════════════║");
            Console.WriteLine("║        S para sair          ║");
            Console.WriteLine("╚═════════════════════════════╝");
        }
    }
}
