using orm_Csharp.Data;
using orm_Csharp.Models;

namespace orm_Csharp.Services;

public class ProfesoresService
{
    private readonly AppDbContext _context;

    public ProfesoresService(AppDbContext context)
    {
        _context = context;
    }
    
    
    // Metodo para insertar estudiante:
    public void InsertarProfesor(string nombre, int edad, string materia, string email)
    {
        var profesor = new Profesor
        {
            Nombre = nombre,
            Edad = edad,
            Materia = materia,
            Email = email
        };

        _context.profesors.Add(profesor);
        _context.SaveChanges();
    }

    
    
    public List<Profesor> ListarProfesores()
    {
        return _context.profesors.ToList();
    }
    
}