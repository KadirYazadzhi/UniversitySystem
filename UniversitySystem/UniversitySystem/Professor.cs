namespace UniversitySystem;

public class Professor : User {
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Department { get; set; }
    public List<Subject> Subjects { get; set; }
    public List<Course> Courses { get; set; }
    
    public Professor(int id, string username, string email, string password, string role, string fullName, string department, List<Subject> subjects, List<Course> courses)
        : base(id, username, email, password, role) {
        FullName = fullName;
        Department = department;
        Subjects = subjects ?? new List<Subject>();
        Courses = courses ?? new List<Course>();
    }

    public static void DeleteProfessor() {
        if (User.LoggedInUser.Role == "Professor") {
            Console.WriteLine("Are you sure you want to delete your profile?");
            char choice = Console.ReadLine()[0];
            
            if (choice != 'y') return;
            
            Professor professor = Start.Professors[User.LoggedInUser.Id - 1];

            Start.Professors.Remove(professor);
            Console.WriteLine("Profile deleted successfully.");
            return;
        }
        else if (User.LoggedInUser.Role == "Admin") {
            Console.WriteLine("Enter the username of the professor you want to delete.");
            string username = Console.ReadLine();

            if (Start.Professors.Any(p => p.Username == username) == false) {
                Console.WriteLine("There is no professor with that username.");
                return;
            }
            
            Professor professor = Start.Professors.FirstOrDefault(p => p.Username == username);
            Start.Professors.Remove(professor);
            Console.WriteLine("Professor deleted successfully.");
        }

    }
    public static void ChangeProfessorData() {
        string name = string.Empty;
        if (User.LoggedInUser.Role == "Professor") {
            name = User.LoggedInUser.Username;
        }
        else {
            Console.Write("Enter professor name: ");
            name = Console.ReadLine();

            if (Start.Professors.Any(n => n.Username == name) == false) {
                Console.WriteLine("Professor with that username does not exist");
                return;
            }
        }
        
        Console.WriteLine("What you want to change? [Username, Full Name, Email, Password, Department, Subjects, Courses]");
        string input = Console.ReadLine();

        switch (input) {
            case "Username":
                ChangeProfessorUsername();
                break;
            case "Full Name":
                ChangeProfessorFullName();
                break;
            case "Email":
                ChangeProfessorEmail();
                break;
            case "Password":
                ChangeProfessorPassword();
                break;
            case "Department":
                ChangeProfessorDepartment();
                break;
            case "Subjects":
                ChangeProfessorSubjects();
                break;
            case "Courses":
                ChangeProfessorCourses();
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
                
        }
    }

    private static void ChangeProfessorUsername() {
        Console.Write("Enter new username: ");
        string username = Console.ReadLine();
        
        if (Start.Professors.Any(n => n.Username == username)) {
            Console.WriteLine("Professor with that username already exists");
            return;
        }

        if (User.LoggedInUser.Username == username) {
            Console.WriteLine("This is your current username.");
            return;
        }
        
        Professor Professor = Start.Professors.FirstOrDefault(n => n.Username == username);
        
        Professor.Username = username;
    }

    private static void ChangeProfessorFullName() {
        Console.Write("Enter new full name: ");
        string fullName = Console.ReadLine();
        
        Start.Professors.FirstOrDefault(n => n.FullName == fullName).FullName = fullName;
    }

    private static void ChangeProfessorEmail() {
        
    }

    private static void ChangeProfessorPassword() {
        
    }

    private static void ChangeProfessorDepartment() {
        
    }

    private static void ChangeProfessorSubjects() {
        
    }

    private static void ChangeProfessorCourses() {
        
    }

    private static Professor GetProfessorByName(string fullName) {
        for (int i = 0; i < Start.Professors.Count; i++) {
            if (Start.Professors[i].FullName == fullName) {
                return Start.Professors[i];
            }
        }
        
        return null;
    }

    public static Professor FindProfessor(string firstMessage) {
        Console.WriteLine(firstMessage);
        string data = Console.ReadLine();
        
        Professor professor = null;
        if (int.TryParse(data, out _)) {
            int id = int.Parse(data);

            if (GetProfessorById(id) == null) {
                Console.WriteLine("Professor does not exist!");
                return null;
            }
            
            professor = GetProfessorById(id);
        }
        else {
            if (GetProfessorByName(data) == null) {
                Console.WriteLine("Professor does not exist!");
                return null;
            }
            
            professor = GetProfessorByName(data);
        }
        
        return professor;
    }

     private static Professor GetProfessorById(int id) {
        return Start.Professors.FirstOrDefault(professor => professor.Id == id);
    }

    public static bool FindCourseForProfessor(int courseIndex) {
        return Start.Professors.Any(professor => professor.Courses.Contains(Start.Courses[courseIndex]));
    }
}