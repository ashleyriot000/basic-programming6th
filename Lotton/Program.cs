namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"==== 로또 추첨 프로그램 ====" 출력
            //Random rnd = new Random();
            //1~45번 중에서 하나를 뽑음.
            //int result = rnd.Next(1, 46);
            //추첨한 숫자를 저장하기
            //지금 뽑은 숫자가 이전에 뽑은 숫자들 중에서 중복된 숫자가 있는지 확인하고
            //중복되었으면 다시 뽑기.

            //모두 뽑았으면 뽑은 숫자들 출력.


            //+α100만번 추첨후, 가장 많이 뽑힌 6개의 숫자를 골라 행운의 로또번호로 출력.

            Console.Write("추첨할 횟수를 입력해주세요 : ");
            int count = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] numbers = new int[6];
            int[] nums = new int[45];
            int[] totals = new int[45];
            for (int i = 0; i < 45; ++i)
            {
                nums[i] = i + 1;
            }


            for (int c = 0; c < count; c++)
            {
                numbers[0] = 0;
                numbers[1] = 0;
                numbers[2] = 0;
                numbers[3] = 0;
                numbers[4] = 0;
                numbers[5] = 0;

                Console.Write($"[{c + 1:D6}회] ");
                for (int i = 0; i < 6; ++i)
                {
                    Thread.Sleep(50);
                    int result = rnd.Next(1, 46);
                    bool found = false;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (numbers[j] == result)
                        {
                            Console.WriteLine($"{j + 1}번째 뽑은 숫자({numbers[j]})와 뽑은 숫자({result})가 중복되서 다시 뽑습니다.");
                            found = true;
                                
                            Console.Write($"[{c + 1:D6}회] ");
                            for(int k = 0; k < i; k++)
                            {
                                Console.Write($"{numbers[k]:D2}, ");
                            }

                            i -= 1;
                            break;
                        }
                    }

                    if (!found)
                    {
                        numbers[i] = result;
                        totals[result - 1]++;
                        Console.Write($"{numbers[i]:D2}{(i < 5 ? "," : "")} ");
                    }
                }
                Console.WriteLine($"");
            }

            for (int i = 44; i > 0; --i)
            {
                for (int j = i -1; j > -1; --j)
                {
                    if(totals[i] > totals[j])
                    {
                        int temp = totals[i];
                        int nTemp = nums[i];
                        totals[i] = totals[j];
                        nums[i] = nums[j];
                        totals[j] = temp;
                        nums[j] = nTemp;
                    }
                }
            }

            Console.WriteLine($"행운의 번호 : {nums[0]}({totals[0]}회),{nums[1]}({totals[1]}회),{nums[2]}({totals[2]}회),{nums[3]}({totals[3]}회),{nums[4]}({totals[4]}회),{nums[5]}({totals[5]}회)");

            for (int i = 0; i < 6; ++i)
            {
                Console.WriteLine($"그 외 순위  : " +
                    $"{nums[6 + 6 * i]}({totals[6 + 6 * i]}회)," +
                    $"{nums[7 + 6 * i]}({totals[7 + 6 * i]}회)," +
                    $"{nums[8 + 6 * i]}({totals[8 + 6 * i]}회)," +
                    $"{nums[9 + 6 * i]}({totals[9 + 6 * i]}회)," +
                    $"{nums[10 + 6 * i]}({totals[10 + 6 * i]}회)," +
                    $"{nums[11 + 6 * i]}({totals[11 + 6 * i]}회)");
            }
            Console.WriteLine($"그 외 순위  : " +
                $"{nums[42]}({totals[42]}회)," +
                $"{nums[43]}({totals[43]}회)," +
                $"{nums[44]}({totals[44]}회)");


        }
    }
}
