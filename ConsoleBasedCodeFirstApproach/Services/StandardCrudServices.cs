using ConsoleAppUsingCodeFirstApproach.Models;
using ConsoleBasedCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUsingCodeFirstApproach.Services
{
    internal class StandardCrudServices
    {
        private readonly EfCoreContext _context;

        public StandardCrudServices(EfCoreContext context)
        {
            _context = context;
        }

        // Create
        public void AddStandard()
        {
            Console.Write("Enter Standard Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            var standard = new Standard
            {
                StandardName = name,
                Description = description
            };

            _context.Standards.Add(standard);
            _context.SaveChanges();

            Console.WriteLine("Standard added successfully.");
        }

        // Read
        public void ListStandards()
        {
            var standards = _context.Standards.ToList();
            if (!standards.Any())
            {
                Console.WriteLine("No standards found.");
                return;
            }

            foreach (var std in standards)
            {
                Console.WriteLine($"{std.StandardId} - {std.StandardName}: {std.Description}");
            }
        }

        // Update
        public void UpdateStandard()
        {
            Console.Write("Enter Standard ID to update: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            var standard = _context.Standards.Find(id);
            if (standard == null)
            {
                Console.WriteLine("Standard not found.");
                return;
            }

            Console.Write($"Enter new Standard Name (current: {standard.StandardName}): ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
                standard.StandardName = newName;

            Console.Write($"Enter new Description (current: {standard.Description}): ");
            string newDesc = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newDesc))
                standard.Description = newDesc;

            _context.SaveChanges();
            Console.WriteLine("Standard updated successfully.");
        }

        // Delete
        public void DeleteStandard()
        {
            Console.Write("Enter Standard ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            var standard = _context.Standards.Find(id);
            if (standard == null)
            {
                Console.WriteLine("Standard not found.");
                return;
            }

            _context.Standards.Remove(standard);
            _context.SaveChanges();

            Console.WriteLine("Standard deleted successfully.");
        }
    }
}
