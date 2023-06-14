using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Minki
{
    class Monster
    {
        public static List<Monster> monsters = new List<Monster>();

        static Random random = new Random();

        public string name;
        private int hp;
        private int power;

        public int Hp { get => hp; set => hp = (int)MathF.Max(0, value); }

        public Monster(string name, int hp, int power)
        {
            this.name = name;
            Hp = hp;
            this.power = power;

            Push();

            TextOptions.TextColor(ConsoleColor.Red, name);
            Console.WriteLine($"(이)가 생성되었습니다.");
        }

        public void Attack(List<Player> players)
        {
            int min = 100;
            List<Player> minPlys = new List<Player>();
            foreach(Player item in players)
            {
                if (item.Hp <= min)
                {
                    minPlys.Add(item);
                    min = item.Hp;
                }
            }

            Player player = minPlys[random.Next(minPlys.Count - 1)];

            TextOptions.TextColor(ConsoleColor.Red, name);
            Console.Write("(이)가 ");
            TextOptions.TextColor(ConsoleColor.Green, player.name);
            Console.WriteLine("을 공격했습니다.");
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
            }
        }

        public void Die()
        {
            TextOptions.TextColor(ConsoleColor.Red, name);
            Console.WriteLine("(이)가 사망했습니다.");

            Pop();
        }

        public void ShowStatus()
        {
            Console.Write($"이름: ");
            TextOptions.TextColor(ConsoleColor.DarkYellow, name);
            Console.Write($" / 체력: ");
            TextOptions.TextColor(ConsoleColor.DarkRed, Hp.ToString());
            Console.Write(" / 공격력: ");
            TextOptions.TextColor(ConsoleColor.DarkMagenta, power.ToString());
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
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
