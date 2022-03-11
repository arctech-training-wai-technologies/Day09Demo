using Day09Demo.AssignmentSample;

namespace Day09Demo;

internal class DemoArrayList
{
    public static void Test()
    {
        Subject[] Subjects = new Subject[10];
        List<Subject> listOfSubjectInfo = new List<Subject>();

        Subjects[0] = new Subject(101, "aaa", "aaa", 100, DateTime.Now);
        Subjects[1] = new Subject(102, "vvv", "ccc", 200, DateTime.Now);

        //listOfSubjectInfo[0] = new SubjectInfo("aaa", "aaa", 100, DateTime.Now);
        //listOfSubjectInfo[1] = new SubjectInfo("vvv", "ccc", 200, DateTime.Now);

        listOfSubjectInfo.Add(new Subject(103, "aaa", "aaa", 100, DateTime.Now));
        listOfSubjectInfo.Add(new Subject(104, "vvv", "ccc", 200, DateTime.Now));

        Console.ReadLine();
    }
}
