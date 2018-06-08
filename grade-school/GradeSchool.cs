using System.Collections.Generic;
using System.Linq;

public class School
{
    private SortedDictionary<int, SortedList<string, string>> roster = new SortedDictionary<int, SortedList<string, string>>();
    public void Add(string student, int grade)
    {
        // create grade if it doesn't exists yet
        if (!roster.ContainsKey(grade))
        {
            roster.Add(grade, new SortedList<string, string>());
        }
        roster[grade].Add(student, student);
    }

    public IEnumerable<string> Roster()
    {
        List<string> students = new List<string>();
        foreach(var grade in roster) 
        {
            foreach(var student in grade.Value)
            {
                students.Add(student.Value);
            }
        }
        return students;
    } 

    public IEnumerable<string> Grade(int grade) =>
        roster.ContainsKey(grade) ? roster[grade].Keys.ToList<string>() : new List<string>();
}