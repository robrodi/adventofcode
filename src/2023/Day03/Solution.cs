using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace AdventOfCode.Y2023.Day03;

[ProblemName("Gear Ratios")]
public class Solution : Solver {

    public object PartOne(string input)
    {
        var g = Grid2d<char>.ParseChars(input);
        var numbers = new List<int>();
        var number = 0;
        var isAdjacent = false;
        foreach(var p in g.GetPoints())
        {
            var c = g.Get(p);
            // end of possible number sequence
            if (!char.IsDigit(c) || p.X == g.Width - 1)
            {
                if (number > 0 && isAdjacent)
                    numbers.Add(number);
                number = 0;
                isAdjacent = false;
                continue;
            }

            number = number * 10 + (c - '0');
            isAdjacent |= g.AdjacentValues(p.X, p.Y).Any(v => v != '.' && !char.IsDigit(v));
        }
        return numbers.Sum();
    }

    

    public object PartTwo(string input) {
        var g = Grid2d<char>.ParseChars(input);
        var possibleGears = new Dictionary<Point, List<int>>();
        var number = 0;
        var numberGears = new List<Point>();

        foreach(var p in g.GetPoints()){
            var c = g.Get(p);
            if (!char.IsDigit(c) || p.X == g.Width - 1)
            {
                if (number > 0 && numberGears.Any()){
                    foreach(var gear in numberGears.Distinct())
                    {
                        possibleGears.TryAdd(gear, new List<int>());
                        possibleGears[gear].Add(number);
                    }
                    numberGears.Clear();
                }
                number = 0;
                continue;
            }

            number = number * 10 + (c - '0');
            numberGears.AddRange(g.AdjacentPoints(p)
                                  .Where(p => g.Get(p) == '*'));
        }

        return possibleGears.Values.Where(v => v.Count == 2)
                                   .Select(v => v[0] * v[1])
                                   .Sum();
    }
}
