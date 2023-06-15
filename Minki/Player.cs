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
        public static int AttackNum { get; set; }

        public string name;
        private int hp;
        private int power;
        public int defensive;
        public int position = -1;

        private bool isAttack = false;
        public bool die = false;

        public int Hp { get => hp; set => hp = (int)MathF.Max(0, value); }

        public Player(string name, int hp, int power, int defensive)
        {
            this.name = name;
            Hp = hp;
            this.power = power;
            this.defensive = defensive;

            Push();
        }

        public void SetPos(int pos = 0)
        {
            if (pos == position)
            {
                Console.Write("이미 ");
                TextOptions.TextColor(ConsoleColor.Yellow, pos == 1 ? "전열" : "후열");
                Console.WriteLine("에 배치되어있습니다.");
            }
            else
            {
                position = pos;

                TextOptions.TextColor(ConsoleColor.Green, name);
                Console.Write("(이)가 ");
                TextOptions.TextColor(ConsoleColor.Yellow, pos == 1 ? "전열" : "후열");
                Console.WriteLine("에 배치되었습니다.");
            }
        }

        public void Attack(Monster monster)
        {
            if (!isAttack)
            {
                TextOptions.TextColor(ConsoleColor.Green, name);
                Console.Write("(이)가 ");
                TextOptions.TextColor(ConsoleColor.Red, monster.name);
                Console.WriteLine("(을)를 공격했습니다.");
                Thread.Sleep(800);

                monster.Damaged(power);
                AttackNum++;
                isAttack = true;
            }
            else
            {
                TextOptions.TextColor(ConsoleColor.Green, name);
                Console.WriteLine("(은)는 이미 공격했습니다.");
            }
        }

        public void ResetAttack() => isAttack = false;

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
                Console.WriteLine();
            }
        }

        public void Die()
        {
            TextOptions.TextColor(ConsoleColor.Green, name);
            Console.WriteLine($"(이)가 사망했습니다.\n");
            die = true;

            Pop();
        }

        public void ShowStatus()
        {
            Console.Write($"이름: ");
            TextOptions.TextColor(ConsoleColor.DarkYellow, name);
            Console.Write($" / 배치: ");
            if (position == 0 || position == 1)
                TextOptions.TextColor(ConsoleColor.DarkGreen, position == 1 ? "전열" : "후열");
            else
                TextOptions.TextColor(ConsoleColor.DarkGreen, "없음");
            Console.WriteLine();
            Console.Write($"체력: ");
            TextOptions.TextColor(ConsoleColor.DarkRed, Hp.ToString());
            Console.Write(" / 공격력: ");
            TextOptions.TextColor(ConsoleColor.DarkMagenta, power.ToString());
            Console.Write(" / 방어력: ");
            TextOptions.TextColor(ConsoleColor.DarkCyan, defensive.ToString());
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
        }

        public void Push()
        {
            players.Add(this);
        }

        public void Pop()
        {
            players.Remove(this);
        }
    }
}
