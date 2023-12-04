using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AdventOfCode.Y2015.Day05;

[ProblemName("Doesn't He Have Intern-Elves For This?")]
public class Solution : Solver {

    public object PartOne(string input) {
        return input.Split('\n')
                .Count(Validate);

    }
    static bool Validate(string s){
        if (s.Count(ch => "aeiou".Contains(ch)) < 3) return false;
        if (!Enumerable.Range(0, s.Length - 1).Any(i => s[i] == s[i + 1])) return false;
        if (new[] {"ab","cd", "pq","xy"}.Any(bad => s.Contains(bad))) return false;
        return true;
    }
    static bool Validate2(string s)
    {
            var appearsTwice = Enumerable.Range(0, s.Length - 1).Any(i => s.IndexOf(s.Substring(i, 2), i+2) >= 0); 
            var repeats = Enumerable.Range(0, s.Length - 2).Any(i => s[i] == s[i + 2]);
            return appearsTwice && repeats;
    }

    public object PartTwo(string input) {
        return input.Split('\n')
            .Count(Validate2);
    }
}
