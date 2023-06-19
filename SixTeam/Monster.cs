using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SixTeam
{
    class Monster
    {
        public static List<Monster> monsters = new List<Monster>();

        static Random random = new Random();

        public string name;
        private int hp;
        private int power;
        private bool boss = false;
        public bool isStun = false;

        public int Hp { get => hp; set => hp = (int)MathF.Max(0, value); }

        public Monster(string name, int hp, int power, bool boss = false)
        {
            this.name = name;
            Hp = hp;
            this.power = power;
            this.boss = boss;

            Push();

            if (boss)
                TextOptions.TextColor(ConsoleColor.Red, "Boss: " + this.name);
            else
                TextOptions.TextColor(ConsoleColor.Red, this.name);
            Console.WriteLine($"(이)가 생성되었습니다.");
            Console.WriteLine("------------------------------------");
        }

        public void Attack(List<Player> players)
        {
            if (!isStun)
            {
                int min = 100;
                List<Player> minPlys = new List<Player>();
                foreach (Player item in players)
                {
                    if (item.Hp == min)
                    {
                        minPlys.Add(item);
                    }
                    else if (item.Hp <= min)
                    {
                        minPlys.Clear();
                        minPlys.Add(item);
                        min = item.Hp;
                    }
                }

                Player player = minPlys[random.Next(minPlys.Count - 1)];

                TextOptions.TextColor(ConsoleColor.Red, name);
                Console.Write("(이)가 ");
                TextOptions.TextColor(ConsoleColor.Green, player.name);
                Console.WriteLine("을(를) 공격했습니다.");
                Thread.Sleep(800);

                if (player.position == 1)
                {
                    player.Damaged(power - player.defensive);
                }
                else if (player.position == 0)
                {
                    player.Damaged(power);
                }
                else
                {
                    Console.WriteLine("-------------------Error-------------------");
                }
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Red, name);
                Console.WriteLine("(은)는 스턴에 걸려 공격하지 못했습니다.");
            }
        }

        public void BossAttack(List<Player> players)
        {
            int min = 100;
            List<Player> minPlys = new List<Player>();
            foreach (Player item in players)
            {
                if (item.Hp == min)
                {
                    minPlys.Add(item);
                }
                else if (item.Hp <= min)
                {
                    minPlys.Clear();
                    minPlys.Add(item);
                    min = item.Hp;
                }
            }

            Player player1 = minPlys[random.Next(minPlys.Count - 1)];

            min = 100;
            minPlys = new List<Player>();
            foreach (Player item in players)
            {
                if (item.Hp == min)
                {
                    minPlys.Add(item);
                }
                else if (item.Hp <= min)
                {
                    minPlys.Clear();
                    minPlys.Add(item);
                    min = item.Hp;
                }
            }

            Player player2 = minPlys[random.Next(minPlys.Count - 1)];

            TextOptions.TextColor(ConsoleColor.Red, name);
            Console.Write("(이)가 ");

            if (player1 != player2)
            {
                TextOptions.TextColor(ConsoleColor.Green, player1.name);
                Console.Write("(과)와");
                TextOptions.TextColor(ConsoleColor.Green, player2.name);
                Console.WriteLine("을(를) 공격했습니다.");
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Green, player1.name);
                Console.Write("(을)를 2번 공격했습니다.");
            }
            Thread.Sleep(800);

            if (player1.position == 1)
            {
                player1.Damaged(power - player1.defensive);
            }
            else if (player1.position == 0)
            {
                player1.Damaged(power);
            }
            else
            {
                Console.WriteLine("-------------------Error-------------------");
            }

            if (player2.position == 1)
            {
                player2.Damaged(power - player2.defensive);
            }
            else if (player2.position == 0)
            {
                player2.Damaged(power);
            }
            else
            {
                Console.WriteLine("-------------------Error-------------------");
            }
        }

        public void Damaged(int damage)
        {
            Hp -= damage;
            TextOptions.TextColor(ConsoleColor.Red, name);
            Console.WriteLine($"(이)가 {damage} 만큼의 피해를 입었습니다.");
            Thread.Sleep(500);

            if (Hp <= 0)
                Die();
            else
            {
                Console.WriteLine($"남은 체력 : {Hp}");
                Console.WriteLine();
                Thread.Sleep(500);
            }
        }

        public void Stun()
        {
            if (boss)
            {
                TextOptions.TextColor(ConsoleColor.Magenta, name);
                Console.WriteLine("(은)는 스턴을 버텨냅니다.");
            }
            else
            {
                isStun = true;

                TextOptions.TextColor(ConsoleColor.Red, name);
                Console.WriteLine("(은)는 스턴에 걸려 1턴동안 움직이지 못합니다.");
            }
        }

        public void Die()
        {
            TextOptions.TextColor(ConsoleColor.Red, name);
            Console.WriteLine("(이)가 사망했습니다.");
            Console.WriteLine();

            Pop();
        }

        public void ShowStatus()
        {
            if (boss)
            {
                TextOptions.TextColor(ConsoleColor.Cyan, "=============== ");
                TextOptions.TextColor(ConsoleColor.Red, "Boss");
                TextOptions.TextColor(ConsoleColor.Cyan, " ===============\n");
            }
            else
                Console.WriteLine("------------------------------------");
            Console.Write($"이름: ");
            TextOptions.TextColor(ConsoleColor.DarkYellow, name);
            Console.Write($" / 체력: ");
            TextOptions.TextColor(ConsoleColor.DarkRed, Hp.ToString());
            Console.Write(" / 공격력: ");
            TextOptions.TextColor(ConsoleColor.DarkMagenta, power.ToString());
            Console.WriteLine();
            if (boss)
            {
                TextOptions.TextColor(ConsoleColor.Cyan, "====================================");
                Console.WriteLine();
            }
            else
                Console.WriteLine("------------------------------------");
            Console.WriteLine();
        }

        public void Push()
        {
            monsters.Add(this);
        }

        public void Pop()
        {
            monsters.Remove(this);
        }
    }
}
