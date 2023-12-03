using System;
using System.Collections.Generic;
using System.Linq;
using AngleSharp.Text;

namespace AdventOfCode.Y2023.Day01;
[ProblemName("Trebuchet?!")]
class Solution : Solver {
    Dictionary<string, int> numbers = new Dictionary<string, int>{
        { "one", 1},
        { "two", 2},
        { "three", 3},
        { "four", 4},
        { "five", 5},
        { "six", 6},
        { "seven", 7},
        { "eight", 8},
        { "nine", 9},
        { "zero", 0},
    };
    public object PartOne(string input) {
          return input.Split(Environment.NewLine)
                      .Select(l => getInt(l, FindFirstDigit))
                      .Sum();
    }

    public object PartTwo(string input)
    {
        return input.Split(Environment.NewLine)
                    .Select(l => getInt(l, l => FindFirstDigit(l) ?? FindFirstNumber(l, numbers)))
                    .Sum();
    }

    private static int getInt(string line, Func<string, int?> parser)
    {
        int? first = null;
        for (var i = 0; i < line.Length; i++){
            first = parser(line[i..]);
            if (first.HasValue) break;
        }

        int? last = null;
        for (var i = line.Length - 1; i >= 0; i--){
            last = parser(line[i..]);
            if (last.HasValue) break;
        }
        return first.Value * 10 + last.Value;
    }
    private static int? FindFirstDigit(string line) => line[0].IsDigit() ? line[0] - '0' : null;
    private static int? FindFirstNumber(string line, Dictionary<string, int> numbers)
    {
        if (line[0].IsDigit()) return line[0] - '0';

        foreach (var number in numbers){
            if (line.StartsWith(number.Key))
                return number.Value;
        }

        return null;
    }
}
