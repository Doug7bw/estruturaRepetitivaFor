namespace ex01;
class Program
{
    static void Main(string[] args)
    {
        int count;

        Console.WriteLine("Digite um número inteiro: ");
        count = int.Parse(Console.ReadLine());

        for(int n = 1; n <= count; n++)
        {
            if((n % 2) != 0)
            {
                Console.WriteLine(n);
            }
        }
    }
}
