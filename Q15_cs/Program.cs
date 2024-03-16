internal class Program
{
   static void Hanoi(int n, char from, char to, char by)
    {
        if (n==1)
        {
            Console.WriteLine($"[{n}] Move : {from} -> {by}");
        }
        else
        {
            Hanoi(n - 1, from, by, to);
            Console.WriteLine($"[{n}] Move : {from} -> {by}");
            Hanoi(n - 1, to, from, by);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hanoi Tower : {0}, {1}->{2}->{3}", 4, 'A', 'B', 'C');
        Hanoi(4, 'A', 'B', 'C');
   
    }
}
    
