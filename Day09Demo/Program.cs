using Day09Demo;
using Day09Demo.AssignmentSample;

// DemoArrayList.Test();
// StudentManagement.Test1();
// StudentManagement.Test2();

var studentManagement = new StudentManagement();
studentManagement.Start();


void Test1()
{
    ISubjectCollection Subject = new SubjectCollection();

    Subject.AddSubject(new Subject(101, "AAAA", "CCC", 100, DateTime.Now));
    Subject.AddSubject(new Subject(102, "BBBB", "This is course", 200, DateTime.Now.AddMonths(2)));
    Subject.AddSubject(new Subject(103, "CCCC", "CCC", 100, DateTime.Now.AddDays(10)));
    Subject.AddSubject(new Subject(104, "DDDD", "DDDD", 200, DateTime.Now.AddDays(-5)));
    Subject.AddSubject(new Subject(105, "EEEE", "CCC", 100, DateTime.Now.AddMonths(6)));
    Subject.AddSubject(new Subject(106, "FFFF", "DDDD", 200.5443243332, DateTime.Now));

    Subject.DisplayAll();
}

void Test2()
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

    student1.Display();
    student2.Display();
    student3.Display();
}