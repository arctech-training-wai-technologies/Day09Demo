using System.Diagnostics;
using Day09Demo.AssignmentSample.Exceptions;
using Day09Demo.AssignmentSample.Interfaces;
using Day09Demo.AssignmentSample.Models;
using Day09Demo.AssignmentSample.Utility;

namespace Day09Demo.AssignmentSample;
public class SubjectCollection : ISubjectCollection
{
    private readonly List<Subject> _subjects = new();

    public void AddSubject(Subject subject)
    {
        _subjects.Add(subject);
    }

    public void AddSubject()
    {
        ConsoleMessage.ShowFormTitle("A D D   N E W   S U B J E C T");

        var subject = Subject.CreateFromConsoleRead();
        
        if (_subjects.Any(s => s.Code == subject.Code))
        {
            ConsoleMessage.ShowError($"Code {subject.Code} already exists");
            return;
        }

        _subjects.Add(subject);
    }

    public virtual void DisplayAll()
    {
        ShowReport(_subjects, " S U B J E C T    L I S T I N G");
    }

    public virtual void DisplayAny()
    {
        ConsoleMessage.ShowFormTitle("S E A R C H   S U B J E C T");
        var subjectSearchText = ConsoleMessage.ReadLine<string>("Enter a Subject name or subject code to search");

        Debug.Assert(subjectSearchText != null, "subjectSearchText != null");

        _ = int.TryParse(subjectSearchText, out var codeEntered);
        var subjectsFound = _subjects.Where(s => s.Name.Contains(subjectSearchText) || s.Code == codeEntered).ToList();

        ShowReport(subjectsFound, "S U B J E C T   S E A R C H   R E S U L T");
    }

    public virtual void Edit()
    {
        ConsoleMessage.ShowFormTitle("E D I T   S U B J E C T");

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

    public bool TryGetStudent(int subjectCode, out Subject subject)
    {
        subject = _subjects.SingleOrDefault(s => s.Code == subjectCode);
        return subject != null;
    }
}