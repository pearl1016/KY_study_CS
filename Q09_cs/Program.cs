
for(int i = 1; i <= 5; i++)
{
    for (int j = 5-i; j>=0; j--)
    {
        Console.Write("  ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
