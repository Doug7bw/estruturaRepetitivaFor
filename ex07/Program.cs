using System;

namespace ex07;
class Program
{
    static void Main(string[] args)
    {
        int numero, n;

        Console.WriteLine("Digite um número inteiro: ");
        numero = int.Parse(Console.ReadLine());
        
        for(n = 1; n <= numero; n++)
        {
            Console.WriteLine($"{n} {Math.Pow(n, 2)} {Math.Pow(n, 3)}");
        };
    }
}
