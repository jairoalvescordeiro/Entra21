using System;

namespace Recebe_string_mostre_intercale_entra21
{
    class Program
    {
        static void Main(string[] args)
        {

            //Faça um programa que receba 10 entradas de textos e
            //mostre todos eles intercalados do caractere “—OU—“.


            string[] lista1 = new string[4];
            

            for (int i = 0; i < lista1.Length; i++)
            {
                Console.WriteLine("Insira itens:");
                lista1[i] = Console.ReadLine();
                     
            }

            for (int i = 0; i < lista1.Length; i++)
            {
                Console.Write(lista1[i] + (" - OU - ") + lista1[i]);
                
            }
        }
    }
}
     
