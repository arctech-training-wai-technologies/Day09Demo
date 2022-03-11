using Day09Demo.AssignmentSample;
using Day09Demo.AssignmentSample.Utility;

namespace Day09Demo;
public class SubjectCollection : ISubjectCollection
{
    private readonly List<Subject> _subjects = new();

    public void AddSubject(Subject subject)
    {
        _subjects.Add(subject);
    }

    public void AddSubject()
    {
        Console.WriteLine("--------------");
        Console.WriteLine("Add new Subject");
        Console.WriteLine("--------------");

        var subject = Subject.CreateFromConsoleRead();

        _subjects.Add(subject);
    }

    public virtual void DisplayAll()
    {
        ShowReport(_subjects, "Subject Listing");
    }

    public virtual void DisplayAny()
    {
        ConsoleMessage.ShowFormTitle("Search Subject", 25);

        var subjectSearchText = ConsoleMessage.ReadLine<string>("Enter a Subject name or subject code to search");

        int.TryParse(subjectSearchText, out int codeEntered);

        var subjectsFound = _subjects.Where(s => s.Name.Contains(subjectSearchText) || s.Code == codeEntered).ToList();

        subjectsFound.ForEach(s => s.Display());
    }

    public virtual void Edit()
    {
        ConsoleMessage.ShowFormTitle("Edit Subject");

        var subjectCode = ConsoleMessage.ReadLine<int>("Enter subject code to update: ");

        var subjectFound = _subjects.SingleOrDefault(s => s.Code == subjectCode);

        if (subjectFound == null)
        {
            ConsoleMessage.ShowError($"Subject \"{subjectCode}\" not found!!");
            return;
        }

        ConsoleMessage.ShowSubTitle("Existing Subject Data is");
        subjectFound.Display();

        ConsoleMessage.ShowSubTitle("Enter new Subject Data:");
        Subject newSubject = Subject.CreateFromConsoleRead();

        subjectFound.Code = newSubject.Code;
        subjectFound.Name = newSubject.Name;
        subjectFound.Description = newSubject.Description;
        subjectFound.CourseFee = newSubject.CourseFee;
        subjectFound.StartDate = newSubject.StartDate;
    }

    public virtual void ShowReport(List<Subject> subjects, string header)
    {
        ConsoleMessage.ShowReportTitle(header, 70);
        Console.WriteLine("|Name           |Description              |Fees      |Start Date     |");
        Console.WriteLine("----------------------------------------------------------------------");

        foreach (var Subject in subjects)
        {
            var displayName = Subject.Name.Left(15);
            var displayDescription = Subject.Name.Left(15);
            
            Console.WriteLine($"|{displayName,-15}|{displayDescription,-25}|{Subject.CourseFee,10:N}|{Subject.StartDate,-15:dd-MMM-yyyy}|");
        }

        Console.WriteLine("----------------------------------------------------------------------");
    }
}