namespace UniversitySystem;

public class Course {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Professor Professor { get; set; }
    public double Price { get; set; }
    public List<Specialty> EligibleSpecialties { get; set; }

    public Course(int id, string name, string description, Professor professor, double price, List<Specialty> eligibleSpecialties) {
        Id = id;
        Name = name;
        Description = description;
        Professor = professor;
        Price = price;
        EligibleSpecialties = eligibleSpecialties ?? new List<Specialty>();
    }

    public static void AddCourse() {
        int id = Start.Courses.Max(c => c.Id) + 1;
        
        Console.WriteLine("Enter the name of the course:");
        string name = Console.ReadLine();

        if (FindCourseIndex(name) != -1) {
            Console.WriteLine("Course already exists!");
            return;
        }
        
        Console.WriteLine("Enter the description of the course:");
        string description = Console.ReadLine();

        Professor professor = Professor.FindProfessor();
        
        Console.WriteLine("Enter the price of the course:");
        double price = double.Parse(Console.ReadLine());

        if (price < 0) {
            Console.WriteLine("Price cannot be negative!");
            return;
        }
        
        Course course = new Course(id, name, description, professor, price, null);
        Start.Courses.Add(course);
        Console.WriteLine("Course is added successfully!");
    }

    public static void ChangeCourseData() {
        if (User.LoggedInUser.Role == "Student") {
            Console.WriteLine("You don't have privileges to change the course!");
            return;
        }
        
        Console.WriteLine("What you want to change? [Name, Description, Professor, Price, Eligible Specialties]");
        string type = Console.ReadLine();

        switch (type) {
            case "Name":
                
                break;
            case "Description":
                
                break;
            case "Professor":
                
                break;
            case "Price":
                
                break;
            case "Eligible Specialties":
                
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
    
    public static void ViewAllCourses() {
        Console.WriteLine("All courses: ");
        foreach (var course in Start.Courses) {
            Console.WriteLine($"    Course ID: {course.Id}");
            Console.WriteLine($"    Name: {course.Name}");
            Console.WriteLine($"    Description: {course.Description}");
            Console.WriteLine($"    Professor: {course.Professor}");
            Console.WriteLine($"    Price: {course.Price:F2}");
            Console.WriteLine($"    Eligible Specialties: {string.Join(" ", course.EligibleSpecialties)}");
            Console.WriteLine();
        }
    }

    public static void DeleteCourse() {
        int courseIndex = FindCourse();
        if (courseIndex == -1) return;
        
        Start.Courses.RemoveAt(courseIndex);
        Console.WriteLine("Successfully deleted course.");
    }

    public static void ViewFullInfoAboutCourse() {
        int courseIndex = FindCourse();
        if (courseIndex == -1) return;

        Console.WriteLine("All information about the course:");
        Console.WriteLine($"    Course ID: {Start.Courses[courseIndex].Id}");
        Console.WriteLine($"    Name: {Start.Courses[courseIndex].Name}");
        Console.WriteLine($"    Description: {Start.Courses[courseIndex].Description}");
        Console.WriteLine($"    Professor: {Start.Courses[courseIndex].Professor}");
        Console.WriteLine($"    Price: {Start.Courses[courseIndex].Price:F2}");
        Console.WriteLine($"    Eligible Specialties: {string.Join(" ", Start.Courses[courseIndex].EligibleSpecialties)}");
    }

    public static void ViewSpecialInfoAboutCourse() {
        int courseIndex = FindCourse();
        if (courseIndex == -1) return;
        
        Console.WriteLine("Enter the information you would like to view: [Id, Description, Professor, Price, Eligible Specialties]");
        string type = Console.ReadLine();

        switch (type) {
            case "Id":
                Console.WriteLine($"Course ID: {Start.Courses[courseIndex].Id}");
                break;
            case "Description":
                Console.WriteLine($"Description: {Start.Courses[courseIndex].Description}");
                break;
            case "Professor":
                Console.WriteLine($"Professor: {Start.Courses[courseIndex].Professor}");
                break;
            case "Price":
                Console.WriteLine($"Price: {Start.Courses[courseIndex].Price:F2}");
                break;
            case "Eligible Specialties":
                Console.WriteLine($"Eligible Specialties: {string.Join(" ", Start.Courses[courseIndex].EligibleSpecialties)}");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static int FindCourseIndex(string courseName) {
        for (int i = 0; i < Start.Courses.Count; i++) {
            if (Start.Courses[i].Name == courseName) {
                return i;
            }
        }

        return -1;
    }

    public static int FindCourse() {
        Console.WriteLine("Enter the name of the course you want to view:");
        string courseName = Console.ReadLine();
        
        int index = FindCourseIndex(courseName);
        if (index == -1) {
            Console.WriteLine("This course does not exist.");
        }

        return index;
    }
}