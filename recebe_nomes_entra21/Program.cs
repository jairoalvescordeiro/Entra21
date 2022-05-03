using System;

namespace Recebe_nomes_entra21
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[10];
            
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Insira um nome");
                nomes[i] = Console.ReadLine();
            }
            for (int i = 0; i < nomes.Length; i++)
            {
               Console.WriteLine(nomes[i]);
            }
          }

    }
}
//Escreva um programa que receba dez nomes de pessoas 
//e apresente-os na tela;
