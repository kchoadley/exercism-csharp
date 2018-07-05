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
    static string[] children = new List<string>()
    {
        "Alice", "Bob", "Charlie", "David",
        "Eve", "Fred", "Ginny", "Harriet",
        "Ileana", "Joseph", "Kincaid", "Larry"
    }.ToArray();
    Dictionary<String, List<Plant>> kindergartenersPlants = new Dictionary<string, List<Plant>>();
    Dictionary<char, Plant> mapPlants = new Dictionary<char, Plant>
    {
        {  'V', Plant.Violets },
        {  'R', Plant.Radishes },
        {  'C', Plant.Clover },
        {  'G', Plant.Grass }
    };
    public KindergartenGarden(string diagram) : this(diagram, children)
    {
    }

    public KindergartenGarden(string diagram, IEnumerable<string> students)
    {
        foreach(var child in children)
        {
            kindergartenersPlants.Add(child, new List<Plant>());
        }

        var rows = diagram.Split("\n");

        foreach (var row in rows)
        {
            for (int count = 0; count < rows[0].Length; count++)
            {
                int child = count / 2;

                var character = row[count];
                var plant = mapPlants[character];
                kindergartenersPlants[children[child]].Add(plant);

                //kindergartenersPlants[children[child]].Add(mapPlants[row[count]]);
            }
        }
    }

    public IEnumerable<Plant> Plants(string student)
    {
        return kindergartenersPlants[student].ToArray();
    }
}