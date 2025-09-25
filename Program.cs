using orm_Csharp.Data;
using orm_Csharp.Services;

public class Program
{
    static void Main(string[] args)
    {
        var context = new AppDbContext();
        var estudianteService = new EstudianteService(context);
        
        // Insert estudiante:
        estudianteService.InsertarEstudiante("Sergio", 23, "Dishwasher");
        
        // Listar:
        foreach (var est in estudianteService.ListarEstudiantes())
        {
            Console.WriteLine($"C# eres nice: {est.Carrera}");
        }
    }
}