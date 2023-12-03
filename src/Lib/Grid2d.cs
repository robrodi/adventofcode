using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AdventOfCode;

public class Grid2d<T>{
    public int Width { get; private set;}
    public int Height { get; private set;}
    public T[] Data { get; private set; }
    public Grid2d(int width,  int height){
        Width = width;
        Height = height;
        Data = new T[width*height];
    }
    public static Grid2d<char> ParseChars(string input)
    {
        var lines = input.Split('\n');
        var g = new Grid2d<char>(lines[0].Length, lines.Length);
        for (var y = 0; y < lines.Length; y++)
        {
            var line = lines[y];
            for (var x = 0; x < line.Length; x++)
                g.Set(x, y, line[x]);
        }
        return g;
    }
    public T Get(Point p) => Get(p.X, p.Y);

    public T Get(int x, int y)
    {
        ValidateBoundaries(x, y);
        return Data[GetIndex(x, y)];
    }

    public IEnumerable<Point> AdjacentPoints(Point p, bool includeDiag = true) => AdjacentPoints(p.X, p.Y, includeDiag);

    public IEnumerable<Point> AdjacentPoints(int x, int y, bool includeDiag = true){
        ValidateBoundaries(x, y);
        var isTop = y == 0;
        var isBottom = y == Height - 1;
        var isLeft = x == 0;
        var isRight = x == Width - 1;
        
        // up
        if (!isTop){
            if (!isLeft && includeDiag) yield return new Point(x-1, y-1);
            yield return new Point(x, y-1);
            if (!isRight && includeDiag) yield return new Point(x+1, y-1);
        }
        // lateral
        if (!isLeft) yield return new Point(x - 1, y);
        if (!isRight) yield return new Point(x+1, y);
        
        // down
        if (!isBottom){
            if (!isLeft && includeDiag) yield return new Point(x-1, y+1);
            yield return new Point(x, y+1);
            if (!isRight && includeDiag)yield return new Point(x+1, y+1);
        }
    }
    public IEnumerable<Point> GetPoints() => GetPoints(Width, Height);
    public static IEnumerable<Point> GetPoints(int w, int h){
        for (var y = 0; y < h; y++)
        for (var x = 0; x < w; x++)
            yield return new Point(x,y);
    }
    public IEnumerable<T> AdjacentValues(int x, int y, bool includeDiag = true) {
        return AdjacentPoints(x, y, includeDiag).Select(s => Get(s.X, s.Y));
    }

    private int GetIndex(int x, int y) => GetIndex(x, y, Width);
    private static int GetIndex(int x, int y, int width)
    {
        return y * width + x;
    }
    public void Set(int x, int y, T value)
    {
        ValidateBoundaries(x, y);
        Data[GetIndex(x,y)] = value;
    }
    private void ValidateBoundaries(int x, int y)
     {
        if (x < 0 || x >= Width) throw new ArgumentOutOfRangeException($"X value of {x} is not between 0 & {Width}");
        if (y < 0 || y >= Height) throw new ArgumentOutOfRangeException($"Y value of {y} is not between 0 & {Height}");
     }
    public IEnumerable<T> GetRow(int rowNumber){
        ValidateBoundaries(0, rowNumber);
        return Data.Skip(GetIndex(0, rowNumber)).Take(Width);
    }
     public IEnumerable<T> GetColumn(int colNumber){
        ValidateBoundaries(colNumber, 0);
        for(var y = 0; y < Height; y++)
            yield return Data[GetIndex(colNumber, y)];
    }
    public void Resize(int width, int height)
    {
        var newData = new T[width*height];
        for(var y = 0; y < Math.Min(Height, height); y++){
            for(var x = 0; x < Math.Min(Height, height); x++){
                newData[GetIndex(x, y, width)] = Data[GetIndex(x,y)];
            }
        }
    }
}
