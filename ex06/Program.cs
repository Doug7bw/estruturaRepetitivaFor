namespace ex06;
class Program
{
    static void Main(string[] args)
    {
        int numero, divisor, n;

        Console.WriteLine("Digite um número inteiro: ");
        numero = int.Parse(Console.ReadLine());

        for(n = 1; n <= numero ; n++)
        {
            if(numero % n == 0)
            {
                Console.WriteLine(n);
            };
        };
    }
}
