namespace UniversitySystem;

public class Admin : User {
    public Admin(int id, string username, string email, string password, string role) 
        : base(id, username, email, password, role) {}
}