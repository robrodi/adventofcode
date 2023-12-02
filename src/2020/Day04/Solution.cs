using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Y2020.Day04;

[ProblemName("Passport Processing")]
class Solution : Solver {

    public object PartOne(string input) => input.Split("\n\n")
                                                .Select(Fields)
                                                .Count(ValidatePassportFieldsPresent);
    
    public static IDictionary<string, string> Fields(string input) => input.Split(new[] {'\n', ' '})
                                                                           .Select(s => s.Split(':'))
                                                                           .Where(s => s.Length == 2)
                                                                           .ToDictionary(s=> s[0], s=>s[1]);
    public static bool ValidatePassportFieldsPresent(IDictionary<string, string> fields)
    {
        var required = new [] {"byr", "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"}; // cid
        return required.All(fields.ContainsKey);
    }
    static Regex hr = new Regex("^(\\d+)(in|cm)", RegexOptions.Compiled);
    static Regex passportIdR = new Regex("^[\\d]{9}$", RegexOptions.Compiled);
    static Regex hairR = new Regex("^#[0-9a-f]{6}$", RegexOptions.Compiled);
    public static bool ValidatePassportFields(IDictionary<string, string> fields){
        if (int.Parse(fields["iyr"]) > 2020|| int.Parse(fields["iyr"]) < 2010)  return false;
        if (int.Parse(fields["byr"]) > 2002|| int.Parse(fields["byr"]) < 1920) return false;
        if (int.Parse(fields["eyr"]) > 2030|| int.Parse(fields["eyr"]) < 2020) return false;
        var hm = hr.Match(fields["hgt"]);
        if (!hm.Success) return false;
        if (
            (hm.Groups[2].Value == "in" && (int.Parse(hm.Groups[1].Value) < 59 || int.Parse(hm.Groups[1].Value) > 76)) ||
            (hm.Groups[2].Value == "cm" && (int.Parse(hm.Groups[1].Value) < 150 || int.Parse(hm.Groups[1].Value) > 193))
        )
           return false;
        if (!hairR.Match(fields["hcl"]).Success) return false;
        var ecls = new[] {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"};
        if (!ecls.Contains(fields["ecl"])) return false;
        if (!passportIdR.Match(fields["pid"]).Success)  return false;
        return true;
    }

    public object PartTwo(string input) => input.Split("\n\n")
                                                .Select(Fields)
                                                .Where(ValidatePassportFieldsPresent)
                                                .Count(ValidatePassportFields);
}
