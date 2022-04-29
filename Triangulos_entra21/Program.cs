using System;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            float tLado1, tLado2, tLado3;

            Console.WriteLine("Digite todos os lados do triangulo ");
            tLado1 = Convert.ToSingle(Console.ReadLine());
            tLado2 = Convert.ToSingle(Console.ReadLine());
            tLado3 = Convert.ToSingle(Console.ReadLine());

            if (== tLado2) && (tLado1 ==(tLado1  tLado3))
                Console.WriteLine("Este é um triangulo Equilátero.");

            else if (((tLado1 == tLado2) || (tLado1 == tLado3) || (tLado2==tLado3)))
                Console.WriteLine("Este é um triangulo Isósceles.");

            else 
                Console.WriteLine("Este é um triangulo Escaleno.");
        }
    }
}
//Escreva um programa que receba os 3 lados de um triângulo. O
//programa deverá informar se os valores podem ser um triângulo.
//Indique, caso os lados formem um triângulo, se o mesmo é:
//equilátero, isósceles ou escaleno.
//Observações:
//a.Três lados formam um triângulo quando a soma de quaisquer
//dois lados for maior que o terceiro;
//b.Triângulo Equilátero: três lados iguais;
//c.Triângulo Isósceles: quaisquer dois lados iguais;
//d.Triângulo Escaleno: três lados diferentes;