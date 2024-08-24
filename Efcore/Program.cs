using Efcore;

 static void Main(string[] args)
{
    using (ITIContext context = new ITIContext())
    {
        
        var student = new Student
        {
            Name = "John Doe",
            Email = "john.doe@example.com"
        };
        context.Students.Add(student);
        context.SaveChanges();

       
        var course = new Course
        {
            Title = "Introduction to C#",
            Credit = 3
        };
        context.Courses.Add(course);
        context.SaveChanges();

       
        var students = context.Students.ToList();
        foreach (var s in students)
        {
            Console.WriteLine($"Student: {s.Name} - {s.Email}");
        }

       
        var courses = context.Courses.ToList();
        foreach (var c in courses)
        {
            Console.WriteLine($"Course: {c.Title} - {c.Credit} credits");
        }
    }
}