namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //화면에 "기계 구조용 탄소강의 부피 및 무게 계산기" 출력
            //1. 재료의 치수(반지름, 높이)를 입력받기
            //탄소강의 밀도 = 7.85,
            //2. 부피 계산 : 파이 * 반지름 * 반지름 * 높이
            //3. 무게 계산 : 부피 * 밀도

            // 부피가 1000이 넘으면서 무게가 1000kg이 넘는지 출력하기
            //Math.PI
            //부피와 무게를 화면에 출력해주세요.

            Console.WriteLine("기계 구조용 탄소강의 부피 및 무게 계산기");

            while(true)
            {
                CalculateVolumeAndMass();

                Console.Write("한번 더 측량하시겠습니까?(Y/N)");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.N)
                    break;
            }
        }


        /// <summary>
        /// 반지름과 높이값을 입력해 부피와 무게를 계산하는 함수입니다.
        /// </summary>
        static void CalculateVolumeAndMass()
        {
            Console.Write("반지름을 입력해 주세요 : ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write("높이를 입력해 주세요 : ");
            double height = double.Parse(Console.ReadLine());
            double volume = (Math.PI * radius * radius * height);
            double mass = volume * 7.85d;

            Console.WriteLine($"부피는 {volume:f2}mm³이며, 무게는 {mass:f2}kg입니다.");
            if (volume >= 1000d && mass >= 1000d)
            {
                Console.WriteLine($"부피와 무게가 원하는 조건에 부합합니다.");
            }
            else
            {
                Console.WriteLine($"부피와 무게가 원하는 조건에 부합하지 않습니다.");
            }
        }
    }
}
