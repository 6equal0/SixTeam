﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SixTeam
{
    class Player
    {
        public static List<Player> players = new List<Player>();
        public static List<Player> unequipPlayers = new List<Player>();
        public static List<Player> frontPlayers = new List<Player>();
        public static List<Player> backPlayers = new List<Player>();

        public static int AttackNum { get; set; }
        public static int primaryKey = 1;

        public int prikey;
        public string name;
        public delegate void ActiveSkill(string name);
        public int defHp;
        internal int hp;
        public int defPower;
        internal int power;
        public int plusPower = 0;
        public int defensive;
        public int position = -1;
        internal bool isAttack = false;
        public bool skillable = true;
        public bool isInv = false;
        public int invTurn;
        public int boomTurn = -1;
        public bool die = false;

        private Action<Player> activeSkill;

        private Random rand = new Random();

        public int Hp { get => hp; set => hp = (int)MathF.Max(0, value); }

        public Player(string name, int hp, int power, int defensive)
        {
            this.name = name;
            defHp = hp;
            defPower = power;
            this.defensive = defensive;

            unequipPlayers.Add(this);

            this.hp = defHp;
            this.power = defPower;

            prikey = primaryKey;
            primaryKey++;

            activeSkill = Skills.Skilll(name);
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
                if(pos == 0)
                {
                    if (frontPlayers.Contains(this))
                        frontPlayers.Remove(this);

                    position = pos;
                    backPlayers.Add(this);
                }
                else if (pos == 1)
                {
                    if (backPlayers.Contains(this))
                        backPlayers.Remove(this);

                    position = pos;
                    frontPlayers.Add(this);
                }

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

                monster.Damaged(power + plusPower);
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

        public void Skill()
        {
            if (skillable)
            {
                activeSkill(this);

                skillable = false;
            }
            else
            {
                Console.WriteLine("이미 스킬을 사용하였습니다.");
            }
        }

        public void Damaged(int damage)
        {
            if(!isInv)
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

        public void TurnEnd()
        {
            if(boomTurn == Cmd.turn)
            {
                TextOptions.TextColor(ConsoleColor.Green, name);
                Console.WriteLine("는 폭발합니다.");

                if(Monster.monsters.Count != 0)
                    Monster.monsters[rand.Next(0, Monster.monsters.Count)].Die();
                Die();
            }
            else if (invTurn == Cmd.turn)
            {
                isInv = false;
            }

            ResetAttack();
        }

        public void Die()
        {
            TextOptions.TextColor(ConsoleColor.Green, name);
            Console.WriteLine($"(이)가 사망했습니다.\n");
            Player.unequipPlayers.Remove(this);
            die = true;

            Pop();
        }

        public void Reset()
        {
            hp = defHp;
            power = defPower;
            plusPower = 0;
            boomTurn = -1;
            skillable = true;
            position = -1;
        }

        public void ShowStatus()
        {
            Console.WriteLine("------------------------------------");
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
            if (activeSkill != Skills.Default)
            {
                TextOptions.TextColor(ConsoleColor.Cyan, "스킬 : ");
                Console.WriteLine(ShowSkill(name));
            }
            Console.WriteLine("------------------------------------");
        }

        public string ShowSkill(string name)
        {
            switch (name)
            {
                case "강윤구":
                    return "2명에게 1.2배로 공격";
                case "권도현":
                    return "적 전체 1턴동안 스턴";
                case "김준표":
                    return "3턴 뒤 자폭하며 적 1명을 데려감";
                case "박영준":
                    return "팀원의 체력을 4 회복";
                case "오윤성":
                    return "2턴동안 무적";
                case "이지우":
                    return "공격력을 모두 소진하여 체력에 더함";
                case "최강호":
                    return "체력을 2 소모하여 공격력 3 상승";
                case "홍상화":
                    return "체력을 2 회복하고 1턴동안 무적";
            }

            return "";
        }

        public void Push()
        {
            players.Add(this);
        }

        public void Pop()
        {
            if (frontPlayers.Contains(this))
                frontPlayers.Remove(this);
            else if (backPlayers.Contains(this))
                backPlayers.Remove(this);

            players.Remove(this);
        }
    }
}
