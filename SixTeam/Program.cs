using System;

namespace SixTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 플레이어
            Player player1 = new Player("강민기", 9, 8, 6);
            Player player2 = new Player("강윤구", 6, 4, 8);
            Player player3 = new Player("권도현", 2, 15, 2);
            Player player4 = new Player("김대현", 7, 7, 5);
            Player player5 = new Player("김민재", 8, 6, 3);
            Player player6 = new Player("김아윤", 4, 8, 4);
            Player player7 = new Player("김준표", 6, 6, 6);
            Player player8 = new Player("김진현", 7, 4, 7);
            Player player9 = new Player("노병민", 1, 4, 1);
            Player player10 = new Player("박영준", 5, 10, 7);
            Player player11 = new Player("심하나", 2, 12, 5);
            Player player12 = new Player("오윤성", 8, 4, 3);
            Player player13 = new Player("유근영", 9, 4, 9);
            Player player14 = new Player("윤서진", 6, 8, 4);
            Player player15 = new Player("이승준", 7, 6, 4);
            Player player16 = new Player("이정빈", 10, 3, 5);
            Player player17 = new Player("이지우", 6, 4, 8);
            Player player18 = new Player("장서윤", 4, 5, 7);
            Player player19 = new Player("정영도", 8, 4, 8);
            Player player20 = new Player("최강호", 8, 8, 8);
            Player player21 = new Player("홍상화", 3, 12, 5);
            #endregion
            #region 몬스터
            Monster monster11 = new Monster("정어리_검사", 7, 5, 1);
            Monster monster12 = new Monster("조개_보병", 12, 5, 1);
            Monster monster13 = new Monster("크릴새우_패거리", 3, 6, 1);

            Monster monster21 = new Monster("흰동가리_마법사", 5, 7, 2);
            Monster monster22 = new Monster("굴_중보병", 16, 5, 2);
            Monster monster23 = new Monster("고등어_전사", 9, 8, 2);
            Monster monster24 = new Monster("해삼_돌격병", 10, 6, 2);

            Monster monster31 = new Monster("미꾸라지_검사", 6, 9, 3);
            Monster monster32 = new Monster("장어_병사", 15, 6, 3);
            Monster monster33 = new Monster("피라냐_암살자", 5, 9, 3);
            Monster monster34 = new Monster("돛사치_기사", 16, 4, 3);
            Monster monster35 = new Monster("방어_갑옷기사", 23, 2, 3);

            Monster monster41 = new Monster("청새치_군사", 13, 7, 4);
            Monster monster42 = new Monster("백상아리_장군", 15, 12, 4);
            Monster monster43 = new Monster("가자미_패거리", 10, 6, 4);
            Monster monster44 = new Monster("용감한_개복치", 7, 3, 4);
            Monster monster45 = new Monster("참다랑어_마법사", 4, 8, 4);

            Monster monster51 = new Monster("문어_수도승", 11, 11, 5);
            Monster monster52 = new Monster("꽃게_중보병", 20, 8, 5);
            Monster monster53 = new Monster("백상아리_전차", 7, 13, 5);

            Monster boss = new Monster("크라켄", 14, 50, 5, true);
            #endregion

            MainMenu.Question();
        }
    }
}
