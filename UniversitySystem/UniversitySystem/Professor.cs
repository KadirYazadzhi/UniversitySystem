namespace UniversitySystem;

public class Professor {
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Department { get; set; }
    public List<Subject> Subjects { get; set; }
    public List<Course> Courses { get; set; }
    
}