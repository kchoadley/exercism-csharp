using System;
using System.Collections.Generic;
using System.Linq;

public class NucleotideCount
{
    public NucleotideCount(string sequence)
    {
        foreach (var letter in sequence)
        {
            if(NucleotideCounts.ContainsKey(letter))
            {
                NucleotideCounts[letter] = NucleotideCounts[letter] + 1;
            }
            else
            {
                throw new InvalidNucleotideException();
            }
        }
    }

    public IDictionary<char, int> NucleotideCounts { get; } = new Dictionary<char, int>
    {
        {'A', 0},
        {'C', 0},
        {'G', 0},
        {'T', 0}
    };
}

public class InvalidNucleotideException : Exception { }
