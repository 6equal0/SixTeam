using System;

namespace Minki
{
    class Program
    {
        static Monster a = new Monster("유근영", 10, 10, 10);

        static Player player1 = new Player("일지우", 10, 10, 5);
        static Player player2 = new Player("이지우", 10, 10, 5);
        static Player player3 = new Player("삼지우", 10, 10, 5);

        static void Main(string[] args)
        {
            player1.SetPos(0);
            player2.SetPos(1);
            player3.SetPos(1);

            Command();
        }

        static void Command()
        {
            command:

            string[] inst = Console.ReadLine().Split();

            switch (inst[0])
            {
                case "/공격":
                    foreach (Player item in Player.players)
                    {
                        if (item.name == inst[1])
                        {
                            a.Attack(item);
                            break;
                        }
                        else if(item == Player.players[Player.players.Count - 1])
                        {
                            Console.WriteLine("올바른 대상을 입력해주세요.");
                            goto command;
                        }
                    }
                    break;
                case "/배치":
                    foreach (Player item in Player.players)
                    {
                        if (item.name == inst[1])
                        {
                            if (inst[2] == "전열")
                                item.SetPos(1);
                            else if (inst[2] == "후열")
                                item.SetPos(0);
                            else
                            {
                                Console.WriteLine("올바른 위치를 입력해주세요.");
                                goto command;
                            }
                            break;
                        }
                        else if (item == Player.players[Player.players.Count - 1])
                        {
                            Console.WriteLine("올바른 대상을 입력해주세요.");
                            goto command;
                        }
                    }
                    break;
                case "/능력치":
                    foreach (Player item in Player.players)
                    {
                        if (item.name == inst[1])
                        {
                            item.ShowStatus();
                        }
                        else if (item == Player.players[Player.players.Count - 1])
                        {
                            Console.WriteLine("올바른 대상을 입력해주세요.");
                            goto command;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("올바른 명령어를 입력해주세요.");
                    goto command;
            }
        }
    }
}
