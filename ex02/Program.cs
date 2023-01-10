namespace ex02;
class Program
{
    static void Main(string[] args)
    {
        int valor, numero, intervaloIn = 0, intervaloOut = 0;

        Console.WriteLine("Digite um número inteiro: ");
        valor = int.Parse(Console.ReadLine());

        for(int n = 1; n <= valor; n++)
        {
            Console.WriteLine("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            if(numero >= 10 && numero <= 20)
            {
                intervaloIn++;
            }
            else
            {
                intervaloOut++;
            };
        };

        Console.WriteLine($"{intervaloIn} in");
        Console.WriteLine($"{intervaloOut} out");
    }
}
