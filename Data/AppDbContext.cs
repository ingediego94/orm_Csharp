using Microsoft.EntityFrameworkCore;
using orm_Csharp.Models;

namespace orm_Csharp.Data;

public class AppDbContext : DbContext
{
    // Data siempre es la que va a interactuar con nuestra BD
    // Debemos instalar la dependencia para que funcione el 'DbContext'
    // comandos en terminal:
    // 1)   dotnet add package microsoft.EntityFrameworkCore
    // 2)   dotnet add package microsoft.EntityFrameworkCore.design
    // 3)   dotnet add package Pomelo.EntityFrameworkCore.MySql
        // Revisamos en nugget y deberian aparecer los 3
    // 4) dotnet tool install --global dotnet-ef
    
    public DbSet<Profesor> profesors { get; set; }
    public DbSet<Estudiante> estudiantes { get; set; }
    
    
    
    // Copiar y pegar este comando
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=orm_prueba;user=root;password=Qwe.123*",      // MODIFICAR:
                new MySqlServerVersion(new Version(8, 0, 36))
            );
        }
    }
    
    // Para empezar la migración:
        //dotnet ef migrations and InitialCreate
        
    // Refrescar la bd:
        // dotnet ef database update
}