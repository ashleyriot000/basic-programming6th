namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[3];
            Console.Write("국어 성적을 입력해주세요 : ");
            points[0] = int.Parse(Console.ReadLine());
            Console.Write("영어 성적을 입력해주세요 : ");
            points[1] = int.Parse(Console.ReadLine());
            Console.Write("국어 성적을 입력해주세요 : ");
            points[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("당신의 국어 성적은 " + points[0] + "점이고, 영어 성적은 " +
                points[1] + "점이고, 수학 성적은 " + points[2] +"점입니다.");

            //다중 배열
            int[,] doublePoints = new int[3, 3];
            /*  성적표     국어 영어 수학
             *  1번 학생   100   90  70
             *  2번 학생   100   50  40
             *  3번 학생   100  100 100 
             */

            int[,,] triPoints = new int[3, 3, 3];

            //지그 배열 : 잘 안쓰임.
            int[][] zigArray = new int[3][];
            zigArray[0] = new int[1];
            zigArray[1] = new int[3];
            zigArray[0] = new int[10];
        }
    }
}
