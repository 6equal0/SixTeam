using System;
using System.Threading;

namespace _6equal0
{
    class Program
    {
        public void Main(string[] args)
        {
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("                                                     << 게임 시작 전 콘솔창을 전체화면으로 해 주세요. >>");
                Thread.Sleep(500);
                Console.Clear();
                Thread.Sleep(500);

                gotoMain();
            }
            
        }
        public void gotoMain()
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
                    Console.WriteLine("여기에 시작하는 코드 입력");
                    break;
                case "/종료하기":
                    Console.WriteLine("여기에 종료하는 코드 입력");
                    break;
                default:
                    Console.WriteLine("제대로 된 명령어를 입력해주세요.");
                    goto command;
            }
        }
    }
}
