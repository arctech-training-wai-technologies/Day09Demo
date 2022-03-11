using Day09Demo.AssignmentSample.Interfaces;
using Day09Demo.AssignmentSample.Models;

namespace Day09Demo.AssignmentSample.Utility;

public class ConsoleReport : IOffset
{
    private readonly string _headerText;
    private readonly string _line;
    private readonly int _offset;
    private readonly string _offsetText;
    public int Width { get; }

    private ConsoleColorState _recordColorState, _headerColorState;
    
    public ConsoleReport(string headerText, int offset = 0, char lineCharacter = '-')
    {
        _headerText = headerText;
        Width = headerText.Length;
        _offset = offset;
        _offsetText = new string(' ', offset);
        _line = new string(lineCharacter, Width);

        _recordColorState = new ConsoleColorState(ConsoleColor.Black, ConsoleColor.Cyan);
        _headerColorState = new ConsoleColorState(ConsoleColor.White, ConsoleColor.Blue);
    }

    public void SetRecordColor(ConsoleColor foreColor, ConsoleColor backColor)
    {
        _recordColorState = new ConsoleColorState(foreColor, backColor);
    }

    public void SetHeaderColor(ConsoleColor foreColor, ConsoleColor backColor)
    {
        _headerColorState = new ConsoleColorState(foreColor, backColor);
    }

    public void DisplayHeader()
    {
        _headerColorState.Set();

        DisplayLine();
        Adjust();
        Console.WriteLine(_headerText);
        DisplayLine();

        _headerColorState.Reset();
    }

    public void DisplayRecord(IReportable reportable, bool displayTopLine = false)
    {
        _recordColorState.Set();

        if(displayTopLine)
            DisplayLine();

        Adjust();
        Console.WriteLine(reportable.RecordText);
        DisplayLine();

        _recordColorState.Reset();
    }

    public void DisplayLine()
    {
        Adjust();
        Console.WriteLine(_line);
    }

    public void Adjust()
    {
        Console.Write(_offsetText);
    }

    public void ShowReportTitle(string header)
    {
        _headerColorState.Set();

        ConsoleMessage.ShowReportTitle(header, this, Width);

        _headerColorState.Reset();
    }

    public static void DisplaySingleRecordReport(string headerText, IReportable reportable)
    {
        var consoleReport = new ConsoleReport(headerText, 5);
        consoleReport.DisplayHeader();
        consoleReport.DisplayRecord(reportable);
    }
}

public interface IOffset
{
    void Adjust();
}
