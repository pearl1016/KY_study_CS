Random r = new Random();
int[] a = new int[10];
for (int i = 0; i < 10; i++)
{
    a[i] = r.Next(0, 101);
}
Console.Write("Before Sorting : ");
foreach (int value in a)
    Console.Write($"{value} ");
Console.WriteLine();
for(int i = 9; i > -0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (a[j] > a[j + 1])
        {
            int t = a[j];
            a[j] = a[j + 1];
            a[j + 1] = t;
        }
    }
}

//Array.Sort(a)
Console.Write("After Sorting : ");
foreach (int value in a)
    Console.Write($"{value} ");
Console.WriteLine();