namespace UniversitySystem;

public class Student : User {
    public string FullName { get; set; }
    public string Speciality { get; set; }
    public Program Program { get; set; }
    public List<Course> EnrolledCourses { get; set; }
    public Dictionary<Subject, double> Grades { get; set; }
    public double Discount { get; set; }
    
}