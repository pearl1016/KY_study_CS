
int cnt = 0;
int pNum;
for (int i =2; i<= 1000; i++)
{
    for(pNum = 2; pNum < i; pNum++)
    {
        if (i % pNum == 0)
        {
            break;
        }
        if (pNum == i)
        {
            cnt++;
            Console.Write($"{i}  ");
        }
    }

}
Console.WriteLine();
Console.WriteLine($"소수의 개수: {cnt}");