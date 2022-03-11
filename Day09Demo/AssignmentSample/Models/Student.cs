using Day09Demo.AssignmentSample;
using Day09Demo.AssignmentSample.Utility;

namespace Day09Demo;

public class Student
{
    public int RollNo;
    public string Name;
    public DateTime DateOfBirth;

    public List<Subject> Subjects;

    public Student(int rollNo, string name, DateTime dateOfBirth)
    {
        RollNo = rollNo;
        Name = name;
        DateOfBirth = dateOfBirth;

        Subjects = new List<Subject>();
    }

    public void AddSubject(Subject SubjectInfo)
    {
        Subjects.Add(SubjectInfo);
    }

    public void Display()
    {
        Console.WriteLine($"Student RollNo:{RollNo}, Name:{Name}, DateOfBirth:{DateOfBirth: dd-MMM-yyyy}");

        Subjects.ForEach(s => s.Display());
    }

    public static Student CreateFromConsoleRead(bool allowSubjectInput = true)
    {
        var rollNo = ConsoleMessage.ReadLine<int>("Enter rollno: ");
        var name = ConsoleMessage.ReadLine<string>("Enter name: ");        
        var dateOfBirth = ConsoleMessage.ReadLine<DateTime>("Enter date of birth: ");

        var student = new Student(rollNo, name, dateOfBirth);

        if (allowSubjectInput)
        {
            var shouldAddSubject = ConsoleMessage.ReadLine<char>("Do you want to add a subject [y/n]: ");

            while (shouldAddSubject == 'y' || shouldAddSubject == 'Y')
            {
                var subject = Subject.CreateFromConsoleRead();
                student.Subjects.Add(subject);

                shouldAddSubject = ConsoleMessage.ReadLine<char>("Do you want to add another subject [y/n]: ");
            }
        }

        return student;
    }
}
