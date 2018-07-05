using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    static List<string> children = new List<string>()
    {
        "Alice", "Bob", "Charlie", "David",
        "Eve", "Fred", "Ginny", "Harriet",
        "Ileana", "Joseph", "Kincaid", "Larry"
    };
    Dictionary<String, List<Plant>> kindergartenersPlants;
    public KindergartenGarden(string diagram) : this(diagram, children)
    {
    }

    public KindergartenGarden(string diagram, IEnumerable<string> students)
    {
        var rows = diagram.Split("\n");
    }

    public IEnumerable<Plant> Plants(string student)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}