using System;
using System.Collections.Generic;

namespace Minki
{
    class Program
    {
        static Monster a = new Monster("유근영", 15, 5);
        static Monster b = new Monster("치른영", 15, 5);
        static Monster c = new Monster("파른영", 15, 5);

        static Player player1 = new Player("일지우", 10, 10, 5);
        static Player player2 = new Player("이지우", 10, 10, 5);
        static Player player3 = new Player("삼지우", 10, 10, 5);

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            a.ShowStatus();
            Console.WriteLine("-------------------------");
            b.ShowStatus();
            Console.WriteLine("-------------------------");
            c.ShowStatus();
            Console.WriteLine("-------------------------");

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
