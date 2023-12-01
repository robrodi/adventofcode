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
          return input.Split(System.Environment.NewLine)
                      .Select(l => getInt(l, numbers, false))
                      .Sum();
    }

    public object PartTwo(string input)
    {
        return input.Split(System.Environment.NewLine)
                    .Select(l => getInt(l, numbers, true))
                    .Sum();
    }

    private static int getInt(string line, Dictionary<string, int> numbers, bool useWords = true)
    {
        int? first = null;
        for (var i = 0; i < line.Length; i++){
            first = FindFirstNumberInSubstring(line[i..], numbers, useWords);
            if (first.HasValue) break;
        }

        int? last = null;
        for (var i = line.Length - 1; i >= 0; i--){
            last = FindFirstNumberInSubstring(line[i..], numbers, useWords);
            if (last.HasValue) break;
        }
        return first.Value * 10 + last.Value;
    }
    private static int? FindFirstNumberInSubstring(string line, Dictionary<string, int> numbers, bool useWords = true)
    {
        if (line[0].IsDigit()) return line[0] - '0';
        if (!useWords) return null;

        foreach (var number in numbers){
            if (line.StartsWith(number.Key))
                return number.Value;
        }

        return null;
    }
}
