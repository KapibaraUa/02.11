using System;

namespace HomeworkCollections;

public class Dolphin : SeaItem
{
    public double JumpHeight { get; set; }

    public Dolphin(string name, double weight, double jumpHeight)
        : base(name, weight)
    {
        JumpHeight = jumpHeight;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Дельфін: {Name}, Вага: {Weight} кг, Висота стрибка: {JumpHeight} м");
    }

    public override string ToString()
    {
        return $"Дельфін: {Name}, Вага: {Weight} кг, Висота стрибка: {JumpHeight} м";
    }
}