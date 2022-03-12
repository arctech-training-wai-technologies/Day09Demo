using Day09Demo.AssignmentSample.Interfaces;
using Day09Demo.AssignmentSample.Models;
// ReSharper disable StringLiteralTypo

namespace Day09Demo.AssignmentSample;

internal class StudentManagement : IMenuActions
{
    private readonly Menu _menu;
    private readonly StudentCollection _students;
    private readonly SubjectCollection _subjects;

    public StudentManagement()
    {
        _menu = new Menu(ConsoleColor.Red, ConsoleColor.Green);
        _students =  new StudentCollection();
        _subjects = new SubjectCollection();


        LoadTestData();
    }

    private void LoadTestData()
    {
        var subject1 = new Subject(1, "Java", "Some programing language", 5000, DateTime.Now.AddDays(25));
        var subject2 = new Subject(2, "C#", "My favorite programing language", 3500, DateTime.Now.AddDays(18));
        var subject3 = new Subject(3, "HTML", "Web Front ending ", 2500, DateTime.Now.AddDays(12));
        var subject4 = new Subject(4, "Asp.NET", "Web Back ending ", 8500, DateTime.Now.AddDays(5));
        var subject5 = new Subject(5, "MVC", "Modern Web", 10000, DateTime.Now.AddDays(7));

        var student1 = new Student(101, "AAAA", DateTime.Now.AddYears(-22));
        student1.Subjects.Add(subject1);
        student1.Subjects.Add(subject3);

        var student2 = new Student(102, "BBBB", DateTime.Now.AddYears(-25));
        student2.Subjects.Add(subject2);
        student2.Subjects.Add(subject3);

        var student3 = new Student(103, "CCCC", DateTime.Now.AddYears(-18));
        student3.Subjects.Add(subject4);
        student3.Subjects.Add(subject5);

        _subjects.AddSubject(subject1);
        _subjects.AddSubject(subject2);
        _subjects.AddSubject(subject3);
        _subjects.AddSubject(subject4);
        _subjects.AddSubject(subject5);

        _students.AddStudent(student1);
        _students.AddStudent(student2);
        _students.AddStudent(student3);
    }

    public void Start()
    {
        _menu.Show(this);
    }

    public void ShowStudentMarks()
    {

    }

    public void EditSubject()
    {
        _subjects.Edit();
    }

    public void ShowAllSubjects()
    {
        _subjects.DisplayAll();
    }

    public void ShowAnySubject()
    {
        _subjects.DisplayAny();
    }

    public void AddSubject()
    {
        _subjects.AddSubject();
    }

    public void ShowAllStudents()
    {
        _students.DisplayAll();
    }

    public void ShowAnyStudent()
    {
        _students.DisplayAny();
    }

    public void EditStudent()
    {
        _students.EditStudent();
    }

    public void AddStudent()
    {
        _students.AddStudent(_subjects);
    }        
}