using Day09Demo.AssignmentSample;
using Day09Demo.AssignmentSample.Models;
// ReSharper disable StringLiteralTypo

namespace Day09Demo;

internal class Demo
{
    public static void Test1()
    {
        var subject = new SubjectCollection();

        subject.AddSubject(new Subject(101, "AAAA", "CCC", 100, DateTime.Now));
        subject.AddSubject(new Subject(102, "BBBB", "This is course", 200, DateTime.Now.AddMonths(2)));
        subject.AddSubject(new Subject(103, "CCCC", "CCC", 100, DateTime.Now.AddDays(10)));
        subject.AddSubject(new Subject(104, "DDDD", "DDDD", 200, DateTime.Now.AddDays(-5)));
        subject.AddSubject(new Subject(105, "EEEE", "CCC", 100, DateTime.Now.AddMonths(6)));
        subject.AddSubject(new Subject(106, "FFFF", "DDDD", 200.5443243332, DateTime.Now));

        subject.DisplayAll();
    }

    public static void Test2()
    {
        var student1 = new Student(101, "Raman Gujral", DateTime.Now.AddYears(-22));
        student1.AddSubject(new Subject(101, "HTML", "Web Designing Course Intro", 100, DateTime.Now));
        student1.AddSubject(new Subject(102, "CSS", "Web Designing Course Intro", 100, DateTime.Now));
        student1.AddSubject(new Subject(103, "BootStrap", "Web Designing Course Intro", 100, DateTime.Now));

        var student2 = new Student(102, "Gwarah Bujal", DateTime.Now.AddYears(-18));
        student2.AddSubject(new Subject(104, "C#", "Programming 101", 100, DateTime.Now));
        student2.AddSubject(new Subject(105, "Asp.NET MVC", "Programming 101", 100, DateTime.Now));
        student2.AddSubject(new Subject(106, "Angular", "Programming 101", 100, DateTime.Now));

        var student3 = new Student(103, "Shamitab Kachaan", DateTime.Now.AddMonths(-1000));
        student3.AddSubject(new Subject(107, "TOFEL", "English as a 2nd language", 100, DateTime.Now));

        Console.WriteLine(student1.RecordText);
        Console.WriteLine(student2.RecordText);
        Console.WriteLine(student3.RecordText);
    }

    public static void TestArrayList()
    {
        var subjects = new Subject[10];
        var listOfSubjectInfo = new List<Subject>();

        subjects[0] = new Subject(101, "aaa", "aaa", 100, DateTime.Now);
        subjects[1] = new Subject(102, "vvv", "ccc", 200, DateTime.Now);

        //listOfSubjectInfo[0] = new SubjectInfo("aaa", "aaa", 100, DateTime.Now);
        //listOfSubjectInfo[1] = new SubjectInfo("vvv", "ccc", 200, DateTime.Now);

        listOfSubjectInfo.Add(new Subject(103, "aaa", "aaa", 100, DateTime.Now));
        listOfSubjectInfo.Add(new Subject(104, "vvv", "ccc", 200, DateTime.Now));

        Console.ReadLine();
    }
}
