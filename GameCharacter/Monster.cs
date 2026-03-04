using System;
using System.Collections.Generic;
using System.Text;

class Monster : IDefender, IAttacker
{
    public string Name;
    public int CurrentHp{ get; set; }

    public int MaxHp { get; private set; }

    public bool IsDead { get; set; }

    public int AttackPower { get; set; }

    public Monster(string name, int MaxHp, int attackpower)
    {
        Name = name;
        this.MaxHp = MaxHp;
        CurrentHp = MaxHp;
        AttackPower = attackpower;
    }

    public void Attack(IDefender target)
    {
        Console.Write($"{Name}(이/가) ");
        target.TakeDamage(AttackPower);
    }

    public void TakeDamage(int damage)
    {
        if (CurrentHp > damage)
        {
            CurrentHp -= damage;
            
        }
        else if(CurrentHp <= damage) 
        {
            IsDead = true;
            CurrentHp = 0;
        
        }

        Console.WriteLine($" {Name}에게 {damage} 대미지! ({Name} HP:{CurrentHp}/{MaxHp})");
    }
}