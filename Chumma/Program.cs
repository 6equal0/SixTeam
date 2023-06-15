using System;

namespace Chumma
{
    class Program
    {
        public static void Main(string[] args)
        {

            Hope hope = new Hope();
            Console.WriteLine("캐릭터를 선택하세요!\n");
            hope.Welcome();
            Console.WriteLine("\n캐릭터의 번호를 입력해주세요!");


            for (int i = 0; i <= 1;)
            {
                int char_num = int.Parse(Console.ReadLine());
                if (char_num != hope.player_number[i])
                {
                    Console.WriteLine("똑바로 입력하세요");
                }

                else
                {
                    if (char_num >= 22)
                    {

                        Console.WriteLine("똑바로 입력하세요");
                    }
                    else
                    {
                        Console.WriteLine($"{hope.name[char_num - 1]}를 선택 하셨습니다!");
                        i++;
                    }
                }  
            }
        }
    }
}

