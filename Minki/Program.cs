using System;
using System.Collections.Generic;

namespace Minki
{
    class Program
    {
        /*static Monster a = new Monster("유근영", 15, 5);
        static Monster b = new Monster("치른영", 15, 5);
        static Monster c = new Monster("파른영", 15, 5);*/

        static Monster bosstest = new Monster("보스", 30, 5, true);

        static Player player1 = new Player("일지우", 10, 10, 5);
        static Player player2 = new Player("이지우", 10, 10, 5);
        static Player player3 = new Player("삼지우", 10, 10, 5);
        static Player player4 = new Player("강윤구", 10, 10, 5);

        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            /*a.ShowStatus();
            b.ShowStatus();
            c.ShowStatus();*/

            bosstest.ShowStatus();

            player1.SetPos(0);
            player2.SetPos(0);
            player3.SetPos(0);
            player4.SetPos(0);

            Cmd.Command();
            Cmd.Command();
            Cmd.Command();
            Cmd.Command();
            Cmd.Command();
            Cmd.Command();
            Cmd.Command();
            Cmd.Command();
            Cmd.Command();
            Cmd.Command();
        }
    }
}
