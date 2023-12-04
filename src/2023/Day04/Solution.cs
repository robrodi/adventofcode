using System;
using System.Collections.Immutable;
using System.Linq;

namespace AdventOfCode.Y2023.Day04;

[ProblemName("Scratchcards")]
public class Solution : Solver {

    public object PartOne(string input)
    {
        // 10 winners, 
        return input.Split('\n')
                    .Select(l => l.Substring(l.IndexOf(':') + 1))
                    .Select(CountMatches)
                    .Sum(GetPoints);
    }

    private static int CountMatches(string line)
    {
        var s = line.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        var winners = s.TakeWhile(s => s != "|")
                       .Select(int.Parse)
                       .ToImmutableSortedSet();
        var choices = s.Skip(winners.Count() + 1)
                       .Select(int.Parse);
        
        int count = 0;
        foreach (var c in choices)
        {
            if (winners.Contains(c)) count++;
        }
        return count;
    }

    private static int GetPoints(int matchCount) =>  matchCount == 0 ? 0 : Convert.ToInt32(Math.Pow(2, matchCount - 1));
                    

    public object PartTwo(string input) {
        var lines =  input.Split('\n');
         var cardScores = input.Split('\n')
                               .Select(l => l.Substring(l.IndexOf(':') + 1))
                               .Select(CountMatches)
                               .ToArray();

        int[] cardCounts = Enumerable.Repeat(1, lines.Count()).ToArray();
        for(var i = 0; i < lines.Length; i++)
        {
            var currentScore = cardScores[i];
            for(var j = 1; j <= currentScore && i+j < cardCounts.Length; j++)
                cardCounts[i+j]+= cardCounts[i];
        }
        return cardCounts.Sum();;
    }
}
