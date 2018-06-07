using System;
using System.Collections.Generic;
using System.Linq;

public class NucleotideCount
{
    private Dictionary<char, int> nucleotideCounts = new Dictionary<char, int>
    {
        {'A', 0},
        {'C', 0},
        {'G', 0},
        {'T', 0}
    };
    public NucleotideCount(string sequence)
    {
        foreach (var letter in sequence)
        {
            if(nucleotideCounts.ContainsKey(letter))
            {
                nucleotideCounts[letter] = nucleotideCounts[letter] + 1;
            }
            else
            {
                throw new InvalidNucleotideException();
            }
        }
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            return nucleotideCounts;
        }
    }
    
}

public class InvalidNucleotideException : Exception { }
