using ConsoleAppUsingDBFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUsingDBFirstApproach.Service
{
    internal class StudentCrudServices
    {
        private readonly EfCoreContext _context;

            public StudentCrudServices(EfCoreContext context)
            {
                _context = context;
            }

            public void AddStudent()
            {
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();

                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName
                };

                _context.Students.Add(student);
                _context.SaveChanges();
                Console.WriteLine("Student added successfully.");
            }

            public void ViewAllStudents()
            {
                var students = _context.Students.ToList();
                foreach (var s in students)
                {
                    Console.WriteLine($"{s.StudentId}: {s.FirstName} {s.LastName}");
                }
            }

            public void UpdateStudent()
            {
                Console.Write("Enter Student ID to Update: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid input.");
                    return;
                }

                var student = _context.Students.Find(id);
                if (student == null)
                {
                    Console.WriteLine("Student not found.");
                    return;
                }

                Console.WriteLine($"Current First Name: {student.FirstName}");
                Console.Write("Enter New First Name (leave blank to keep current): ");
                string newFirstName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newFirstName))
                {
                    student.FirstName = newFirstName;
                }

                Console.WriteLine($"Current Last Name: {student.LastName}");
                Console.Write("Enter New Last Name (leave blank to keep current): ");
                string newLastName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newLastName))
                {
                    student.LastName = newLastName;
                }

                _context.SaveChanges();
                Console.WriteLine("Student updated successfully.");
            }

            public void DeleteStudent()
            {
                Console.Write("Enter Student ID to Delete: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid input.");
                    return;
                }

                var student = _context.Students.Find(id);
                if (student == null)
                {
                    Console.WriteLine("Student not found.");
                    return;
                }

                _context.Students.Remove(student);
                _context.SaveChanges();
                Console.WriteLine("Student deleted.");
            }
    }
}

