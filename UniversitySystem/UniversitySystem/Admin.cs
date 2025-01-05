namespace UniversitySystem;

public class Admin : User {
    public Admin(int id, string username, string email, string password, string role) 
        : base(id, username, email, password, role) {}
    
     public static void AdminsProfileOptions() {
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

    public static void AdminsOptionsAboutStudents() {
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

    public static void AdminsOptionsAboutProfessors() {
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

    public static void AdminsOptionsAboutSubjects() {
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

    public static void AdminsOptionsAboutCourse() {
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

    public static void AdminsOptionsAboutSchedules() {
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

    public static void AdminsOptionsAboutSpecialties() {
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

    public static void AdminsOptionsAboutPrograms() {
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
    
    public static void ViewAllStudents() {
        if (Start.Students.Count == 0) {
            Console.WriteLine("No students found");
            return;
        } 
        
        Console.WriteLine("All Students:");

        foreach (Student student in Start.Students) {
            Console.WriteLine($"    Username: {student.Username}, Full Name: {student.FullName}, Email: {student.Email}, Specialty: {student.Specialty}");
        }
    }

    public static void RemoveStudent() {
        Console.WriteLine("Enter the username of the student you want to remove:");
        string name = Console.ReadLine();
        
        int index = FindStudentByUsername(name);
        if (index == -1) {
            Console.WriteLine("Invalid username");
            return;
        }
        
        Console.WriteLine("Are you sure you want to remove this student? [Y/N]");
        char input = Console.ReadLine().ToLower()[0];
        
        if (input != 'y') return;
        
        Start.Students.RemoveAt(index);
        Console.WriteLine("Student removed");
    }

    public static void RemoveAllStudents() {
        Console.WriteLine("Are you sure you want to remove all students? [Y/N]");
        char input = Console.ReadLine().ToLower()[0];
        
        if (input != 'y') return;
        
        Start.Students.Clear();
        Console.WriteLine("You sucessfully removed all students.");
    }

    public static void ViewStudentGrades() {
        int index = FindUserIndex() ;
        if (index == -1) return;
        
        Console.WriteLine($"Student ${Start.Students[index].Username} have the following grades:");
        Console.WriteLine(string.Join(" " ,Start.Students[index].Grades));
    }

    public void ViewStudentProgram() {
        int index = FindUserIndex() ;
        if (index == -1) return;
        
        Console.WriteLine($"Student ${Start.Students[index].Username} have the following program:");
    
    }

    public static void ChangeStudentData() {
        int index = FindUserIndex() ;
        if (index == -1) return;
        
        Console.WriteLine("What do you want to change? [Username, Full Name, Email, Specialty, Program, Enrolled Courses, Grades, Discount] ");
        string type = Console.ReadLine();

        switch (type) {
            case "Username":
                ChangeStudentUsername(index);
                break;
            case "Full Name":
                ChangeStudentFullName(index);
                break;
            case "Email":
                ChangeStudentEmail(index);
                break;
            case "Specialty":
                ChangeStudentSpecialty(index);
                break;
            case "Program":
                break;
            case "Enrolled Courses":
                break;
            case "Grades":
                break;
            case "Discount":
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
    
    public static void ViewEnrolledCoursesOfStudent() {
        int index = FindUserIndex() ;
        if (index == -1) return;
        
        Console.WriteLine("Enrolled courses:");
        Console.WriteLine(string.Join(", " ,Start.Students[index].EnrolledCourses));
    }

    private static void ChangeStudentUsername(int index) {
        Console.WriteLine("Enter new username for this student:");
        string newUsername = Console.ReadLine();

        if (Start.Students[index].Username == newUsername) {
            Console.WriteLine("This is the current username of the student.");
            return;
        }

        if (Start.Students.Any(s => s.Username == newUsername)) {
            Console.WriteLine("This username is already taken.");
            return;
        }
        
        Start.Students[index].Username = newUsername;
                
        Console.WriteLine("You sucessfully changed student username.");
    }
    
    private static void ChangeStudentSpecialty(int index) {
        Console.WriteLine("Enter new specialty for this student:");
        Specialty newSpecialty = new Specialty(Console.ReadLine());

        if (Start.Students[index].Specialty == newSpecialty) {
            Console.WriteLine("This is the current specialty.");
            return;
        }

        if (!newSpecialty.isSpecialtyExist()) {
            Console.WriteLine("This specialty does not exist.");
            return;
        }
        
        Start.Students[index].Specialty = newSpecialty;
        Console.WriteLine("You sucessfully changed student specialty.");
    }
    
    private static void ChangeStudentFullName(int index) {
        Console.WriteLine("Enter new full name for this student:");
        string newFullName = Console.ReadLine();

        if (Start.Students[index].FullName == newFullName) {
            Console.WriteLine("This is the current full name.");
            return;
        }
        
        Start.Students[index].FullName = newFullName;
        Console.WriteLine("You sucessfully changed student full name.");
    }

    private static void ChangeStudentEmail(int index) {
        Console.WriteLine("Enter new email for this student:");
        string newEmail = Console.ReadLine();

        if (Start.Students[index].Email == newEmail) {
            Console.WriteLine("This is the current email.");
            return;
        }

        if (Start.Students.Any(s => s.Email == newEmail)) {
            Console.WriteLine("This email is already taken.");
            return;
        }
        
        Start.Students[index].Email = newEmail;
        Console.WriteLine("You sucessfully changed student email.");
    }

    private static int FindUserIndex() {
        Console.WriteLine("Enter student username:");
        string name = Console.ReadLine();

        int index = FindStudentByUsername(name);
        if (index == -1) {
            Console.WriteLine("Invalid username");
        }
        
        return index;
    }
    
    private static int FindStudentByUsername(string username) {
        for (int i = 0; i < Start.Students.Count; i++) {
            if (Start.Students[i].Username == username) return i;
        }
        
        return -1;
    }
}