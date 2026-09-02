namespace RCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("짱껨뽀 시작하자!");
            //1 : 가위
            //2 : 바위
            //3 : 보자기
            int user = 0;
            Random rnd = new Random();

            for(int i = 1; i < 4; ++i)
            {
                Console.Write($"[{i}판] 가위/바위/보 중에 하나를 내주세요(가위:1, 바위:2, 보:3)");
                //유저 입력으로 값 받기
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int result))
                    {
                        user = result;
                        break;
                    }
                    else
                    {
                        Console.Write("잘못 내셨습니다. 다시 내주세요(가위:1, 바위:2, 보:3)");
                    }
                }
                int com = rnd.Next(3) + 1;

                if (user == com)
                {
                    Console.WriteLine("비겼습니다.");
                }
                else if (user == 1 && com == 3)
                {
                    Console.WriteLine("유저가 이겼습니다.");
                }
                else if (user == 2 && com == 1)
                {
                    Console.WriteLine("유저가 이겼습니다.");
                }
                else if (user == 3 && com == 2)
                {
                    Console.WriteLine("유저가 이겼습니다.");
                }
                else
                {
                    Console.WriteLine("유저가 졌습니다.");
                }
            }            
        }
    }
}
