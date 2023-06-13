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
        public string name;
        private int hp;
        private int damage;
        public int defensive;

        public int Hp { get => hp; set => hp = (int)MathF.Max(0, value); }

        public Monster(string name, int hp, int damage, int defensive)
        {
            this.name = name;
            this.Hp = hp;
            this.damage = damage;
            this.defensive = defensive;
        }

        public void Damaged(int damage)
        {
            Hp -= damage;
            TextOptions.TextColor(ConsoleColor.Red, name);
            Console.WriteLine($"(이)가 {damage} 만큼의 피해를 입었습니다.");
            Console.WriteLine($"남은 체력 : {Hp}");
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
                player.Damaged(damage - player.defensive);
            }
            else if(player.position == 0)
            {
                player.Damaged(damage);
            }
            else
            {
                Console.WriteLine("-------------------Error-------------------");
            }
        }
    }
}
