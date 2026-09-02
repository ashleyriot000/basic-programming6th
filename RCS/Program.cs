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
            int user;
            string userText;
            int com;
            string comText;

            Random rnd = new Random();

            //Console.Write($"[1판] 가위/바위/보 중에 하나를 내주세요(가위:1, 바위:2, 보:3)");
            //user = int.Parse(Console.ReadLine());
            //if (user == 1)
            //{
            //    userText = "가위";
            //}
            //else if (user == 2)
            //{
            //    userText = "바위";
            //}
            //else
            //{
            //    userText = "보";
            //}

            //com = rnd.Next(3) + 1;
            //if (com == 1)
            //{
            //    comText = "가위";
            //}
            //else if (com == 2)
            //{
            //    comText = "바위";
            //}
            //else
            //{
            //    comText = "보";
            //}

            //if (user == com)
            //{
            //    Console.WriteLine($"컴:{comText} : 유저:{userText} => 비김");
            //}
            //else if ((user == 1 && com == 3) || (user == 2 && com == 1) || (user == 3 && com == 2))
            //{
            //    Console.WriteLine($"컴:{comText} : 유저:{userText} => 유저 승");
            //}
            //else
            //{
            //    Console.WriteLine($"컴:{comText} : 유저:{userText} => 유저 패");
            //}

            //Console.Write($"[2판] 가위/바위/보 중에 하나를 내주세요(가위:1, 바위:2, 보:3)");
            //user = int.Parse(Console.ReadLine());           

            //if (user == 1)
            //{
            //    userText = "가위";
            //}
            //else if (user == 2)
            //{
            //    userText = "바위";
            //}
            //else
            //{
            //    userText = "보";
            //}

            //com = rnd.Next(3) + 1;
            //if (com == 1)
            //{
            //    comText = "가위";
            //}
            //else if (com == 2)
            //{
            //    comText = "바위";
            //}
            //else
            //{
            //    comText = "보";
            //}

            //if (user == com)
            //{
            //    Console.WriteLine($"컴:{comText} : 유저:{userText} => 비김");
            //}
            //else if ((user == 1 && com == 3) || (user == 2 && com == 1) || (user == 3 && com == 2))
            //{
            //    Console.WriteLine($"컴:{comText} : 유저:{userText} => 유저 승");
            //}
            //else
            //{
            //    Console.WriteLine($"컴:{comText} : 유저:{userText} => 유저 패");
            //}

            //Console.Write($"[3판] 가위/바위/보 중에 하나를 내주세요(가위:1, 바위:2, 보:3)");
            //user = int.Parse(Console.ReadLine());
            //if (user == 1)
            //{
            //    userText = "가위";
            //}
            //else if (user == 2)
            //{
            //    userText = "바위";
            //}
            //else
            //{
            //    userText = "보";
            //}

            //com = rnd.Next(3) + 1;
            //if (com == 1)
            //{
            //    comText = "가위";
            //}
            //else if (com == 2)
            //{
            //    comText = "바위";
            //}
            //else
            //{
            //    comText = "보";
            //}

            //if (user == com)
            //{
            //    Console.WriteLine($"컴:{comText} : 유저:{userText} => 비김");
            //}
            //else if ((user == 1 && com == 3) || (user == 2 && com == 1) || (user == 3 && com == 2))
            //{
            //    Console.WriteLine($"컴:{comText} : 유저:{userText} => 유저 승");
            //}
            //else
            //{
            //    Console.WriteLine($"컴:{comText} : 유저:{userText} => 유저 패");
            //}


            for (int i = 1; i < 4; ++i)
            {
                Console.Write($"[{i}판] 가위/바위/보 중에 하나를 내주세요(가위:1, 바위:2, 보:3)");
                //유저 입력으로 값 받기
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int result))
                    {
                        if (result > 3 || result < 1)
                        {
                            Console.Write("잘못 내셨습니다. 다시 내주세요(가위:1, 바위:2, 보:3)");
                            continue;
                        }

                        user = result;
                        userText = result switch
                        {
                            1 => "가위",
                            2 => "바위",
                            3 => "보",
                            _ => string.Empty
                        };
                        break;
                    }
                    else
                    {
                        Console.Write("잘못 내셨습니다. 다시 내주세요(가위:1, 바위:2, 보:3)");
                    }
                }
                com = rnd.Next(3) + 1;
                comText = com switch
                {
                    1 => "가위",
                    2 => "바위",
                    3 => "보",
                    _ => string.Empty
                };

                if (user == com)
                {
                    Console.WriteLine($"컴:{comText} : 유저:{userText} => 비김");
                }
                else if ((user == 1 && com == 3) || (user == 2 && com == 1) || (user == 3 && com == 2))
                {
                    Console.WriteLine($"컴:{comText} : 유저:{userText} => 유저 승");
                }
                else
                {
                    Console.WriteLine($"컴:{comText} : 유저:{userText} => 유저 패");
                }
            }
        }
    }
}
