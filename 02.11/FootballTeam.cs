using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeworkCollections;

internal class FootballTeam : IEnumerable<Player>
{
    private List<Player> _players = new List<Player>();

    public string Name { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;

    public FootballTeam(string name, string city)
    {
        Name = name;
        City = city;
    }

    public void AddPlayer(Player player)
    {
        if (player == null)
        {
            throw new ArgumentNullException("Player cannot be null");
        }
        _players.Add(player);
    }

    public void ShowPlayers()
    {
        Console.WriteLine($"Команда: {Name} ({City})");
        foreach (Player player in _players)
        {
            Console.WriteLine(player);
        }
    }

    public IEnumerator<Player> GetEnumerator()
    {
        foreach (Player player in _players)
        {
            yield return player;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}