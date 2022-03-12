using Day09Demo.AssignmentSample.Exceptions;
using Day09Demo.AssignmentSample.Interfaces;
using Day09Demo.AssignmentSample.Utility;

namespace Day09Demo.AssignmentSample.Models;

public class Student : IReportable
{
    private const string FieldTitleRollNo = "Roll No";
    private const string FieldTitleName = "Name";
    private const string FieldTitleDateOfBirth = "Date of Birth";

    public int RollNo;
    public string Name;
    public DateTime DateOfBirth;

    public readonly List<Subject> Subjects;

    public Student(int rollNo, string name, DateTime dateOfBirth)
    {
        RollNo = rollNo;
        Name = name;
        DateOfBirth = dateOfBirth;

        Subjects = new List<Subject>();
    }

    public void AddSubject(Subject subjectInfo)
    {
        Subjects.Add(subjectInfo);
    }

    public void AddSubjectRange(IEnumerable<Subject> subjects)
    {
        Subjects.AddRange(subjects);
    }

    public static Student CreateFromConsoleRead(ISubjectCollection subjectCollection, bool allowSubjectInput = true)
    {
        var rollNo = ConsoleMessage.ReadLine<int>("Enter roll no");
        var name = ConsoleMessage.ReadLine<string>("Enter name");
        var dateOfBirth = ConsoleMessage.ReadLine<DateTime>("Enter date of birth");

        var student = new Student(rollNo, name, dateOfBirth);

        if (!allowSubjectInput) return student;

        var subjects = ConsoleReadSubjects(subjectCollection);

        if (subjects.Any())
            student.AddSubjectRange(subjects);

        return student;
    }

    private static List<Subject> ConsoleReadSubjects(ISubjectCollection subjectCollection)
    {
        var subjects = new List<Subject>();
        var shouldAddSubject = ConsoleMessage.ReadLine<char>("Do you want to add a subject [y/n]");

        while (shouldAddSubject is 'y' or 'Y')
        {
            var subjectCode = ConsoleMessage.ReadLine<int>("Enter subject code to add");

            if(subjectCollection.TryGetStudent(subjectCode, out var subject)) 
                subjects.Add(subject);
            else
                ConsoleMessage.ShowError($"Subject code {subjectCode} not found!");

            shouldAddSubject = ConsoleMessage.ReadLine<char>("Do you want to add another subject [y/n]");
        }

        return subjects;
    }

    public static string HeaderText => $"| {FieldTitleRollNo,-20} | {FieldTitleName,-30} | {FieldTitleDateOfBirth,-13} |".ToUpper();

    public string RecordText
    {
        get
        {
            var displayName = Name.Left(30);
            return $"| {RollNo,-20} | {displayName,-30} | {DateOfBirth,-13:dd-MMM-yyyy} |";
        }
    }
}