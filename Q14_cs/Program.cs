internal class Program
{
    static int Facotrial(int a)
    {
        if (a == 1)
            return 1;
        if (a == 2)
            return 2;

        return a * Facotrial(a - 1);
    }
    static void Main(string[] args)
    {
        Console.Write("정수 하나를 입력하세요 : ");
        int a = int.Parse(Console.ReadLine());
        int b = Facotrial(a);
        Console.WriteLine($"{a}!= {b}");
    }
}