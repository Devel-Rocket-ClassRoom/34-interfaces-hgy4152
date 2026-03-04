using System;

// README.md를 읽고 코드를 작성하세요.


Character character1 = new Character();
Monster monster = new Monster("슬라임", 30, 5);
Monster monster1 = new Monster("고블린", 50, 10);


Console.WriteLine("=== 전투 시작 ===");

while (!monster.IsDead)
{
    ProcessBattle(character1, monster);
    if (monster.IsDead)
    {
        Console.WriteLine($"{monster.Name}(이/가) 쓰러졌습니다!");
        break;
    }
    ProcessBattle(monster, character1);
}


Console.WriteLine("=== 고블린 등장 ===");

while (!monster1.IsDead)
{
    ProcessBattle(character1, monster1);
    if (monster1.IsDead)
    {
        Console.WriteLine($"{monster1.Name}(이/가) 쓰러졌습니다!");
        break;
    }    
        

    
    ProcessBattle(monster1, character1);
}




void ProcessBattle(IAttacker attacker, IDefender defender)
{
    attacker.Attack(defender);
    
}