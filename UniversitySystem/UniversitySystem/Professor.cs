namespace UniversitySystem;

public class Professor : User {
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Department { get; set; }
    public List<Subject> Subjects { get; set; }
    public List<Course> Courses { get; set; }
    
    public Professor(int id, string username, string email, string password, string role, string fullName, string department, List<Subject> subjects, List<Course> courses)
        : base(id, username, email, password, role) {
        FullName = fullName;
        Department = department;
        Subjects = subjects ?? new List<Subject>();
        Courses = courses ?? new List<Course>();
    }



    private static Professor GetProfessorByName(string fullName) {
        for (int i = 0; i < Start.Professors.Count; i++) {
            if (Start.Professors[i].FullName == fullName) {
                return Start.Professors[i];
            }
        }
        
        return null;
    }

    public static Professor FindProfessor(string firstMessage) {
        Console.WriteLine(firstMessage);
        string data = Console.ReadLine();
        
        Professor professor = null;
        if (int.TryParse(data, out _)) {
            int id = int.Parse(data);

            if (GetProfessorById(id) == null) {
                Console.WriteLine("Professor does not exist!");
                return null;
            }
            
            professor = GetProfessorById(id);
        }
        else {
            if (GetProfessorByName(data) == null) {
                Console.WriteLine("Professor does not exist!");
                return null;
            }
            
            professor = GetProfessorByName(data);
        }
        
        return professor;
    }

     private static Professor GetProfessorById(int id) {
        return Start.Professors.FirstOrDefault(professor => professor.Id == id);
    }

    public static bool FindCourseForProfessor(int courseIndex) {
        return Start.Professors.Any(professor => professor.Courses.Contains(Start.Courses[courseIndex]));
    }
}