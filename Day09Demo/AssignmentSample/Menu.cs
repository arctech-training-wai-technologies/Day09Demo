namespace Day09Demo.AssignmentSample
{
    public class Menu
    {
        public MenuItem SelectedMenuItem;

        protected readonly ConsoleColor _foreColor;
        protected readonly ConsoleColor _backColor;

        protected readonly string[] menuItems =
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
            _foreColor = foreColor;
            _backColor = backColor;
        }

        public virtual void Show(IMenuActions menuActions)
        {            
            do
            {
                DisplayMenuText();
                WaitForMenuItemKeyPressed();

                switch (SelectedMenuItem)
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
                    default:
                        break;
                }
            } while (true);
        }

        public virtual void DisplayMenuText()
        {
            Console.ForegroundColor = _foreColor;
            Console.ForegroundColor = _backColor;

            Array.ForEach(menuItems, item => Console.WriteLine(item));

            Console.ResetColor();
        }

        public virtual void WaitForMenuItemKeyPressed()
        {
            var keyInfo = Console.ReadKey(true);

            if (keyInfo.KeyChar >= '0' && keyInfo.KeyChar <= '9')
            {
                var asciiOfKeyChar = keyInfo.KeyChar - '0';
                SelectedMenuItem = (MenuItem)asciiOfKeyChar;
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
                SelectedMenuItem = MenuItem.Exit;
            else if (keyInfo.Key == ConsoleKey.X)
                SelectedMenuItem = MenuItem.ClearScreen;
        }        
    }
}
