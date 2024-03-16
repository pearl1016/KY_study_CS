// Q5. (반복문)1에서 100를 더하시오. 또 1에서 100 사이의 짝수의 합과 홀수의 합을 계산하시오. 또 1에서 100까지의 역수의 합을 구하시오.

namespace Q05_cs
{
    class program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;
            Console.WriteLine("1~100의 합 : {0}, sum");

            int oddnumbersum = 0;
            int evennumbersum = 0;
            for (int i = 1; i <= 100; i++)
            {

                if (i % 2 == 0)
                    oddnumbersum += i;
                else
                    evennumbersum += i;
            }
            Console.WriteLine("1~100의 짝수의 합 = {0}", evennumbersum);
            Console.WriteLine("1~100의 홀수의 합 = {0}", oddnumbersum);

            double rSum = 0;
            for (int i = 1; i <= 100; i++)
                rSum += 1.0 / i; //역수라 i를 나눔

            Console.WriteLine("1~100의 역수의 합 = {0}", rSum);

        }
    }
}
//값이 잘 나온건지 확인해야함