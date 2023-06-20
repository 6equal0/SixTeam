using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixTeam
{
    class Lobby
    {
        private static int pos = 0;
        public static int Pos
        {
            get
            {
                return pos;
            }
            set
            {
                pos = Math.Clamp(value, 0, 2);
            }
        }

        public static int day = 1;
        static string username;

        public Lobby(string name) => username = name;

        public static void LobbyMenu()
        {
            Console.Clear();

            MainMenu.Texting("\n\n\n\n", 30);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            MainMenu.Texting("【 로 비 】", 30);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            MainMenu.Texting($"{day}일차\n\n\n\n", 30);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            MainMenu.Texting("전설의 해적 ",30);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            MainMenu.Texting(username + "\n\n\n\n\n\n\n",30);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;

            MainMenu.Texting($"< 약 탈 하 러  가 기 >\n\n", 30);
            MainMenu.Texting($"   < 강 화 하 기 >\n\n", 30);
            MainMenu.Texting($"< 메 인 화 면 으 로 >\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n", 30);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 156; i++) Console.Write("-");
            Console.WriteLine("\n W , S / ↑ , ↓ 로  이 동   |   스 페 이 스 바 로  선 택");
            Console.WriteLine("제작 - 6팀 : 강민기, 김준표, 유근영, 정영도");



            pos = 0;
            Sstart();
            while (true)
            {
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        Pos--;
                        if (Pos == 0) Sstart();
                        else if (Pos == 1) GangHwa();
                        break;

                    case ConsoleKey.UpArrow:
                        Pos--;
                        if (Pos == 0) Sstart();
                        else if (Pos == 1) GangHwa();
                        break;

                    case ConsoleKey.S:
                        Pos++;
                        if (Pos == 2) GoMain();
                        else if (Pos == 1) GangHwa();
                        break;

                    case ConsoleKey.DownArrow:
                        Pos++;
                        if (Pos == 2) GoMain();
                        else if (Pos == 1) GangHwa();
                        break;

                    case ConsoleKey.Spacebar:
                        if (Pos == 0) { Console.Clear(); Hope.Select_Player(); }
                        if (Pos == 1) { Console.Clear(); Upgrade.EnchantQ(); }
                        if (Pos == 2) MainMenu.gotoMain();
                        return;

                    default:
                        break;
                }
            }
        }

        public static void Sstart()
        {
            Console.Clear();

            Console.Write("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("【 로 비 】");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{day}일차\n\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("전설의 해적 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(username + "\n\n\n\n\n\n\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write($"< 약 탈 하 러  가 기 >\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($"   < 강 화 하 기 >\n\n");
            Console.Write($"< 메 인 화 면 으 로 >\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 156; i++) Console.Write("-");
            Console.WriteLine("\n W , S / ↑ , ↓ 로  이 동   |   스 페 이 스 바 로  선 택");
            Console.WriteLine("제작 - 6팀 : 강민기, 김준표, 유근영, 정영도");
        }
        public static void GangHwa()
        {
            Console.Clear();

            Console.Write("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("【 로 비 】");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{day}일차\n\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("전설의 해적 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(username + "\n\n\n\n\n\n\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($"< 약 탈 하 러  가 기 >\n\n");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write($"   < 강 화 하 기 >\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($"< 메 인 화 면 으 로 >\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 156; i++) Console.Write("-");
            Console.WriteLine("\n W , S / ↑ , ↓ 로  이 동   |   스 페 이 스 바 로  선 택");
            Console.WriteLine("제작 - 6팀 : 강민기, 김준표, 유근영, 정영도");
        }
        public static void GoMain()
        {
            Console.Clear();

            Console.Write("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("【 로 비 】");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{day}일차\n\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("전설의 해적 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(username + "\n\n\n\n\n\n\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($"< 약 탈 하 러  가 기 >\n\n");

            Console.Write($"   < 강 화 하 기 >\n\n");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write($"< 메 인 화 면 으 로 >\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 156; i++) Console.Write("-");
            Console.WriteLine("\n W , S / ↑ , ↓ 로  이 동   |   스 페 이 스 바 로  선 택");
            Console.WriteLine("제작 - 6팀 : 강민기, 김준표, 유근영, 정영도");
        }
    }
}
