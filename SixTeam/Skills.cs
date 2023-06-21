using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SixTeam
{
    class Skills
    {
        static Random rand = new Random();

        public static Action<Player> Skilll(string name)
        {
            switch (name)
            {
                case "강윤구":
                    return KYK;
                case "권도현":
                    return KDomi;
                case "김준표":
                    return KJP;
                case "박영준":
                    return PYJ;
                case "오윤성":
                    return OYS;
                case "이지우":
                    return LJW;
                case "최강호":
                    return CGH;
                case "홍상화":
                    return HSH;
                default:
                    return Default;
            }
        }

        static void KYK(Player player)
        {
            if (!player.isAttack)
            {
                List<Monster> monsters = new List<Monster>();

                foreach(Monster item in Monster.monsters)
                {
                    monsters.Add(item);
                }

                Monster tar1 = monsters[rand.Next(0, monsters.Count)];
                monsters.Remove(tar1);

                Monster tar2 = null;
                if (monsters.Count != 0)
                {
                    tar2 = monsters[rand.Next(0, monsters.Count - 1)];
                    monsters.Remove(tar2);
                }

                if (tar2 == null)
                {
                    TextOptions.TextColor(ConsoleColor.Green, player.name);
                    Console.Write("가 ");
                    TextOptions.TextColor(ConsoleColor.Red, tar1.name);
                    Console.WriteLine("을(를) 공격했습니다.");
                }
                else
                {
                    TextOptions.TextColor(ConsoleColor.Green, player.name);
                    Console.Write("가 ");
                    TextOptions.TextColor(ConsoleColor.Red, tar1.name);
                    Console.Write("(와)과 ");
                    TextOptions.TextColor(ConsoleColor.Red, tar2.name);
                    Console.WriteLine("을(를) 공격했습니다.");
                }
                Thread.Sleep(800);

                if (tar2 == null)
                {
                    tar1.Damaged((int)(Math.Ceiling(player.power * 1.2f)));
                }
                else
                {
                    tar1.Damaged((int)(Math.Ceiling(player.power * 1.2f)));
                    Thread.Sleep(1000);
                    tar2.Damaged((int)(Math.Ceiling(player.power * 1.2f)));
                }

                player.isAttack = true;

                if(player.position == 0)
                    Player.AttackNum++;
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("는 이미 공격했습니다.");
            }
        }

        static void KDomi(Player player)
        {
            if (!player.isAttack)
            {
                foreach(Monster item in Monster.monsters)
                {
                    item.Stun();
                }

                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("이 적 모두를 해킹했습니다.");

                player.isAttack = true;
                if (player.position == 0)
                    Player.AttackNum++;
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("은 이미 공격했습니다.");
            }
        }

        static void KJP(Player player)
        {
            if (!player.isAttack)
            {
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("는 3턴 뒤 자폭합니다.");

                player.boomTurn = Cmd.turn + 3;
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("는 이미 공격했습니다.");
            }
        }

        static void PYJ(Player player)
        {
            if (!player.isAttack)
            {
                foreach(Player item in Player.players)
                {
                    item.hp += 4;

                    player.isAttack = true;
                    if (player.position == 0)
                        Player.AttackNum++;
                }

                Console.WriteLine("모든 플레이어가 Hp를 4 회복했습니다.");
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("은 이미 공격했습니다.");
            }
        }

        static void OYS(Player player)
        {
            if (!player.isAttack)
            {
                player.invTurn = Cmd.turn + 2;
                player.isInv = true;

                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("은 2턴동안 무적입니다.");

                player.isAttack = true;
                if (player.position == 0)
                    Player.AttackNum++;
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("은 이미 공격했습니다.");
            }
        }

        static void LJW(Player player)
        {
            if (!player.isAttack)
            {
                player.hp += player.power;
                player.plusPower = -player.power;

                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("가 공격력을 모두 체력으로 변환시켰습니다.");
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("는 이미 공격했습니다.");
            }
        }

        static void CGH(Player player)
        {
            if (!player.isAttack)
            {
                player.plusPower += 3;
                player.hp -= 2;

                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("가 운동을 하여 Hp를 2 소모해 공격력을 3 얻었습니다.");

                player.isAttack = true;
                if (player.position == 0)
                    Player.AttackNum++;
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("는 이미 공격했습니다.");
            }
        }

        static void HSH(Player player)
        {
            if (!player.isAttack)
            {
                player.invTurn = Cmd.turn + 1;
                player.isInv = true;

                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("는 이 턴 무적입니다.");
                player.hp += 2;
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("가 2 회복했습니다.");

                player.isAttack = true;
                if (player.position == 0)
                    Player.AttackNum++;
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("는 이미 공격했습니다.");
            }
        }

        public static void Default(Player player)
        {
            TextOptions.TextColor(ConsoleColor.Green, player.name);
            Console.WriteLine("(은)는 스킬이 없는 플레이어입니다.");
        }
    }
}
