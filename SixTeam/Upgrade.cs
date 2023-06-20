﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixTeam
{
    class Upgrade
    {
        public static void Enhance(Player player, string stat, int value)
        {
            if (stat == "공격력")
            {
                if (value >= 1 && value <= 5)
                {
                    player.power += value;
                    Console.WriteLine($"{player.name}의 공격력이 {value}만큼 증가했습니다.");
                }
                else
                {
                    Console.WriteLine("잘못된 수치입니다. 1~5의 범위로 강화할 수 있습니다.");
                }
            }
            else if (stat == "방어력")
            {
                if (value >= 1 && value <= 5)
                {
                    player.defensive += value;
                    Console.WriteLine($"{player.name}의 방어력이 {value}만큼 증가했습니다.");
                }
                else
                {
                    Console.WriteLine("잘못된 수치입니다. 1~5의 범위로 강화할 수 있습니다.");
                }
            }
            else if (stat == "체력")
            {
                if (value >= 1 && value <= 5)
                {
                    player.Hp += value;
                    Console.WriteLine($"{player.name}의 체력이 {value}만큼 증가했습니다.");
                }
                else
                {
                    Console.WriteLine("잘못된 수치입니다. 1~5의 범위로 강화할 수 있습니다.");
                }
            }

            Console.WriteLine("\n계속하려면 Enter를 입력해주세요.");
            Console.ReadLine();

            Lobby.LobbyMenu();
        }

        public static void EnchantQ()
        {
            PlayerTask:
            Console.WriteLine("강화할 캐릭터를 선택하세요");
            string pInst = Console.ReadLine();
            if (!Cmd.CheckAllP(pInst))
            {
                Cmd.ErrorMsg("대상전체플");
                Console.Clear();
                goto PlayerTask;
            }

            StatTask:
            Player player = null;
            foreach (Player item in Player.unequipPlayers)
            {
                if (item.name == pInst)
                {
                    player = item;
                    break;
                }
            }
            Console.WriteLine("강화할 스탯을 선택하세요");
            string stat = Console.ReadLine();
            if (stat != "체력" && stat != "공격력" && stat != "방어력")
            {
                Console.WriteLine("잘못된 강화 스탯입니다. 공격력, 방어력, 체력을 강화할 수 있습니다.");
                goto StatTask;
            }

            ValueTask:
            int value = 0;
            Console.WriteLine("증가할 수치를 입력하세요:");
            try
            {
                value = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("올바른 값을 입력하세요.");
                goto ValueTask;
            }

            Enhance(player, stat, value);
        }
    }
}