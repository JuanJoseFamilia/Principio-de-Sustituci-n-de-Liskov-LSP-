

namespace Principio_de_Sustitución_de_Liskov__LSP_
{
    public class HybridCourse : Course
    {
        public override void Subscribe(Cliente std)
        {
            // Código para suscribirse a un curso híbrido
        }

        public override string GetCourseDetails()
        {
            return $"Curso Híbrido: {Title} (ID: {CourseId})";
        }
    }
}
