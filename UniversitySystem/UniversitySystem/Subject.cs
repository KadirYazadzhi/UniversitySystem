namespace UniversitySystem;

public class Subject {
    public int Id { get; set; }
    public string Name { get; set; }
    public Professor Professor { get; set; }
    public int Credits { get; set; }
    public int Semester { get; set; }
    
}