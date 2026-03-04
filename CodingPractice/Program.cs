using System;

// README.md를 읽고 코드를 작성하세요.


Car car = new Car();
car.Go();

IRepository repository = new Repository();
repository.Get();


IBattery battery1 = new GoodBattery();
IBattery battery2 = new NormalBattery();

Car1 car1 = new Car1(battery1);
Car1 car2 = new Car1(battery2);

car1.Run();
car2.Run();

Dog dog = new Dog();
dog.Eat();
dog.Bark();


Bird bird = new Bird();
bird.Breathe();
bird.Fly();


Pet pet = new Pet();
pet.Eat();
((IDog1)pet).Eat();

IExample example = new Example();
example.DoWork();

TextEditor editor = new TextEditor();
editor.Undo();
editor.Redo();

Car2 car21 = new Car2();
car21.Run();
car21.Left();
car21.Back();


Player player = new Player();
Enemy enemy = new Enemy();
Building building = new Building();

player.TakeDamage(20);
enemy.TakeDamage(30);
building.TakeDamage(100);


Hero hero = new Hero();
hero.Move();
hero.Attack();

Turret turret = new Turret();
turret.Attack();

interface IMovable
{
    void Move();
}

interface IAttackable
{
    void Attack();
}

class Hero : IMovable, IAttackable
{
    public void Move()
    {
        Console.WriteLine("영웅이 이동합니다.");

    }

    public void Attack()
    {
        Console.WriteLine("영웅이 공격합니다.");
    }
}

class Turret : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("포탑이 발사합니다.");
    }
}

interface IDamageable
{
    int Health { get; set; }

    void TakeDamage(int damage) ;
}

class Player : IDamageable
{
    
    public int Health { get; set; } = 100;
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"플레이어가 {damage} 대미지를 받음. 남은 체력: {Health}");
    }
}

class Enemy : IDamageable
{
    public int Health { get; set; } = 50;
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"적이 {damage} 대미지를 받음. 남은 체력: {Health}");
    }
}

class Building : IDamageable
{
    public int Health { get; set; } = 500;
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"건물이 {damage} 대미지를 받음. 남은 체력: {Health}");
    }
}

interface IStandard
{
    void Run();
}

abstract class Vehicle
{
    public abstract void Back();

    public void Left()
    {
        Console.WriteLine("좌회전");
    }

}

class Car2 : Vehicle, IStandard
{
    public void Run()
    {
        Console.WriteLine("전진");
    }

    public override void Back()
    {
        Console.WriteLine("후진");
    }
}


interface IUndoable
{
    void Undo();
}

interface IRedoable : IUndoable
{
    void Redo();
}

class TextEditor : IRedoable
{
    public void Redo()
    {
        Console.WriteLine("다시 실행");
    }

    public void Undo()
    {
        Console.WriteLine("실행 취소");

    }
}

interface IExample
{
    void DoWork();
}

class Example : IExample
{
    void IExample.DoWork()
    {
        Console.WriteLine("작업 중 입니다.");
    }
}

interface IDog1
{
    void Eat();
}
interface ICat
{
    void Eat();
}

class Pet : IDog1, ICat
{
    void IDog1.Eat()
    {
        Console.WriteLine("개처럼 먹습니다.");
    }

    public void Eat()
    {
        Console.WriteLine("고양이처럼 먹습니다.");
    }
}
interface IFlyable
{
    void Fly();
}

class Animal
{
    public void Breathe()
    {
        Console.WriteLine("숨을 쉽니다.");
    }
}

class Bird : Animal, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("날아갑니다.");
    }

}

interface IAnimal
{
    void Eat();
}

interface IDog
{
    void Bark();
}

class Dog : IAnimal, IDog
{
    public void Eat()
    {
        Console.WriteLine("먹습니다.");
    }

    public void Bark()
    {
        Console.WriteLine("짖습니다.");
    }
}

interface IBattery
{
    string GetName();
}

class GoodBattery : IBattery
{

    public string GetName()
    {
        return "고급 배터리";
    }
}

class NormalBattery : IBattery
{
    public string GetName()
    {
        return "일반 배터리";
    }
}

class Car1
{
    public string Name { get; set; }

    public Car1(IBattery battery)
    {
        Name = battery.GetName();
    }

    public void Run()
    {
        Console.WriteLine($"{Name}를 장착한 자동차가 달립니다.");

    }
}

interface IPeroson
{
    void Work();
    void Rest();
}

class Person : IPeroson
{
    public void Work()
    {
        Console.WriteLine("일을 합니다.");
    }

    public void Rest() 
    {
        Console.WriteLine("휴식을 취합니다.");
    }
}




interface IRepository
{
    void Get();

}

class Repository : IRepository
{
    public void Get()
    {
        Console.WriteLine("데이터를 가져옵니다.");
    }
}


interface ICar
{
    void Go();
}

class Car : ICar
{
    public void Go()
    {
        Console.WriteLine("자동차가 달립니다.");
    }
}