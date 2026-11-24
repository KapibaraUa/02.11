using System;

namespace HomeworkCollections;

public class Shark : SeaItem
{
    public double MaxSpeed { get; set; }

    public Shark(string name, double weight, double maxSpeed)
        : base(name, weight)
    {
        MaxSpeed = maxSpeed;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Акула: {Name}, Вага: {Weight} кг, Макс. швидкість: {MaxSpeed} км/год");
    }

    public override string ToString()
    {
        return $"Акула: {Name}, Вага: {Weight} кг, Макс. швидкість: {MaxSpeed} км/год";
    }
}