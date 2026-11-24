using System;

namespace HomeworkCollections;

public class Octopus : SeaItem
{
    public int TentaclesCount { get; set; }

    public Octopus(string name, double weight, int tentaclesCount)
        : base(name, weight)
    {
        TentaclesCount = tentaclesCount;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Восьминіг: {Name}, Вага: {Weight} кг, Щупалець: {TentaclesCount}");
    }

    public override string ToString()
    {
        return $"Восьминіг: {Name}, Вага: {Weight} кг, Щупалець: {TentaclesCount}";
    }
}