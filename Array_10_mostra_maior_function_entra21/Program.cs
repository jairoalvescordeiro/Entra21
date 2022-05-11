using System;

namespace Array_10_mostra_maior_function_entra21
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }


    static double calcular();
        

        double[] entradas = new double[10];
        double maior = 0;
          
        for (int i = 0; i<entradas.Length; i++)
        {
        Console.WriteLine("Insira as 10 entradas:");
        entradas[i] = Convert.ToDouble(Console.ReadLine());

        }
        for (int i = 0; i<entradas.Length; i++)
            {
            if (entradas[i] > maior)
            maior = entradas[i];
            }
            
        }
    }
}
