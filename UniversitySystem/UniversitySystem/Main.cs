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

    private static void ChooseOption(int startChoice) {
        if (startChoice == 1) {
            // TODO: Students Options
        }

        if (User.LoggedInUser.Role == "Admin") {
            AdminOptions();
        }
        else if (User.LoggedInUser.Role == "Student") {
            
        }
        else if (User.LoggedInUser.Role == "Professor") {
            
        }
    }

    private static void AdminOptions() {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("  1. Profile menu");
        Console.WriteLine("  2. Students menu");
        Console.WriteLine("  3. Professors menu");
        Console.WriteLine("  4. Subjects menu");
        Console.WriteLine("  5. Courses menu");
        Console.WriteLine("  6. Schedules menu");
        Console.WriteLine("  7. Specialties menu");
        Console.WriteLine("  8. Programs menu");
        Console.WriteLine("  9. Exit");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                Admin.AdminsProfileOptions();
                break;
            case 2:
                Admin.AdminsOptionsAboutStudents();
                break;
            case 3:
                Admin.AdminsOptionsAboutProfessors();
                break;
            case 4:
                Admin.AdminsOptionsAboutSubjects();
                break;
            case 5:
                Admin.AdminsOptionsAboutCourse();
                break;
            case 6:
                Admin.AdminsOptionsAboutSchedules();
                break;
            case 7:
                Admin.AdminsOptionsAboutSpecialties();
                break;
            case 8:
                Admin.AdminsOptionsAboutPrograms();
                break;
            case 9:
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

   
}