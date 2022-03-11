namespace Day09Demo.AssignmentSample.Models;

public struct ConsoleColorState
{
    public readonly ConsoleColor Foreground;
    public readonly ConsoleColor Background;

    public ConsoleColorState(ConsoleColor foreground, ConsoleColor background)
    {
        Foreground = foreground;
        Background = background;
    }

    public void Reset()
    {
        Console.ResetColor();
    }

    public void Set()
    {
        Console.ForegroundColor = Foreground;
        Console.BackgroundColor = Background;
    }
}