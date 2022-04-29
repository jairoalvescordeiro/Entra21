using System;

namespace Exercio_2_19_04
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso;
            float altura;
            float IMC;

            Console.WriteLine("Digite seu peso:");
            peso = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("Digite sua altura:");
            altura = Convert.ToSingle(Console.ReadLine());
            
            IMC = peso / (altura*altura);
            Console.WriteLine("Seu IMC é:" + IMC);
            
        }
    }
}
