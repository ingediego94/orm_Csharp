using orm_Csharp.Data;
using orm_Csharp.Models;

namespace orm_Csharp.Services;

public class EstudianteService
{

    private readonly AppDbContext _context;

    public EstudianteService(AppDbContext context)
    {
        _context = context;
    }



    // Creamos un metodo para insertar 'Estudiante'
    public void InsertarEstudiante(string nombre, int edad, string carrera)
    {
        var estudiante = new Estudiante
        {
            Nombre = nombre,
            Edad = edad,
            Carrera = carrera

        };

        _context.estudiantes.Add(estudiante);
        _context.SaveChanges();
    }

    public List<Estudiante> ListarEstudiantes()
    {
        return _context.estudiantes.ToList();
    }

}