using System;

namespace Burbuja
{
    class Program
    {
        static int[] numeros = new int[]{12, 21, 201, 3, 23, 33, 48};
        static void Main(string[] args)
        {
            System.Console.WriteLine("Antes:");
            Imprimir(numeros);
            BubbleSort(numeros);
            System.Console.WriteLine("Después:");
            Imprimir(numeros);
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Cambiar(arr, j, j + 1);
                    }
                }

            }
        }
        static void Cambiar(int[] arr, int i, int j)
        {
            int copia = arr[i];

            arr[i] = arr[j];

            arr[j] = copia;
        }

        static void Imprimir(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i] + ", "); 
            }
            System.Console.WriteLine();
        }
    }
}
