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
            CheckStudentUsernameAndPassword(username, password);
            return;
        }
        
        if (type.ToLower() == "admin") {
            CheckAdminUsernameAndPassword(username, password);
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
}