namespace ProyectoPrototipo;

public class ExamenCalculo : Examen
{
    private string unidadTematica;
    private int numeroEjercicios;

    public ExamenCalculo(string docente, string salon, string grupo, string semestre,
                          string unidadTematica, int numeroEjercicios)
        : base("CAL-102", "Calculo Diferencial", docente, salon, grupo,
               10, 120, semestre, "Resolución de Problemas")
    {
        this.unidadTematica   = unidadTematica;
        this.numeroEjercicios = numeroEjercicios;
    }

    private ExamenCalculo(ExamenCalculo otro) : base(otro)
    {
        unidadTematica   = otro.unidadTematica;
        numeroEjercicios = otro.numeroEjercicios;
    }

    public override object Clone() => new ExamenCalculo(this);

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Unidad        : {unidadTematica}");
        Console.WriteLine($"Ejercicios    : {numeroEjercicios}");
        Console.WriteLine("========================================");
    }
}