using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
 

            float X, X1, Y, Y1;
            float distancia;

            Console.WriteLine("Digite cordenada X:");
            X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite cordenada X1:");
            X1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite cordenada Y:");
            Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite cordenada Y1:");
            Y1 = Convert.ToDouble(Console.ReadLine());
                        
            
            distancia = Math.Sqrt(((X - X1) * (X - X1)) + ((Y - Y1) * (Y - Y1)));

            Console.WriteLine("A distância é: " + distancia);







        }
    }
}
