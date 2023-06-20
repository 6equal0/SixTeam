using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6equal0
{
    class Hope22222
    {
        public int playerCount;

        public List<int> player_number = new List<int>();
        Random rand = new Random();
        public string[] name = { "강민기", "강윤구","권도현", "김대현", "김민재", "김아윤",
                                "김준표", "김진현", "노병민",
                                "박영준", "심하나", "오윤성", "유근영", "윤서진",
                                "이승준", "이정빈", "이지우", "장서윤", "정영도", "최강호","홍상화"};
        public void Welcome()
        {
            HashSet<int> playerCounts = new HashSet<int>();
            while (playerCounts.Count < 5)
            {

                playerCount = rand.Next(1, 22);
                playerCounts.Add(playerCount);
            }
            foreach (var item in playerCounts)
            {
                player_number.Add(item);
            }
            foreach (int playerCount in playerCounts)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                MainMenu.Texting($"[{playerCount}]{name[playerCount - 1]}\n\n",20);
                Console.ResetColor();
            }
        }
    }
}
