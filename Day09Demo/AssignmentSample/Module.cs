using Day09Demo.AssignmentSample;

namespace Day09Demo;
public class Module : IModule
{
    //ModuleInfo[] modules = new ModuleInfo[10];
    List<ModuleInfo> modules = new List<ModuleInfo>();

    public void AddModule(ModuleInfo moduleInfo)
    {
        modules.Add(moduleInfo);
    }

    public void AddModule()
    {
        Console.WriteLine("--------------");
        Console.WriteLine("Add new Module");
        Console.WriteLine("--------------");
        Console.Write("Enter name: ");
        var name = Console.ReadLine();

        Console.Write("Enter Description: ");
        var description = Console.ReadLine();

        Console.Write("Enter Course Fees: ");
        var courseFeesText = Console.ReadLine();

        Console.Write("Enter Course Start Date: ");
        var startDateText = Console.ReadLine();

        ModuleInfo module = new ModuleInfo(name, description, double.Parse(courseFeesText), DateTime.Parse(startDateText));
        modules.Add(module);
    }

    public void DisplayAllModuleInfo()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Module Listing Report");
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("|Name           |Description              |Fees      |Start Date     |");
        Console.WriteLine("----------------------------------------------------------------------");

        foreach (var module in modules)
        {
            //module.Display();
            Console.WriteLine($"|{module.Name,-15}|{module.Description,-25}|{module.CourseFees,10:N}|{module.StartDate,-15:dd-MMM-yyyy}|");
        }
        Console.WriteLine("----------------------------------------------------------------------");
    }

    public void DisplayAnyModuleInfo()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Search Module");
        Console.WriteLine("--------------------------------");

        Console.Write("Enter a module name to search");
    }

    public void UpdateModule()
    {
        throw new NotImplementedException();
    }
}

