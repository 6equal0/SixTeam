using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace SixTeam
{
    class Hope
    {
        static int[] SelectPlayer = new int[3];
        public int playerCount;
        private int i;
        public List<int> player_number = new List<int>();
        Random rand = new Random();
        public string[] name = { "강민기", "강윤구","권도현", "김대현", "김민재", "김아윤",
                                "김준표", "김진현", "노병민",
                                "박영준", "심하나", "오윤성", "유근영", "윤서진",
                                "이승준", "이정빈", "이지우", "장서윤", "정영도", "최강호","홍상화"};
        public void Welcome()
        {
            Console.ResetColor();

            HashSet<int> playerCounts = new HashSet<int>();
            while (playerCounts.Count < 5)
            {
                i++;
                playerCount = rand.Next(1, 22);
                playerCounts.Add(playerCount);
            }
            foreach (var item in playerCounts)
            {
                Player player = null;

                foreach(Player ply in Player.unequipPlayers)
                {
                    if(item == ply.prikey)
                    {
                        player = ply;
                        break;
                    }
                }

                player_number.Add(item);

                MainMenu.Texting($"[{item}]{name[item - 1]:D2} 체력: {player.hp} | 공격력: {player.power} | 방어력: {player.defensive} {(player.ShowSkill(player.name) == "" ? "" : $"스킬: {player.ShowSkill(player.name)}")}\n", 10);
            }
        }

        public static void Select_Player()
        {
            Hope hope = new Hope();
            MainMenu.Texting("캐릭터를 선택하세요!\n\n", 20);
            hope.Welcome();
            MainMenu.Texting("\n\n캐릭터의 번호를 입력해주세요!\n\n", 20);

            for (int i = 0; i < 3;)
            {
                int char_num;
                bool isValidInput = false;

                while (!isValidInput)
                {
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out char_num))
                    {
                        if (hope.player_number.Contains(char_num))
                        {
                            if (IsCharacterSelected(char_num))
                            {
                                MainMenu.Texting("이미 선택한 캐릭터입니다!\n", 10);
                            }
                            else
                            {
                                MainMenu.Texting($"{hope.name[char_num - 1]}를 선택하셨습니다!\n\n", 10);
                                SelectPlayer[i] = char_num;
                                i++;
                                isValidInput = true;
                            }
                        }
                        else
                        {
                            MainMenu.Texting("그는 아직 술집에 오지 않았습니다\n\n", 10);
                        }
                    }
                    else
                    {
                        MainMenu.Texting("범위 안에 숫자를 입력해주세요!(1~21)\n\n", 10);
                    }
                }
        }

            foreach (Player item in Player.unequipPlayers)
            {
                if (item.prikey == SelectPlayer[0] || item.prikey == SelectPlayer[1] || item.prikey == SelectPlayer[2])
                    item.Push();
            }

            Console.WriteLine();
            if (Player.players.Count == 3)
                Console.WriteLine("\n\n모두 무사히 합류했습니다.\n");
            else
            {
                Console.WriteLine(Player.players.Count);

                foreach(Player item in Player.players)
                {
                    Console.WriteLine(item.name);
                }

                Console.WriteLine("Error");
            }

            Thread.Sleep(1200);
            Console.ForegroundColor = ConsoleColor.White;
            SelectPlayer = new int[3];
            Cmd.batComplete = false;
            Console.WriteLine("배치를 시작합니다.\n");
            Cmd.stage = 1;
            Cmd.BatchCmd();
        }

        public static bool IsCharacterSelected(int characterNumber)
        {
            foreach (int selectedCharacter in SelectPlayer)
            {
                if (selectedCharacter == characterNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

