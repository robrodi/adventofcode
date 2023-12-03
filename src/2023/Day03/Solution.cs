using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode.Y2023.Day03;

[ProblemName("Gear Ratios")]
public class Solution : Solver {

    public object PartOne(string input)
    {
        Console.WriteLine(new string(input.ToCharArray().Distinct().ToArray()));
        Renderer2d g = ParseToRenderer(input);
        var numbers = new List<int>();
        var number = 0;
        var isAdjacent = false;
        for (var y = 0; y < g.Height; y++)
            for (var x = 0; x < g.Width; x++)
            {
                var c = g.Get(x, y).Character;
                // end of possible number sequence
                if (!char.IsDigit(c) || x == g.Width - 1)
                {
                    if (number > 0) {
                        if (isAdjacent)
                            numbers.Add(number);
                    }
                    number = 0;
                    isAdjacent = false;
                    continue;
                }

                number = number * 10 + (c - '0');
                isAdjacent |= g.Back.AdjacentValues(x, y).Any(v => v.Character != '.' && !char.IsDigit(v.Character));
            }
        return numbers.Sum();
    }

    private static Renderer2d ParseToRenderer(string input)
    {
        var lines = input.Split('\n');
        var g = new Renderer2d(lines[0].Length, lines.Length);
        for (var y = 0; y < lines.Length; y++)
        {
            var line = lines[y];
            for (var x = 0; x < line.Length; x++)
                g.Draw(x, y, line[x]);
        }
        return g;
    }

    public object PartTwo(string input) {
        return 0;
    }
}
