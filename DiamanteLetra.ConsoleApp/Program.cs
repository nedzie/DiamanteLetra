using System;

namespace DiamanteLetra.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alfabeto = 65;
            int alfabetoReverso = 0;
            Console.WriteLine("Digite uma letra: ");
            char letraEscolhida = Convert.ToChar(Console.ReadLine().ToUpper());
            int numeroDaLetra = Convert.ToInt32(letraEscolhida);
            int linhas = (numeroDaLetra - 65); // 2 se for 'C'
            int colunas = (linhas * 2) + 1; // Identifica quantas colunas terá
            int meio = (colunas + 1) / 2; // Identifica o centro
            #region Imprime parte superior
            // Imprime parte superior até > LETRA

            for (int indice = 0; indice <= linhas; indice++) // Desce uma linha
            {
                for (int i = 0; i <= colunas; i++)
                {
                    if (i == (meio) - indice || i == meio + indice)
                    {
                        Console.Write(Convert.ToChar(alfabeto + indice));
                        alfabetoReverso = alfabeto + indice;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            #endregion

            #region Imprime parte inferior
            // Parte inferior
            for (int indice = 1; indice <= linhas; indice++) // Desce uma linha
            {
                for (int i = 0; i <= colunas; i++)
                {
                    if (i == indice+1 || i == ((meio * 2)-1) - indice)
                    {
                        Console.Write(Convert.ToChar(alfabetoReverso - indice));
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            #endregion
        }
    }
}