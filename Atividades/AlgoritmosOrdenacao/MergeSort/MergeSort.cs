using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSort
    {
        // Método para realizar a divisão do array
        public static T[] Sort<T>(T[] array) where T : IComparable
        {
            if (array.Length <= 1) // Se o tamanho do array for menor ou igual a 1, não há mais o que dividir
                return array;
            
            int mid = array.Length / 2; // Encontra o ponto central do array
            
            // Criando as duas subarrays
            T[] left = new T[mid]; // Uma recebe o lado esquerdo
            T[] right = new T[array.Length - mid]; // E a outra o lado direito

            // Copiando os elementos para as arrays desejadas
            for (int i = 0; i < mid; i++) {
                left[i] = array[i]; // Copia os primeiros 'mid' elementos para o left
            }

            // Copiando os elementos para o subarray right
            for (int i = mid; i < array.Length; i++) {
                right[i - mid] = array[i]; // Copia o restante dos elementos para o right
            }

            // Ordenando os subarrays e mesclando
            left = Sort(left);
            right = Sort(right);

            return Merge(left, right); // Mescla os dois arrays ordenados
        }

        // Método para mesclar os arrays
        public static T[] Merge<T>(T[] left, T[] right) where T : IComparable
        {
            T[] result = new T[left.Length + right.Length]; // Array que armazenará o resultado final
            int i = 0, j = 0, k = 0; // i percorre o left, j percorre o right, e k percorre result

            // Mesclando os arrays
            while (i < left.Length && j < right.Length) {
                if (left[i].CompareTo(right[j]) <= 0) // Se left[i] for menor ou igual a right[j]
                    result[k++] = left[i++]; // Copia o left[i] para o result
                else
                    result[k++] = right[j++]; // Caso contrário, copia o right[j] para o result
            }

            // Se restarem elementos no array left, copia-os
            while (i < left.Length)
                result[k++] = left[i++];

            // Se restarem elementos no array right, copia-os
            while (j < right.Length)
                result[k++] = right[j++];

            return result;
        }

        // Método para imprimir o array
        public static void Print<T>(T[] array) 
        {
            Console.Write('[');
            foreach (T i in array) {
                Console.Write($"{i} ");
            }
            Console.Write(']');
        }
    }
}