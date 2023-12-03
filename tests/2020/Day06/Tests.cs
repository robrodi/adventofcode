using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using Xunit;
using AdventOfCode.Y2020.Day06;

namespace AdventOfCode.tests.Y2020.Day06;

[ProblemName("Custom Customs")]
public class Tests {
    [Fact]
    public void Parser(){
      var sampleInput = @"abcx
abcy
abcz";
    }

    [Fact]
    public void PartOneSample() {
      var sampleInput = @"abcx
abcy
abcz";
    }

    [Fact]
    public void PartTwoSample() {
      var sampleInput = @"abc

a
b
c

ab
ac

a
a
a
a

b";
    }
}
