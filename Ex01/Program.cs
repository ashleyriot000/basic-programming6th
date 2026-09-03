namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //학생 10명의 이름과 국어 성적을 저장하고 학생 번호로 이름과 성적을 조회할 수 있는 프로그램 작성.
            string[] names = new string[10];
            int[] points = new int[10];

            Console.WriteLine("=========  학생 국어 성적표 작성 프로그램 ============");
            //for문 - N회 반복하고 싶을 때 많이 사용됩니다.

            int a = 0;
            Console.WriteLine("A의 값은 " + a++);
            a += 1;
            Console.WriteLine("A의 값은 " + a++);
            for (int i = 0; i < names.Length; ++i)
            {
                //홀수번호는 생략하고 싶을때
                //if (i % 2 == 0)
                //{
                //    //continue문까지 실행하고 다음 반복으로 이어짐.
                //    continue;
                //}
                Console.Write((i + 1) + "번 학생의 이름을 입력해주세요 : ");
                names[i] = Console.ReadLine();
                Console.Write((i + 1) +"번 학생의 국어 성적을 입력해주세요 : ");
                points[i] = int.Parse(Console.ReadLine());

                //입력을 중단하고 싶을때
                //Console.Write("계속 입력하시겠습니까?(Y/N)");
                //ConsoleKeyInfo yes = Console.ReadKey();
                //if (yes.Key == ConsoleKey.N)
                //    break문까지 실행하고 반복 중단.
                //    break;
            }

            Console.Clear();
            Console.WriteLine("==========  학생 리스트  =========");
            //foreach - 배열 안에 있는 데이터를 꺼내와 하나씩 반복할 때 사용.
            int number = 1;
            foreach(string name in names)
            {
                Console.WriteLine($"{number++:D2}번 : {name}");
            }
            Console.WriteLine("=============================");

            //While - 조건을 만족하는 동안 계속 반복
            while(true)
            {
                Console.Write("점수를 조회할 학생의 번호를 입력해 주세요 : ");
                int index = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine(index + "번 학생의 이름은 " + names[index] + "국어 성적은 " + points[index]);
                Console.Write("더 조회하시겠습니까?(Y/N)");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.N)
                    break;
            }

            //Console.Write("1번 학생의 이름을 입력해주세요 : ");
            //names[0] = Console.ReadLine();
            //Console.Write("1번 학생의 국어 성적을 입력해주세요 : ");
            //points[0] = int.Parse(Console.ReadLine());
            //Console.Write("2번 학생의 이름을 입력해주세요 : ");
            //names[1] = Console.ReadLine();
            //Console.Write("2번 학생의 국어 성적을 입력해주세요 : ");
            //points[1] = int.Parse(Console.ReadLine());
            //Console.Write("3번 학생의 이름을 입력해주세요 : ");
            //names[2] = Console.ReadLine();
            //Console.Write("3번 학생의 국어 성적을 입력해주세요 : ");
            //points[2] = int.Parse(Console.ReadLine());
            //Console.Write("4번 학생의 이름을 입력해주세요 : ");
            //names[3] = Console.ReadLine();
            //Console.Write("4번 학생의 국어 성적을 입력해주세요 : ");
            //points[3] = int.Parse(Console.ReadLine());
            //Console.Write("5번 학생의 이름을 입력해주세요 : ");
            //names[4] = Console.ReadLine();
            //Console.Write("5번 학생의 국어 성적을 입력해주세요 : ");
            //points[4] = int.Parse(Console.ReadLine());
            //Console.Write("6번 학생의 이름을 입력해주세요 : ");
            //names[5] = Console.ReadLine();
            //Console.Write("6번 학생의 국어 성적을 입력해주세요 : ");
            //points[5] = int.Parse(Console.ReadLine());
            //Console.Write("7번 학생의 이름을 입력해주세요 : ");
            //names[6] = Console.ReadLine();
            //Console.Write("7번 학생의 국어 성적을 입력해주세요 : ");
            //points[6] = int.Parse(Console.ReadLine());
            //Console.Write("8번 학생의 이름을 입력해주세요 : ");
            //names[7] = Console.ReadLine();
            //Console.Write("8번 학생의 국어 성적을 입력해주세요 : ");
            //points[7] = int.Parse(Console.ReadLine());
            //Console.Write("9번 학생의 이름을 입력해주세요 : ");
            //names[8] = Console.ReadLine();
            //Console.Write("9번 학생의 국어 성적을 입력해주세요 : ");
            //points[8] = int.Parse(Console.ReadLine());
            //Console.Write("10번 학생의 이름을 입력해주세요 : ");
            //names[9] = Console.ReadLine();
            //Console.Write("10번 학생의 국어 성적을 입력해주세요 : ");
            //points[9] = int.Parse(Console.ReadLine());
            //Console.Write("\n몇 번 학생의 데이터가 필요합니까? ");
            //int index = int.Parse(Console.ReadLine());

            //Console.WriteLine(index + "번 학생의 이름은 " + names[index - 1] + "국어 성적은 " + points[index - 1]);
        }
    }
}
