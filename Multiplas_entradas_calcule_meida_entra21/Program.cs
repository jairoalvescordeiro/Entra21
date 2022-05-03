using System;

namespace Multiplas_entradas_calcule_meida_entra21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que receba um número indefinido de
            //entradas e calcule a média de todas elas. Quando o usuário 
            //inserir um valor negativo, o programa encerra e mostra a
            //média.

            float entrada;
            float entradatotal = 0;
            float contador = 0;

            Console.WriteLine("Digite um valor:");
            entrada = Convert.ToSingle(Console.ReadLine());            
            while (entrada >= 1)
            
            {
                contador = contador + 1;
                entradatotal = entrada + entradatotal;                
                entrada=Convert.ToSingle(Console.ReadLine());
            }   
                Console.WriteLine("A media é:" + entradatotal/contador);

        }


    }
    
}
