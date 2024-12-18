namespace UniversitySystem;

public class Student : User {
    public string FullName { get; set; }
    public string Speciality { get; set; }
    public string Group { get; set; }
    public Dictionary<string, double> Grades { get; set; }
    public List<Course> Courses { get; set; }
    public List<Schedule> Schedules { get; set; }
    public double Discount { get; set; }
    
    
}