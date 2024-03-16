// Q7.(2중반복문)구구단을 출력하시오.

Console.WriteLine("구구단!");
for(int i=1; i<10; i++)
{
    for (int j = 2; j < 10; j++)
        Console.Write($"{j}X{i}={j * i}\t");
    Console.WriteLine();
}