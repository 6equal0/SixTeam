using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6equal0
{
    class Lobby
    {
        private int pos = 0;
        public int Pos
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            MainMenu.Texting(username + "\n\n\n\n\n\n",40);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;

            MainMenu.Texting($"< 약 탈 하 러  가 기 >\n\n", 40);
            MainMenu.Texting($"< 강 화 하 기 >\n\n", 40);
            MainMenu.Texting($"< 메 인 화 면 으 로 >\n\n\n\n\n\n", 40);

            Console.ForegroundColor = ConsoleColor.DarkGray;
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
                        pos--;
                        if (Pos == 0) Sstart();
                        else if (Pos == 1) GangHwa();
                        break;

                    case ConsoleKey.UpArrow:
                        pos--;
                        if (Pos == 0) Sstart();
                        else if (Pos == 1) GangHwa();
                        break;

                    case ConsoleKey.S:
                        pos++;
                        if (Pos == 2) GoMain();
                        else if (Pos == 1) GangHwa();
                        break;

                    case ConsoleKey.DownArrow:
                        pos++;
                        if (Pos == 2) GoMain();
                        else if (Pos == 1) GangHwa();
                        break;

                    case ConsoleKey.Spacebar:
                        if (Pos == 0) Console.WriteLine("약탈코드");
                        if (Pos == 1) Console.WriteLine("강화코드");
                        if (Pos == 2) Console.WriteLine("나감코드");
                        return;

                    default:
                        break;
                }
            }
        }

        public void Sstart()
        {
            Console.Clear();

            Console.Write("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("【 로 비 】");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{day}일차\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("전설의 해적  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(username + "\n\n\n\n\n\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine($"< 약 탈 하 러  가 기 >\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"< 강 화 하 기 >\n\n");
            Console.WriteLine($"< 메 인 화 면 으 로 >\n\n\n\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n W , S / ↑ , ↓ 로  이 동   |   스 페 이 스 바 로  선 택");
            Console.WriteLine("제작 - 6팀 : 강민기, 김준표, 유근영, 정영도");
        }
        public void GangHwa()
        {
            Console.Clear();

            Console.WriteLine("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("【 로 비 】");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{day}일차\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("전설의 해적  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(username + "\n\n\n\n\n\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"< 약 탈 하 러  가 기 >\n\n");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine($"< 강 화 하 기 >\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"< 메 인 화 면 으 로 >\n\n\n\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n W , S / ↑ , ↓ 로  이 동   |   스 페 이 스 바 로  선 택");
            Console.WriteLine("제작 - 6팀 : 강민기, 김준표, 유근영, 정영도");
        }
        public void GoMain()
        {
            Console.Clear();

            Console.WriteLine("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("【 로 비 】");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{day}일차\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("전설의 해적  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(username + "\n\n\n\n\n\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"< 약 탈 하 러  가 기 >\n\n");

            Console.WriteLine($"< 강 화 하 기 >\n\n");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine($"< 메 인 화 면 으 로 >\n\n\n\n\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n W , S / ↑ , ↓ 로  이 동   |   스 페 이 스 바 로  선 택");
            Console.WriteLine("제작 - 6팀 : 강민기, 김준표, 유근영, 정영도");
        }
    }
}
