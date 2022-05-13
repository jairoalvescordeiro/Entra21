using System;

namespace Funcao_Vetor_mostra_maior_entra21
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] entradas = new double[10];
            
            for (int i = 0; i < entradas.Length; i++)
            {
                Console.WriteLine("Insira as entradas:");
                entradas[i] = Convert.ToDouble(Console.ReadLine());

            }

        MostrarMaior(entradas);
 
        }

        static void MostrarMaior(double[] mostra)
        {
            double maior = 0;

            for (int i = 0; i < mostra.Length; i++)
            {
                if (mostra[i] > maior)
                    maior = mostra[i];
            }
            Console.WriteLine("A maior entrada é:" + maior);
        }
    }
}
