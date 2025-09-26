using orm_Csharp.Data;
using orm_Csharp.Services;

public class Program
{
    static void Main(string[] args)
    {
        var context = new AppDbContext();

        
        // ESTUDIANTES:
        var estudianteService = new EstudianteService(context);


        // 1) Insertar Estudiantes:
        estudianteService.InsertarEstudiante("Sergio", 23, "Desarrollador Sr");
        estudianteService.InsertarEstudiante("David", 44, "Ing. de sofware");


        // 1) Listar Estudiantes:
        foreach (var est in estudianteService.ListarEstudiantes())
        {
            Console.WriteLine($"{est.Nombre}  {est.Edad}  {est.Carrera}");
        }

// -----------------------------------------------------------
        // PROFESORES:
        var profesorService = new ProfesoresService(context);
        
        // Insertar Profesores:
        profesorService.InsertarProfesor("Andres",25,"POO","andres@gmail.com");
        profesorService.InsertarProfesor("Andrea", 22, "Java", "andre@gmail.com");
        profesorService.InsertarProfesor("David", 34, "TypeScript", "david@gmail.com");
        
        
        // Listar los profesores:
        foreach (var prof in profesorService.ListarProfesores())
        {
            Console.WriteLine($"{prof.Nombre}  {prof.Edad}  {prof.Materia}  {prof.Email}");
        }
            
            
            
    }


}