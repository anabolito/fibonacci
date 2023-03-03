internal class Program
{
    private static void Main(string[] args)
    {
        double ant = 0, atual = 1, n;

        Console.Write("Escreva a posição desejada da sequência Fibonacci: ");
        n = double.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            Console.Write(ant + ", ");
            atual = ant + atual;
            ant = atual - ant;
        }
    }
}