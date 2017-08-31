using SystemIO.Common.Data;
using SystemIO.Cmd.Helpers;
using SystemIO.Common.Models;
using SystemIO.Common.Helpers;
using System;

namespace SystemIO.Cmd.Workflows
{
    public class AddStudentWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Add Student");
            Console.WriteLine(ConsoleIO.SeparatorBar);
            Console.WriteLine();

            Student newStudent = new Student
            {
                FirstName = ConsoleIO.GetRequiredStringFromUser("First Name: "),
                LastName = ConsoleIO.GetRequiredStringFromUser("Last Name: "),
                Major = ConsoleIO.GetRequiredStringFromUser("Major: "),
                GPA = ConsoleIO.GetRequiredDecimalFromUser("GPA: ")
            };

            Console.WriteLine();
            ConsoleIO.PrintStudentListHeader();
            Console.WriteLine(ConsoleIO.StudentLineFormat, newStudent.LastName + ", " + newStudent.FirstName, newStudent.Major, newStudent.GPA);

            Console.WriteLine();
            if(ConsoleIO.GetYesNoAnswerFromUser("Add the following information") == "Y")
            {
                StudentRepository repo = new StudentRepository(Settings.FilePath);
                repo.Add(newStudent);
                Console.WriteLine("Student Added!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Add Cancelled");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
