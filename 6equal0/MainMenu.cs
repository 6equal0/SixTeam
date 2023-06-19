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
        public static void beepStart()
        {
            while (true)
            {
                Console.Beep();
                Thread.Sleep(100);
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("/");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("n");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
                Thread.Sleep(time);
            }
        public static void Texting(string text, int time)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(time);
                }
            }
        public static void Question()
        {
        Console.ForegroundColor = ConsoleColor.White;

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
        static void gotoMain()
        {
            //Thread beepMusic = new Thread(() => beepStart());
            //beepMusic.Start();

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

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\n\n\n");
            Empty(69);
            Texting("< < 시 작 하 기 > >", 40);
            Console.Write("\n\n");
            Empty(69);
            Texting("< < 종 료 하 기 > >\n\n\n\n\n\n", 40);
            for (int i = 0; i < 156; i++) Console.Write("-");
            Console.WriteLine("\n W , S / ↑ , ↓ 로  이 동   |   스 페 이 스 바 로  선 택");
            Console.WriteLine("제작 - 6팀 : 강민기, 김준표, 유근영, 정영도");

            bool sijakhagi = true;

            Sijak();
            while (true)
            {
                bool STTTTOOOP = false;
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        Sijak();
                        sijakhagi = true;
                        break;
                    case ConsoleKey.UpArrow:
                        Sijak();
                        sijakhagi = true;
                        break;
                    case ConsoleKey.S:
                        Nagagi();
                        sijakhagi = false;
                        break;
                    case ConsoleKey.DownArrow:
                        Nagagi();
                        sijakhagi = false;
                        break;
                    case ConsoleKey.Spacebar:
                        if (!sijakhagi)
                        {
                            Environment.Exit(0);
                            return;
                        }
                        STTTTOOOP = true;
                        break;
                    default:
                        break;
                }

                if (STTTTOOOP) break;
            }

            Story();
        }
        static void Sijak()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("                             -====*~               .*=;-.              .;=!~.                ~=*:,               :=*:,   -*====- ");
            Console.WriteLine("                             :@@@@;            ,!!~, !@@:                :@@;            :!;-.,$@=,               ,#@#.  .;@@@@~ ");
            Console.WriteLine("                             :@@@=.      ,::-.  ,=@#.-@@.           .    ,$@-      ~:~,   :@@=.!@!    ~,,,--:*:.   =@=    ,*@@@~ ");
            Console.WriteLine("                             :@@#:        ;@#-   !@$.,@#.   ,-,,,,-~!-   ,$@-      ,=@!.   @@; !@!    ;#####@@#:   =@*     :#@@~ ");
            Console.WriteLine("                             :@@$,   ..   -@$..,.!@=.,@#.   -=$=$$$@@$,  ,$@-  -.  .!@;.,, @@: !@!     ;;:~:$@=-   =@*     ,=@@~ ");
            Console.WriteLine("                             :@@*    ,;!;;*@#!*=;!@=.,@#.    ~*;;:;@@=.  ,$@-  :!;;!$@=!*=.@@: !@!         ;@#;~~~~$@*      !@@~ ");
            Console.WriteLine("                             :@#:     !#$=**!!!=!=@=.,@#.     .   ;@#~   ,$@-  .$#$=**!!*=~@@: !@!        ~#@;,;$$$@@*      :#@~ ");
            Console.WriteLine("                             :@#-     .--,::,..,,*@=.,@#.        -@@!-;;;*#@-   ,-,-:-,..,,@@: !@!       ,$@#!,,:~~$@*      ~#@~ ");
            Console.WriteLine("                             :@#,       .*$$**:  !@#;!@#.       .=@$,,=###@@-     -=$=**,  @@*;$@!      .=@*;$=!,  =@*      -$@~ ");
            Console.WriteLine("                             :@$.       *@#*;*#: !@@#@@#.       !@@#! -~,~$@-    ,#@$!;$$, @@@#@@!     .=@;. ;##~  =@*      ,$@~ ");
            Console.WriteLine("                             :@$.      ~#@,  -#$-!@$,~@#.      ;@@,;@$~  ,$@-    *@=.  !@: @@;,*@!    ,$@-    !@:  =@:      .=@~ ");
            Console.WriteLine("                             :@$.      :@$   -$#~!@=.,@#.     ~#@,  !@$~ ,$@-    $@;   !@! @@: !@!   ,#!.     -*-  =:       .=@~ ");
            Console.WriteLine("                             :@$.      ~@#   ~@$-!@=.,@#.    ~$#,   .$#: ,$@-    =@*   *@: @@: !@!  ;!.       ..   -        ,$@~ ");
            Console.WriteLine("                             :@#,      .$@$~:#@; !@=.,@#.   ~=!.     -#; ,$@-    -@@*~*@#, @@: !@!       ;;:~~::;!=@#-      -$@~ ");
            Console.WriteLine("                             :@#~       ,$###$!. !@=.,@#.  -;-       ,;  ,$@-     :$###$-  @@: !@!        *##$$$$$$@@:      ~#@~ ");
            Console.WriteLine("                             :@@;         -::,   !@=.,@#.  .             ,$@-      .~:-.   @@: !@!        .:,..   .#@-      ;@@~ ");
            Console.WriteLine("                             :@@*                !@! ,@#.                ,$@-              @@- !@!                .#@-      *@@~ ");
            Console.WriteLine("                             :@@$,               ;$- ,@#                 ,$#,              @*  !@;                .#@-     -$@@~ ");
            Console.WriteLine("                             :@@@;               ;;. ,@;                 ,=;.              #,  ;$-                .#@-     ;@@@~ ");
            Console.WriteLine("                             :@@@$-              ~,  ,#.                 .!-               *   :!                 .#*.    -$@@@~ ");
            Console.WriteLine("                             :@@@@*,             .   .*                  .~.               ,   -~                 .=.    ,*@@@@~ ");
            Console.WriteLine("                             ,::::~,                  ,                                                            ,     .~::::. ");

            Console.Write("\n\n\n");
            Empty(69);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("< < 시 작 하 기 > >");
            Console.ResetColor();
            Console.Write("\n");
            Empty(69);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("< < 종 료 하 기 > >\n\n\n\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 156; i++) Console.Write("-");
            Console.WriteLine("\n W , S / ↑ , ↓ 로  이 동   |   스 페 이 스 바 로  선 택");
            Console.WriteLine("제작 - 6팀 : 강민기, 김준표, 유근영, 정영도");
        }
        static void Nagagi()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("                             -====*~               .*=;-.              .;=!~.                ~=*:,               :=*:,   -*====- ");
            Console.WriteLine("                             :@@@@;            ,!!~, !@@:                :@@;            :!;-.,$@=,               ,#@#.  .;@@@@~ ");
            Console.WriteLine("                             :@@@=.      ,::-.  ,=@#.-@@.           .    ,$@-      ~:~,   :@@=.!@!    ~,,,--:*:.   =@=    ,*@@@~ ");
            Console.WriteLine("                             :@@#:        ;@#-   !@$.,@#.   ,-,,,,-~!-   ,$@-      ,=@!.   @@; !@!    ;#####@@#:   =@*     :#@@~ ");
            Console.WriteLine("                             :@@$,   ..   -@$..,.!@=.,@#.   -=$=$$$@@$,  ,$@-  -.  .!@;.,, @@: !@!     ;;:~:$@=-   =@*     ,=@@~ ");
            Console.WriteLine("                             :@@*    ,;!;;*@#!*=;!@=.,@#.    ~*;;:;@@=.  ,$@-  :!;;!$@=!*=.@@: !@!         ;@#;~~~~$@*      !@@~ ");
            Console.WriteLine("                             :@#:     !#$=**!!!=!=@=.,@#.     .   ;@#~   ,$@-  .$#$=**!!*=~@@: !@!        ~#@;,;$$$@@*      :#@~ ");
            Console.WriteLine("                             :@#-     .--,::,..,,*@=.,@#.        -@@!-;;;*#@-   ,-,-:-,..,,@@: !@!       ,$@#!,,:~~$@*      ~#@~ ");
            Console.WriteLine("                             :@#,       .*$$**:  !@#;!@#.       .=@$,,=###@@-     -=$=**,  @@*;$@!      .=@*;$=!,  =@*      -$@~ ");
            Console.WriteLine("                             :@$.       *@#*;*#: !@@#@@#.       !@@#! -~,~$@-    ,#@$!;$$, @@@#@@!     .=@;. ;##~  =@*      ,$@~ ");
            Console.WriteLine("                             :@$.      ~#@,  -#$-!@$,~@#.      ;@@,;@$~  ,$@-    *@=.  !@: @@;,*@!    ,$@-    !@:  =@:      .=@~ ");
            Console.WriteLine("                             :@$.      :@$   -$#~!@=.,@#.     ~#@,  !@$~ ,$@-    $@;   !@! @@: !@!   ,#!.     -*-  =:       .=@~ ");
            Console.WriteLine("                             :@$.      ~@#   ~@$-!@=.,@#.    ~$#,   .$#: ,$@-    =@*   *@: @@: !@!  ;!.       ..   -        ,$@~ ");
            Console.WriteLine("                             :@#,      .$@$~:#@; !@=.,@#.   ~=!.     -#; ,$@-    -@@*~*@#, @@: !@!       ;;:~~::;!=@#-      -$@~ ");
            Console.WriteLine("                             :@#~       ,$###$!. !@=.,@#.  -;-       ,;  ,$@-     :$###$-  @@: !@!        *##$$$$$$@@:      ~#@~ ");
            Console.WriteLine("                             :@@;         -::,   !@=.,@#.  .             ,$@-      .~:-.   @@: !@!        .:,..   .#@-      ;@@~ ");
            Console.WriteLine("                             :@@*                !@! ,@#.                ,$@-              @@- !@!                .#@-      *@@~ ");
            Console.WriteLine("                             :@@$,               ;$- ,@#                 ,$#,              @*  !@;                .#@-     -$@@~ ");
            Console.WriteLine("                             :@@@;               ;;. ,@;                 ,=;.              #,  ;$-                .#@-     ;@@@~ ");
            Console.WriteLine("                             :@@@$-              ~,  ,#.                 .!-               *   :!                 .#*.    -$@@@~ ");
            Console.WriteLine("                             :@@@@*,             .   .*                  .~.               ,   -~                 .=.    ,*@@@@~ ");
            Console.WriteLine("                             ,::::~,                  ,                                                            ,     .~::::. ");

            Console.Write("\n\n\n");
            Empty(69);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("< < 시 작 하 기 > >");
            Console.Write("\n");
            Empty(69);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("< < 종 료 하 기 > >\n\n\n\n\n\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 156; i++) Console.Write("-");
            Console.WriteLine("\n W , S / ↑ , ↓ 로  이 동   |   스 페 이 스 바 로  선 택");
            Console.WriteLine("제작 - 6팀 : 강민기, 김준표, 유근영, 정영도");
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

                Thread.Sleep(500);

                Lobby lob = new Lobby(name);
                lob.LobbyMenu();
            }
        }
    }
