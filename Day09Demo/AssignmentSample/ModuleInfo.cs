namespace Day09Demo.AssignmentSample;
public class ModuleInfo
{
    public string Name;
    public string Description;
    public double CourseFees;
    public DateTime StartDate;

    public ModuleInfo(string name, string description, double courseFees, DateTime startDate)
    {
        Name = name;
        Description = description;
        CourseFees = courseFees;
        StartDate = startDate;
    }

    public void Display()
    {
        Console.WriteLine($"Module Name: {Name}, Description: {Description}, Fees: {CourseFees}, StartDate: {StartDate}");
    }
}

