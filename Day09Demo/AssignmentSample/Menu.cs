using Day09Demo.AssignmentSample.Interfaces;

namespace Day09Demo.AssignmentSample;

public class Menu
{
    private MenuItem _selectedMenuItem;

    protected readonly ConsoleColor ForeColor;
    protected readonly ConsoleColor BackColor;

    protected readonly string[] MenuItems =
    {
        " 1) Add Student",
        " 2) Edit Student",
        " 3) Get any Student",
        " 4) Get all Students",
        " 5) Add Subject",
        " 6) Edit Subject",
        " 7) Get any Subject",
        " 8) Get all Subjects",
        " 9) Show Student Marks",
        " 0) Exit",
        " x) Clear Screen"
    };

    public Menu(ConsoleColor foreColor, ConsoleColor backColor)
    {
        ForeColor = foreColor;
        BackColor = backColor;
    }

    public virtual void Show(IMenuActions menuActions)
    {            
        do
        {
            DisplayMenuText();
            WaitForMenuItemKeyPressed();

            switch (_selectedMenuItem)
            {
                case MenuItem.AddStudent:
                    menuActions.AddStudent();
                    break;
                case MenuItem.EditStudent:
                    menuActions.EditStudent();
                    break;
                case MenuItem.GetAnyStudent:
                    menuActions.GetAnyStudent();
                    break;
                case MenuItem.GetAllStudents:
                    menuActions.GetAllStudents();
                    break;
                case MenuItem.AddSubject:
                    menuActions.AddSubject();
                    break;
                case MenuItem.GetAnySubject:
                    menuActions.GetAnySubject();
                    break;
                case MenuItem.GetAllSubjects:
                    menuActions.GetAllSubjects();
                    break;
                case MenuItem.EditSubject:
                    menuActions.EditSubject();
                    break;
                case MenuItem.ShowStudentMarks:
                    menuActions.ShowStudentMarks();
                    break;
                case MenuItem.ClearScreen:
                    Console.Clear();
                    break;
                case MenuItem.Exit:
                    return;
            }
        } while (true);
    }

    protected virtual void DisplayMenuText()
    {
        Console.ForegroundColor = ForeColor;
        Console.ForegroundColor = BackColor;

        Array.ForEach(MenuItems, Console.WriteLine);

        Console.ResetColor();
    }

    protected virtual void WaitForMenuItemKeyPressed()
    {
        var keyInfo = Console.ReadKey(true);

        if (keyInfo.KeyChar is >= '0' and <= '9')
        {
            var asciiOfKeyChar = keyInfo.KeyChar - '0';
            _selectedMenuItem = (MenuItem)asciiOfKeyChar;
        }
        else
            _selectedMenuItem = keyInfo.Key switch
            {
                ConsoleKey.Escape => MenuItem.Exit,
                ConsoleKey.X => MenuItem.ClearScreen,
                _ => _selectedMenuItem
            };
    }        
}