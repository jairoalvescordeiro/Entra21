using System;

namespace recebe_nomes_entra21
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
            //for (int i = 0; i < nomes.Length; i++)
            //{

            //    Console.WriteLine(nomes[i]);
            }
          }

    }
}
