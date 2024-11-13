
﻿using System;

namespace GnomeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 34, 2, 10, -9, 7, 5, 12, 45, 3 };

            Console.WriteLine("Array antes da ordenação:");
            PrintArray(array);

            // Aplicar o Gnome Sort no array
            GnomeSort(array);

            Console.WriteLine("\nArray após a ordenação:");
            PrintArray(array);
        }

        /* Algoritmo Gnome Sort */
        static void GnomeSort(int[] array)
        {
            int i = 1; // Começa do segundo elemento
            while (i < array.Length)
            {
                // Se o elemento atual é maior ou igual ao anterior, move para o próximo
                if (i == 0 || array[i] >= array[i - 1])
                {
                    i++; // Avança para o próximo
                }
                else
                {
                    // Caso contrário, troca os dois elementos
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    i--; // Volta um índice para verificar novamente
                }
            }
        }

        /* Função para imprimir o array */
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
