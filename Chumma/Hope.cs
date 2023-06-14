using System;
using System.Collections.Generic;

namespace Chumma
{
    class Hope
    {
        
        Random rand = new Random();
        public void Welcome()
        {
            HashSet<int> playerCounts = new HashSet<int>();

            while (playerCounts.Count < 3)
            {
                int playerCount = rand.Next(1, 22);
                playerCounts.Add(playerCount);
            }

            foreach (int playerCount in playerCounts)
            {
                Console.WriteLine(playerCount);
            }
            switch (playerCounts)
            {
                case 1:
                    Console.WriteLine("강민기");
                    break;
                case 2:
                    Console.WriteLine("강윤구");
                    break;
                case 3:
                    Console.WriteLine("권도현");
                    break;
                case 4:
                    Console.WriteLine("김대현");
                    break;
                case 5:
                    Console.WriteLine("김민재");
                    break;
                case 6:
                    Console.WriteLine("김아윤");
                    break;
                case 7:
                    Console.WriteLine("김준표");
                    break;
                case 8:
                    Console.WriteLine("김진현");
                    break;
                case 9:
                    Console.WriteLine("노병민");
                    break;
                case 10:
                    Console.WriteLine("박영준");
                    break;
                case 11:
                    Console.WriteLine("심하나");
                    break;
                case 12:
                    Console.WriteLine("오윤성");
                    break;
                case 13:
                    Console.WriteLine("유근영");
                    break;
                case 14:
                    Console.WriteLine("윤서진");
                    break;
                case 15:
                    Console.WriteLine("이승준");
                    break;
                case 16:
                    Console.WriteLine("이정빈");
                    break;
                case 17:
                    Console.WriteLine("이지우");
                    break;
                case 18:
                    Console.WriteLine("장서윤");
                    break;
                case 19:
                    Console.WriteLine("정영도");
                    break;
                case 20:
                    Console.WriteLine("최강호");
                    break;
                case 21:
                    Console.WriteLine("홍상화");
                    break;
             



















            }
        }
    }
}

