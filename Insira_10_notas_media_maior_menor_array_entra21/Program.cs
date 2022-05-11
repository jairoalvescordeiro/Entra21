using System;

namespace Insira_10_notas_media_maior_menor_array_entra21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que receba as notas de 10 alunos e
            //mostre a média das notas, a maior e a menor.

            double[] nota = new double[10];
            double maior = 0, menor = 10, soma = 0;
                
                for (int i = 0; i < nota.Length; i++)
                {
                    Console.WriteLine("Insira as notas:");
                    nota[i] = Convert.ToDouble(Console.ReadLine());

                }
                for (int i = 0; i <nota.Length; i++)
                {
                    if (nota[i] > maior)
                        maior = nota[i];
                    
                    if (nota[i] < menor)
                        menor = nota[i];
                    
                    soma = soma + nota[i];
                }
                Console.WriteLine("A maior nota é:" + maior);
                Console.WriteLine("A menor nota é:" + menor);
                Console.WriteLine("A media é:" + soma / 10);
        }
    }
}
