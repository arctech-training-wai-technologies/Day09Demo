using Day09Demo.AssignmentSample;

namespace Day09Demo;

internal class DemoArrayList
{
    public static void Test()
    {
        ModuleInfo[] modules = new ModuleInfo[10];
        List<ModuleInfo> listOfModuleInfo = new List<ModuleInfo>();

        modules[0] = new ModuleInfo("aaa", "aaa", 100, DateTime.Now);
        modules[1] = new ModuleInfo("vvv", "ccc", 200, DateTime.Now);

        //listOfModuleInfo[0] = new ModuleInfo("aaa", "aaa", 100, DateTime.Now);
        //listOfModuleInfo[1] = new ModuleInfo("vvv", "ccc", 200, DateTime.Now);

        listOfModuleInfo.Add(new ModuleInfo("aaa", "aaa", 100, DateTime.Now));
        listOfModuleInfo.Add(new ModuleInfo("vvv", "ccc", 200, DateTime.Now));

        Console.ReadLine();
    }
}
