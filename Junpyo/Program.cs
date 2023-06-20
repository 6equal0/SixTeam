using System;

class Character
{
    public string Name { get; set; }
    public int AttackStat { get; set; }
    public int DefenseStat { get; set; }
    public int HpStat { get; set; }

    public Character(string name, int Attack, int Defense, int Hp)
    {
        Name = name;
        AttackStat = Attack;
        DefenseStat = Defense;
        HpStat = Hp;

    }

    public void Enhance(string stat, int value)
    {
        if (stat == "공격력")
        {
            if (value >= 1 && value <= 5)
            {
                AttackStat += value;
                Console.WriteLine($"{Name}의 공격력이 {value}만큼 증가했습니다.");
            }
            else
            {
                Console.WriteLine("잘못된 수치입니다. 1~5의 범위로 강화할 수 있습니다.");
            }
        }
        else if (stat == "방어력")
        {
            if (value >= 1 && value <= 5)
            {
                DefenseStat += value;
                Console.WriteLine($"{Name}의 방어력이 {value}만큼 증가했습니다.");
            }
            else
            {
                Console.WriteLine("잘못된 수치입니다. 1~5의 범위로 강화할 수 있습니다.");
            }
        }
        else if (stat == "체력")
        {
            if (value >= 1 && value <= 5)
            {
                HpStat += value;
                Console.WriteLine($"{Name}의 체력이 {value}만큼 증가했습니다.");
            }
            else
            {
                Console.WriteLine("잘못된 수치입니다. 1~5의 범위로 강화할 수 있습니다.");
            }
        }
        else
        {
            Console.WriteLine("잘못된 강화 스탯입니다. 공격력, 방어력, 체력을 강화할 수 있습니다.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            #region 캐릭터 목록
            Character[] characters = new Character[]
        {
            new Character("강민기", 5, 10, 25),
            new Character("강윤구", 5, 10, 25),
            new Character("권도미", 5, 10, 25),
            new Character("김대현", 5, 10, 25),
            new Character("김민재", 5, 10, 25),  
            new Character("김아윤", 5, 10, 25),
            new Character("김준표", 5, 10, 25),
            new Character("김진현", 5, 10, 25),
            new Character("노병민", 5, 10, 25),
            new Character("박영준", 5, 10, 25),
            new Character("심하나", 5, 10, 25),
            new Character("오윤성", 5, 10, 25),
            new Character("유근영", 5, 10, 25),
            new Character("윤서진", 5, 10, 25),
            new Character("이승준", 5, 10, 25),
            new Character("이정빈", 5, 10, 25),
            new Character("이지우", 5, 10, 25),
            new Character("최강호", 5, 10, 25),
            new Character("정영도", 5, 10, 25),
            new Character("장서윤", 5, 10, 25),
            new Character("홍상화", 5, 10, 25)
        };
            #endregion

            #region 사용자 입력 받기
            Console.WriteLine("강화할 캐릭터를 선택하세요");
            string characterName = Console.ReadLine();

            Console.WriteLine("강화할 스탯을 선택하세요");
            string stat = Console.ReadLine();

            Console.WriteLine("증가할 수치를 입력하세요:");
            int value = int.Parse(Console.ReadLine());
            #endregion

            #region 선택한 캐릭터와 스탯 강화
            Character selectedCharacter = null;

            foreach (Character character in characters)
            {
                if (character.Name == characterName)
                {
                    selectedCharacter = character;
                    break;
                }
            }

            if (selectedCharacter != null)
            {
                selectedCharacter.Enhance(stat, value);
            }
            else
            {
                Console.WriteLine("잘못된 캐릭터입니다.");
            }
            #endregion
        }
    }
}

