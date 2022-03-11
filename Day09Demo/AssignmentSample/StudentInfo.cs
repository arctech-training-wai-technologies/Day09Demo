using Day09Demo.AssignmentSample;

namespace Day09Demo;

public class StudentInfo
{
    public int RollNo;
    public string Name;
    public DateTime DateOfBirth;

    List<ModuleInfo> ModuleInfos;

    public StudentInfo(int rollNo, string name, DateTime dateOfBirth)
    {
        RollNo = rollNo;
        Name = name;
        DateOfBirth = dateOfBirth;

        ModuleInfos = new List<ModuleInfo>();
    }

    public void AddModule(ModuleInfo moduleInfo)
    {
        ModuleInfos.Add(moduleInfo);
    }

    public void Display()
    {
        Console.WriteLine($"Student RollNo:{RollNo}, Name:{Name}, DateOfBirth:{DateOfBirth: dd-MMM-yyyy}");

        string modulesText = "Student has enrolled in: ";
        foreach (var module in ModuleInfos)
        {
            modulesText += module.Name + ",";
        }
        Console.WriteLine(modulesText);
    }
}
