using System;
using System.IO;
using System.Text;

namespace Atividade17_01
{
    public class Main1
    {
        // Método para exportar dados para CSV
        static void ExportCSV(string[,] dados, string caminho)
        {
            using (StreamWriter sw = new StreamWriter(caminho + ".csv"))
            {
                for (int i = 0; i < dados.GetLength(0); i++)
                {
                    for (int j = 0; j < dados.GetLength(1); j++)
                    {
                        sw.Write(dados[i, j] + ";");
                    }
                    sw.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            string caminho = "dados";

            Console.WriteLine("Digite a quantidade de linhas da matriz:");
            int linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de colunas da matriz:");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            // Preenchendo a matriz
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.WriteLine($"Digite o valor da linha {i} e coluna {j}:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            while (true)
            {
                Console.WriteLine("\nMenu de usuário:");
                Console.WriteLine("1 - Somar todas as linhas da matriz");
                Console.WriteLine("2 - Somar todas as colunas da matriz");
                Console.WriteLine("3 - Transpor a matriz");
                Console.WriteLine("4 - Sair");

                int op = int.Parse(Console.ReadLine());
                int soma = 0;

                // Soma das linhas da matriz
                if (op == 1)
                {
                    string[,] SomaLinha = new string[linhas, 2];
                    Console.WriteLine("Soma das linhas da matriz:");
                    for (int i = 0; i < linhas; i++)
                    {
                        soma = 0;
                        for (int j = 0; j < colunas; j++)
                        {
                            soma += matriz[i, j];
                        }
                        Console.WriteLine($"Linha {i}: {soma}");
                        SomaLinha[i, 0] = $"Linha {i}";
                        SomaLinha[i, 1] = soma.ToString();
                    }
                    ExportCSV(SomaLinha, "soma_linhas");
                    Console.WriteLine("Soma das linhas exportada para soma_linhas.csv");
                }

                // Soma das colunas da matriz
                else if (op == 2)
                {
                    string[,] SomaColuna = new string[colunas, 2];
                    Console.WriteLine("Soma das colunas da matriz:");
                    for (int i = 0; i < colunas; i++)
                    {
                        soma = 0;
                        for (int j = 0; j < linhas; j++)
                        {
                            soma += matriz[j, i];
                        }
                        Console.WriteLine($"Coluna {i}: {soma}");
                        SomaColuna[i, 0] = $"Coluna {i}";
                        SomaColuna[i, 1] = soma.ToString();
                    }
                    ExportCSV(SomaColuna, "soma_colunas");
                    Console.WriteLine("Soma das colunas exportada para soma_colunas.csv");
                }

                // Transpor a matriz
                else if (op == 3)
                {
                    int[,] Transposed = new int[colunas, linhas];
                    for (int i = 0; i < linhas; i++)
                    {
                        for (int j = 0; j < colunas; j++)
                        {
                            Transposed[j, i] = matriz[i, j];
                        }
                    }

                    // Convertendo a matriz transposta para string[,] para exportar
                    string[,] TransposedString = new string[colunas, linhas];
                    for (int i = 0; i < colunas; i++)
                    {
                        for (int j = 0; j < linhas; j++)
                        {
                            TransposedString[i, j] = Transposed[i, j].ToString();
                        }
                    }

                    ExportCSV(TransposedString, "matriz_transposta");
                    Console.WriteLine("Matriz transposta exportada para matriz_transposta.csv");
                }

                // Sair
                else if (op == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
        }
    }
}
