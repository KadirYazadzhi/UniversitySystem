namespace UniversitySystem;

public class Course {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Professor Professor { get; set; }
    public double Price { get; set; }
    public List<string> EligibleSpecialties { get; set; }
}