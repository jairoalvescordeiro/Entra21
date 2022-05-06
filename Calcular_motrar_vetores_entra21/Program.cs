using System;

namespace Calcular_mostra_vetores_entra21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba 5 valores em dois vetores e
            //mostre o produto entre cada célula de cada vetor(multiplique
            //a célula um do vetor “A” pela célula um do vetor “B” e assim
            //armazene o resultado em um terceiro vetor e mostre os resultados deste.


            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Informe números:");
                vetor1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Informe cinco números:");
                vetor2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Resultado A: " + vetor1[i]);
                Console.WriteLine();//pula linha
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Resultado B: " + vetor2[i]);
                Console.WriteLine(); //pula linha
            }

            for (int i = 0; i < vetor3.Length; i++)
            {
                vetor3[i] = vetor1[i] * vetor2[i];
            }
            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.WriteLine("Multiplicação entre A e B é: " + vetor3[i]);
                Console.WriteLine();
            }
                

        }
    }
}
