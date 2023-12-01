using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2020.Day01;

[ProblemName("Report Repair")]
class Solution : Solver {

    public object PartOne(string input) {
        var numbers = Numbers(input);
        foreach (var n in numbers)
        {
            if (numbers.Contains(2020-n))
            return n * (2020-n);
        }
        return -4;
    }

    public object PartTwo(string input) {
    var numbers = Numbers(input);
        foreach (var n in numbers)
        foreach(var o in numbers)
        {
            if (numbers.Contains(2020-n-o)){
                return n * o * (2020 - n - o);
            }
        }
        return 0;
    }

    HashSet<int> Numbers(string input) {
        return input.Split('\n').Select(int.Parse).ToHashSet<int>();
    }
}
