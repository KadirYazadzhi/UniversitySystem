namespace UniversitySystem;

using System;
using System.Collections.Generic;
using System.Linq;

class Start {
    public static List<Admin> Admins = new List<Admin>();
    public static List<Student> Students = new List<Student>();
    public static List<Professor> Professors = new List<Professor>();
    public static List<Program> Programs = new List<Program>();
    public static List<Subject> Subjects = new List<Subject>();
    public static List<Course> Courses = new List<Course>();
    public static List<Schedule> Schedules = new List<Schedule>();
    public static List<Specialty> Specialties = new List<Specialty>();
    
    public static void Main(string[] args) {
        Console.WriteLine("Welcome to University System!");
        
        RegistrationAndLoginManage();
    }

    private static void RegistrationAndLoginManage() {
        Console.WriteLine("Choose an option:");
        Console.WriteLine(" 1. Register");
        Console.WriteLine(" 2. Login");
        
        Console.WriteLine("Enter your choice:");
        int choice = int.Parse(Console.ReadLine());
        
        switch (choice) {
            case 1:
                User.Register();
                break;
            case 2:
                User.Login();
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    private static void ChooseOption() {
        
    }

    private static void AdminOptions() {
        
        Console.WriteLine("Choose an option:");
        string choice = Console.ReadLine();
        
        Console.WriteLine("  1. Profile menu");
        Console.WriteLine("  2. Students menu");
        Console.WriteLine("  3. Professors menu");
        Console.WriteLine("  4. Subjects menu");
        Console.WriteLine("  5. Courses menu");
        Console.WriteLine("  6. Schedules");
        Console.WriteLine("  7. Specialties menu");
        Console.WriteLine("  8. Programs menu");
        Console.WriteLine("  9. Exit");
    }

    private static void AdminsProfileOptions() {
        Console.WriteLine("     1. Edit your profile.");
        Console.WriteLine("     2. Delete your profile.");
        Console.WriteLine("     3. Exit");
    }

    private static void AdminsOptionsAboutStudents() {
        Console.WriteLine("     1. Add student.");
        Console.WriteLine("     2. Edit student.");
        Console.WriteLine("     3. View all students.");
        Console.WriteLine("     4. View all information about every students.");
        Console.WriteLine("     5. View all information about one student.");
        Console.WriteLine("     6. View specific information about one student.");
        Console.WriteLine("     7. Delete student.");
        Console.WriteLine("     8. Delete all students.");
        Console.WriteLine("     9. Return back.");
        Console.WriteLine("     10. Exit.");
    }

    private static void AdminsOptionsAboutProfessors() {
        Console.WriteLine("     1. Add professor.");
        Console.WriteLine("     2. Edit professor.");
        Console.WriteLine("     3. View all information about professor.");
        Console.WriteLine("     4. View all information about every professor.");
        Console.WriteLine("     5. View all professors.");
        Console.WriteLine("     6. Delete professor.");
        Console.WriteLine("     7. Delete all professors.");
        Console.WriteLine("     8. Return back.");
        Console.WriteLine("     9. Exit.");
    }
}