using System;
using System.Collections.Generic;
using System.Text;

class Character : IAttacker, IDefender
{
    public string Name = "용사";
    public int MaxHp { get; set; } = 100;
    public int AttackPower { get; set; } = 20;

    public int CurrentHp { get; set; }
    public bool IsDead { get; set; } = false;

    public Character()
    {
        CurrentHp = MaxHp;
    }

    public void Attack(IDefender target)
    {
        //Console.Write($"{Name}(이/가) ");
        target.TakeDamage(AttackPower);
        Console.WriteLine($"{Name}(이/가) {target.ToString()}에게 {AttackPower} 대미지! ({target} HP:{target.CurrentHp}/{target.MaxHp})");
        // target is Monster 같은 방향도 있음.
        // 근데 그러면 클래스 종류별로 캐스팅 해줘야해서 별론듯
    }

    public void TakeDamage(int damage) 
    {
        if (CurrentHp > damage)
        {
            CurrentHp -= damage;
        }
        else if (CurrentHp <= damage) 
        {
            IsDead = true;
            CurrentHp = 0;

        }
        //Console.WriteLine($" {Name}에게 {damage} 대미지! ({Name} HP:{CurrentHp}/{MaxHp})");

    }

    public override string ToString()
    {
        return Name;
    }
}