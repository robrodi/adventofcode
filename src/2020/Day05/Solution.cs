using System.Collections.Immutable;
using System.Linq;

namespace AdventOfCode.Y2020.Day05;

[ProblemName("Binary Boarding")]
public class Solution : Solver {
    public record Seat (int row, int column);

    public static int BinaryPart(string input, int count, char lesser, char greater){
        var min = 0; 
        var max = count - 1;
        foreach(var c in input)
        {
            var midpoint = ((max - min) / 2) + min;
            if (c == lesser) max = midpoint;
            else if (c == greater) min = midpoint;
            if (max == min) break; 
        }
        return max;
    }
    public static int GetRow(string input, int rowCount = 128) => BinaryPart(input, rowCount, 'F', 'B');
    public static int GetColumn(string input, int colCount = 8) => BinaryPart(input, colCount, 'L', 'R');
    public static Seat GetSeat(string input) => GetSeat(input, 128, 8);
    public static Seat GetSeat(string input, int rowCount, int colCount){
        return new Seat(GetRow(input, rowCount), GetColumn(input, colCount));
    }
    public static int GetSeatId(Seat s) => 8*s.row + s.column;
    public object PartOne(string input) =>
        input.Split('\n').Select(GetSeat).Max(GetSeatId);

    public object PartTwo(string input) {

        var seats = input.Split('\n').Select(GetSeat).Select(GetSeatId).ToImmutableSortedSet();
        for(var i = seats.First(); i < seats.Last(); i++)
            if (!seats.Contains(i)) return i;
        return -1;
    }
}
