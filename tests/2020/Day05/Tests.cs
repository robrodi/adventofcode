using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using AdventOfCode.Y2020.Day05;

namespace AdventOfCode.tests.Y2020.Day05;

[ProblemName("Binary Boarding")]
public class Tests {
    private readonly ITestOutputHelper output;

    public Tests(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void Parser(){
      var sampleInput = @"";
    }
    [Fact]
    public void First(){
      Assert.Equal(44,  Solution.GetRow((string?)"FBFBBFFRLR", 128));
      Assert.Equal(5,  Solution.GetColumn((string?)"FBFBBFFRLR", 8));
      var s = Solution.GetSeat("BFFFBBFRRR");
      Assert.Equal(new Solution.Seat(70, 7), s);
      Assert.Equal(567, Solution.GetSeatId(s));
      var t = Solution.GetSeat("FFFBBBFRRR");
      Assert.Equal(new Solution.Seat(14, 7), t);
      Assert.Equal(119, Solution.GetSeatId(t));
      var u = Solution.GetSeat("BBFFBBFRLL");
      Assert.Equal(new Solution.Seat(102, 4), u);
      Assert.Equal(820, Solution.GetSeatId(u));
    }

    [Fact]
    public void PartOneSample() {
      var sampleInput = @"";
    }

    [Fact]
    public void PartTwoSample() {
      var sampleInput = @"";
    }
}
