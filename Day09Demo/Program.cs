using Day09Demo;
using Day09Demo.AssignmentSample;

//Test1();
Test2();

void Test1()
{
    IModule module = new Module();

    module.AddModule(new ModuleInfo("AAAA", "CCC", 100, DateTime.Now));
    module.AddModule(new ModuleInfo("BBBB", "This is course", 200, DateTime.Now.AddMonths(2)));
    module.AddModule(new ModuleInfo("CCCC", "CCC", 100, DateTime.Now.AddDays(10)));
    module.AddModule(new ModuleInfo("DDDD", "DDDD", 200, DateTime.Now.AddDays(-5)));
    module.AddModule(new ModuleInfo("EEEE", "CCC", 100, DateTime.Now.AddMonths(6)));
    module.AddModule(new ModuleInfo("FFFF", "DDDD", 200.5443243332, DateTime.Now));

    module.DisplayAllModuleInfo();
}

void Test2()
{
    var student1 = new StudentInfo(101, "Raman Gujral", DateTime.Now.AddYears(-22));
    student1.AddModule(new ModuleInfo("HTML", "Web Designing Course Intro", 100, DateTime.Now));
    student1.AddModule(new ModuleInfo("CSS", "Web Designing Course Intro", 100, DateTime.Now));
    student1.AddModule(new ModuleInfo("BootStrap", "Web Designing Course Intro", 100, DateTime.Now));

    var student2 = new StudentInfo(101, "Gwarah Bujal", DateTime.Now.AddYears(-18));
    student2.AddModule(new ModuleInfo("C#", "Programming 101", 100, DateTime.Now));
    student2.AddModule(new ModuleInfo("Asp.NET MVC", "Programming 101", 100, DateTime.Now));
    student2.AddModule(new ModuleInfo("Angular", "Programming 101", 100, DateTime.Now));

    var student3 = new StudentInfo(101, "Shamitab Kachaan", DateTime.Now.AddMonths(-1000));
    student3.AddModule(new ModuleInfo("TOFEL", "English as a 2nd language", 100, DateTime.Now));

    student1.Display();
    student2.Display();
    student3.Display();
}

DemoArrayList.Test();