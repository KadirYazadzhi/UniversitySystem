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
                AdminsProfileOptions();
                break;
            case 2:
                AdminsOptionsAboutStudents();
                break;
            case 3:
                AdminsOptionsAboutProfessors();
                break;
            case 4:
                AdminsOptionsAboutSubjects();
                break;
            case 5:
                AdminsOptionsAboutCourse();
                break;
            case 6:
                AdminsOptionsAboutSchedules();
                break;
            case 7:
                AdminsOptionsAboutSpecialties();
                break;
            case 8:
                AdminsOptionsAboutPrograms();
                break;
            case 9:
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    private static void AdminsProfileOptions() {
        Console.WriteLine(" Choose an option:");
        Console.WriteLine("     1. Edit your profile.");
        Console.WriteLine("     2. Delete your profile.");
        Console.WriteLine("     3. Exit");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                
                break;
            case 2:
                
                break;
            case 3:
                
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    private static void AdminsOptionsAboutStudents() {
        Console.WriteLine("  Choose an option:");
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
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:
                
                break;
            case 8:

                break;
            case 9:

                break;
            case 10:

                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    private static void AdminsOptionsAboutProfessors() {
        Console.WriteLine("  Choose an option:");
        Console.WriteLine("     1. Add professor.");
        Console.WriteLine("     2. Edit professor.");
        Console.WriteLine("     3. View all information about professor.");
        Console.WriteLine("     4. View all information about every professor.");
        Console.WriteLine("     5. View all professors.");
        Console.WriteLine("     6. Delete professor.");
        Console.WriteLine("     7. Delete all professors.");
        Console.WriteLine("     8. Return back.");
        Console.WriteLine("     9. Exit.");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:
                
                break;
            case 8:

                break;
            case 9:

                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    private static void AdminsOptionsAboutSubjects() {
        Console.WriteLine("  Choose an option:");
        Console.WriteLine("     1. Add subject.");
        Console.WriteLine("     2. Edit subject.");
        Console.WriteLine("     3. View all subjects.");
        Console.WriteLine("     4. View all information about specific subject.");
        Console.WriteLine("     5. View all information about every subject.");
        Console.WriteLine("     6. Delete subject.");
        Console.WriteLine("     7. Delete all subjects.");
        Console.WriteLine("     8. Return back.");
        Console.WriteLine("     9. Exit.");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:
                
                break;
            case 8:

                break;
            case 9:

                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    private static void AdminsOptionsAboutCourse() {
        Console.WriteLine("  Choose an option:");
        Console.WriteLine("     1. Add course.");
        Console.WriteLine("     2. Edit course.");
        Console.WriteLine("     3. View all courses.");
        Console.WriteLine("     4. View all information about specific course.");
        Console.WriteLine("     5. View all information about every course.");
        Console.WriteLine("     6. Delete course.");
        Console.WriteLine("     7. Delete all courses.");
        Console.WriteLine("     8. Return back.");
        Console.WriteLine("     9. Exit.");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:
                
                break;
            case 8:

                break;
            case 9:

                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    private static void AdminsOptionsAboutSchedules() {
        Console.WriteLine("  Choose an option:");
        Console.WriteLine("     1. Add schedule.");
        Console.WriteLine("     2. Edit schedule.");
        Console.WriteLine("     3. View all schedules.");
        Console.WriteLine("     4. View all information about specific schedule.");
        Console.WriteLine("     5. View all information about every schedule.");
        Console.WriteLine("     6. Delete schedule.");
        Console.WriteLine("     7. Delete all schedules.");
        Console.WriteLine("     8. Return back.");
        Console.WriteLine("     9. Exit.");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:
                
                break;
            case 8:

                break;
            case 9:

                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    private static void AdminsOptionsAboutSpecialties() {
        Console.WriteLine("  Choose an option:");
        Console.WriteLine("     1. Add specialty.");
        Console.WriteLine("     2. Edit specialty.");
        Console.WriteLine("     3. View all specialties.");
        Console.WriteLine("     4. View all information about specific specialty.");
        Console.WriteLine("     5. View all information about every specialty.");
        Console.WriteLine("     6. Delete specialty.");
        Console.WriteLine("     7. Delete all specialties.");
        Console.WriteLine("     8. Return back.");
        Console.WriteLine("     9. Exit.");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:
                
                break;
            case 8:

                break;
            case 9:

                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    private static void AdminsOptionsAboutPrograms() {
        Console.WriteLine("  Choose an option:");
        Console.WriteLine("     1. Add program.");
        Console.WriteLine("     2. Edit program.");
        Console.WriteLine("     3. View all programs.");
        Console.WriteLine("     4. View all information about specific program.");
        Console.WriteLine("     5. View all information about every program.");
        Console.WriteLine("     6. Delete program.");
        Console.WriteLine("     7. Delete all programs.");
        Console.WriteLine("     8. Return back.");
        Console.WriteLine("     9. Exit.");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:
                
                break;
            case 8:

                break;
            case 9:

                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
}