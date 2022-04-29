using System;

namespace Numeros_em_ordem_crescente
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, n3;
           
            Console.WriteLine("Digite três números:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());

            if ((n1 < n2) && (n1 < n3) && (n2 < n3))
            {
                Console.WriteLine("A sequencia númerica é:" + n1 + ", " + n2 + ", " + n3);
            }

            else if ((n1 < n2) && (n1 < n3) && (n3 < n2))
            {
                Console.WriteLine("A sequencia númerica é:" + n1 + ", " + n3 + ", " + n2);
            }

            else if ((n2 < n1) && (n2 < n3) && (n3 < n1))
            {
                Console.WriteLine("A sequencia númerica é:" + n2 + ", " + n3 + ", " + n1);
            }
            else if ((n2 < n1) && (n2 < n3) && (n1 < n3))
            {
                Console.WriteLine("A sequencia númerica é:" + n2 + ", " + n1 + ", " + n3);
            }
            else if ((n3 < n1) && (n3 < n2) && (n1 < n2))
            {
                Console.WriteLine("A sequencia númerica é:" + n3 + ", " + n1 + ", " + n2);
            }
            else if ((n3 < n1) && (n3 < n2) && (n2 < n1))
            {
                Console.WriteLine("A sequencia númerica é:" + n3 + ", " + n2 + ", " + n1);
            }

        }
    }
}
