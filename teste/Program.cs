//Soma dois números e retorna o valor total.
static int SomarNumeros(int a, int b)
{
    return a + b;
}
//Mesma função que SomarNumeros, porém, soma valores diferentes.
//O compilador entende que, por receberem valores de tipos diferentes, têm assinaturas diferentes e são diferentes.
static double SomarNumeros(double a, double b)
{
    return a + b;
}
//esta função apenas executa um bloco de operações e não possui retorno.
static void PedirEntradaParaSomaDeDoisNumeros()
{
    int num1;
    int num2;
    double num1d;
    double num2d;
    Console.WriteLine("Insira um valor para num1");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira um valor para num2");
    num2 = Convert.ToInt32(Console.ReadLine());
    //a linguagem infere que é a função com retorno de inteiro
    int retorno = SomarNumeros(num1, num2);
    Console.WriteLine("O valor da soma é: " + retorno);
    Console.WriteLine("Insira um valor para num1d");
    num1d = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Insira um valor para num2d");
    num2d = Convert.ToDouble(Console.ReadLine());
    //é possível chamar uma função dentro de outra
    double retornoDouble = SomarNumeros(num1d, num2d);
    Console.WriteLine("O valor da soma é: " + retornoDouble);
}
//quebra uma string em um vetor de char
static char[] QuebrarString(string texto)
{
    char[] textoQuebrado = new char[texto.Length];
    for (int i = 0; i < texto.Length; i++)
    {
        textoQuebrado[i] = texto[i];
    }
    return textoQuebrado;
}
static string MontarString(char[] texto)
{
    StringBuilder retorno = new StringBuilder();
    foreach (char item in texto)
    {
        retorno.Append(item);
    }
    return retorno.ToString();
}
} 