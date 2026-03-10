namespace ProyectoPrototipo;

public class ExamenProgramacion : Examen
{
    private string lenguaje;
    private bool permitidoInternet;

    public ExamenProgramacion(string docente, string salon, string grupo, string semestre,
                               string lenguaje, bool permitidoInternet)
        : base("PROG-202", "Programacion Orientada a Objetos", docente, salon, grupo,
               15, 110, semestre, "Practico")
    {
        this.lenguaje         = lenguaje;
        this.permitidoInternet = permitidoInternet;
    }

    private ExamenProgramacion(ExamenProgramacion otro) : base(otro)
    {
        lenguaje          = otro.lenguaje;
        permitidoInternet = otro.permitidoInternet;
    }

    public override object Clone() => new ExamenProgramacion(this);

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Lenguaje      : {lenguaje}");
        Console.WriteLine($"Internet      : {(permitidoInternet ? "Si" : "No")}");
        Console.WriteLine("========================================");
    }
}