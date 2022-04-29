using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        //Faça um programa que receba 3 notas de um aluno e identifique a maior
        //nota, a menor nota e a média entre as notas;
        {
            float nota1;
            float nota2;
            float nota3;
            float media;

            Console.WriteLine("Digite a primeira nota:");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            nota3 = Convert.ToSingle(Console.ReadLine());

            if ((nota1 > nota2) && (nota1 > nota3)) {

                Console.WriteLine("Sua nota mais alta é:" + nota1);
                Console.WriteLine("\n");

            } else if ((nota1 < nota2) && (nota1 < nota3)) {
                Console.WriteLine("Sua nota mais baixa é:" + nota1);
                Console.WriteLine("\n");
            }

            if ((nota2 > nota1) && (nota2 > nota3)) {
                Console.WriteLine("Sua nota mais alta é:" + nota2);
                Console.WriteLine("\n");

            } else if ((nota2 < nota1) && (nota2 < nota3))

            { Console.WriteLine("Sua nota mais baixa é:" + nota2);
                Console.WriteLine("\n");
            }


            if ((nota3 > nota1) && (nota3 > nota2))
            {
                Console.WriteLine("Sua nota mais baixa é:" + nota3);
                Console.WriteLine("\n");

            } else if ((nota3 < nota1) && (nota3 < nota2)) {

                Console.WriteLine("Sua nota mais baixa é:" + nota3);
                Console.WriteLine("\n");
            }

            media = (nota1 + nota2 + nota3) / 3;             
                Console.WriteLine("A sua média é:" +media);
           

        }
    }
}
