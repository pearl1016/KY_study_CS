internal class Program
{
    static void pyPrint(int a)
    {
        for(int i=1; i<= a; i++)
        {
            for (int j = a - 1; j >= 0; j--)
            {
                Console.Write(" ");
            }
            for (int k = i; k <= 2 * i-1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        pyPrint(3);
        pyPrint(5);
        pyPrint(7);
    }
}