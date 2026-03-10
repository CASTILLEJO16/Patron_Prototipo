namespace ProyectoPrototipo;

public class ExamenAlgoritmos : Examen
{
    private string estructuraDatos;
    private bool requiereSeudocodigo;

    public ExamenAlgoritmos(string docente, string salon, string grupo, string semestre,
                             string estructuraDatos, bool requiereSeudocodigo)
        : base("ALG-204", "Estructura de Datos y Algoritmos", docente, salon, grupo,
               18, 95, semestre, "Escrito")
    {
        this.estructuraDatos     = estructuraDatos;
        this.requiereSeudocodigo = requiereSeudocodigo;
    }

    private ExamenAlgoritmos(ExamenAlgoritmos otro) : base(otro)
    {
        estructuraDatos     = otro.estructuraDatos;
        requiereSeudocodigo = otro.requiereSeudocodigo;
    }

    public override object Clone() => new ExamenAlgoritmos(this);

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Estructura    : {estructuraDatos}");
        Console.WriteLine($"Seudocodigo   : {(requiereSeudocodigo ? "Si" : "No")}");
        Console.WriteLine("========================================");
    }
}