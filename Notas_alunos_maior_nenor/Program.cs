using System;

namespace Notas_alunos_maior_nenor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Faça um programa que receba as notas de 10 alunos e
            //mostre a média das notas, a maior e a menor.

            double[] nota = new double[3];
            double maior = 0;
            double menor = 10;
            double soma = 0;
            double contador = 0;
                        
            for (int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine("Insira as notas:");
                nota[i] = Convert.ToDouble(Console.ReadLine());

            }
            for (int i = 0; i < nota.Length; i++)
            {
                if (nota[i] > maior)
                    maior = nota[i];
                    Console.WriteLine("A maior nota é:" + maior);
                if (nota[i] < menor)
                    menor = nota[i];
                    Console.WriteLine("A menor nota é:" + menor);
            }
            
            contador = contador + 1;
            soma = nota + soma;
                Console.WriteLine("A media é:" + soma / contador);

            }
        }
}
