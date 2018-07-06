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
    private const int PlantsPerStudent = 2;
    private static readonly string[] children = new string[12]
    {
        "Alice", "Bob", "Charlie", "David",
        "Eve", "Fred", "Ginny", "Harriet",
        "Ileana", "Joseph", "Kincaid", "Larry"
    };
    private static readonly Dictionary<char, Plant> mapPlants = new Dictionary<char, Plant>
    {
        {  'V', Plant.Violets },
        {  'R', Plant.Radishes },
        {  'C', Plant.Clover },
        {  'G', Plant.Grass }
    };

    private Dictionary<String, List<Plant>> kindergartenersPlants;

    public KindergartenGarden(string diagram) : this(diagram, children)
    {
    }

    public KindergartenGarden(string diagram, IEnumerable<string> students)
    {
        kindergartenersPlants = new Dictionary<string, List<Plant>>();
        string[] studentsArray = (string[])students;

        foreach (var student in students)
        {
            kindergartenersPlants.Add(student, new List<Plant>());
        }

        var rowsOfPlants = diagram.Split("\n");

        foreach (var row in rowsOfPlants)
        {
            for (int plantPosition = 0; plantPosition < rowsOfPlants[0].Length; plantPosition++)
            {
                int studentId = plantPosition / PlantsPerStudent;

                var character = row[plantPosition];
                var plant = mapPlants[character];
                kindergartenersPlants[studentsArray[studentId]].Add(plant);
            }
        }
    }

    public IEnumerable<Plant> Plants(string student)
    {
        return kindergartenersPlants[student].ToArray();
    }
}