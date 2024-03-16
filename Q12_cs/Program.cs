using System.Runtime.CompilerServices;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("첫번째 정수를 입력하시오: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("두번째 정수를 입력하시오: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("세번째 정수를 입력하시오: ");
        int c = int.Parse(Console.ReadLine());

        int max = Larger(Larger(a, b), c);
        Console.WriteLine($"{max}");
    }

    private static int Larger(int a, int b)
    {
        return (a > b) ? a : b;
    }
}
