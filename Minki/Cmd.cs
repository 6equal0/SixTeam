using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Minki
{
    class Cmd
    {
        public static int turn = 0;

        static string yn = "";

        public static void Command()
        {
            Console.Write("\n명령어를 입력하세요 : ");

            string[] inst = Console.ReadLine().Split();

            switch (inst[0])
            {
                case "/배틀시작":
                    BattleStart();
                    break;
                case "/보스시작":
                    BossStart();
                    break;
                case "/공격":
                    Attack(inst);
                    break;
                case "/스킬":
                    Skill(inst);
                    break;
                case "/배치":
                    Deployment(inst);
                    break;
                case "/능력치":
                    ShowStat(inst);
                    break;
                case "/관찰":
                    Spectate(inst);
                    break;
                case "/?":
                    Console.WriteLine("/공격 [대상]\n/배치 [대상] [전열, 후열]\n/능력치 [대상]\n/관찰 [대상]");
                    break;
                default:
                    ErrorMsg("명령어");
                    Command();
                    return;
            }
        }

        static void ErrorMsg(string type)
        {
            switch (type)
            {
                case "명령어":
                    Console.WriteLine("올바른 명령어를 입력해주세요.");
                    break;
                case "대상플":
                    Console.Write("올바른 대상을 입력해주세요.\n(");
                    for (int i = 0; i < Player.players.Count - 1; i++)
                    {
                        Console.Write($"{Player.players[i].name}, ");
                    }
                    Console.WriteLine($"{Player.players[Player.players.Count - 1].name})");
                    break;
                case "대상몹":
                    Console.Write("올바른 대상을 입력해주세요.\n(");
                    for (int i = 0; i < Monster.monsters.Count - 1; i++)
                    {
                        Console.Write($"{Monster.monsters[i].name}, ");
                    }
                    Console.WriteLine($"{Monster.monsters[Monster.monsters.Count - 1].name})");
                    break;
            }
        }
        
        private static void BossStart()
        {
            yn = "";

            Console.Write("배치를 완료하셨습니까? (");
            TextOptions.TextColor(ConsoleColor.DarkGreen, "y");
            Console.Write("/");
            TextOptions.TextColor(ConsoleColor.DarkRed, "n");
            Console.WriteLine(")");

            do
            {
                yn = Console.ReadLine();
                if (yn == "y")
                {
                    Console.WriteLine("배틀을 시작합니다.");
                    Console.WriteLine();
                }
                else if (yn == "n")
                {
                    Console.WriteLine("배치를 완료하고 와주십시오.");
                    Command();
                    return;
                }
                else
                    Console.WriteLine("올바른 대답을 해주십시오.");
            } while (yn != "y" && yn != "n");
            Thread.Sleep(600);

            if(Player.players.Count == 0 || Monster.monsters.Count == 0)
                Console.WriteLine("-------------------Error-------------------");

            turn = 0;
            while (Player.players.Count != 0 && Monster.monsters.Count != 0)
            {
                Console.WriteLine("공격을 진행해주세요.\n");
                while (Monster.monsters.Count > 0)
                {
                    Command();

                    if (Player.AttackNum >= Player.backPlayers.Count)
                        break;
                }
                foreach (Player item in Player.backPlayers)
                {
                    item.ResetAttack();
                    Player.AttackNum = 0;
                }
                Thread.Sleep(500);
                foreach (Monster item in Monster.monsters)
                {
                    item.BossAttack(Player.frontPlayers);
                    item.isStun = false;
                }
                turn++;
                foreach (Player item in Player.players)
                {
                    item.TurnEnd();
                }
            }

            if (Player.players.Count == 0)
            {
                Console.WriteLine("패배");
            }
            else if (Monster.monsters.Count == 0)
            {
                Console.WriteLine("승리");
            }
        }

        static void BattleStart()
        {
            yn = "";

            Console.Write("배치를 완료하셨습니까? (");
            TextOptions.TextColor(ConsoleColor.DarkGreen, "y");
            Console.Write("/");
            TextOptions.TextColor(ConsoleColor.DarkRed, "n");
            Console.WriteLine(")");

            do
            {
                yn = Console.ReadLine();
                if (yn == "y")
                {
                    Console.WriteLine("배틀을 시작합니다.");
                    Console.WriteLine();
                }
                else if (yn == "n")
                {
                    Console.WriteLine("배치를 완료하고 와주십시오.");
                    Command();
                    return;
                }
                else
                    Console.WriteLine("올바른 대답을 해주십시오.");
            } while (yn != "y" && yn != "n");
            Thread.Sleep(600);

            turn = 0;
            do
            {
                Console.WriteLine("공격을 진행해주세요.\n");
                while (Monster.monsters.Count > 0)
                {
                    Command();

                    if (Player.AttackNum >= Player.backPlayers.Count)
                        break;
                }
                Player.AttackNum = 0;
                Thread.Sleep(500);
                foreach (Monster item in Monster.monsters)
                {
                    item.Attack(Player.frontPlayers);
                    item.isStun = false;
                }
                turn++;
                foreach(Player item in Player.players)
                {
                    item.TurnEnd();
                }
            } while (Player.players.Count != 0 && Monster.monsters.Count != 0);
            Thread.Sleep(500);

            foreach(Player item in Player.players)
            {
                item.plusPower = 0;
            }

            Console.WriteLine();
            if (Monster.monsters.Count == 0)
            {
                TextOptions.TextColor(ConsoleColor.DarkGreen, "승리하였습니다.");
                Console.WriteLine();
            }
            else if(Player.players.Count == 0)
            {
                TextOptions.TextColor(ConsoleColor.DarkRed, "패배하였습니다.");
                Console.WriteLine();
            }
        }

        static void Attack(string[] inst)
        {
            if(inst.Length == 1 || inst.Length == 2)
            {
                Console.WriteLine("사용방법: '/공격 [플레이어] [대상몬스터]'");
                return;
            }
            else if (!CheckP(inst[1]))
            {
                ErrorMsg("대상플");
                Command();
                return;
            }
            else if (!CheckM(inst[2]))
            {
                ErrorMsg("대상몹");
                Command();
                return;
            }

            foreach (Player item in Player.frontPlayers)
            {
                if (item.name == inst[1])
                {
                    TextOptions.TextColor(ConsoleColor.Green, item.name);
                    Console.Write("(은)는 ");
                    TextOptions.TextColor(ConsoleColor.Yellow, "전열");
                    Console.WriteLine("에 배치되어 공격할 수 없습니다.");
                    return;
                }
            }
            foreach (Player item in Player.backPlayers)
            {
                if (item.name == inst[1])
                {
                    foreach (Monster mon in Monster.monsters)
                    {
                        if (mon.name == inst[2])
                        {
                            item.Attack(mon);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        static void Skill(string[] inst)
        {
            if (inst.Length == 1)
            {
                Console.WriteLine("사용방법: '/스킬 [플레이어]'");
                return;
            }
            else if (!CheckP(inst[1]))
            {
                ErrorMsg("대상플");
                Command();
                return;
            }

            foreach (Player item in Player.players)
            {
                if (item.name == inst[1])
                {
                    item.Skill();
                    break;
                }
            }
        }

        static void Deployment(string[] inst)
        {
            if(inst.Length == 1)
            {
                Console.WriteLine("사용방법: '/배치 [플레이어] [전열, 후열]'");
                return;
            }
            else if(!CheckP(inst[1]))
            {
                ErrorMsg("대상플");
                Command();
                return;
            }

            foreach (Player item in Player.players)
            {
                if (item.name == inst[1])
                {
                    if (inst.Length == 2)
                    {
                        Console.WriteLine("올바른 위치를 입력해주세요.\n(전열, 후열)");
                        Command();
                        return;
                    }
                    else if (inst[2] == "전열")
                        item.SetPos(1);
                    else if (inst[2] == "후열")
                        item.SetPos(0);
                    else
                    {
                        Console.WriteLine("올바른 위치를 입력해주세요.\n(전열, 후열)");
                        Command();
                        return;
                    }
                    break;
                }
            }
        }

        static void ShowStat(string[] inst)
        {
            if (inst.Length == 1)
            {
                Console.WriteLine("사용방법: '/능력치 [플레이어]'");
                return;
            }
            else if (inst[1] == "전체")
            {
                Console.WriteLine();
                foreach (Player ply in Player.players)
                    ply.ShowStatus();
                return;
            }
            else if (!CheckP(inst[1]))
            {
                ErrorMsg("대상플");
                Command();
                return;
            }

            foreach (Player item in Player.players)
            {
                if (item.name == inst[1])
                {
                    item.ShowStatus();
                    return;
                }
            }
        }

        static void Spectate(string[] inst)
        {
            if (inst.Length == 1)
            {
                Console.WriteLine("사용방법: '/관찰 [대상몬스터]'");
                return;
            }
            else if (inst[1] == "전체")
            {
                Console.WriteLine();
                foreach (Monster mon in Monster.monsters)
                    mon.ShowStatus();
                return;
            }
            else if (!CheckM(inst[1]))
            {
                ErrorMsg("대상몹");
                Command();
                return;
            }

            foreach (Monster item in Monster.monsters)
            {
                if (item.name == inst[1])
                {
                    item.ShowStatus();
                    return;
                }
            }
        }

        static bool CheckP(string name)
        {
            foreach (Player item in Player.players)
            {
                if (item.name == name)
                    return true;
            }
            return false;
        }

        static bool CheckM(string name)
        {
            foreach (Monster item in Monster.monsters)
            {
                if (item.name == name)
                    return true;
            }
            return false;
        }
    }
}
