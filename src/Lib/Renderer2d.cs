using System;
using System.Threading;

namespace AdventOfCode;
public struct ConsoleSprite{
    public ConsoleSprite(char c, ConsoleColor color = ConsoleColor.White){
        Character = c;
        ConsoleColor = color;
    }

    public char Character { get; set; }
    public ConsoleColor ConsoleColor { get; set; }
    public static bool operator== (ConsoleSprite obj1, ConsoleSprite obj2) => obj1.Character == obj2.Character;
    public static bool operator!= (ConsoleSprite obj1, ConsoleSprite obj2) => obj1.Character != obj2.Character;
    public override int GetHashCode() => Character.GetHashCode();
    public override bool Equals(object o) => Character == ((ConsoleSprite) o).Character;
    public static implicit operator ConsoleSprite(char c) => new ConsoleSprite(c);

}
class Renderer2d{
    private bool IsRedFront = true;
    private Grid2d<ConsoleSprite> Red, Blue;

    readonly TimeSpan sleepTime = TimeSpan.FromMilliseconds(1);
    public int Width { get; private set;}
    public int Height { get; private set;}

    public Renderer2d(int width,  int height){
        Width = width;
        Height = height;
        Red = new Grid2d<ConsoleSprite>(width, height);
        Blue = new Grid2d<ConsoleSprite>(width, height);
    }
    public void Draw(int x, int y, ConsoleSprite value)
    {
        Back.Set(x, y, value);
    }
    public ConsoleSprite Get(int x, int y) => Back.Get(x,y);
    public Grid2d<ConsoleSprite> Front => IsRedFront ? Red : Blue;
    public Grid2d<ConsoleSprite> Back => !IsRedFront ? Red : Blue;
    public void Render()
    {
        var s = (int)sleepTime.TotalMilliseconds;
        SwapBuffers();

        for (var y = 0; y < Height; y++)
            for (var x = 0; x < Width; x++)
            {
                var val = Front.Get(x, y);
                if (val == Back.Get(x, y)) continue;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = val.ConsoleColor;
                Console.Write(val.Character);
                Back.Set(x,y,val);
            }
        // if diff, render in place.
        Thread.Sleep(s);

    }

    private void SwapBuffers()
    {
        IsRedFront = !IsRedFront;
    }
}
