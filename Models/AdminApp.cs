using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_School.Models
{
    static class AdminApp
    {
        public static List<Student> Students { get; set; } =
        [
            new Student("Juan", "Perez", "DNI", "123456789", "juan.perez@gmail.com", "Calle Falsa 123", "987654321", "Juan Perez", "Matemáticas", new DateOnly(1995, 1, 1), new List<double> { 8.5, 7.0, 9.0 }),
            new Student("Maria", "Lopez", "DNI", "987654321", "maria.lopez@gmail.com", "Avenida Viva 742", "123456789", "Maria Lopez", "Física", new DateOnly(1996, 2, 15), new List<double> { 9.5, 8.0, 7.5 }),
            new Student("Carlos", "Martinez", "DNI", "123123123", "carlos.martinez@gmail.com", "Boulevard Bosque 56", "234567890", "Carlos Martin", "Química", new DateOnly(1994, 3, 10), new List<double> { 6.5, 7.5, 8.0 }),
            new Student("Ana", "Garcia", "DNI", "456456456", "ana.garcia@gmail.com", "Plaza Central 99", "345678901", "Ana Garcia", "Historia", new DateOnly(1997, 4, 25), new List<double> { 9.0, 8.5, 7.0 }),
            new Student("Luis", "Gonzalez", "DNI", "789789789", "luis.gonzalez@gmail.com", "Calle Luna 12", "456789012", "Luis Nuñes", "Lengua", new DateOnly(1998, 5, 5), new List<double> { 7.5, 8.0, 7.0 }),
            new Student("Elena", "Perez", "DNI", "111111111", "elena.hernandez@gmail.com", "Calle Sol 34", "567890123", "Elena Perez", "Biología", new DateOnly(1995, 6, 20), new List<double> { 8.5, 7.5, 9.0 }),
            new Student("Pedro", "Sanchez", "DNI", "222222222", "pedro.sanchez@gmail.com", "Calle Estrella 56", "678901234", "Pedro Diaz", "Informática", new DateOnly(1996, 7, 15), new List<double> { 9.0, 8.5, 8.0 }),
            new Student("Laura", "Diaz", "DNI", "333333333", "laura.diaz@gmail.com", "Avenida Liberta 77", "789012345", "Laura Diaz", "Edu. Física", new DateOnly(1997, 8, 30), new List<double> { 7.5, 7.0, 8.0 }),
            new Student("Jorge", "Lopez", "DNI", "444444444", "jorge.fernandez@gmail.com", "Calle Victoria 89", "890123456", "Jorge Lopez", "Matemáticas", new DateOnly(1994, 9, 12), new List<double> { 8.0, 9.0, 8.5 }),
            new Student("Sofia", "Ramirez", "DNI", "555555555", "sofia.ramirez@gmail.com", "Calle Amistad 101", "901234567", "Sofia Ramirez", "Física", new DateOnly(1995, 10, 1), new List<double> { 7.5, 7.5, 8.0 }),
            new Student("Miguel", "Torres", "DNI", "666666666", "miguel.torres@gmail.com", "Calle Paz 123", "012345678", "Miguel Torres", "Química", new DateOnly(1996, 11, 17), new List<double> { 8.0, 7.0, 9.0 }),
            new Student("Lucia", "Vazquez", "DNI", "777777777", "lucia.vazquez@gmail.com", "Calle Amor 145", "123456789", "Lucia Vazquez", "Historia", new DateOnly(1997, 12, 8), new List<double> { 9.0, 8.5, 8.0 }),
            new Student("Fernando", "Reyes", "DNI", "888888888", "fernando.reyes@gmail.com", "Calle Amistad 167", "234567890", "Fernando Reyes", "Lengua", new DateOnly(1994, 1, 23), new List<double> { 7.5, 8.0, 7.0 }),
            new Student("Isabel", "Morales", "DNI", "999999999", "isabel.morales@gmail.com", "Calle Unión 189", "345678901", "Isabel Morales", "Biología", new DateOnly(1995, 2, 14), new List<double> { 8.5, 7.5, 8.0 }),
            new Student("Oscar", "Castro", "DNI", "101010101", "oscar.castro@gmail.com", "Calle Alegría 201", "456789012", "Oscar Castro", "Informática", new DateOnly(1996, 3, 19), new List<double> { 9.0, 8.0, 8.5 }),
            new Student("Raquel", "Ortega", "DNI", "202020202", "raquel.ortega@gmail.com", "Calle Esperanza 223", "567890123", "Raquel Ortega", "Edu. Física", new DateOnly(1997, 4, 22), new List<double> { 7.0, 7.5, 8.0 }),
            new Student("Hector", "Alvarez", "DNI", "303030303", "hector.alvarez@gmail.com", "Calle Sueños 245", "678901234", "Hector Alvarez", "Matemáticas", new DateOnly(1998, 5, 11), new List<double> { 8.0, 8.5, 9.0 }),
            new Student("Patricia", "Romero", "DNI", "404040404", "patricia.romero@gmail.com", "Calle Libertad 267", "789012345", "Patricia Romero", "Física", new DateOnly(1994, 6, 27), new List<double> { 7.5, 8.0, 8.5 }),
            new Student("Andres", "Serrano", "DNI", "505050505", "andres.serrano@gmail.com", "Calle Esperanza 289", "890123456", "Andres Serrano", "Química", new DateOnly(1995, 7, 9), new List<double> { 8.0, 7.0, 7.5 }),
            new Student("Sandra", "Mendoza", "DNI", "606060606", "sandra.mendoza@gmail.com", "Calle Vida 301", "901234567", "Sandra Mendoza", "Historia", new DateOnly(1996, 8, 31), new List<double> { 8.5, 9.0, 7.5 }),
            new Student("David", "Ruiz", "DNI", "707070707", "david.ruiz@gmail.com", "Calle Paz 323", "012345678", "David Ruiz", "Lengua", new DateOnly(1997, 9, 16), new List<double> { 7.0, 8.0, 8.5 }),
            new Student("Angela", "Rios", "DNI", "808080808", "angela.rios@gmail.com", "Calle Fe 345", "123456789", "Angela Rios", "Biología", new DateOnly(1998, 10, 4), new List<double> { 9.0, 7.5, 8.0 }),
            new Student("Martin", "Delgado", "DNI", "909090909", "martin.delgado@gmail.com", "Calle Armonía 367", "234567890", "Martin Delgado", "Informática", new DateOnly(1994, 11, 20), new List<double> { 8.5, 8.0, 9.0 }),
            new Student("Natalia", "Campos", "DNI", "010101010", "natalia.campos@gmail.com", "Calle Luz 389", "345678901", "Natalia Campos", "Edu. Física", new DateOnly(1995, 12, 5), new List<double> { 7.5, 7.0, 8.5 }),
            new Student("Victor", "Fuentes", "DNI", "111111112", "victor.fuentes@gmail.com", "Calle Esperanza 401", "456789012", "Victor Fuentes", "Matemáticas", new DateOnly(1996, 1, 27), [8.0, 7.5, 7.0])
        ];

        public static List<Teacher> Teachers { get; set; } =
        [
            new Teacher("Jose", "Martinez", "DNI", "112233445", "jose.martinez@gmail.com", "112233445", "Matemáticas", 50000, new DateTime(2010, 9, 1))
            {
                Courses = new List<string> { "Matemáticas" }
            },
            new Teacher("Ana", "Fernandez", "DNI", "223344556", "ana.fernandez@gmail.com", "223344556", "Física", 52000, new DateTime(2012, 8, 15))
            {
                Courses = new List<string> { "Física" }
            },
            new Teacher("Luis", "Rodriguez", "DNI", "334455667", "luis.rodriguez@gmail.com", "334455667", "Química", 53000, new DateTime(2015, 7, 10))
            {
                Courses = new List<string> { "Química" }
            },
            new Teacher("Maria", "Gomez", "DNI", "445566778", "maria.gomez@gmail.com", "445566778", "Historia", 54000, new DateTime(2011, 6, 20))
            {
                Courses = new List<string> { "Historia" }
            },
            new Teacher("Carlos", "Lopez", "DNI", "556677889", "carlos.lopez@gmail.com", "556677889", "Lengua", 55000, new DateTime(2013, 5, 5))
            {
                Courses = new List<string> { "Lengua" }
            },
            new Teacher("Elena", "Ruiz", "DNI", "667788990", "elena.ruiz@gmail.com", "667788990", "Biología", 56000, new DateTime(2014, 4, 25))
            {
                Courses = new List<string> { "Biología" }
            },
            new Teacher("Pedro", "Hernandez", "DNI", "778899001", "pedro.hernandez@gmail.com", "778899001", "Informática", 57000, new DateTime(2016, 3, 15))
            {
                Courses = new List<string> { "Informática" }
            },
            new Teacher("Laura", "Sanchez", "DNI", "889900112", "laura.sanchez@gmail.com", "889900112", "Edu. Física", 58000, new DateTime(2017, 2, 10))
            {
                Courses = new List<string> { "Edu. Física" }
            },
            new Teacher("Miguel", "Diaz", "DNI", "990011223", "miguel.diaz@gmail.com", "990011223", "Matemáticas", 59000, new DateTime(2018, 1, 20))
            {
                Courses = new List<string> { "Matemáticas" }
            },
            new Teacher("Sofia", "Garcia", "DNI", "001122334", "sofia.garcia@gmail.com", "001122334", "Física", 60000, new DateTime(2019, 11, 15))
            {
                Courses = new List<string> { "Física" }
            }
        ];

        // Metodos para agregar, ver, editar y eliminar estudiantes y profesores
        public static void AddStudent()
        {
            string name = Setting.InputString("Ingresa el nuevo nombre => ");
            string lastName = Setting.InputString("Ingresa el nuevo apellido => ");
            string documentType = Setting.InputString("Ingresa el nuevo tipo de documento => ");
            string documentNumber = Setting.InputString("Ingresa el nuevo número de documento => ");
            string email = Setting.InputString("Ingresa el nuevo correo electrónico => ");
            string address = Setting.InputString("Ingresa la nueva dirección => ");
            string phone = Setting.InputString("Ingresa el nuevo número de Celular => ");
            string nameGuardian = Setting.InputString("Ingresa el nuevo nombre del acudiente => ");
            string currentCourse = Setting.InputString("Ingresa el nuevo curso actual => ");
            DateOnly fechaNacimiento = Setting.InputDateOnly("Ingresa la nueva fecha de nacimiento => ");

            Student newStudent = new(name, lastName, documentType, documentNumber, email, address, phone, nameGuardian, currentCourse, fechaNacimiento, []);
            Students.Add(newStudent);

            Console.WriteLine("");
            Console.WriteLine("Estudiante agregado con éxito!");
            Console.WriteLine("");
        }

        public static void UpdateStudent()
        {
            ShowStudents();
            int index = Setting.InputInt("Ingresa el índice del estudiante que desea actualizar => ") - 1;

            if (index < 0 || index >= Students.Count)
            {
                Console.WriteLine("Índice inválido. Por favor, inténtalo de nuevo.");
                return;
            }

            Student student = Students[index];

            string name = Setting.InputString($"Ingresa el nuevo nombre o presiona Intro para mantener el mismo ({student.GetName()}) => ");
            string lastName = Setting.InputString($"Ingresa el nuevo apellido o presiona Intro para mantener el mismo ({student.GetLastName()}) => ");
            string documentType = Setting.InputString($"Ingresa el nuevo tipo de documento o presiona Intro para mantener el mismo ({student.GetDocumentType()}) => ");
            string documentNumber = Setting.InputString($"Ingresa el nuevo número de documento o presiona Intro para mantener el mismo ({student.GetDocumentNumber()}) => ");
            string email = Setting.InputString($"Ingresa el nuevo correo electrónico o presiona Intro para mantener el mismo ({student.GetEmail()}) => ");
            string address = Setting.InputString($"Ingresa la nueva dirección o presiona Intro para mantener el mismo ({student.Address}) => ");
            string phone = Setting.InputString($"Ingresa el nuevo número de Celular o presiona Intro para mantener el mismo ({student.GetPhone()}) => ");
            string nameGuardian = Setting.InputString($"Ingresa el nuevo nombre del acudiente o presiona Intro para mantener el mismo ({student.NameGuardian}) => ");
            string currentCourse = Setting.InputString($"Ingresa el nuevo curso actual o presiona Intro para mantener el mismo ({student.CurrentCourse}) => ");
            DateOnly fechaNacimiento = Setting.InputDateOnly($"Ingresa la nueva fecha de nacimiento o presiona Intro para mantener el mismo ({student.FechaNacimiento}) => ");

            // Mantener valores originales si se presiona Enter
            student.SetName(string.IsNullOrEmpty(name) ? student.GetName() : name);
            student.SetLastName(string.IsNullOrEmpty(lastName) ? student.GetLastName() : lastName);
            student.SetDocumentType(string.IsNullOrEmpty(documentType) ? student.GetDocumentType() : documentType);
            student.SetDocumentNumber(string.IsNullOrEmpty(documentNumber) ? student.GetDocumentNumber() : documentNumber);
            student.SetEmail(string.IsNullOrEmpty(email) ? student.GetEmail() : email);
            student.Address = string.IsNullOrEmpty(address) ? student.Address : address;
            student.SetPhone(string.IsNullOrEmpty(phone) ? student.GetPhone() : phone);
            student.NameGuardian = string.IsNullOrEmpty(nameGuardian) ? student.NameGuardian : nameGuardian;
            student.CurrentCourse = string.IsNullOrEmpty(currentCourse) ? student.CurrentCourse : currentCourse;
            student.FechaNacimiento = fechaNacimiento == default ? student.FechaNacimiento : fechaNacimiento;

            Console.WriteLine("");
            Console.WriteLine("Estudiante actualizado con éxito!");
            Console.WriteLine("");
        }

        public static void DeleteStudent()
        {
            ShowStudents();
            int index = Setting.InputInt("Ingresa el índice del estudiante que desea eliminar => ") - 1;

            if (index < 0 || index >= Students.Count)
            {
                Console.WriteLine("Índice inválido. Por favor, inténtalo de nuevo.");
                return;
            }

            Students.RemoveAt(index);

            Console.WriteLine("");
            Console.WriteLine("Estudiante eliminado con éxito!");
            Console.WriteLine("");
        }

        public static void ShowStudents()
        {
            string studentLineSeparator = new('-', Console.WindowWidth);
            Console.WriteLine($"N°| {"Nombre",-8} | {"last name",-8} | {"Type"} | {"Document"} | {"email",-25} | {"address",-20} | {"phone",-8} | {"Acudiente",-15} | {"current course",-14} | {"Age"}");
            Console.WriteLine(studentLineSeparator);

            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"{i + 1} | {Students[i].GetName(),-8} | {Students[i].GetLastName(),-8} | {Students[i].GetDocumentType()} | {Students[i].GetDocumentNumber()} | {Students[i].GetEmail(),-25} | {Students[i].Address,-20} | {Students[i].GetPhone(),-5} | {Students[i].NameGuardian,-15} | {Students[i].CurrentCourse,-12} | {Students[i].CalculateAge(Students[i].FechaNacimiento)}");
                Console.WriteLine(studentLineSeparator);
            }
        }

        public static void ShowTeachers()
        {
            string teacherLineSeparator = new('-', Console.WindowWidth);
            Console.WriteLine($"N°| {"Name",-8} | {"last name",-14} | {"Type",-4} | {"Document"}  | {"email",-25} | {"phone",-10} | {"Subject",-15} | {"Salary",-12} | {"Hire Date"}");
            Console.WriteLine(teacherLineSeparator);

            for (int i = 0; i < Teachers.Count; i++)
            {
                Console.WriteLine($"{i + 1} | {Teachers[i].GetName(),-8} | {Teachers[i].GetLastName(),-14} | {Teachers[i].GetDocumentType(),-4} | {Teachers[i].GetDocumentNumber()} | {Teachers[i].GetEmail(),-25} | {Teachers[i].GetPhone(),-10} | {Teachers[i].Subject,-15} | {Teachers[i].Salary,-12} | {Teachers[i].HiringDate}");
                Console.WriteLine(teacherLineSeparator);
            }
        }

        public static void AddTeacher()
        {
            string name = Setting.InputString("Ingresa el nuevo nombre => ");
            string lastName = Setting.InputString("Ingresa el nuevo apellido => ");
            string documentType = Setting.InputString("Ingresa el nuevo tipo de documento => ");
            string documentNumber = Setting.InputString("Ingresa el nuevo número de documento => ");
            string email = Setting.InputString("Ingresa el nuevo correo electrónico => ");
            string phone = Setting.InputString("Ingresa el nuevo número de Celular => ");
            string subject = Setting.InputString("Ingresa el nuevo asunto => ");
            double salary = Setting.InputDouble("Ingresa el nuevo salario => ");
            DateTime hiringDate = Setting.InputDate("Ingresa la nueva fecha de contratación => ");

            Teacher newTeacher = new(name, lastName, documentType, documentNumber, email, phone, subject, salary, hiringDate);
            Teachers.Add(newTeacher);

            Console.WriteLine("");
            Console.WriteLine("Profesor agregado con éxito!");
            Console.WriteLine("");

            Setting.FinishOption();
        }

        public static void UpdateTeacher()
        {
            ShowTeachers();
            int index = Setting.InputInt("Ingresa el índice del profesor que desea actualizar => ") - 1;

            if (index < 0 || index >= Teachers.Count)
            {
                Console.WriteLine("Índice inválido. Por favor, inténtalo de nuevo.");
                return;
            }

            Teacher teacher = Teachers[index];

            string name = Setting.InputString($"Ingresa el nuevo nombre o presiona Intro para mantener el mismo ({teacher.GetName()}) => ");
            string lastName = Setting.InputString($"Ingresa el nuevo apellido o presiona Intro para mantener el mismo ({teacher.GetLastName()}) => ");
            string documentType = Setting.InputString($"Ingresa el nuevo tipo de documento o presiona Intro para mantener el mismo ({teacher.GetDocumentType()}) => ");
            string documentNumber = Setting.InputString($"Ingresa el nuevo número de documento o presiona Intro para mantener el mismo ({teacher.GetDocumentNumber()}) => ");
            string email = Setting.InputString($"Ingresa el nuevo correo electrónico o presiona Intro para mantener el mismo ({teacher.GetEmail()}) => ");
            string phone = Setting.InputString($"Ingresa el nuevo número de Celular o presiona Intro para mantener el mismo ({teacher.GetPhone()}) => ");
            string subject = Setting.InputString($"Ingresa el nuevo asunto o presiona Intro para mantener el mismo ({teacher.Subject}) => ");
            double salary = Setting.InputDouble($"Ingresa el nuevo salario o presiona Intro para mantener el mismo ({teacher.Salary}) => ");
            DateTime hiringDate = Setting.InputDate($"Ingresa la nueva fecha de contratación o presiona Intro para mantener el mismo ({teacher.HiringDate}) => ");

            // Mantener valores originales si se presiona Enter
            teacher.SetName(string.IsNullOrEmpty(name) ? teacher.GetName() : name);
            teacher.SetLastName(string.IsNullOrEmpty(lastName) ? teacher.GetLastName() : lastName);
            teacher.SetDocumentType(string.IsNullOrEmpty(documentType) ? teacher.GetDocumentType() : documentType);
            teacher.SetDocumentNumber(string.IsNullOrEmpty(documentNumber) ? teacher.GetDocumentNumber() : documentNumber);
            teacher.SetEmail(string.IsNullOrEmpty(email) ? teacher.GetEmail() : email);
            teacher.SetPhone(string.IsNullOrEmpty(phone) ? teacher.GetPhone() : phone);
            teacher.Subject = string.IsNullOrEmpty(subject) ? teacher.Subject : subject;
            teacher.Salary = salary == 0 ? teacher.Salary : salary;
            teacher.HiringDate = hiringDate == default ? teacher.HiringDate : hiringDate;

            Console.WriteLine("");
            Console.WriteLine("Profesor actualizado con éxito!");
            Console.WriteLine("");
        }

        public static void DeleteTeacher()
        {
            ShowTeachers();
            int index = Setting.InputInt("Ingresa el índice del profesor que desea eliminar => ") - 1;

            if (index < 0 || index >= Teachers.Count)
            {
                Console.WriteLine("Índice inválido. Por favor, inténtalo de nuevo.");
                return;
            }

            Teachers.RemoveAt(index);

            Console.WriteLine("");
            Console.WriteLine("Profesor eliminado con éxito!");
            Console.WriteLine("");
        }

        public static void AddGradeToStudent()
        {
            ShowStudents();
            int index = Setting.InputInt("Enter the index of the student you want to add a grade to => ") - 1;

            if (index < 0 || index >= Students.Count)
            {
                Console.WriteLine("Invalid index. Please try again.");
                return;
            }

            double grade = Setting.InputDouble("Enter the grade => ");
            Students[index].Grades.Add(grade);

            Console.WriteLine("Grade added successfully!");
        }

        /*
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
        */

        public static void FilterByAverage(double minimumAverage)
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            List<Student> filteredStudents = new List<Student>();

            foreach (var student in Students)
            {
                if (student.Grades.Count > 0)
                {
                    double totalGrades = student.Grades.Sum();
                    double average = totalGrades / student.Grades.Count;

                    if (average >= minimumAverage)
                    {
                        filteredStudents.Add(student);
                    }
                }
            }

            if (filteredStudents.Count == 0)
            {
                Console.WriteLine($"No students with an average grade equal to or greater than {minimumAverage}.");
            }
            else
            {
                Console.WriteLine($"Students with an average grade equal to or greater than {minimumAverage}:");
                foreach (var student in filteredStudents)
                {
                    double totalGrades = student.Grades.Sum();
                    double average = totalGrades / student.Grades.Count;
                    Console.WriteLine($"{student.GetName()} {student.GetLastName()} - Average Grade: {average:F2}");
                }
            }
        }

        public static void FilterByCoursesStudents(int minimumCoursesStudents)
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            List<Student> filteredStudents = [];

            foreach (var student in Students)
            {
                if (student.Grades.Count > 0)
                {
                    int numberOfCourses = student.Grades.Count();

                    if (numberOfCourses >= minimumCoursesStudents)
                    {
                        filteredStudents.Add(student);
                    }
                }
            }

            if (filteredStudents.Count == 0)
            {
                Console.WriteLine($"No estudiantes con al menos {minimumCoursesStudents} cursos.");
            }
            else
            {
                Console.WriteLine($"Estudiantes con al menos {minimumCoursesStudents} cursos:");
                foreach (var student in filteredStudents)
                {
                    int numberOfCourses = student.Grades.Count;
                    Console.WriteLine($"{student.GetName()} {student.GetLastName()} - Courses: {numberOfCourses}");
                }
            }
        }

        public static void FilterByCoursesTeachers(int minimumCoursesProfessors)
        {
            if (Teachers.Count == 0)
            {
                Console.WriteLine("No profesores available.");
                return;
            }

            List<Teacher> filteredTeachers = [];

            foreach (var teacher in Teachers)
            {
                if (teacher.Courses.Count > 0)
                {
                    int numberOfCourses = teacher.Courses.Count;

                    if (numberOfCourses >= minimumCoursesProfessors)
                    {
                        filteredTeachers.Add(teacher);
                    }
                }
            }

            if (filteredTeachers.Count == 0)
            {
                Console.WriteLine($"No profesores con al menos {minimumCoursesProfessors} cursos.");
            }
            else
            {
                Console.WriteLine($"Profesores con al menos {minimumCoursesProfessors} cursos:");
                foreach (var teacher in filteredTeachers)
                {
                    int numberOfCourses = teacher.Courses.Count;
                    Console.WriteLine($"{teacher.GetName()} {teacher.GetLastName()} - Cursos: {numberOfCourses}");
                }
            }
        }

        public static void FilterByAgeStudents(int minimumAgeStudents)
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            List<Student> filteredStudents = [];

            foreach (var student in Students)
            {
                if (student.FechaNacimiento.Year >= minimumAgeStudents)
                {
                    filteredStudents.Add(student);
                }
            }

            if (filteredStudents.Count == 0)
            {
                Console.WriteLine($"No students with an age equal to or greater than {minimumAgeStudents}.");
            }
            else
            {
                Console.WriteLine($"Students with an age equal to or greater than {minimumAgeStudents}:");
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"{student.GetName()} {student.GetLastName()} - Age: {student.FechaNacimiento.Year}");
                }
            }
        }

        public static void FilterByLastName(string lastName)
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            List<Student> filteredStudents = Students.OrderBy(student => student.GetLastName()).ToList();

            foreach (var student in Students)
            {
                if (student.GetLastName().Contains(lastName))
                {
                    filteredStudents.Add(student);
                }
            }

            if (filteredStudents.Count == 0)
            {
                Console.WriteLine($"No students with a last name containing {lastName}.");
            }
            else
            {
                Console.WriteLine($"Students with a last name containing {lastName}:");
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"{student.GetName()} {student.GetLastName()}");
                }
            }
        }

        public static void CalculateSalaryProfessors()
        {
            if (Teachers.Count == 0)
            {
                Console.WriteLine("No profesores available.");
                return;
            }

            double totalSalary = 0;
            int numberOfProfessors = 0;

            foreach (var teacher in Teachers)
            {
                totalSalary += teacher.Salary;
                numberOfProfessors++;
            }

            if (numberOfProfessors == 0)
            {
                Console.WriteLine("No hay profesores registrados.");
                return;
            }

            Console.WriteLine($"Salario total de los profesores: {totalSalary:F2}");
        }

        public static void FilterByGrade(double minimumGrade)
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No estudiantes disponibles.");
                return;
            }

            List<Student> filteredStudents = [];

            foreach (var student in Students)
            {
                if (student.Grades.Count > 0)
                {
                    double totalGrades = student.Grades.Sum();
                    double average = totalGrades / student.Grades.Count;

                    if (average >= minimumGrade) filteredStudents.Add(student);
                }
            }

            if (filteredStudents.Count == 0)
            {
                Console.WriteLine($"No estudiantes con un promedio de calificación superior o igual a {minimumGrade}.");
            }
            else
            {
                Console.WriteLine($"Estudiantes con un promedio de calificación superior o igual a {minimumGrade}:");
                foreach (var student in filteredStudents)
                {
                    double totalGrades = student.Grades.Sum();
                    double average = totalGrades / student.Grades.Count;
                    Console.WriteLine($"{student.GetName()} {student.GetLastName()} - Promedio de calificación: {average:F2}");
                }
            }
        }
    
        public static void FilterByHiringDate(DateTime minimumHiringDate)
        {
            if (Teachers.Count == 0)
            {
                Console.WriteLine("No profesores disponibles.");
                return;
            }

            List<Teacher> filteredTeachers = [];

            foreach (var teacher in Teachers)
            {
                if (teacher.HiringDate >= minimumHiringDate)
                {
                    filteredTeachers.Add(teacher);
                }
            }

            if (filteredTeachers.Count == 0)
            {
                Console.WriteLine($"No profesores contratados con una contratación posterior a {minimumHiringDate}.");
            }
            else
            {
                Console.WriteLine($"Profesores contratados con una contratación posterior a {minimumHiringDate}:");
                foreach (var teacher in filteredTeachers)
                {
                    Console.WriteLine($"{teacher.GetName()} {teacher.GetLastName()} - Contratación: {teacher.HiringDate}");
                }
            }
        }

        public static void GetCourses()
        {
            if (Teachers.Count == 0)
            {
                Console.WriteLine("No profesores disponibles.");
                return;
            }

            List<string> courses = new List<string>();

            foreach (var teacher in Teachers)
            {
                foreach (var course in teacher.Courses)
                {
                    courses.Add(course);
                }
            }

            Console.WriteLine($"Cursos disponibles: {string.Join(", ", courses)}");
        }
    
        public static void FilterByName(string name)
        {
            if (Teachers.Count == 0) return;

            List<Teacher> filteredTeachers = [];

            foreach (var teacher in Teachers)
            {
                if (teacher.GetName().Contains(name))
                {
                    filteredTeachers.Add(teacher);
                }
            }

            if (filteredTeachers.Count == 0)
            {
                Console.WriteLine($"No profesores con un nombre que contenga {name}.");
            }
            else
            {
                Console.Write($"Profesores con un nombre que contenga {name} => ");
                foreach (var teacher in filteredTeachers)
                {
                    Console.WriteLine($"{teacher.GetName()} {teacher.GetLastName()}");
                }
            }

            if (Students.Count == 0) return;

            List<Student> filteredStudents = [];

            foreach (var student in Students)
            {
                if (student.GetName().Contains(name))
                {
                    filteredStudents.Add(student);
                }
            }

            if (filteredStudents.Count == 0)
            {
                Console.WriteLine($"No estudiantes con un nombre que contenga {name}.");
            }
            else
            {
                Console.Write($"Estudiantes con un nombre que contenga {name} => ");
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"{student.GetName()} {student.GetLastName()}");
                }
            }
        }

        public static void OrderTeachersBySalary()
        {
            if (Teachers.Count == 0)
            {
                Console.WriteLine("No profesores disponibles.");
                return;
            }

            List<Teacher> sortedTeachers = Teachers.OrderByDescending(teacher => teacher.Salary).ToList();

            Console.WriteLine($"Profesores ordenados por salario:");
            foreach (var teacher in sortedTeachers)
            {
                Console.WriteLine($"{teacher.GetName()} {teacher.GetLastName()} - Salary: {teacher.Salary:F2}");
            }
        }
    }
}
