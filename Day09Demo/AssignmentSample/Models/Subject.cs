using Day09Demo.AssignmentSample.Utility;

namespace Day09Demo.AssignmentSample;
public class Subject
{
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

    public void Display()
    {
        Console.WriteLine($"Subject Code: {Code}, Name: {Name}, Description: {Description}, Fees: {CourseFee}, StartDate: {StartDate}");
    }

    public static Subject CreateFromConsoleRead()
    {
        var code = ConsoleMessage.ReadLine<int>("Enter code: ");
        var name = ConsoleMessage.ReadLine<string>("Enter name: ");
        var description = ConsoleMessage.ReadLine<string>("Enter Description: ");
        var courseFees = ConsoleMessage.ReadLine<double>("Enter Course Fees: ");
        var startDate = ConsoleMessage.ReadLine<DateTime>("Enter Course Start Date: ");

        return new Subject (code, name, description, courseFees, startDate);
    }
}
