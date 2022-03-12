using Day09Demo.AssignmentSample.Exceptions;
using Day09Demo.AssignmentSample.Interfaces;
using Day09Demo.AssignmentSample.Utility;

namespace Day09Demo.AssignmentSample.Models;
public class Subject : IReportable
{
    private const string FieldTitleCode = nameof(Code);
    private const string FieldTitleStartDate = "Start Date";
    private const string FieldTitleDescription = nameof(Description);
    private const string FieldTitleName = nameof(Name);
    private const string FieldTitleCourseFee = "Course Fee";

    public int Code;
    public string Name;
    public string Description;
    public Fee CourseFee;
    public DateTime StartDate;

    public Subject(int code, string name, string description, Fee courseFee, DateTime startDate)
    {
        Code = code;
        Name = name;
        Description = description;
        CourseFee = courseFee;
        StartDate = startDate;
    }

    public static Subject CreateFromConsoleRead()
    {
        var code = ConsoleMessage.ReadLine<int>("Enter code");
        var name = ConsoleMessage.ReadLine<string>("Enter name");
        var description = ConsoleMessage.ReadLine<string>("Enter Description");
        var courseFees = ConsoleMessage.ReadLine<double>("Enter Course Fees");
        var startDate = ConsoleMessage.ReadLine<DateTime>("Enter Course Start Date");

        return new Subject(code, name, description, courseFees, startDate);
    }

    public string RecordText
    {
        get
        {
            var displayName = Name.Left(15);
            var displayDescription = Description.Left(25);

            return
                $"| {Code,-5} | {displayName,-15} | {displayDescription,-35} | {CourseFee,12:N0} | {StartDate,-11:dd-MMM-yyyy} |";
        }
    }

    public static string HeaderText => $"| {FieldTitleCode,-5} | {FieldTitleName,-15} | {FieldTitleDescription,-35} | {FieldTitleCourseFee,12} | {FieldTitleStartDate,-11} |".ToUpper();

    public void Display()
    {
        var consoleReport = new ConsoleReport(HeaderText);
        consoleReport.DisplayHeader();
        consoleReport.DisplayRecord(this);
    }
}