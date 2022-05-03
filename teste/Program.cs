using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float[] numeros = new float[10];
            float menor = 0, maior = 0;

            Console.WriteLine("Informe 10 números inteiros:");
            numeros[i] = Convert.ToSingle(Console.ReadLine());
            for (int i = 0; i < numeros; i++)
            {

                Console.WriteLine((i + 1) + "º número:");
                numeros[i] = Convert.ToSingle(Console.ReadLine());

                if (i == 0)
                {
                    menor = numeros[0];
                    maior = numeros[0];
                }

                if (numeros[i] < menor)
                {

                    menor = numeros[i];
                    
                }
                else if (numeros[i] > maior)
                {
                    maior = numeros[i];

                }

            }

            Console.WriteLine("O menor número é:" + menor);
            Console.WriteLine("O maior número é:" + maior);

            Console.Read();
        }
    }
}
