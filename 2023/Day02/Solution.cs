using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace AdventOfCode.Y2023.Day02;

[ProblemName("Cube Conundrum")]
class Solution : Solver {

    public record Color (int Red, int Green, int Blue);
    public static Color Parse(string reveal){
        var values = reveal.Split(',').Select(s => s.Split(' ', System.StringSplitOptions.RemoveEmptyEntries | System.StringSplitOptions.TrimEntries)).ToArray();
        var red = 0; 
        var green = 0;
        var blue = 0;

        foreach(var v in values)
        {
            if (values.Length != 2) Console.WriteLine($"Bad line. {values}");
            if (v[1] == "red") red = int.Parse(v[0]);
            if (v[1] == "green") green = int.Parse(v[0]);
            if (v[1] == "blue") blue = int.Parse(v[0]);
        }
        return new Color(red, green, blue);
    }
    public static bool Supported(Color maxes, Color sample) => maxes.Blue >= sample.Blue && maxes.Red >= sample.Red && maxes.Green >= sample.Green;
    // {
    //     if (maxes.Red < sample.Red) { Console.WriteLine("Bad Red"); return false; }
    //     if (maxes.Green < sample.Green) { Console.WriteLine("Bad Green"); return false; }
    //     if (maxes.Blue < sample.Blue) { Console.WriteLine("Bad Blue"); return false; }
    //     return true;
    // }
public static void Print(Color c) {
    Console.WriteLine($"color: R: {c.Red} G: {c.Green}, B: {c.Blue}");
}
    public object PartOne(string input)
    {
        
        var test = @"Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
//         var testR = test.Split('\n').Select(CleanInput);
        var max = new Color(12, 13, 14);
        Console.WriteLine($"31: {ValidateGame(max, "Game 31: 19 green, 6 red; 4 green, 10 red; 12 green, 1 blue")}");
        return input.Split('\n').Sum(g => ValidateGame(max, g));
    }

    private int ValidateGame(Color max, string game)
    {
        int firstSpace = game.IndexOf(" ");
        var id = int.Parse(game.Substring(firstSpace + 1, game.IndexOf(':') - firstSpace - 1));
        var gameReveals = game.Substring(game.IndexOf(':') + 2).Split(';').ToArray();
        foreach(var r in gameReveals){
            // Console.Write(r + " => ");
            if (!Supported(max, Parse(r))){
                return 0;
            }
            // Console.WriteLine();
        }
        Console.Write($"{id},");
        return id;
    }


    public object PartTwo(string input) {
        return 0;
    }
}
