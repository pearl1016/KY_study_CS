// Q1.(입출력)자신의 학번과 이름을 입력으로 받아서 화면에 출력하시오.

namespace Q01_cs
{
    class program
    {
        static void Main (string[] args)
        {
            int ID; // 학번
            string name; // 이름(스트링=문자열)

            Console.Write("학번을 입력하세요 : ");
            ID = int.Parse(Console.ReadLine());

            Console.Write("이름을 입력하세요 : ");
            name = Console.ReadLine();

            Console.WriteLine("학번 : {0}", ID);
            Console.WriteLine("이름 : {0}", name);
        }
    }
}
