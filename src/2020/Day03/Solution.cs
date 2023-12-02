using System;
using System.Linq;

namespace AdventOfCode.Y2020.Day03;

[ProblemName("Toboggan Trajectory")]
class Solution : Solver {

    public object PartOne(string input) => Solve(input, 3, 1);

    private static UInt128 Solve(string input, int right, int down)
    {
        var width = input.IndexOf('\n');
        var height = input.Length / (width + 1);
        
        var x = 0;
        var treeCount = 0;

        for (var y = 1; y <= height; y += down)
        {
            x += right;
            if (charAt(input, width, x, y) == '#')
            {
                treeCount++;
            }

        }

        return (UInt128) treeCount;
    }

    private static char charAt(string input, int width, int x, int y)
    {
        var pos = y * (width + 1) + (x % width);
        var height = input.Length / width;

        if (pos >= input.Length)
            throw new ArgumentOutOfRangeException($"Invalid input. W:{width} H: {height} $ x: {x}, y: {y}, {pos}");
        return input[pos];
    }

    public object PartTwo(string input){
        var inputs = new int[][] {[1,1],[3,1], [5,1], [7,1], [1,2]};
        var result = inputs.Select(i => Solve(input, i[0], i[1]));
        return result.Aggregate((a,b) => a*b);
    }
}
