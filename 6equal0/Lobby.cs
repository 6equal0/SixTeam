using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6equal0
{
    class Lobby
    {
        int day = 1;
        string username;

        public Lobby(string name) => username = name;

        public void LobbyMenu()
        {

            Console.Clear();

            MainMenu.Texting("\n\n\n\n", 40);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            MainMenu.Texting("【 로 비 】", 40);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            MainMenu.Texting($"{day}일차\n\n\n", 40);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            MainMenu.Texting("전설의 해적 ",40);
            MainMenu.Texting(username+"\n\n\n\n\n\n", 40);
            Console.ForegroundColor = ConsoleColor.Gray;

            MainMenu.Texting($"< 탐 험 시 작 >\n\n", 40);
            MainMenu.Texting($"< 강 화 >\n\n", 40);
            MainMenu.Texting($"< 동 료 모 집 >\n\n", 40);
            MainMenu.Texting($"< 동 료 모 집 >\n\n", 40);
            MainMenu.Texting($"< 나 가 기 >\n\n\n\n\n", 40);


            cmd:
            string asdf = Console.ReadLine();
            switch (asdf)
            {
                case "/탐험시작":
                    Console.WriteLine("여기에 탐험 코드 입력");
                    break;
                case "/강화":
                    Console.WriteLine("여기에 강화 코드 입력");
                    break;
                case "/동료모집":
                    Console.WriteLine("여기에 모집 코드 입력");
                    break;
                case "/나가기":
                    Console.WriteLine("여기에 나가는 코드 입력");
                    break;
                default:
                    MainMenu.Texting("올바른 명령어를 입력 해 주세요.", 40);
                    goto cmd;
                    
            }
        }
    }
}
