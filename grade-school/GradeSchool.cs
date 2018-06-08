using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class School
{
    private SortedDictionary<int, List<string>> roster = new SortedDictionary<int, List<string>>();
    public void Add(string student, int grade)
    {
        // create grade if it doesn't exists yet
        if (!roster.ContainsKey(grade))
        {
            roster.Add(grade, new List<string>());
        }
        // lazy solution, should add to sorted index.
        roster[grade].Add(student);
        roster[grade].Sort();
    }

    public IEnumerable<string> Roster()
    {
        List<string> students = new List<string>();
        foreach(var grade in roster) 
        {
            foreach(var student in roster[grade.Key])
            {
                students.Add(student);
            }
        }
        return students;
    } 

    public IEnumerable<string> Grade(int grade) =>
        roster.ContainsKey(grade) ? roster[grade] : new List<string>();
}