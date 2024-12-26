namespace UniversitySystem;

public class Specialty {
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public List<Course> AvailableCourses { get; set; }

    public Specialty(string name) {
        Name = name;
        Students = new List<Student>();
        AvailableCourses = new List<Course>();
    }

    public void AddStudent(Student student) {
        Students.Add(student);
    }

    public void AddCourse(Course course) {
        AvailableCourses.Add(course);
    }

    public static void ViewAllSpecialties() {
        Console.WriteLine("All specialties:");
        foreach (string name in Start.Specialties.Select(s => s.Name)) {
            Console.WriteLine($"    {name}");
        }
    }

    public bool isSpecialtyExist() {
        if (Start.Specialties.Any(s => s.Name == this.Name)) {
            return true;
        }
        Console.WriteLine("This specialty does not exist.");
        return false;
    }
}