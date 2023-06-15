using System;

namespace Chumma
{
    class Program
    {
        static int checkPlayer;

        public static void Main(string[] args)
        {
            Hope hope = new Hope();
            Console.WriteLine("캐릭터를 선택하세요!\n");
            hope.Welcome();
            Console.WriteLine("\n캐릭터의 번호를 입력해주세요!");

            for (int i = 0; i <= 1;)
            {
                int char_num = int.Parse(Console.ReadLine());

                if (!hope.player_number.Contains(char_num))
                {
                    Console.WriteLine("그는 아직 술집에 오지 않았습니다");
                }
                else
                {
                    if (char_num == checkPlayer)
                    {
                        Console.WriteLine("이미 선택한 캐릭터 입니다!");
                    }
                    else
                    {
                        if (char_num >= 22)
                        {
                            Console.WriteLine("그런 번호의 캐릭터는 존재 하지 않아요..");
                        }
                        else
                        {
                            Console.WriteLine($"{hope.name[char_num - 1]}를 선택 하셨습니다!");
                            checkPlayer = char_num;
                            i++;
                        }

                    }
                } 
            }
        }
    }
}
