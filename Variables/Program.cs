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
        }
    }
}
