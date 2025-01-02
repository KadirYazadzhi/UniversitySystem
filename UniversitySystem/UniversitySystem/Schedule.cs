namespace UniversitySystem;

public class Schedule {
    public string Course { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Location { get; set; }

    public Schedule(string course, DateTime startDate, DateTime endDate, string location) {
        Course = course;
        StartDate = startDate;
        EndDate = endDate;
        Location = location;
    }
    
    public static void GenerateSchedules() {
        Random random = new Random();
        
        List<string> courseNames = new List<string> {
            "Introduction to Programming",
            "Data Structures and Algorithms",
            "Database Management Systems",
            "Web Development",
            "Software Engineering",
            "Operating Systems",
            "Artificial Intelligence",
            "Machine Learning",
            "Computer Networks",
            "Cybersecurity"
        };

        for (int i = 0; i < courseNames.Count; i++) {
            string courseName = courseNames[i];
            DateTime startDate = DateTime.Now.AddDays(random.Next(1, 30));
            DateTime endDate = startDate.AddDays(random.Next(30, 120));
            string location = $"Building {random.Next(1, 10)}, Room {random.Next(100, 500)}";

            Start.Schedules.Add(new Schedule(courseName, startDate, endDate, location));
        }
    }

}