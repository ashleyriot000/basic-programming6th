namespace Structure
{
    internal class Program
    {
        //사용자 정의 타입, 값(Value) 타입
        public struct Student
        {
            private int id;
            public string name;
            public int[] points;

            public void SetStudent()
            {
                Console.Write("학생의 이름은 무엇입니까? ");
                Random rnd = new Random();
                name = Console.ReadLine();
                //칸을 만들면서 값도 넣어주고 있음.
                points = new int[3]
                {
                    rnd.Next(101),rnd.Next(101),rnd.Next(101)
                };

                //points = new[]
                //{
                //    rnd.Next(101),rnd.Next(101),rnd.Next(101)
                //};

                //별도 값을 넣지 않고 칸만 만듬.
                //points = new int[3];
            }

            public void PrintInfo()
            {
                Console.WriteLine($"{name} : 국어({points[0]}),영어({points[1]}),수학({points[2]}),");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("입력할 학생의 숫자는 몇명입니까? ");
            int count = int.Parse(Console.ReadLine());
            
            Student[] students = new Student[count];
            for(int i = 0; i <count; i++)
            {
                students[i].SetStudent();
            }

            Console.Clear();
            Console.WriteLine("==============================================");
            for(int i = 0; i < count; i++)
            {
                students[i].PrintInfo();
            }
            Console.WriteLine("==============================================");

            Console.WriteLine($"A의 이름은 {students[0].name}, B의 이름은 {students[1].name}입니다.");
            Swap(students[0], students[1]);
            Console.WriteLine($"A의 이름은 {students[0].name}, B의 이름은 {students[1].name}입니다.");
        }


        static void Swap(Student a, Student b)
        {
            Student temp = a;
            a.name = b.name;
            a.points = b.points;
            b.name = temp.name;
            b.points = temp.points;
        }
    }
}
