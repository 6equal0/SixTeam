using System;

namespace Chumma
{
 

    class Program
    {
        static int[] SelectPlayer = new int[3];

        public static void Main(string[] args)
        {
            Select_Player();
        }

        public static void Select_Player()
        {
            Hope hope = new Hope();
            Console.WriteLine("캐릭터를 선택하세요!\n");
            hope.Welcome();
            Console.WriteLine("\n캐릭터의 번호를 입력해주세요!");

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
                                Console.WriteLine("이미 선택한 캐릭터입니다!");
                            }
                            else
                            {
                                Console.WriteLine($"{hope.name[char_num - 1]}를 선택하셨습니다!");
                                SelectPlayer[i] = char_num;
                                i++;
                                isValidInput = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("그는 아직 술집에 오지 않았습니다");
                        }
                    }
                    else
                    {
                        Console.WriteLine("범위 안에 숫자를 입력해주세요!(1~21)");
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
                    return true; ; ; ; ;; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;
                }
            }

            return false;
        }
    }
}
