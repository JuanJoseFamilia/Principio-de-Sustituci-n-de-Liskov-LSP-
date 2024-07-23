

namespace Principio_de_Sustitución_de_Liskov__LSP_
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Cliente std);

        public abstract string GetCourseDetails();
    }
}
