using System;
using System.Linq;

namespace AdventOfCode.Y2023.Day02;

[ProblemName("Cube Conundrum")]
class Solution : Solver {

    public record Color (int Red, int Green, int Blue);
    public static Color Parse(string reveal){
        var values = reveal.Split(',').Select(s => s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)).ToArray();
        var red = 0; 
        var green = 0;
        var blue = 0;

        foreach(var v in values)
        {
            if (v[1] == "red") red = int.Parse(v[0]);
            if (v[1] == "green") green = int.Parse(v[0]);
            if (v[1] == "blue") blue = int.Parse(v[0]);
        }
        return new Color(red, green, blue);
    }
    public static bool Supported(Color maxes, Color sample) => maxes.Blue >= sample.Blue && maxes.Red >= sample.Red && maxes.Green >= sample.Green;
    public static void Print(Color c) {
        Console.WriteLine($"color: R: {c.Red} G: {c.Green}, B: {c.Blue}");
    }
    public object PartOne(string input)
    {
        var max = new Color(12, 13, 14);
        return input.Split('\n').Sum(g => ValidateGame(max, g));
    }

    private int ValidateGame(Color max, string game)
    {
        int firstSpace = game.IndexOf(" ");
        var id = int.Parse(game.Substring(firstSpace + 1, game.IndexOf(':') - firstSpace - 1));
        foreach (var r in ParseRevealsFromGame(game))
        {
            if (!Supported(max, r))
            {
                return 0;
            }
        }
        return id;
    }
    private static Color[] ParseRevealsFromGame(string game) =>
        game.Substring(game.IndexOf(':') + 2).Split(';').Select(Parse).ToArray();
    public Color Max(params Color[] colors){
        int r = 0, g = 0, b = 0;
        foreach(var c in colors)
        {
            r = Math.Max(r, c.Red);
            g = Math.Max(g, c.Green);
            b = Math.Max(b, c.Blue);
        }
        return new Color(r, g, b);
    }

    public int Power(Color c) => c.Red * c.Blue * c.Green;
    public object PartTwo(string input) {
        var t1 = Power(Max(ParseRevealsFromGame("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green").ToArray()));
        var t1_expected = 48;
        if (t1 != t1_expected) throw new Exception("T1 Failed.");

        return input.Split('\n')
                    .Select(ParseRevealsFromGame)
                    .Select(Max)
                    .Select(Power)
                    .Sum();
    }
}
