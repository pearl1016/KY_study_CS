//Q10. (배열) 10개의 숫자를 랜덤으로 만들어서 배열에 저장하고, 평균, 최소, 최대값을 구하시오.
namespace Q10_cs
{
    class program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] value = new int[10];

            for (int i = 0; i < value.Length; i++)
            {
                value[i] = r.Next(10);
                Console.Write("{0} ", value[i]);
            }
            Console.WriteLine("");
            int max = value[0];
            int min = value[0];
            for (int i = 1; i < value.Length; i++)
                if (value[i] > max)
                    max = value[i];
                if (value[1] < min)
                    min = value[1];
            Console.WriteLine("최대값: {0}, 최소값: {1}", max, min);

            int sum = 0;
            for (int i = 0; i < value.Length; i++)
                sum += value[i];
            Console.WriteLine("평균: {0}", (double)sum / value.Length);
        }
    }
}