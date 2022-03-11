using System.Diagnostics;
using Day09Demo.AssignmentSample.Models;
using Day09Demo.AssignmentSample.Utility;

namespace Day09Demo.AssignmentSample;
public class SubjectCollection
{
    private readonly List<Subject> _subjects = new();

    public void AddSubject(Subject subject)
    {
        _subjects.Add(subject);
    }

    public void AddSubject()
    {
        ConsoleMessage.ShowFormTitle("Add new Subject", 15);

        var subject = Subject.CreateFromConsoleRead();

        _subjects.Add(subject);
    }

    public virtual void DisplayAll()
    {
        ShowReport(_subjects, " S U B J E C T    L I S T I N G");
    }

    public virtual void DisplayAny()
    {
        ConsoleMessage.ShowFormTitle("Search Subject", 25);
        var subjectSearchText = ConsoleMessage.ReadLine<string>("Enter a Subject name or subject code to search");

        Debug.Assert(subjectSearchText != null, "subjectSearchText != null");

        int.TryParse(subjectSearchText, out var codeEntered);
        var subjectsFound = _subjects.Where(s => s.Name.Contains(subjectSearchText) || s.Code == codeEntered).ToList();

        //subjectsFound.ForEach(s => s.Display());

        ShowReport(subjectsFound, "S U B J E C T   S E A R C H   R E S U L T");
    }

    public virtual void Edit()
    {
        ConsoleMessage.ShowFormTitle("Edit Subject");

        var subjectCode = ConsoleMessage.ReadLine<int>("Enter subject code to update");
        var subjectFound = _subjects.SingleOrDefault(s => s.Code == subjectCode);

        if (subjectFound == null)
        {
            ConsoleMessage.ShowError($"Subject \"{subjectCode}\" not found!!");
            return;
        }

        ConsoleMessage.ShowSubTitle("Existing Subject Data is");
        subjectFound.Display();
        
        ConsoleMessage.ShowSubTitle("Enter new Subject Data:");
        var newSubject = Subject.CreateFromConsoleRead();

        subjectFound.Code = newSubject.Code;
        subjectFound.Name = newSubject.Name;
        subjectFound.Description = newSubject.Description;
        subjectFound.CourseFee = newSubject.CourseFee;
        subjectFound.StartDate = newSubject.StartDate;
    }

    protected virtual void ShowReport(List<Subject> subjects, string header)
    {
        var consoleReport = new ConsoleReport(Subject.HeaderText, 5);

        consoleReport.ShowReportTitle(header);

        consoleReport.DisplayHeader();

        foreach (var subject in subjects)
        {
            consoleReport.DisplayRecord(subject, true);
        }
    }
}