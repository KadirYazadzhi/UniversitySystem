using System.Collections;

namespace UniversitySystem;

public class User {
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    
    public static User LoggedInUser { get; private set; }

    protected User(int id, string username, string email, string password, string role) {
        Id = id;
        Username = username;
        Email = email;
        Password = password;
        Role = role;
    }

    public void Register() {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        if (FindStudentUsername(username)) {
            Console.WriteLine("Username already exists");
            return;
        }
        
        Console.WriteLine("Enter your full name:");
        string fullName = Console.ReadLine();
        
        Console.WriteLine("Enter your email:");
        string email = Console.ReadLine();

        if (IsEmailExist(email)) {
            Console.WriteLine("Email already exists");
            return;
        }
        
        Console.WriteLine("Enter your speciality: ");
        Specialty specialty = null;

        while (true) {
            specialty =  new Specialty(Console.ReadLine());
            
            if (!specialty.isSpecialtyExist()) {
                Console.WriteLine("Specialty doesn't exist");
                Console.WriteLine("Are you want to view all the specialties? [y/n]");
                
                char key = Console.ReadKey().KeyChar;

                if (key != 'y') continue;
            
                Specialty.ViewAllSpecialties();
            }
            else {
                break;
            }
        }
        
        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();

        if (!CheckPasswordIsStrong(password)) return;
        
        Student student = new Student(
            id: GetLastId() + 1,
            username: username,
            email: email,
            password: password,
            role: "Student",
            fullName: fullName,
            specialty: specialty,
            program: new Program(),
            enrolledCourses: new List<Course>()
        );
        
        Start.Students.Add(student);
        Console.WriteLine("You successfully registered");
    }

    public void Login() {
        Console.WriteLine("Enter the type of the user you want to login: ");
        string type = Console.ReadLine();

        if (type.ToLower() != "admin" || type.ToLower() != "student") {
            Console.WriteLine("Invalid type");
            return;
        }
        
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();

        if (type.ToLower() == "admin" && !FindAdminUsername(username) || type.ToLower() == "student" && !FindStudentUsername(username)) {
            Console.WriteLine("Invalid username");
            return;
        }
        
        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();

        if (type.ToLower() == "student") {
            if (CheckStudentUsernameAndPassword(username, password)) {
                Console.WriteLine("You are logged in as student!");
            }
            return;
        }
        
        if (type.ToLower() == "admin") {
            if (CheckAdminUsernameAndPassword(username, password)) {
                Console.WriteLine("You are logged in as admin!");
            }
            return;
        }
        
        Console.WriteLine("Invalid password");
    }

    private bool FindStudentUsername(string username) {
        return Start.Students.Any(student => student.Username == username);
    }

    private bool FindAdminUsername(string username) {
        return Start.Admins.Any(admin => admin.Username == username);
    }

    private bool CheckStudentUsernameAndPassword(string username, string password) {
        Student student = Start.Students.FirstOrDefault(s => s.Username == username && s.Password == password);
        
        if (student != null) {
            LoggedInUser = student;
            return true;
        }
        
        return false;
    }

    private bool CheckAdminUsernameAndPassword(string username, string password) {
        Admin admin = Start.Admins.FirstOrDefault(a => a.Username == username && a.Password == password);
        
        if (admin != null) {
            LoggedInUser = admin;
            return true;
        }
        
        return false;
    }

    private bool IsEmailExist(string email) {
        return Start.Students.Any(student => student.Email == email);
    }

    private bool CheckPasswordIsStrong(string password) {
        if (password.Length < 6) {
            Console.WriteLine("Password must be at least 6 characters long");
            return false;
        }
        if (!password.Any(char.IsUpper)) {
            Console.WriteLine("Password must contain at least one uppercase letter");
            return false;
        }
        if (!password.Any(char.IsLower)) {
            Console.WriteLine("Password must contain at least one lowercase letter");
            return false;
        }
        if (!password.Any(char.IsDigit)) {
            Console.WriteLine("Password must contain at least one digit");
            return false;
        }
        if (!password.Any(ch => "!@#$%^&*()_+[]{}|;:',.<>?".Contains(ch))) {
            Console.WriteLine("Password must contain at least one special character");
            return false;
        }
        return true;
    }

    private int GetLastId() {
        return Start.Students.Count;
    }
}