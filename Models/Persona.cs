namespace orm_Csharp.Models;

public class Persona
{
    // En orm siempre debemos trabajar con ID
    public int ID { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
}