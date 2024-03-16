// Q6. (반복문)두 정수 x, y를 입력받아 x의 y 승을 계산하시오.
namespace Q06_cs
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("x를 입력하세요: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y를 입력하세요: ");
            int y = int.Parse(Console.ReadLine());

            int pow = 1;
            for (int i = 0; i < y; i++)
                pow *= x;
            Console.WriteLine("{0} ^ {1} = {2}", x, y, pow);
        }
    }
}