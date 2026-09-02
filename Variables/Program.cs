namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //리터럴 상수 =>  100 , 120처럼 직접 값을 기입해놓은 상수
            Console.WriteLine(100 + 120);
            //리터럴 상수 => " "안에 직접 기입한 문자열도 상수
            Console.WriteLine("100 + 120");

            //변수
            //참/거짓 bool
            bool isMale = true;

            //정수 타입
            //int, long, uint, ulong

            //실수 타입
            //float, double
            float fValue = 0.1f;

            float result = fValue + fValue + fValue + fValue + fValue +
                fValue + fValue + fValue + fValue + fValue;
            //잘못된 실수 비교 사용법
            if(result == 1.0f)
            {
                Console.WriteLine("네 결과값이 1과 같습니다.");
            }
            else if(result >= 1.0f)
            {
                Console.WriteLine("네 결과값이 1보다 크거나 같습니다.");
            }
            else if (result <= 1.0f)
            {
                Console.WriteLine("네 결과값이 1보다 작거나 같습니다.");
            }
            else
            {
                Console.WriteLine("아니요, 결과값이 1과 다릅니다.");
            }

            //+,-,*,/,%

            Console.Write("국어성적을 입력해주세요 : ");
            //string koreanText = Console.ReadLine();
            //int korean = int.Parse(koreanText);
            int korean = int.Parse(Console.ReadLine());
            Console.Write("영어성적을 입력해주세요 : ");
            int english = int.Parse(Console.ReadLine());
            Console.Write("수학성적을 입력해주세요 : ");
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine("국어 성적은 " + korean + "점이고,\n 영어 성적은 " + 
                english + "점이고,\n 수학점수는 " + math + "점입니다." );
            Console.WriteLine("전체 점수의 총합은 " + (korean + english + math));
            Console.WriteLine("평균 점수는 " + (korean + english + math)/3);
            Console.WriteLine($"평균 점수(실수)는 {(korean + english + math) / 3f:F2}");
            Console.WriteLine($"평균 점수(실수)는 {1 / 3f:P2}");

            //오버플로우 : 예상한 결과가 나오지 않아 원하는 동작을 하지 않을 가능성이 생김. 
            long lValue = 1000000000000000;
            int iValue = (int)lValue;

            Console.WriteLine(lValue);
            Console.WriteLine(iValue);
        }
    }
}
