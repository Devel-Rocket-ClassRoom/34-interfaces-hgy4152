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
        Console.Write($"{Name}(이/가) ");
        target.TakeDamage(AttackPower);
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
        Console.WriteLine($" {Name}에게 {damage} 대미지! ({Name} HP:{CurrentHp}/{MaxHp})");

    }
}