using System;

namespace HomeworkCollections;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Завдання 1: Океанаріум ===");

        Oceanarium oceanarium = new Oceanarium("Nemo");
        oceanarium.AddInhabitant(new Shark("Брюс", 850.5, 50));
        oceanarium.AddInhabitant(new Dolphin("Фліппер", 180, 4.5));
        oceanarium.AddInhabitant(new Octopus("Пауль", 12.3, 8));

        oceanarium.ShowInhabitants();

        Console.WriteLine();
        Console.WriteLine("Перебір через foreach:");
        foreach (SeaItem item in oceanarium)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("=== Завдання 2: Футбольна команда ===");

        FootballTeam team = new FootballTeam("Чорноморець", "Одеса");
        team.AddPlayer(new Player("Андрій Шевченко", "Нападник", 7));
        team.AddPlayer(new Player("Олександр Зінченко", "Захисник", 17));
        team.AddPlayer(new Player("Анатолій Трубін", "Воротар", 1));

        team.ShowPlayers();

        Console.WriteLine();
        Console.WriteLine("Перебір через foreach:");
        foreach (Player player in team)
        {
            Console.WriteLine(player);
        }
    }
}
