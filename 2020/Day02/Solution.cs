using System;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace AdventOfCode.Y2020.Day02;

[ProblemName("Password Philosophy")]
class Solution : Solver {

    public object PartOne(string input) =>
        input.Split("\n")
             .Select(Parse)
             .Count(RuleAndPw.Eval1);
    public object PartTwo(string input) =>
        input.Split("\n")
             .Select(Parse)
             .Count(RuleAndPw.Eval2);

    RuleAndPw Parse(string line)
    {
        int dashPos = line.IndexOf('-');
        int spacePos = line.IndexOf(' ');

        return new RuleAndPw
        {
            Min = int.Parse(line.Substring(0, dashPos)),
            Max = int.Parse(line.Substring(dashPos+1, spacePos - dashPos)),
            Char = line[spacePos+1],
            Password = line.Split(' ')[2]
        };

    }
    public struct RuleAndPw{
        public int Min;
        public int Max;
        public char Char;
        public string Password;
        public override string ToString() => $"{Min}-{Max} {Char}: {Password}";
        public static bool Eval1(RuleAndPw r)
        {
            var count = r.Password.Count(c => c == r.Char);
            return count <= r.Max && count >= r.Min;
        }
        public static bool Eval2(RuleAndPw r) =>r.Password[r.Min - 1] == r.Char ^ r.Password[r.Max - 1] == r.Char;
    }
}
