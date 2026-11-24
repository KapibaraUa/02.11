using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeworkCollections;

internal class Oceanarium : IEnumerable<SeaItem>
{
    private List<SeaItem> _inhabitants = new List<SeaItem>();

    public string Title { get; set; } = string.Empty;

    public Oceanarium(string title)
    {
        Title = title;
    }

    public void AddInhabitant(SeaItem item)
    {
        if (item == null)
        {
            throw new ArgumentNullException("SeaItem cannot be null");
        }
        _inhabitants.Add(item);
    }

    public void ShowInhabitants()
    {
        Console.WriteLine($"Океанаріум: {Title}");
        foreach (SeaItem item in _inhabitants)
        {
            item.ShowInfo();
        }
    }

    public IEnumerator<SeaItem> GetEnumerator()
    {
        foreach (SeaItem item in _inhabitants)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}