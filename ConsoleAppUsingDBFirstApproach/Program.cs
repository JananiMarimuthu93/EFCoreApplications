using ConsoleAppUsingDBFirstApproach.Models;
using ConsoleAppUsingDBFirstApproach.Service;

internal class Program
{
    private static void Main(string[] args)
    {
        var context = new EfCoreContext();
        var studentService = new StudentCrudServices(context);

        while (true)
        {
            Console.WriteLine("\n--- Student CRUD Menu ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    studentService.AddStudent();
                    break;
                case "2":
                    studentService.ViewAllStudents();
                    break;
                case "3":
                    studentService.UpdateStudent();
                    break;
                case "4":
                    studentService.DeleteStudent();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

    }
}