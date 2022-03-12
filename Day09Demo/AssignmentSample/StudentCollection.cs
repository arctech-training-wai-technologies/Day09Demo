using System.Diagnostics;
using Day09Demo.AssignmentSample.Exceptions;
using Day09Demo.AssignmentSample.Utility;
using Day09Demo.AssignmentSample.Models;

namespace Day09Demo.AssignmentSample;

internal class StudentCollection
{
    private readonly List<Student> _students = new();

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public Student AddStudent(SubjectCollection subjectCollection)
    {
        ConsoleMessage.ShowFormTitle("A D D   N E W   S T U D E N T");

        try
        {
            var student = Student.CreateFromConsoleRead(subjectCollection);
            _students.Add(student);
            return student;
        }
        catch (DuplicateRollNoException e)
        {
            ConsoleMessage.ShowError($"Roll no {e.RollNo} already exists");
        }

        return null;
    }

    public virtual void DisplayAll()
    {
        ShowReport(_students, " S T U D E N T    L I S T I N G");
    }

    public void DisplayAny()
    {
        ConsoleMessage.ShowFormTitle("Search Student", 25);

        var studentSearchText = ConsoleMessage.ReadLine<string>("Enter Name or Roll No to search");

        _ = int.TryParse(studentSearchText, out var codeEntered);

        var studentsFound = _students.Where(s => s.Name.Contains(studentSearchText) || s.RollNo == codeEntered).ToList();

        ShowReport(studentsFound, "S T U D E N T   S E A R C H   R E S U L T");
    }

    public void EditStudent()
    {
        ConsoleMessage.ShowFormTitle("S T U D E N T   E D I T");

        var rollNo = ConsoleMessage.ReadLine<int>("Enter Roll No to update");

        var studentFound = _students.SingleOrDefault(s => s.RollNo == rollNo);

        if (studentFound == null)
        {
            ConsoleMessage.ShowError($"Roll No \"{rollNo}\" not found!!");
            return;
        }

        ConsoleMessage.ShowSubTitle("Existing Student Data is");
        ConsoleReport.DisplaySingleRecordReport(Student.HeaderText, studentFound);

        ConsoleMessage.ShowSubTitle("Enter new Student Data:");
        var newStudent = Student.CreateFromConsoleRead(null, false);

        studentFound.RollNo = newStudent.RollNo;
        studentFound.Name = newStudent.Name;
        studentFound.DateOfBirth = newStudent.DateOfBirth;

        ConsoleMessage.ShowHighlight("Student record successfully edited");
    }

    protected virtual void ShowReport(List<Student> students, string header)
    {
        var studentConsoleReport = new ConsoleReport(Student.HeaderText, 2);
        var subjectConsoleReport = new ConsoleReport(Subject.HeaderText, 7);

        subjectConsoleReport.SetRecordColor(ConsoleColor.Green, ConsoleColor.DarkMagenta);
        subjectConsoleReport.SetHeaderColor(ConsoleColor.DarkMagenta, ConsoleColor.Blue);

        studentConsoleReport.ShowReportTitle(header);

        studentConsoleReport.DisplayHeader();

        foreach (var student in students)
        {
            studentConsoleReport.DisplayRecord(student, true);

            subjectConsoleReport.DisplayHeader();
            student.Subjects.ForEach(s => subjectConsoleReport.DisplayRecord(s));
        }
    }
}