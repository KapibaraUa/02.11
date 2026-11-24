using System;

namespace HomeworkCollections;

public abstract class SeaItem
{
    private string _name = string.Empty;
    private double _weight;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid name");
            }
            _name = value;
        }
    }

    public double Weight
    {
        get
        {
            return _weight;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Weight must be greater than zero");
            }
            _weight = value;
        }
    }

    protected SeaItem(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public abstract void ShowInfo();

    public override string ToString()
    {
        return $"{Name} (Вага: {Weight} кг)";
    }
}