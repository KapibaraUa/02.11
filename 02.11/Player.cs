using System;

namespace HomeworkCollections;

public class Player
{
    private string _name = string.Empty;
    private int _number;

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
                throw new ArgumentException("Invalid player name");
            }
            _name = value;
        }
    }

    public string Position { get; set; } = string.Empty;

    public int Number
    {
        get
        {
            return _number;
        }
        set
        {
            if (value <= 0 || value > 99)
            {
                throw new ArgumentOutOfRangeException("Player number must be between 1 and 99");
            }
            _number = value;
        }
    }

    public Player(string name, string position, int number)
    {
        Name = name;
        Position = position;
        Number = number;
    }

    public override string ToString()
    {
        return $"#{Number} {Name} — {Position}";
    }
}