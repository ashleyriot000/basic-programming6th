namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //산술 연산자
            int ia = 5;
            int ib = 6;
            int 덧셈 = ia + ib;
            int 뺄셈 = ia - ib;
            int 곱하기 = ia * ib;
            int 나누기 = ia / ib;
            int 나머지 = ia % ib;


            //비교 연산자
            bool 같은가 = ia == ib;
            bool 다른가 = ia != ib;
            bool 왼쪽이크냐 = ia > ib;
            bool 오른쪽이크냐 = ia < ib;
            bool 왼쪽이_크거나_같냐 = ia >= ib;
            bool 오른쪽이_크거나_같냐 = ia <= ib;

            //논리 연산자
            bool 진실 = true;
            //! : 부정 연산자 => 결과를 반전시킨다.
            bool 거짓 = !진실;

            if(!거짓)
            {
                Console.WriteLine("거짓은 False입니다");
            }

            //&& : 조건부 And 연산자 => 앞 뒤의 조건이 둘다 true일 경우 true 반환.
            //|| : 조건부 Or 연산자 => 앞이든 뒤든 둘 중에 하나라도 true면 true 반환.
            //^ : XOR 연산자 => 앞과 뒤가 서로 달라야 true;
            bool and = 같은가 && 다른가;
            bool or = 같은가 || 다른가;
            bool xor = 같은가 ^ 다른가;

            //삼항 연상자
            int number = 5;
            //(조건) ? true일 때 반환값 : false일 때 반환값
            int result = number > 5 ? 0 : 1;
        }
    }
}
