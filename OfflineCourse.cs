

namespace Principio_de_Sustitución_de_Liskov__LSP_
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Cliente std)
        {
            // Código para suscribirse a un curso presencial
        }

        public override string GetCourseDetails()
        {
            return $"Curso Presencial: {Title} (ID: {CourseId})";
        }
    }
}
