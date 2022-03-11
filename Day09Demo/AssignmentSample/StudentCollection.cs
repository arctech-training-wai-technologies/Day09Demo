using Day09Demo.AssignmentSample.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Demo.AssignmentSample
{
    internal class StudentCollection
    {
        private readonly List<Student> _students = new();

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void AddStudent()
        {
            var student = Student.CreateFromConsoleRead();
            _students.Add(student);
        }

        public virtual void DisplayAll()
        {
            ShowReport(_students, "Subject Listing");
        }

        public void DisplayAny()
        {
            ConsoleMessage.ShowFormTitle("Search Student", 25);

            var studentSearchText = ConsoleMessage.ReadLine<string>("Enter Name or Roll No to search: ");

            int.TryParse(studentSearchText, out int codeEntered);

            var studentsFound = _students.Where(s => s.Name.Contains(studentSearchText) || s.RollNo == codeEntered).ToList();

            studentsFound.ForEach(s => s.Display());
        }

        public void EditStudent()
        {
            ConsoleMessage.ShowFormTitle("Subject Edit", 25);
            
            var rollNo = ConsoleMessage.ReadLine<int>("Enter Roll No to update");

            var studentFound = _students.SingleOrDefault(s => s.RollNo == rollNo);

            if (studentFound == null)
            {
                ConsoleMessage.ShowError($"Roll No \"{rollNo}\" not found!!");
                return;
            }

            ConsoleMessage.ShowSubTitle("Existing Student Data is");
            studentFound.Display();

            ConsoleMessage.ShowSubTitle("Enter new Subject Data:");
            Student newStudent = Student.CreateFromConsoleRead(false);

            studentFound.RollNo = newStudent.RollNo;
            studentFound.Name = newStudent.Name;
            studentFound.DateOfBirth = newStudent.DateOfBirth;

            ConsoleMessage.ShowHighlight("Student record successfully edited");
        }

        public virtual void ShowReport(List<Student> students, string header)
        {
            ConsoleMessage.ShowReportTitle("Student List", 44);
            
            Console.WriteLine("|Roll No   |Name           |Start Date     |");
            Console.WriteLine("-------------------------------------------|");

            foreach (var student in students)
            {
                var displayName = student.Name.Left(15);
                Console.WriteLine($"|{student.RollNo,-10}|{displayName, -15}|{student.DateOfBirth,-15:dd-MMM-yyyy}|");
                Console.WriteLine("|------------------------------------------|");
                student.Subjects.ForEach(s => Console.WriteLine($"|Subject {s.Name} ({s.Code}), Starts on {s.StartDate:dd-MMM-yyyy}"));
                Console.WriteLine("|------------------------------------------|");
            }

            Console.WriteLine("============================================");
        }

    }
}
