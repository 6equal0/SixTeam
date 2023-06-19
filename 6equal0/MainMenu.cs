using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6equal0
{
    class MainMenu
    {
        public static void Question()
        {
        firstQuestion:
            Console.Clear();

            Empty(52);
            Texting("<< 게임 시작 전 콘솔창을 전체화면으로 해 주세요. >>\n", 40);
            Thread.Sleep(50);

            Empty(59);
            Texting("<< 전체화면으로 해주셨나요?  [", 40);
            Select(40);
            Texting(" >>\n", 50);

            string yn = Console.ReadLine();
            switch (yn)
            {
                case "y":
                    break;
                case "n":
                    goto firstQuestion;
                default:
                    Empty(62);
                    Texting("올바른 명령어를 입력 해 주세요.", 40);
                    Thread.Sleep(100);
                    goto firstQuestion;
            }

        secondQuestion:
            Console.Clear();

            Empty(64);
            Texting("<< 정말 하셨나요?  [", 40);
            Select(40);
            Texting(" >>\n", 40);

            yn = Console.ReadLine();
            switch (yn)
            {
                case "y":
                    gotoMain();
                    break;
                case "n":
                    goto firstQuestion;
                default:
                    Empty(62);
                    Texting("올바른 명령어를 입력 해 주세요.", 40);
                    Thread.Sleep(100);
                    goto secondQuestion;
            }
        }
        static void Empty(int count)
            {
                for (int i = 0; i < count; i++) Console.Write(" ");
            }
        static void Select(int time)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("y");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("/");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("n");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("]");
                Thread.Sleep(time);
            }
        static void gotoMain()
            {
                Console.Clear();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine("                             -====*~               .*=;-.              .;=!~.                ~=*:,               :=*:,   -*====- ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@@@;            ,!!~, !@@:                :@@;            :!;-.,$@=,               ,#@#.  .;@@@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@@=.      ,::-.  ,=@#.-@@.           .    ,$@-      ~:~,   :@@=.!@!    ~,,,--:*:.   =@=    ,*@@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@#:        ;@#-   !@$.,@#.   ,-,,,,-~!-   ,$@-      ,=@!.   @@; !@!    ;#####@@#:   =@*     :#@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@$,   ..   -@$..,.!@=.,@#.   -=$=$$$@@$,  ,$@-  -.  .!@;.,, @@: !@!     ;;:~:$@=-   =@*     ,=@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@*    ,;!;;*@#!*=;!@=.,@#.    ~*;;:;@@=.  ,$@-  :!;;!$@=!*=.@@: !@!         ;@#;~~~~$@*      !@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@#:     !#$=**!!!=!=@=.,@#.     .   ;@#~   ,$@-  .$#$=**!!*=~@@: !@!        ~#@;,;$$$@@*      :#@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@#-     .--,::,..,,*@=.,@#.        -@@!-;;;*#@-   ,-,-:-,..,,@@: !@!       ,$@#!,,:~~$@*      ~#@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@#,       .*$$**:  !@#;!@#.       .=@$,,=###@@-     -=$=**,  @@*;$@!      .=@*;$=!,  =@*      -$@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@$.       *@#*;*#: !@@#@@#.       !@@#! -~,~$@-    ,#@$!;$$, @@@#@@!     .=@;. ;##~  =@*      ,$@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@$.      ~#@,  -#$-!@$,~@#.      ;@@,;@$~  ,$@-    *@=.  !@: @@;,*@!    ,$@-    !@:  =@:      .=@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@$.      :@$   -$#~!@=.,@#.     ~#@,  !@$~ ,$@-    $@;   !@! @@: !@!   ,#!.     -*-  =:       .=@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@$.      ~@#   ~@$-!@=.,@#.    ~$#,   .$#: ,$@-    =@*   *@: @@: !@!  ;!.       ..   -        ,$@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@#,      .$@$~:#@; !@=.,@#.   ~=!.     -#; ,$@-    -@@*~*@#, @@: !@!       ;;:~~::;!=@#-      -$@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@#~       ,$###$!. !@=.,@#.  -;-       ,;  ,$@-     :$###$-  @@: !@!        *##$$$$$$@@:      ~#@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@;         -::,   !@=.,@#.  .             ,$@-      .~:-.   @@: !@!        .:,..   .#@-      ;@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@*                !@! ,@#.                ,$@-              @@- !@!                .#@-      *@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@$,               ;$- ,@#                 ,$#,              @*  !@;                .#@-     -$@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@@;               ;;. ,@;                 ,=;.              #,  ;$-                .#@-     ;@@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@@$-              ~,  ,#.                 .!-               *   :!                 .#*.    -$@@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             :@@@@*,             .   .*                  .~.               ,   -~                 .=.    ,*@@@@~ ");
                Thread.Sleep(75);
                Console.WriteLine("                             ,::::~,                  ,                                                            ,     .~::::. ");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("\n\n\n");
                Empty(69);
                Texting("< < 시 작 하 기 > >", 50);
                Console.Write("\n\n");
                Empty(69);
                Texting("< < 종 료 하 기 > >\n\n\n\n", 50);

            command:

                string startDisplay = Console.ReadLine();
                switch (startDisplay)
                {
                    case "/시작하기":
                        Story();
                        break;
                    case "/종료하기":
                        Console.WriteLine("여기에 종료하는 코드 입력");
                        break;
                    default:
                        Texting("올바른 명령어를 입력 해 주세요.", 40);
                        goto command;
                }
            }
        public static void Texting(string text, int time)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(time);
                }
            }
        static void Story()
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Gray;
                Texting("옛날 옛날 먼 옛날.. 모든 바다 위를 공평하게 약탈한 전설의 해적이 있었다...\n\n", 40);
                Thread.Sleep(1500);

                Texting("그 해적은 바다 위 모든 것을 약탈 한 나머지 약탈 할 것이 아무것도 없었다...\n\n", 40);
                Thread.Sleep(1500);

                Texting("그래서 그는 바다 아래를 약탈하기로 했다...\n\n", 40);
                Thread.Sleep(1500);

                Texting("그렇다..\n\n", 40);
                Thread.Sleep(1500);

                Texting("당신이 바로 그 전설의 해적이었던 것이다!!\n\n", 40);
                Thread.Sleep(1500);

                Texting("바다 아래에 공포를 퍼뜨릴 당신의 이름은..?\n\n\n\n\n\n", 40);

                string name = "";
                while (name == "")
                    name = Console.ReadLine();

                Thread.Sleep(1000);

                Lobby lob = new Lobby(name);
                lob.LobbyMenu();
            }
        }
    }
