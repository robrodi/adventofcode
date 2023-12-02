using System.Text.RegularExpressions;
using AdventOfCode.Model;
namespace AdventOfCode.Generator;

class SolutionTemplateGenerator {
    public string Generate(Problem problem) {
        return $@"using System;
             |using System.Collections.Generic;
             |using System.Collections.Immutable;
             |using System.Linq;
             |using System.Text.RegularExpressions;
             |using System.Text;
             |
             |namespace AdventOfCode.Y{problem.Year}.Day{problem.Day.ToString("00")};
             |
             |[ProblemName(""{problem.Title}"")]
             |class Solution : Solver {{
             |
             |    public object PartOne(string input) {{
             |        return 0;
             |    }}
             |
             |    public object PartTwo(string input) {{
             |        return 0;
             |    }}
             |}}
             |".StripMargin();
    }
}
class TestTemplateGenerator{
    public string Generate(Problem problem) {
        var sampleMatch = new Regex("\n<code>(.+?)\n</code>", RegexOptions.Singleline).Match(problem.ContentMd);
        var first = sampleMatch.Groups[1].Value;
        var second = sampleMatch.NextMatch().Groups[1].Value;

        return $@"using System;
             |using System.Collections.Generic;
             |using System.Collections.Immutable;
             |using System.Linq;
             |using System.Text.RegularExpressions;
             |using System.Text;
             |using Xunit;
             |using AdventOfCode.Y{problem.Year}.Day{problem.Day.ToString("00")};
             |
             |namespace AdventOfCode.tests.Y{problem.Year}.Day{problem.Day.ToString("00")};
             |
             |[ProblemName(""{problem.Title}"")]
             |public class Tests {{
             |    [Fact]
             |    public void Parser(){{
             |      var sampleInput = @""{first}"";
             |    }}
             |
             |    [Fact]
             |    public void PartOneSample() {{
             |      var sampleInput = @""{first}"";
             |    }}
             |
             |    [Fact]
             |    public void PartTwoSample() {{
             |      var sampleInput = @""{second}"";
             |    }}
             |}}
             |".StripMargin();
    }
}
