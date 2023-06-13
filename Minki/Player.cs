using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Minki
{
    class Player
    {
        public static List<Player> players = new List<Player>();

        public string name;
        private int hp;
        private int damage;
        public int defensive;
        public int position = -1;
        public bool die = false;

        public int Hp { get => hp; set => hp = (int)MathF.Max(0, value); }

        public Player(string name, int hp, int damage, int defensive)
        {
            this.name = name;
            this.Hp = hp;
            this.damage = damage;
            this.defensive = defensive;

            players.Add(this);
        }

        public void SetPos(int pos = 0)
        {
            position = pos;

            TextOptions.TextColor(ConsoleColor.Green, name);
            Console.Write("(이)가 ");
            TextOptions.TextColor(ConsoleColor.Yellow, pos == 1 ? "전열" : "후열");
            Console.WriteLine("에 배치되었습니다.");
        }

        public void Damaged(int damage)
        {
            Hp -= damage;

            TextOptions.TextColor(ConsoleColor.Green, name);
            Console.Write($"(이)가 ");
            TextOptions.TextColor(ConsoleColor.Blue, damage.ToString());
            Console.WriteLine(" 만큼의 피해를 입었습니다.");
            Thread.Sleep(500);

            if (Hp == 0)
            {
                Die();
            }
            else
            {
                Console.WriteLine($"남은 체력 : {Hp}");
            }
        }

        public void Die()
        {
            TextOptions.TextColor(ConsoleColor.Green, name);
            Console.WriteLine($"(이)가 사망했습니다.");
            die = true;
        }

        public void ShowStatus()
        {
            Console.Write($"이름: ");
            TextOptions.TextColor(ConsoleColor.DarkYellow, name);
            Console.WriteLine();
            Console.Write($"체력: ");
            TextOptions.TextColor(ConsoleColor.DarkRed, Hp.ToString());
            Console.Write(" / 공격력: ");
            TextOptions.TextColor(ConsoleColor.DarkMagenta, damage.ToString());
            Console.Write(" / 방어력: ");
            TextOptions.TextColor(ConsoleColor.DarkCyan, defensive.ToString());
        }
    }
}
