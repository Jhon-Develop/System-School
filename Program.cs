using System_School.Models;

namespace System_School;

class Program
{
    static void Main(string[] args)
    {
        bool menuOpen = true;

        while (menuOpen)
        {
            Console.WriteLine($"{Setting.Header("¡Bienvenido al Sistema Escolar!")}");
            Console.WriteLine(@"
                1. Estudiantes.
                2. Profesores.
                3. Ver datos.
                4. Agregar Calificaciones.
                5. Salir.
            ");
            Console.Write("Elija una opción => ");
            int option = Setting.InputInt("");

            switch (option)
            {
                case 1:
                    Console.WriteLine($"{Setting.Header("Estudiantes")}");
                    Console.WriteLine(@"
                    1. Agregar estudiante.
                    2. Ver estudiantes.
                    3. Editar estudiante.
                    4. Eliminar estudiante.
                    ");
                    int studentOption = Setting.InputInt("Elija una opción => ");

                    switch(studentOption)
                    {
                        case 1:
                            AdminApp.AddStudent();
                            Setting.FinishOption();
                            break;
                        case 2:
                            AdminApp.ShowStudents();
                            Setting.FinishOption();
                            break;
                        case 3:
                            AdminApp.UpdateStudent();
                            Setting.FinishOption();
                            break;
                        case 4:
                            AdminApp.DeleteStudent();
                            Setting.FinishOption();
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    };
                    break;
                case 2:
                    Console.WriteLine($"{Setting.Header("Profesores")}");
                    Console.WriteLine(@"
                        1. Agregar profesor.
                        2. Ver profesores.
                        3. Editar profesor.
                        4. Eliminar profesor.
                        ");
                    int teacherOption = Setting.InputInt("Elija una opción => ");
                    switch(teacherOption)
                    {
                        case 1:
                            AdminApp.AddTeacher();
                            Setting.FinishOption();
                            break;
                        case 2:
                            AdminApp.ShowTeachers();
                            Setting.FinishOption();
                            break;
                        case 3:
                            AdminApp.UpdateTeacher();
                            Setting.FinishOption();
                            break;
                        case 4:
                            AdminApp.DeleteTeacher();
                            Setting.FinishOption();
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine($"{Setting.Header("Filtros")}");
                    Console.WriteLine(@"
                    1. Filtrar por promedio.
                    2. Filtrar profesores por cantidad de cursos.
                    3. Filtrar estudiantes por edad.
                    4. Filtrar por apellido.
                    5. Calculo del salario de todos los profesores.
                    6. Filtrar por calificación.
                    7. Cantidad de estudiantes por curso.
                    8. Filtrar por Antigüedad.
                    9. Obtener asignaturas.
                    10. Filtrar por nombre.
                    11. Ordenar profesores por salario.
                    12. Promedio de edad de estudiantes.
                    13. Filtrar profesores por curso.
                    14. Filtrar por estudiantes con calificaciones registradas.
                    15. Promedio de antigüedad de profesores.
                    ");
                    int filterOption = Setting.InputInt("Elija una opción => ");
                    switch (filterOption)
                    {
                        case 1:
                            double minimumAverage = Setting.InputDouble("Ingresa el valor mínimo de la calificación => ");
                            AdminApp.FilterByAverage(minimumAverage);
                            Setting.FinishOption();
                            break;
                        case 2:
                            int minimumCoursesProfessors = Setting.InputInt("Ingresa el número mínimo de cursos => ");
                            AdminApp.FilterByCoursesTeachers(minimumCoursesProfessors);
                            Setting.FinishOption();
                            break;
                        case 3:
                            int minimumAgeStudents = Setting.InputInt("Ingresa el año mínimo => ");
                            AdminApp.FilterByAgeStudents(minimumAgeStudents);
                            Setting.FinishOption();
                            break;
                        case 4:
                            string lastName = Setting.InputString("Ingresa el nombre del último alfabetico => ");
                            AdminApp.FilterByLastName(lastName);
                            Setting.FinishOption();
                            break;
                        case 5:
                            AdminApp.CalculateSalaryProfessors();
                            Setting.FinishOption();
                            break;
                        case 6:
                            double minimumGrade = Setting.InputDouble("Ingresa el valor mínimo de la calificación => ");
                            AdminApp.FilterByGrade(minimumGrade);
                            Setting.FinishOption();
                            break;
                        case 7:
                            int minimumCoursesStudents = Setting.InputInt("Ingresa el número mínimo de cursos => ");
                            AdminApp.FilterByCoursesStudents(minimumCoursesStudents);
                            Setting.FinishOption();
                            break;
                        case 8:
                            DateTime minimumHiringDate = Setting.InputDate("Ingresa la fecha mínima de contratación => ");
                            AdminApp.FilterByHiringDate(minimumHiringDate);
                            Setting.FinishOption();
                            break;
                        case 9:
                            AdminApp.GetCourses();
                            Setting.FinishOption();
                            break;
                        case 10:
                            string name = Setting.InputString("Ingresa el nombre que desea filtrar => ");
                            AdminApp.FilterByName(name);
                            Setting.FinishOption();
                            break;
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine($"{Setting.Header("Agregar Calificaciones")}");
                    AdminApp.AddGradeToStudent();
                    Setting.FinishOption();
                    break;
                case 5:
                    menuOpen = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}

