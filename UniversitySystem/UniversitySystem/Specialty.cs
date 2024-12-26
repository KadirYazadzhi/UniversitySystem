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
}