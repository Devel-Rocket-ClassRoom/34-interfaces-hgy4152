using System;
using System.Collections.Generic;
using System.Text;

interface IAttacker
{
    int AttackPower { get; }
    void Attack(IDefender target);
}

interface IDefender
{
    int CurrentHp {  get; }
    int MaxHp {  get; }
    bool IsDead { get; }
    void TakeDamage(int damage);
}


