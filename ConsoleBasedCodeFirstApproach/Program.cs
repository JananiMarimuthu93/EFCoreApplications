using ConsoleAppUsingCodeFirstApproach.Services;
using ConsoleBasedCodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    public static void Main(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<EfCoreContext>();
        optionsBuilder.UseSqlServer("Data Source=KDJ-LAPTOP\\SQLEXPRESS;Initial Catalog=efcore;Integrated Security=True;TrustServerCertificate=True");

        using var context = new EfCoreContext(optionsBuilder.Options);
        var service = new StandardCrudServices(context);

        while (true)
        {
            Console.WriteLine("\n--- Standard CRUD Menu ---");
            Console.WriteLine("1. Add Standard");
            Console.WriteLine("2. List Standards");
            Console.WriteLine("3. Update Standard");
            Console.WriteLine("4. Delete Standard");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    service.AddStandard();
                    break;
                case "2":
                    service.ListStandards();
                    break;
                case "3":
                    service.UpdateStandard();
                    break;
                case "4":
                    service.DeleteStandard();
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


