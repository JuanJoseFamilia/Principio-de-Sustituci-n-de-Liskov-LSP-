

namespace Principio_de_Sustitución_de_Liskov__LSP_
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Cliente std)
        {
            // Código para suscribirse a un curso en línea
        }

        public override string GetCourseDetails()
        {
            return $"Curso en Línea: {Title} (ID: {CourseId})";
        }
    }
}
