
//  Author: PHNO - Tecnólogo | Pós-Graduado em Energia Solar Fotovoltaica
//  Data Release: 08/12/2024
//  Versão Código: 0.0.0.4v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algoritmo: Dimensionamento e Calculo para Sistema Fotovoltaico na area de Energia Solar Fotovoltaica, 
// desenvolvido para estudantes e profissionais de engenharia eletrica e areas correlatas, como energias renovaveis.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Algoritmo_Dimensionamento_e_Calculo_para_Sistema_Fotovoltaico
    {
        class Program
        { // classe

            public static void Main(string[] args)
            {

                while (true)
                {
                    // class, method, string
                    Console.WriteLine("\n");
                    Console.WriteLine(" Dimensionamento e Calculo para Sistema Fotovoltaico ");
                    Console.WriteLine("");
                    Console.WriteLine("\n\t Menu \n");
                    Console.WriteLine("");
                    Console.WriteLine("1. Converter - volts [CA] em watts [CC]");
                    Console.WriteLine("2. Converter - watts [CC] em volts [CA]");
                    Console.WriteLine("3. Calcular a Potencia dos Modulos");
                    Console.WriteLine("4. Calcular Geração Semanal de Energia Solar");
                    Console.WriteLine("5. Calcular Geração Mensal de Energia Solar");
                    Console.WriteLine("6. Calcular Geração Anual de Energia Solar");
                    Console.WriteLine("7. Calcular e Dimensionar a Quantidade de Modulos");
                    Console.WriteLine("");
                    Console.WriteLine("[8] Info");
                    Console.WriteLine("[9] Sobre");
                    Console.WriteLine("\n10. Sair");

                    Console.WriteLine("\nDigite sua escolha: "); // choice

                try
                    {
                        int choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");

                        switch (choice)
                        {
                            case 1:
                                double v2 = 10;
                                Console.WriteLine("Digite quantos volts quer converter em watts: ");
                                double v1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                double resultado = (v1 * v2);
                                Console.WriteLine();
                                Console.WriteLine("Os " + (v1) + " volts inseridos equivalem a " + (resultado) + " watts.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 2:
                                double v4 = 10;
                                Console.WriteLine("Digite quantos watts quer converter em volts: ");
                                double v3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                double resultado2 = (v3 / v4);
                                Console.WriteLine();
                                Console.WriteLine("Os " + (v3) + " watts inseridos equivalem a " + (resultado2) + " volts.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 3:
                                Console.WriteLine("Digite a potencia nominal do modulo em watts: ");
                                int v5 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite a quantidade de modulos: ");
                                int v6 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                int resultado3 = (v5 * v6);
                                Console.WriteLine();
                                Console.WriteLine("A potencia dos modulos sera de " + (resultado3) + " watts.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 4:
                                float v11 = 1000;
                                Console.WriteLine("Digite a potencia dos modulos em watts: ");
                                float v7 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite a quantidade de horas por dia: ");
                                float v8 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Digite a quantidade de dias por semana: ");
                                float v9 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                float v10 = (v7 * v8 * v9);
                                float resultado4 = (v10 / v11);
                                Console.WriteLine("o resultado sera " + (resultado4) + " kwh/semana geracao [leste/oeste]");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 5:
                                float v16 = 1000;
                                Console.WriteLine("Digite a potencia dos modulos em watts: ");
                                float v12 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite a quantidade de horas por dia: ");
                                float v13 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Digite a quantidade de dias por mes: ");
                                float v14 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                float v15 = (v12 * v13 * v14);
                                float resultado5 = (v15 / v16);
                                Console.WriteLine("o resultado sera " + (resultado5) + " kwh/mes geracao [leste/oeste]");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 6:
                                float v21 = 1000;
                                Console.WriteLine("Digite a potencia dos modulos em watts: ");
                                float v17 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite a quantidade de horas por dia: ");
                                float v18 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Digite a quantidade de dias por ano: ");
                                float v19 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                float v20 = (v17 * v18 * v19);
                                float resultado6 = (v20 / v21);
                                Console.WriteLine("o resultado sera " + (resultado6) + " kwh/ano geracao [leste/oeste]");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 7:                          
                                Console.WriteLine("Digite a Potencia calculada do sistema (Pfv) em watts: ");
                                float v22 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite a Potencia nominal do modulo em watts: ");
                                float v23 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                // float resultado7 = (v22 / v23);
                                int resultado7 = Convert.ToInt32(v22 / v23); // converter para int para resposta aproximada, motivo imprimindo disma periodica
                                Console.WriteLine("A quantidade maxima de modulos para este dimensionamento eh de " + (resultado7) + " placas fotovoltaicas.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;                    
                            case 8:
                                Clear();
                                Console.WriteLine();
                                Console.WriteLine("Info");
                                Console.WriteLine();
                                Console.WriteLine("Para converter volts em watts multiplicamos os volts por 10.");
                                Console.WriteLine("Para converter watts em volts dividimos os watts por 10.");
                                Console.WriteLine("Para calcular a potencia dos modulos fazemos a multiplicacao da potencia nominal do modulo vezes a quantidade de modulos.");
                                Console.WriteLine("Para calcular a geração semanal utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por semana). ");
                                Console.WriteLine("e o resultado sera em watts-hora e entao para obte-lo em kwh dividiremos por 1000 para converter para kwh, conforme calculado na opcao 4 neste algoritmo.");
                                Console.WriteLine("Para calcular a geração mensal utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por mes). ");
                                Console.WriteLine("e o resultado sera em watts-hora e entao para obte-lo em kwh dividiremos por 1000 para converter para kwh, conforme calculado na opcao 5 neste algoritmo.");
                                Console.WriteLine("Para calcular a geração anual utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por ano). ");
                                Console.WriteLine("e o resultado sera em watts-hora e entao para obte-lo em kwh dividiremos por 1000 para converter para kwh, conforme calculado na opcao 6 neste algoritmo.");
                                Console.WriteLine("Para calcular e dimensionar a quantidade de modulos que compoe um painel solar utilizamos o seguinte calculo: ");
                                Console.WriteLine("Potencia calculada do sistema (Pfv) em watts dividido pela Potencia nominal do modulo em watts = a Quantidade de Modulos.");
                                Console.WriteLine("Para converter 1kwh para 1wh basta fazer o calculo ex: 73kwh para wh sera 73000 wh.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 9:
                                Clear();
                                Console.WriteLine();
                                Console.WriteLine("Algoritmo: Dimensionamento e Calculo para Sistema Fotovoltaico");
                                Console.WriteLine();
                                Console.WriteLine("Author: PHNO");
                                Console.WriteLine("Data Release: 08/12/2024");
                                Console.WriteLine("Versao Codigo: 0.0.0.4v");
                                Console.WriteLine("Replit: @PHNO, @PHREPLIT");
                                Console.WriteLine("E-mail: phreplit@gmail.com");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 10:
                                Exit();
                                break;
                            default:
                                Console.WriteLine("Opcao Incorreta! ");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro, falha no sistema.");
                        Console.WriteLine();
                        Console.WriteLine("Teclar enter para retornar ao menu...");
                        Console.ReadKey();
                        Clear();
                    }
                }
            }
            public static void Exit()
            { // exit method
                Console.WriteLine();
                Console.WriteLine(" Algoritmo Finalizado! ");
                System.Environment.Exit(-1);
                return;
            }
            public static void Clear()
            { // method 
                Console.Clear();
                return;
            }
        }
    }
