using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2020.Day04;

[ProblemName("Passport Processing")]
class Solution : Solver {

    public object PartOne(string input) => input.Split("\n\n")
                                                .Select(Fields)
                                                .Count(ValidatePassportFieldsPresent);
    
    public static IDictionary<string, string> Fields(string input) => input.Split(new[] {'\n', ' '})
                                                                           .Select(s => s.Split(':'))
                                                                           .ToDictionary(s=> s[0], s=>s[1]);
    public static bool ValidatePassportFieldsPresent(IDictionary<string, string> fields)
    {
        var required = new [] {"byr", "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"}; // cid
        return required.All(fields.ContainsKey);
    }
    public static bool ValidatePassportFields(IDictionary<string, string> fields){
        bool inRange(string key, int min, int max ) => int.Parse(fields[key]) >= min && int.Parse(fields[key]) <= max;

        var years = inRange("byr", 1920, 2002) && inRange("iyr", 2010,2020) && inRange("eyr", 2020, 2030);

        return years;
    }

    public object PartTwo(string input) => input.Split("\n\n")
                                                .Select(Fields)
                                                .Where(ValidatePassportFieldsPresent)
                                                .Count(ValidatePassportFields);
}
