namespace Day09Demo.AssignmentSample.Models;

public readonly struct ConsoleColorState
{
    private readonly ConsoleColor _foreground;
    private readonly ConsoleColor _background;

    public ConsoleColorState(ConsoleColor foreground, ConsoleColor background)
    {
        _foreground = foreground;
        _background = background;
    }

    public static void Reset()
    {
        Console.ResetColor();
    }

    public void Set()
    {
        Console.ForegroundColor = _foreground;
        Console.BackgroundColor = _background;
    }
}