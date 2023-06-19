using System;
using System.Threading;

namespace _6equal0
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<3; i++)
            {
            firstQuestion:
                Console.Clear();

                Console.WriteLine("                                                     << 게임 시작 전 콘솔창을 전체화면으로 해 주세요. >>");
                Thread.Sleep(500);

                Console.Write("                                                            << 전체화면으로 해주셨나요?  [");
                Select();
                Console.Write(" >>");

                string yn = Console.ReadLine();
                switch (yn)
                {
                    case "y":
                        break;
                    case "n":
                        goto firstQuestion;
                    default:
                        Console.WriteLine("제대로 된 명령어를 입력 해 주세요.");
                        goto firstQuestion;
                }

            secondQuestion:
                Console.Clear();

                Console.Write("                                                                   << 정말 하셨나요?  [");
                Select();
                Console.Write(" >>");

                yn = Console.ReadLine();
                switch (yn)
                {
                    case "y":
                        gotoMain();
                        break;
                    case "n":
                        goto firstQuestion;
                    default:
                        Console.WriteLine("제대로 된 명령어를 입력 해 주세요.");
                        goto secondQuestion;
                }
            }
            
        }
        static void Select()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("y");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
        }
        static void gotoMain()
        {
            Console.Clear();
            Thread.Sleep(500);
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
            Thread.Sleep(75);
            Console.WriteLine("\n");
            Thread.Sleep(75);
            Console.WriteLine("\n");
            Thread.Sleep(75);
            Console.WriteLine("\n");
            Thread.Sleep(50);
            Console.Write("                                                                     < ");
            Thread.Sleep(50);
            Console.Write("< ");
            Thread.Sleep(50);
            Console.Write("시 ");
            Thread.Sleep(50);
            Console.Write("작 ");
            Thread.Sleep(50);
            Console.Write("하 ");
            Thread.Sleep(50);
            Console.Write("기 ");
            Thread.Sleep(50);
            Console.Write("> ");
            Thread.Sleep(50);
            Console.WriteLine(">\n");
            Thread.Sleep(50);
            Console.Write("                                                                     < ");
            Thread.Sleep(50);
            Console.Write("< ");
            Thread.Sleep(50);
            Console.Write("종 ");
            Thread.Sleep(50);
            Console.Write("료 ");
            Thread.Sleep(50);
            Console.Write("하 ");
            Thread.Sleep(50);
            Console.Write("기 ");
            Thread.Sleep(50);
            Console.Write("> ");
            Thread.Sleep(50);
            Console.WriteLine(">\n\n\n\n");

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
                    Console.WriteLine("제대로 된 명령어를 입력해주세요.");
                    goto command;
            }
        }

        static void Story()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;
            string str = "옛날 옛날 먼 옛날.. 모든 바다 위를 공평하게 약탈한 전설의 해적이 있었따...";
            foreach (char c in str)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine("\n");

            Thread.Sleep(1000);

            str = "그 해적은 바다 위 모든 것을 약탈 한 나머지 약탈 할 것이 아무것도 없었따...";
            foreach (char c in str)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine("\n");

            Thread.Sleep(1000);

            str = "그래서 그는 바다 아래를 약탈하기로 했따...";
            foreach (char c in str)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine("\n");

            Thread.Sleep(1000);

            str = "그리고 그 해적이 바로 당신이다..!";
            foreach (char c in str)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine("\n");
        }
    }
}
