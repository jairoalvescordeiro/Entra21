using System;

namespace inteiros_reperidos_entra21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba o número de entradas(as
            //entradas devem ser de valores inteiros), mostre se há
            //elementos repetidos e quantas vezes estes se repetem.

            int valor;
            
            Console.WriteLine("Digite um valor:");
            valor = Convert.ToInt32(Console.ReadLine());
            
            int[] entradas = new int[valor];
            int[] copia = new int[valor];
            int[] contaRepetido = new int[valor];
            int[] marcaRepetido = new int[valor];

            for (int i = 0; i < entradas.Length; i++)
            {
                entradas[i] = Convert.ToInt32(Console.ReadLine());
                copia[i] = entradas[i];
            }

            for (int i = 0; i < entradas.Length; i++)
            {
                for (int j = 0; j < entradas.Length; j++)
                {
                    if (i != j)
                    {
                        if (entradas[i] == copia[j] && marcaRepetido[j] == 0)
                        {
                            contaRepetido[i]++;
                            marcaRepetido[i] = 1;
                            marcaRepetido[j] = -1;
                        }
                    }
                }
            }

            for (int i = 0; i < contaRepetido.Length; i++)
            {
                if (contaRepetido[i] > 0 && marcaRepetido[i] > 0)
                {
                    Console.WriteLine($"O elemento {entradas[i]} na posição {i} repete {contaRepetido[i]} vezes.");
                }
            }
        }
    }
}