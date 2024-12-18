namespace UniversitySystem;

public class Student : User {
    public string FullName { get; set; }
    public string Speciality { get; set; }
    public Program Program { get; set; }
    public List<Course> EnrolledCourses { get; set; }
    public Dictionary<Subject, double> Grades { get; set; }
    public double Discount { get; set; }

    public Student(int id, string username, string email, string password, string role, string fullName, string speciality, Program program, List<Course> enrolledCourses)
        : base(id, username, email, password, role) {
        FullName = fullName;
        Speciality = speciality;
        Program = program;
        EnrolledCourses = enrolledCourses ?? new List<Course>();
        Grades = new Dictionary<Subject, double>();
        Discount = 0;
    }

}