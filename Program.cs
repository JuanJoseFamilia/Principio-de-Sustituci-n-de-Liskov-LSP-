using Principio_de_Sustitución_de_Liskov__LSP_;

class Program
{
    static void Main(string[] args)
    {
        List<Course> courses = new List<Course>
        {
            new OnlineCourse { CourseId = 1, Title = "Curso de C# en Línea" },
            new OfflineCourse { CourseId = 2, Title = "Curso de Java Presencial" },
            new HybridCourse { CourseId = 3, Title = "Curso de Python Híbrido" }
        };

        Cliente cliente = new Cliente { ClienteId = 1, Name = "John Doe" };

        foreach (var course in courses)
        {
            course.Subscribe(cliente);
            Console.WriteLine(course.GetCourseDetails());
        }
    }
}