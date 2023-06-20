using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6equal0
{
    class Chunma222222222
    {
        static int[] SelectPlayer = new int[3];

        public static void Main(string[] args)
        {
            Select_Player();
        }

        public static void Select_Player()
        {
            Hope22222 hope = new Hope22222();
            MainMenu.Texting("캐릭터를 선택하세요!\n\n",20);
            hope.Welcome();
            MainMenu.Texting("\n\n캐릭터의 번호를 입력해주세요!\n\n",20);

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
                                MainMenu.Texting("이미 선택한 캐릭터입니다!\n",10);
                            }
                            else
                            {
                                MainMenu.Texting($"{hope.name[char_num - 1]}를 선택하셨습니다!\n\n",10);
                                SelectPlayer[i] = char_num;
                                i++;
                                isValidInput = true;
                            }
                        }
                        else
                        {
                            MainMenu.Texting("그는 아직 술집에 오지 않았습니다\n\n",10);
                        }
                    }
                    else
                    {
                        MainMenu.Texting("범위 안에 숫자를 입력해주세요!(1~21)\n\n",10);
                    }
                }
            }
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
