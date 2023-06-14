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

        public string name;
        private int hp;
        private int power;

        public int Hp { get => hp; set => hp = (int)MathF.Max(0, value); }

        public Monster(string name, int hp, int power)
        {
            this.name = name;
            Hp = hp;
            this.power = power;

            monsters.Add(this);

            TextOptions.TextColor(ConsoleColor.Red, name);
            Console.WriteLine($"(이)가 생성되었습니다.");
        }

        public void Damaged(int damage)
        {
            Hp -= damage;
            TextOptions.TextColor(ConsoleColor.Red, name);
            Console.WriteLine($"(이)가 {damage} 만큼의 피해를 입었습니다.");
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

            monsters.Remove(this);
        }

        public void Attack(Player player)
        {
            TextOptions.TextColor(ConsoleColor.Red, name);
            Console.Write("(이)가 ");
            TextOptions.TextColor(ConsoleColor.Green, player.name);
            Console.WriteLine("을 공격했습니다.");
            Thread.Sleep(1000);

            if (player.position == 1)
            {
                player.Damaged(power - player.defensive);
            }
            else if(player.position == 0)
            {
                player.Damaged(power);
            }
            else
            {
                Console.WriteLine("-------------------Error-------------------");
            }
        }

        public void ShowStatus()
        {
            Console.Write($"이름: ");
            TextOptions.TextColor(ConsoleColor.DarkYellow, name);
            Console.WriteLine();
            Console.Write($"체력: ");
            TextOptions.TextColor(ConsoleColor.DarkRed, Hp.ToString());
            Console.Write(" / 공격력: ");
            TextOptions.TextColor(ConsoleColor.DarkMagenta, power.ToString());
            Console.WriteLine();
        }
    }
}
