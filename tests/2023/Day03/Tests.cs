using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using Xunit;
using AdventOfCode.Y2023.Day03;

namespace AdventOfCode.tests.Y2023.Day03;

[ProblemName("Gear Ratios")]
public class Tests {
    [Fact]
    public void Parser(){
      var sampleInput = @"467..114..
...*......
..35..633.
......#...
617*......
.....+.58.
..592.....
......755.
...$.*....
.664.598..";
    }

    [Fact]
    public void PartOneSample() {
      var sampleInput = @"467..114..
...*......
..35..633.
......#...
617*......
.....+.58.
..592.....
......755.
...$.*....
.664.598..";
    }

    [Fact]
    public void PartTwoSample() {
      var sampleInput = @"";
    }
}
